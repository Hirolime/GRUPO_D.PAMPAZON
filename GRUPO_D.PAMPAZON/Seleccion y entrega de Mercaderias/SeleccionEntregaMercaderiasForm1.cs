using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GRUPO_D.PAMPAZON.Seleccion_y_entrega_de_Mercaderias
{
    /// <summary>
    /// CU2 - Selección y entrega de mercadería (A02 Seleccionar y entregar mercadería, I03 Registrar servicio a cobrar).
    /// Validaciones de datos según la planilla de apoyo (campos C.1 a C.6).
    /// Los controles y su diseño están en el Designer; acá se conectan los eventos y se validan los datos.
    /// </summary>
    public partial class SeleccionEntregaMercaderiasForm1 : Form
    {
        // Columnas de los ListView (ver Designer)
        private const int ColSelNumero = 0, ColSelFechaCorte = 1, ColSelCorte = 2, ColSelModalidad = 3, ColSelEstado = 6;
        private const int ColCliente = 0, ColSku = 1, ColProducto = 2, ColUbicacion = 3, ColRequerida = 4, ColRetirada = 5;

        private const string EstadoEmitida = "EMITIDA";
        private const string EstadoCumplida = "CUMPLIDA";
        private const string ModalidadFulfillment = "Fulfillment";
        private const string ModalidadPale = "Palé cerrado";

        // ---------- Datos de prueba del prototipo (en el sistema real vienen de la base) ----------

        private class Renglon
        {
            public string Cliente = "";
            public string Sku = "";
            public string Producto = "";
            public string Ubicacion = "";
            public int Requerida;
            public string Reparto = "";
        }

        private class Seleccion
        {
            public string Numero = "";
            public string FechaCorte = "";
            public string Corte = "";
            public string Modalidad = "";
            public int Pedidos;
            public string Estado = EstadoEmitida;
            public string Servicio = "";
            public List<Renglon> Renglones = new List<Renglon>();
        }

        private readonly List<Seleccion> selecciones = new List<Seleccion>();
        private readonly Dictionary<string, int> stockFisico = new Dictionary<string, int>();
        private readonly Dictionary<string, int> stockComprometido = new Dictionary<string, int>();

        public SeleccionEntregaMercaderiasForm1()
        {
            InitializeComponent();

            cboDeposito.SelectedItem = "GBA";
            txtCantidadRetirada.MaxLength = 6;
            txtObservacion.MaxLength = 200;

            CargarDatosPrueba();

            lvSelecciones.SelectedIndexChanged += lvSelecciones_SelectedIndexChanged;
            btnRegistrarRetiro.Click += btnRegistrarRetiro_Click;
            btnConfirmarEntrega.Click += btnConfirmarEntrega_Click;
            btnReportarIncidente.Click += btnReportarIncidente_Click;

            MostrarSelecciones();
            LimpiarDetalle();
        }

        private void CargarDatosPrueba()
        {
            stockFisico["SKU-001"] = 148; stockComprometido["SKU-001"] = 120;
            stockFisico["SKU-002"] = 65; stockComprometido["SKU-002"] = 50;

            selecciones.Add(new Seleccion
            {
                Numero = "OS-000071", FechaCorte = "14/10/2026", Corte = "Segundo", Modalidad = ModalidadFulfillment, Pedidos = 2,
                Renglones = new List<Renglon>
                {
                    new Renglon { Cliente = "Cliente Demo A", Sku = "SKU-001", Producto = "Remera de algodón", Ubicacion = "12-43-2", Requerida = 120, Reparto = "OP-000181 (80); OP-000182 (40)" },
                    new Renglon { Cliente = "Cliente Demo A", Sku = "SKU-002", Producto = "Pantalón deportivo", Ubicacion = "12-44-1", Requerida = 30, Reparto = "OP-000181 (30)" }
                }
            });
            selecciones.Add(new Seleccion
            {
                Numero = "OS-000072", FechaCorte = "14/10/2026", Corte = "Segundo", Modalidad = ModalidadPale, Pedidos = 1,
                Renglones = new List<Renglon>
                {
                    new Renglon { Cliente = "Cliente Demo B", Sku = "SKU-002", Producto = "Pantalón deportivo", Ubicacion = "12-44-1", Requerida = 20, Reparto = "OP-000183 (20)" }
                }
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

        // ---------- Selección de la orden (C.1 / C.2) ----------

        private void MostrarSelecciones()
        {
            lvSelecciones.Items.Clear();
            foreach (Seleccion s in selecciones)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    s.Numero, s.FechaCorte, s.Corte, s.Modalidad, s.Pedidos.ToString(), s.Renglones.Count.ToString(), s.Estado
                });
                item.Tag = s;
                lvSelecciones.Items.Add(item);
            }
        }

        private Seleccion? SeleccionElegida()
        {
            return lvSelecciones.SelectedItems.Count == 0 ? null : (Seleccion)lvSelecciones.SelectedItems[0].Tag!;
        }

        private Seleccion? ExigirSeleccion()
        {
            Seleccion? seleccion = SeleccionElegida();
            if (seleccion == null)
                MostrarError("Seleccione una orden de selección.", lvSelecciones);
            return seleccion;
        }

        private void LimpiarDetalle()
        {
            txtOrdenSeleccion.Text = "";
            txtModalidadSel.Text = "";
            txtCorteSel.Text = "";
            txtEmitidaPor.Text = "";
            txtServicio.Text = "";
            lvRenglones.Items.Clear();
            txtCantidadRetirada.Clear();
            txtObservacion.Clear();
            chkEntregaPreparacion.Checked = false;
        }

        private void lvSelecciones_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Seleccion? seleccion = SeleccionElegida();
            if (seleccion == null) return;

            LimpiarDetalle();
            txtOrdenSeleccion.Text = seleccion.Numero;
            txtModalidadSel.Text = seleccion.Modalidad;
            txtCorteSel.Text = seleccion.Corte;
            txtEmitidaPor.Text = "Jefe de Preparación";
            txtServicio.Text = seleccion.Servicio;

            foreach (Renglon r in seleccion.Renglones)
            {
                ListViewItem fila = new ListViewItem(new string[]
                {
                    r.Cliente, r.Sku, r.Producto, r.Ubicacion, r.Requerida.ToString(),
                    seleccion.Estado == EstadoCumplida ? r.Requerida.ToString() : "", r.Reparto
                });
                fila.Tag = r;
                lvRenglones.Items.Add(fila);
            }
        }

        // ---------- Cantidad retirada por renglón (C.3) ----------

        private string MensajeDiferencia(Renglon r)
        {
            return "La cantidad retirada de " + r.Sku + " en " + r.Ubicacion + " debe coincidir con la requerida (" + r.Requerida + ").";
        }

        private void btnRegistrarRetiro_Click(object? sender, EventArgs e)
        {
            Seleccion? seleccion = ExigirSeleccion();
            if (seleccion == null) return;

            if (seleccion.Estado == EstadoCumplida)
            {
                MostrarInfo("La orden de selección " + seleccion.Numero + " ya fue cumplida. No se vuelve a registrar el retiro.", "Selección cumplida");
                return;
            }

            if (lvRenglones.SelectedItems.Count == 0)
            {
                MostrarError("Seleccione el renglón al que corresponde la cantidad retirada.", lvRenglones);
                return;
            }

            string texto = txtCantidadRetirada.Text.Trim();
            if (texto.Length > 0 && !Regex.IsMatch(texto, "^[0-9]+$"))
            {
                MostrarError("Ingrese una cantidad retirada válida (número entero mayor o igual a 0, hasta 6 dígitos).", txtCantidadRetirada);
                return;
            }

            int retirada;
            if (texto.Length == 0 || !int.TryParse(texto, out retirada) || retirada == 0)
            {
                MostrarError("Ingrese la cantidad retirada de cada renglón.", txtCantidadRetirada);
                return;
            }

            ListViewItem fila = lvRenglones.SelectedItems[0];
            Renglon renglon = (Renglon)fila.Tag!;
            fila.SubItems[ColRetirada].Text = retirada.ToString();

            if (retirada != renglon.Requerida)
                MostrarError(MensajeDiferencia(renglon), txtCantidadRetirada);
            else
                txtCantidadRetirada.Clear();
        }

        // ---------- Confirmar entrega (C.1, C.3, C.4, C.5, C.6) ----------

        private void btnConfirmarEntrega_Click(object? sender, EventArgs e)
        {
            Seleccion? seleccion = ExigirSeleccion();
            if (seleccion == null) return;

            // El cumplimiento se registra una sola vez: si ya existe, solo se informa.
            if (seleccion.Estado == EstadoCumplida)
            {
                MostrarInfo("La orden de selección " + seleccion.Numero + " ya fue cumplida. Servicio registrado: " + seleccion.Servicio + ".", "Selección cumplida");
                return;
            }

            // Cada renglón debe tener su cantidad retirada registrada.
            foreach (ListViewItem fila in lvRenglones.Items)
            {
                if (fila.SubItems[ColRetirada].Text.Length == 0)
                {
                    MostrarError("Ingrese la cantidad retirada de cada renglón.", lvRenglones);
                    return;
                }
            }

            // La cantidad retirada debe coincidir con la requerida.
            foreach (ListViewItem fila in lvRenglones.Items)
            {
                Renglon r = (Renglon)fila.Tag!;
                if (int.Parse(fila.SubItems[ColRetirada].Text) != r.Requerida)
                {
                    string mensaje = MensajeDiferencia(r);
                    if (txtObservacion.Text.Trim().Length == 0)
                        mensaje += Environment.NewLine + "Describa la diferencia observada (hasta 200 caracteres).";
                    MostrarError(mensaje, txtObservacion.Text.Trim().Length == 0 ? (Control)txtObservacion : lvRenglones);
                    return;
                }
            }

            if (txtObservacion.Text.Length > 200)
            {
                MostrarError("Describa la diferencia observada (hasta 200 caracteres).", txtObservacion);
                return;
            }

            if (!chkEntregaPreparacion.Checked)
            {
                MostrarError("Confirme la entrega de la mercadería a Preparación.", chkEntregaPreparacion);
                return;
            }

            // Se descuenta el stock físico y se libera el compromiso.
            foreach (Renglon r in seleccion.Renglones)
            {
                stockFisico[r.Sku] -= r.Requerida;
                stockComprometido[r.Sku] -= r.Requerida;
            }

            seleccion.Estado = EstadoCumplida;
            // Servicio a cobrar según la operación (supuesto del prototipo: Fulfillment / Out).
            seleccion.Servicio = seleccion.Modalidad == ModalidadFulfillment ? "Fulfillment" : "Out";
            txtServicio.Text = seleccion.Servicio;
            lvSelecciones.SelectedItems[0].SubItems[ColSelEstado].Text = seleccion.Estado;

            string resumen = string.Join(Environment.NewLine, seleccion.Renglones.Select(r =>
                r.Sku + ": físico " + stockFisico[r.Sku] + ", comprometido " + stockComprometido[r.Sku] +
                ", disponible " + (stockFisico[r.Sku] - stockComprometido[r.Sku])));

            MostrarInfo("Selección " + seleccion.Numero + " cumplida. Los pedidos vinculados pasan a EN PREPARACIÓN." + Environment.NewLine +
                        "Servicio registrado: " + seleccion.Servicio + "." + Environment.NewLine + Environment.NewLine + resumen,
                        "Entrega confirmada");
        }

        private void btnReportarIncidente_Click(object? sender, EventArgs e)
        {
            Seleccion? seleccion = ExigirSeleccion();
            if (seleccion == null) return;

            MostrarInfo("Incidente informado para la orden de selección " + seleccion.Numero + ".", "Incidente");
        }
    }
}
