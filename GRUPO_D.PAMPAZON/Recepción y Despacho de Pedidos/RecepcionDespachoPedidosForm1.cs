using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GRUPO_D.PAMPAZON.Recepción_y_Despacho_de_Pedidos
{
    /// <summary>
    /// CU4 - Recepción y despacho de pedidos (E01 Recibir pedido preparado, E03 Entregar mercadería y cerrar despacho,
    /// con E02, E04 y E05). Validaciones de datos según la planilla de apoyo (campos E.1 a E.5 y F.1 a F.6).
    /// Los controles y su diseño están en el Designer; acá se conectan los eventos y se validan los datos.
    /// </summary>
    public partial class RecepcionDespachoPedidosForm1 : Form
    {
        // Columnas de los ListView (ver Designer)
        private const int ColEstado = 6;
        private const int ColCtlSku = 0, ColCtlSegunOrden = 2, ColCtlRecibida = 3, ColCtlDiferencia = 4;

        private const string EstadoPreparada = "PREPARADA";
        private const string EstadoEnDespacho = "EN DESPACHO";
        private const string EstadoDespachada = "DESPACHADA";
        private const string OrigenTraslado = "Traslado interno";

        // Prototipo: en el sistema real los transportistas autorizados salen del contrato o del flete confirmado (E02).
        private static readonly string[] TransportistasAutorizados = { "Transportista Demo 1", "Transportista Demo 2" };

        // ---------- Datos de prueba del prototipo (en el sistema real vienen de la base) ----------

        private class Linea
        {
            public string Sku = "";
            public string Producto = "";
            public int Cantidad;
            public int? Recibida;
        }

        private class Entrega
        {
            public string Numero = "";
            public string Pedido = "";
            public string Cliente = "";
            public string Origen = "";
            public string Destino = "";
            public int Bultos;
            public string Estado = EstadoPreparada;
            public string Observacion = "";
            public string Documento = "";
            public List<Linea> Lineas = new List<Linea>();
        }

        private readonly List<Entrega> entregas = new List<Entrega>();

        public RecepcionDespachoPedidosForm1()
        {
            InitializeComponent();

            cboDeposito.SelectedItem = "GBA";
            txtBuscarEntrega.MaxLength = 30;
            txtCantidadRecibida.MaxLength = 6;
            txtObsRecepcion.MaxLength = 200;
            txtTransportista.MaxLength = 60;
            txtFlete.MaxLength = 20;

            CargarDatosPrueba();

            btnBuscar.Click += btnBuscar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            lvPreparadas.SelectedIndexChanged += lvPreparadas_SelectedIndexChanged;
            btnRegistrarRecepcion.Click += btnRegistrarRecepcion_Click;
            btnConfirmarRecepcion.Click += btnConfirmarRecepcion_Click;
            btnReportarIncidenteRecepcion.Click += btnReportarIncidenteRecepcion_Click;

            lvEnDespacho.SelectedIndexChanged += lvEnDespacho_SelectedIndexChanged;
            btnEmitirDocumento.Click += btnEmitirDocumento_Click;
            btnCerrarDespacho.Click += btnCerrarDespacho_Click;
            btnReportarIncidenteDespacho.Click += btnReportarIncidenteDespacho_Click;

            MostrarPreparadas(entregas);
            lvControlRecepcion.Items.Clear();
            ActualizarEnDespacho();
        }

        private void CargarDatosPrueba()
        {
            entregas.Add(new Entrega
            {
                Numero = "OE-000051", Pedido = "OP-000181", Cliente = "Cliente Demo A", Origen = "Cliente", Destino = "Destino demo A", Bultos = 2,
                Lineas = new List<Linea>
                {
                    new Linea { Sku = "SKU-001", Producto = "Remera de algodón", Cantidad = 80 },
                    new Linea { Sku = "SKU-002", Producto = "Pantalón deportivo", Cantidad = 30 }
                }
            });
            entregas.Add(new Entrega
            {
                Numero = "OE-000052", Pedido = "TR-000026", Cliente = "Cliente Demo A", Origen = OrigenTraslado, Destino = "Destino demo B", Bultos = 1,
                Lineas = new List<Linea> { new Linea { Sku = "SKU-002", Producto = "Pantalón deportivo", Cantidad = 20 } }
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

        private static ListViewItem FilaEntrega(Entrega e)
        {
            ListViewItem item = new ListViewItem(new string[] { e.Numero, e.Pedido, e.Cliente, e.Origen, e.Destino, e.Bultos.ToString(), e.Estado });
            item.Tag = e;
            return item;
        }

        // ---------- Búsqueda (E.1) ----------

        private void MostrarPreparadas(IEnumerable<Entrega> lista)
        {
            lvPreparadas.Items.Clear();
            foreach (Entrega e in lista) lvPreparadas.Items.Add(FilaEntrega(e));
        }

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            string texto = txtBuscarEntrega.Text.Trim();
            if (texto.Length == 0)
            {
                MostrarPreparadas(entregas);
                return;
            }

            List<Entrega> encontradas = entregas.Where(x => x.Numero.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            MostrarPreparadas(encontradas);
            lvControlRecepcion.Items.Clear();
            if (encontradas.Count == 0)
                MostrarError("La orden de entrega no existe o pertenece a otro depósito.", txtBuscarEntrega);
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            txtBuscarEntrega.Clear();
            MostrarPreparadas(entregas);
            lvControlRecepcion.Items.Clear();
        }

        // ---------- Orden a recibir (E.2) ----------

        private Entrega? EntregaARecibir()
        {
            return lvPreparadas.SelectedItems.Count == 0 ? null : (Entrega)lvPreparadas.SelectedItems[0].Tag!;
        }

        private Entrega? ExigirEntregaARecibir()
        {
            Entrega? entrega = EntregaARecibir();
            if (entrega == null)
                MostrarError("Seleccione una orden de entrega.", lvPreparadas);
            return entrega;
        }

        private void lvPreparadas_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Entrega? entrega = EntregaARecibir();
            if (entrega == null) return;

            lvControlRecepcion.Items.Clear();
            foreach (Linea l in entrega.Lineas)
            {
                string recibida = l.Recibida.HasValue ? l.Recibida.Value.ToString() : "";
                string diferencia = l.Recibida.HasValue ? (l.Recibida.Value - l.Cantidad).ToString() : "";
                ListViewItem fila = new ListViewItem(new string[] { l.Sku, l.Producto, l.Cantidad.ToString(), recibida, diferencia });
                fila.Tag = l;
                lvControlRecepcion.Items.Add(fila);
            }
            txtCantidadRecibida.Clear();
            txtObsRecepcion.Text = entrega.Observacion;
            chkRecepcionCompleta.Checked = false;
        }

        // ---------- Cantidad recibida por renglón (E.3) ----------

        private void btnRegistrarRecepcion_Click(object? sender, EventArgs e)
        {
            Entrega? entrega = ExigirEntregaARecibir();
            if (entrega == null) return;

            if (entrega.Estado != EstadoPreparada)
            {
                MostrarInfo("La orden de entrega " + entrega.Numero + " ya fue recibida. Estado: " + entrega.Estado + ".", "Recepción existente");
                return;
            }

            if (lvControlRecepcion.SelectedItems.Count == 0)
            {
                MostrarError("Seleccione el renglón al que corresponde la cantidad recibida.", lvControlRecepcion);
                return;
            }

            string texto = txtCantidadRecibida.Text.Trim();
            int recibida;
            if (texto.Length == 0 || !Regex.IsMatch(texto, "^[0-9]+$") || !int.TryParse(texto, out recibida))
            {
                MostrarError("Ingrese una cantidad recibida válida (número entero mayor o igual a 0, hasta 6 dígitos).", txtCantidadRecibida);
                return;
            }

            ListViewItem fila = lvControlRecepcion.SelectedItems[0];
            Linea linea = (Linea)fila.Tag!;
            linea.Recibida = recibida;
            fila.SubItems[ColCtlRecibida].Text = recibida.ToString();
            fila.SubItems[ColCtlDiferencia].Text = (recibida - linea.Cantidad).ToString();

            if (recibida != linea.Cantidad)
                MostrarError("Los bultos recibidos no coinciden con la orden de entrega.", txtCantidadRecibida);
            else
                txtCantidadRecibida.Clear();
        }

        // ---------- Confirmar recepción (E.2 a E.5) ----------

        private void btnConfirmarRecepcion_Click(object? sender, EventArgs e)
        {
            Entrega? entrega = ExigirEntregaARecibir();
            if (entrega == null) return;

            // La recepción se registra una sola vez: si ya existe, solo se informa.
            if (entrega.Estado != EstadoPreparada)
            {
                MostrarInfo("La orden de entrega " + entrega.Numero + " ya fue recibida. Estado: " + entrega.Estado + ".", "Recepción existente");
                return;
            }

            if (entrega.Lineas.Any(l => !l.Recibida.HasValue))
            {
                MostrarError("Ingrese la cantidad recibida de cada renglón.", lvControlRecepcion);
                return;
            }

            if (entrega.Lineas.Any(l => l.Recibida!.Value != l.Cantidad))
            {
                string observacion = txtObsRecepcion.Text.Trim();
                if (observacion.Length == 0)
                {
                    MostrarError("Describa la diferencia observada (hasta 200 caracteres).", txtObsRecepcion);
                    return;
                }
                // La observación queda registrada y el pedido sigue PREPARADA.
                entrega.Observacion = observacion;
                MostrarError("Los bultos recibidos no coinciden con la orden de entrega.", lvControlRecepcion);
                return;
            }

            if (!chkRecepcionCompleta.Checked)
            {
                MostrarError("Confirme la recepción completa de los preparados.", chkRecepcionCompleta);
                return;
            }

            entrega.Estado = EstadoEnDespacho;
            lvPreparadas.SelectedItems[0].SubItems[ColEstado].Text = entrega.Estado;
            ActualizarEnDespacho();

            MostrarInfo("Orden de entrega " + entrega.Numero + " recibida. Pedido " + entrega.Pedido + " EN DESPACHO." + Environment.NewLine +
                        "El stock de almacén no cambia.", "Recepción confirmada");
        }

        private void btnReportarIncidenteRecepcion_Click(object? sender, EventArgs e)
        {
            Entrega? entrega = ExigirEntregaARecibir();
            if (entrega == null) return;

            MostrarInfo("Incidente informado para la orden de entrega " + entrega.Numero + ".", "Incidente");
        }

        // ---------- Despacho: orden a despachar (F.1) ----------

        private void ActualizarEnDespacho()
        {
            Entrega? elegida = EntregaADespachar();
            lvEnDespacho.Items.Clear();
            foreach (Entrega e in entregas.Where(x => x.Estado == EstadoEnDespacho || x.Estado == EstadoDespachada))
            {
                ListViewItem item = FilaEntrega(e);
                lvEnDespacho.Items.Add(item);
                if (e == elegida) item.Selected = true;
            }
        }

        private Entrega? EntregaADespachar()
        {
            return lvEnDespacho.SelectedItems.Count == 0 ? null : (Entrega)lvEnDespacho.SelectedItems[0].Tag!;
        }

        private Entrega? ExigirEntregaADespachar()
        {
            Entrega? entrega = EntregaADespachar();
            if (entrega == null)
                MostrarError("Seleccione una orden de entrega a despachar.", lvEnDespacho);
            return entrega;
        }

        private void lvEnDespacho_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Entrega? entrega = EntregaADespachar();
            if (entrega == null) return;

            txtDocumento.Text = entrega.Documento;
            chkConformidad.Checked = false;
        }

        // Valida transportista (F.2) y flete (F.3). Devuelve true si son correctos.
        private bool ValidarTransporte(Entrega entrega)
        {
            string transportista = txtTransportista.Text.Trim();
            if (transportista.Length == 0)
            {
                MostrarError("Ingrese la identificación del transportista.", txtTransportista);
                return false;
            }
            if (!TransportistasAutorizados.Contains(transportista, StringComparer.OrdinalIgnoreCase))
            {
                MostrarError("El transportista no está autorizado para este retiro.", txtTransportista);
                return false;
            }
            if (entrega.Origen == OrigenTraslado && txtFlete.Text.Trim().Length == 0)
            {
                MostrarError("Ingrese la referencia del flete confirmado.", txtFlete);
                return false;
            }
            return true;
        }

        // ---------- Emitir documento de salida (F.4 / E04) ----------

        private void btnEmitirDocumento_Click(object? sender, EventArgs e)
        {
            Entrega? entrega = ExigirEntregaADespachar();
            if (entrega == null) return;

            if (!ValidarTransporte(entrega)) return;

            // Reimprimir no registra otro egreso: si ya existe el documento, solo se muestra.
            if (entrega.Documento.Length > 0)
            {
                txtDocumento.Text = entrega.Documento;
                MostrarInfo("El documento de salida ya fue emitido: " + entrega.Documento + "." + Environment.NewLine + "Se reimprime el existente.", "Documento de salida");
                return;
            }

            string prefijo = entrega.Origen == OrigenTraslado ? "GT-" : "RE-";
            entrega.Documento = prefijo + entrega.Numero.Replace("OE-", "").PadLeft(9, '0');
            txtDocumento.Text = entrega.Documento;

            string tipo = entrega.Origen == OrigenTraslado ? "Guía de traslado" : "Remito de entrega";
            MostrarInfo(tipo + " emitido: " + entrega.Documento + "." + Environment.NewLine + "Emitirlo no descuenta stock.", "Documento de salida");
        }

        // ---------- Cerrar despacho (F.1 a F.6 / E05) ----------

        private void btnCerrarDespacho_Click(object? sender, EventArgs e)
        {
            Entrega? entrega = ExigirEntregaADespachar();
            if (entrega == null) return;

            // El egreso se registra una sola vez: si ya está DESPACHADA, solo se muestra el comprobante.
            if (entrega.Estado == EstadoDespachada)
            {
                MostrarInfo("La orden de entrega " + entrega.Numero + " ya fue despachada. Comprobante: " + entrega.Documento + ".", "Despacho cerrado");
                return;
            }

            if (!ValidarTransporte(entrega)) return;

            if (entrega.Documento.Length == 0)
            {
                MostrarError("Emita el documento de salida antes de cerrar el despacho.", btnEmitirDocumento);
                return;
            }

            if (!chkConformidad.Checked)
            {
                MostrarError("Registre la conformidad de retiro del transportista.", chkConformidad);
                return;
            }

            if (dtpRetiro.Value.Date > DateTime.Today)
            {
                MostrarError("La fecha de retiro no puede ser posterior a hoy.", dtpRetiro);
                return;
            }

            entrega.Estado = EstadoDespachada;
            ActualizarEnDespacho();
            foreach (ListViewItem fila in lvPreparadas.Items)
                if (fila.Tag == entrega) fila.SubItems[ColEstado].Text = entrega.Estado;

            MostrarInfo("Despacho cerrado. Pedido " + entrega.Pedido + " DESPACHADA." + Environment.NewLine +
                        "Egreso registrado una sola vez. El stock de almacén no cambia.", "Despacho cerrado");
        }

        private void btnReportarIncidenteDespacho_Click(object? sender, EventArgs e)
        {
            Entrega? entrega = ExigirEntregaADespachar();
            if (entrega == null) return;

            MostrarInfo("Incidente informado para la orden de entrega " + entrega.Numero + ".", "Incidente");
        }
    }
}
