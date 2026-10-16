using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pampazon.Prototipos
{
    /// <summary>
    /// CU1 - Gestión de pedidos y selección (P01 Validar orden de preparación, P02 Rechazar por falta de stock).
    /// Validaciones de datos según la planilla de apoyo (campos A.1 a A.6).
    /// Los controles y su diseño están en el Designer; acá se conectan los eventos y se validan los datos.
    /// </summary>
    public partial class GestionPedidosSeleccionForm : Form
    {
        // Columnas de los ListView (ver Designer)
        private const int ColNumero = 0, ColAsignacion = 1, ColCliente = 2, ColOrigen = 3, ColModalidad = 4, ColProductos = 5, ColEstado = 6;
        private const int ColDispSolicitado = 3, ColDispDisponible = 4, ColDispValidacion = 5;

        private const string EstadoAsignada = "ASIGNADA";
        private const string EstadoPendiente = "PENDIENTE";
        private const string EstadoRechazada = "RECHAZADA";

        private static readonly Regex PatronContrato = new Regex(@"^CT-\d{6}$");

        // ---------- Datos de prueba del prototipo (en el sistema real vienen de la base) ----------

        private class Linea
        {
            public string Sku = "";
            public string Producto = "";
            public string Unidad = "Unidad";
            public int Solicitado;
        }

        private class Orden
        {
            public string Numero = "";
            public DateTime Asignacion;
            public string Cliente = "";
            public string Origen = "";
            public string Modalidad = "";
            public string Contrato = "";
            public string Estado = EstadoAsignada;
            public List<Linea> Lineas = new List<Linea>();
        }

        private readonly List<Orden> ordenes = new List<Orden>();
        private readonly Dictionary<string, int> stockFisico = new Dictionary<string, int>();
        private readonly Dictionary<string, int> stockComprometido = new Dictionary<string, int>();

        // Estado de la validación de la orden elegida
        private bool validada;
        private List<string> faltantes = new List<string>();
        private readonly string textoValidacionInicial;
        private readonly string textoMotivoInicial;

        public GestionPedidosSeleccionForm()
        {
            InitializeComponent();

            cboDeposito.SelectedItem = "GBA";
            textoValidacionInicial = lblValidacion.Text;
            textoMotivoInicial = txtMotivo.Text;
            // Los botones quedan habilitados: si falta un dato, se informa con el mensaje de la planilla.
            btnAceptar.Enabled = true;
            btnRechazar.Enabled = true;

            txtBuscarOrden.MaxLength = 30;
            cboCliente.SelectedIndex = 0;
            cboOrigen.SelectedIndex = 0;
            dtpDesde.ShowCheckBox = true;
            dtpDesde.Checked = false;

            CargarDatosPrueba();

            lvAsignadas.SelectedIndexChanged += lvAsignadas_SelectedIndexChanged;
            btnBuscar.Click += btnBuscar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnValidar.Click += btnValidar_Click;
            btnAceptar.Click += btnAceptar_Click;
            btnRechazar.Click += btnRechazar_Click;
            btnIrCortes.Click += btnIrCortes_Click;

            MostrarOrdenes(ordenes.Where(o => o.Estado == EstadoAsignada));
            LimpiarDetalle();
        }

        private void CargarDatosPrueba()
        {
            stockFisico["SKU-001"] = 148; stockComprometido["SKU-001"] = 0;
            stockFisico["SKU-002"] = 65; stockComprometido["SKU-002"] = 0;

            ordenes.Add(new Orden
            {
                Numero = "OP-000184", Asignacion = new DateTime(2026, 10, 12), Cliente = "Cliente Demo A", Origen = "Cliente",
                Modalidad = "Fulfillment", Contrato = "CT-000028",
                Lineas = new List<Linea>
                {
                    new Linea { Sku = "SKU-001", Producto = "Remera de algodón", Solicitado = 80 },
                    new Linea { Sku = "SKU-002", Producto = "Pantalón deportivo", Solicitado = 30 }
                }
            });
            ordenes.Add(new Orden
            {
                Numero = "OP-000185", Asignacion = new DateTime(2026, 10, 12), Cliente = "Cliente Demo B", Origen = "Cliente",
                Modalidad = "Palé cerrado", Contrato = "CT-000029",
                Lineas = new List<Linea> { new Linea { Sku = "SKU-001", Producto = "Remera de algodón", Solicitado = 100 } }
            });
            ordenes.Add(new Orden
            {
                Numero = "TR-000026", Asignacion = new DateTime(2026, 10, 12), Cliente = "Cliente Demo A", Origen = "Traslado interno",
                Modalidad = "Palé cerrado", Contrato = "CT-000028",
                Lineas = new List<Linea> { new Linea { Sku = "SKU-002", Producto = "Pantalón deportivo", Solicitado = 20 } }
            });
        }

        // ---------- Mensajes ----------

        private void MostrarError(string mensaje, Control? foco = null)
        {
            MessageBox.Show(mensaje, "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (foco != null) foco.Focus();
        }

        private void MostrarInfo(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ---------- Búsqueda (A.1 a A.4) ----------

        private void MostrarOrdenes(IEnumerable<Orden> lista)
        {
            lvAsignadas.Items.Clear();
            foreach (Orden o in lista)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    o.Numero, o.Asignacion.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture), o.Cliente, o.Origen,
                    o.Modalidad, o.Lineas.Count.ToString(), o.Estado
                });
                item.Tag = o;
                lvAsignadas.Items.Add(item);
            }
        }

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            IEnumerable<Orden> asignadas = ordenes.Where(o => o.Estado == EstadoAsignada);

            string numero = txtBuscarOrden.Text.Trim();
            if (numero.Length > 0)
            {
                asignadas = asignadas.Where(o => o.Numero.IndexOf(numero, StringComparison.OrdinalIgnoreCase) >= 0);
                if (!asignadas.Any())
                {
                    MostrarOrdenes(asignadas);
                    LimpiarDetalle();
                    MostrarError("No se encontraron órdenes asignadas con ese número.", txtBuscarOrden);
                    return;
                }
            }

            if (cboCliente.SelectedIndex > 0)
            {
                string cliente = cboCliente.SelectedItem!.ToString()!;
                asignadas = asignadas.Where(o => o.Cliente == cliente);
            }
            if (cboOrigen.SelectedIndex > 0)
            {
                string origen = cboOrigen.SelectedItem!.ToString()!;
                asignadas = asignadas.Where(o => o.Origen == origen);
            }
            // La fecha solo filtra si la casilla del control está marcada.
            if (dtpDesde.Checked)
            {
                DateTime desde = dtpDesde.Value.Date;
                asignadas = asignadas.Where(o => o.Asignacion.Date >= desde);
            }

            List<Orden> resultado = asignadas.ToList();
            MostrarOrdenes(resultado);
            LimpiarDetalle();
            if (resultado.Count == 0)
                MostrarInfo("No hay órdenes asignadas que cumplan los filtros indicados.", "Búsqueda");
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            txtBuscarOrden.Clear();
            cboCliente.SelectedIndex = 0;
            cboOrigen.SelectedIndex = 0;
            dtpDesde.Checked = false;
            MostrarOrdenes(ordenes.Where(o => o.Estado == EstadoAsignada));
            LimpiarDetalle();
        }

        // ---------- Orden seleccionada (A.5) y disponibilidad (A.6) ----------

        private Orden? OrdenSeleccionada()
        {
            return lvAsignadas.SelectedItems.Count == 0 ? null : (Orden)lvAsignadas.SelectedItems[0].Tag!;
        }

        private Orden? ExigirOrden()
        {
            Orden? orden = OrdenSeleccionada();
            if (orden == null)
                MostrarError("Seleccione una orden asignada para validar.", lvAsignadas);
            return orden;
        }

        private int Disponible(string sku)
        {
            return stockFisico[sku] - stockComprometido[sku];
        }

        private void LimpiarDetalle()
        {
            validada = false;
            faltantes = new List<string>();
            grpDetalle.Text = "Detalle de la orden";
            txtDetalleCliente.Text = "";
            txtContrato.Text = "";
            txtModalidad.Text = "";
            txtEstado.Text = "";
            lvDisponibilidad.Items.Clear();
            lblValidacion.Text = textoValidacionInicial;
            txtMotivo.Text = textoMotivoInicial;
            btnAceptar.Enabled = true;
            btnRechazar.Enabled = true;
        }

        private void lvAsignadas_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Orden? orden = OrdenSeleccionada();
            if (orden == null) return;

            validada = false;
            faltantes = new List<string>();
            grpDetalle.Text = "Detalle de la orden " + orden.Numero;
            txtDetalleCliente.Text = orden.Cliente;
            txtContrato.Text = orden.Contrato;
            txtModalidad.Text = orden.Modalidad;
            txtEstado.Text = orden.Estado;

            lvDisponibilidad.Items.Clear();
            foreach (Linea l in orden.Lineas)
            {
                lvDisponibilidad.Items.Add(new ListViewItem(new string[]
                {
                    l.Sku, l.Producto, l.Unidad, l.Solicitado.ToString(), Disponible(l.Sku).ToString(), "Pendiente de validar"
                }));
            }

            lblValidacion.Text = textoValidacionInicial;
            txtMotivo.Text = textoMotivoInicial;
            btnAceptar.Enabled = true;
            btnRechazar.Enabled = true;
        }

        // Calcula la disponibilidad de cada renglón y actualiza la grilla. Devuelve los faltantes.
        private List<string> CalcularDisponibilidad(Orden orden)
        {
            List<string> faltas = new List<string>();
            for (int i = 0; i < orden.Lineas.Count; i++)
            {
                Linea l = orden.Lineas[i];
                int disponible = Disponible(l.Sku);
                ListViewItem fila = lvDisponibilidad.Items[i];
                fila.SubItems[ColDispDisponible].Text = disponible.ToString();
                if (disponible >= l.Solicitado)
                {
                    fila.SubItems[ColDispValidacion].Text = "Disponible";
                }
                else
                {
                    fila.SubItems[ColDispValidacion].Text = "Faltan " + (l.Solicitado - disponible);
                    faltas.Add("Stock insuficiente para el SKU " + l.Sku + ": solicitado " + l.Solicitado + ", disponible " + disponible + ".");
                }
            }
            return faltas;
        }

        private void btnValidar_Click(object? sender, EventArgs e)
        {
            Orden? orden = ExigirOrden();
            if (orden == null) return;

            // El contrato debe estar informado y tener el formato CT-######.
            if (!PatronContrato.IsMatch(orden.Contrato))
            {
                MostrarError("Los datos de la orden no son compatibles con el contrato.");
                return;
            }

            faltantes = CalcularDisponibilidad(orden);
            validada = true;

            if (faltantes.Count == 0)
            {
                lblValidacion.Text = "Disponibilidad validada: el stock cubre todos los renglones. Ya puede aceptar la orden.";
                txtMotivo.Text = textoMotivoInicial;
                btnAceptar.Enabled = true;
                btnRechazar.Enabled = true;
            }
            else
            {
                lblValidacion.Text = faltantes[0] + (faltantes.Count > 1 ? " (y " + (faltantes.Count - 1) + " más)" : "");
                txtMotivo.Text = "Stock insuficiente. " + string.Join(" ", faltantes);
                btnAceptar.Enabled = true;
                btnRechazar.Enabled = true;
                MostrarError(string.Join(Environment.NewLine, faltantes));
            }
        }

        // ---------- Aceptar (P01) ----------

        private void btnAceptar_Click(object? sender, EventArgs e)
        {
            Orden? orden = ExigirOrden();
            if (orden == null) return;

            if (!validada)
            {
                MostrarError("Valide la disponibilidad antes de aceptar la orden.", btnValidar);
                return;
            }

            // Se revalida: el stock pudo cambiar desde la validación.
            faltantes = CalcularDisponibilidad(orden);
            if (faltantes.Count > 0)
            {
                btnAceptar.Enabled = true;
                btnRechazar.Enabled = true;
                MostrarError(string.Join(Environment.NewLine, faltantes));
                return;
            }

            // Se compromete el stock; el físico no cambia hasta que Almacén retire la mercadería.
            foreach (Linea l in orden.Lineas) stockComprometido[l.Sku] += l.Solicitado;
            orden.Estado = EstadoPendiente;

            string resumen = string.Join(Environment.NewLine, orden.Lineas.Select(l =>
                l.Sku + ": físico " + stockFisico[l.Sku] + ", comprometido " + stockComprometido[l.Sku] + ", disponible " + Disponible(l.Sku)));

            MostrarOrdenes(ordenes.Where(o => o.Estado == EstadoAsignada));
            LimpiarDetalle();
            MostrarInfo("Orden " + orden.Numero + " aceptada. Estado: " + EstadoPendiente + "." + Environment.NewLine + Environment.NewLine + resumen, "Orden aceptada");
        }

        // ---------- Rechazar por falta de stock (P02) ----------

        private void btnRechazar_Click(object? sender, EventArgs e)
        {
            Orden? orden = ExigirOrden();
            if (orden == null) return;

            if (!validada)
            {
                MostrarError("Valide la disponibilidad antes de rechazar la orden.", btnValidar);
                return;
            }

            faltantes = CalcularDisponibilidad(orden);
            if (faltantes.Count == 0)
            {
                MostrarError("La orden tiene stock suficiente: no corresponde rechazarla por falta de stock.");
                btnAceptar.Enabled = true;
                btnRechazar.Enabled = true;
                return;
            }

            // El rechazo no compromete stock.
            orden.Estado = EstadoRechazada;
            string motivo = "Stock insuficiente. " + string.Join(" ", faltantes);

            MostrarOrdenes(ordenes.Where(o => o.Estado == EstadoAsignada));
            LimpiarDetalle();
            MostrarInfo("Orden " + orden.Numero + " rechazada. Estado: " + EstadoRechazada + "." + Environment.NewLine +
                        "Motivo: " + motivo + Environment.NewLine + "Se registró el aviso al cliente. No se comprometió stock.", "Orden rechazada");
        }

        // ---------- Cortes de selección ----------

        private void txtEstado_TextChanged(object? sender, EventArgs e)
        {
        }

        // Los cortes de selección están en su propio formulario.
        private void btnIrCortes_Click(object? sender, EventArgs e)
        {
            using (CortesSeleccionForm cortes = new CortesSeleccionForm())
            {
                cortes.ShowDialog(this);
            }
        }
    }
}
