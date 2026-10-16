using System;
using GRUPO_D.PAMPAZON;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GRUPO_D.PAMPAZON.Empaquetado_y_Preparación_de_Mercaderias
{
    /// <summary>
    /// CU3 - Empaquetado y preparación de entregas (P04 / P05).
    /// Validaciones de datos según la planilla de apoyo (campos D.1 a D.9).
    /// Los controles y su diseño están en el Designer; acá solo se conectan los eventos
    /// y se validan los datos ingresados.
    /// </summary>
    public partial class EmpaquetadoPreparacionMercaderiasForm1 : Form
    {
        // Columnas de los ListView (ver Designer)
        private const int ColEstadoPedido = 5;   // lvPedidosEnPreparacion: Estado
        private const int ColSku = 0, ColSolicitada = 2, ColControlada = 4, ColDiferencia = 5; // lvControl
        private const int ColBultoSku = 1, ColBultoCantidad = 3;                              // lvBultos

        private const string ModalidadFulfillment = "Fulfillment";
        private const string ModalidadPale = "Palé cerrado";
        private const string EstadoEnPreparacion = "EN PREPARACIÓN";
        private const string EstadoPreparada = "PREPARADA";

        // Prototipo: en el sistema real el código del palé viene de la orden de selección (D.6).
        private const string PaleAsignado = "PAL-000183";

        private readonly Dictionary<string, string> ordenesEmitidas = new Dictionary<string, string>();
        private static readonly Regex PatronIdentificacion = new Regex("^[A-Za-z0-9-]+$");

        public EmpaquetadoPreparacionMercaderiasForm1()
        {
            InitializeComponent();
            AjustePantalla.Aplicar(this);

            txtCantidadControlada.MaxLength = 6;
            txtCantBulto.MaxLength = 6;

            lvPedidosEnPreparacion.SelectedIndexChanged += lvPedidosEnPreparacion_SelectedIndexChanged;
            btnRegistrarControl.Click += btnRegistrarControl_Click;
            btnAgregarBulto.Click += btnAgregarBulto_Click;
            btnConfirmarPreparacion.Click += btnConfirmarPreparacion_Click;
            btnReimprimir.Click += btnReimprimir_Click;
            btnReportarIncidente.Click += btnReportarIncidente_Click;

            HabilitarSeccionesPorModalidad(null);
        }

        // ---------- Mensajes ----------

        private void MostrarError(string mensaje, Control foco = null)
        {
            MessageBox.Show(mensaje, "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (foco != null) foco.Focus();
        }

        private void MostrarInfo(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ---------- Selección de pedido (D.1 / D.2) ----------

        private ListViewItem PedidoSeleccionado()
        {
            return lvPedidosEnPreparacion.SelectedItems.Count == 0 ? null : lvPedidosEnPreparacion.SelectedItems[0];
        }

        private bool ExigirPedido()
        {
            if (PedidoSeleccionado() != null) return true;
            MostrarError("Seleccione un pedido para preparar.", lvPedidosEnPreparacion);
            return false;
        }

        private void lvPedidosEnPreparacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem pedido = PedidoSeleccionado();
            if (pedido == null) return;

            txtCliente.Text = pedido.SubItems[1].Text;
            txtModalidad.Text = pedido.SubItems[2].Text;
            txtDestino.Text = pedido.SubItems[3].Text;

            // Se limpia lo cargado para el pedido anterior.
            lvBultos.Items.Clear();
            foreach (ListViewItem renglon in lvControl.Items)
            {
                renglon.SubItems[ColControlada].Text = "";
                renglon.SubItems[ColDiferencia].Text = "";
            }
            txtCantidadControlada.Clear();
            txtIdBulto.Clear();
            txtCantBulto.Clear();
            txtIdPale.Clear();
            chkPaleConforme.Checked = false;
            chkListo.Checked = false;

            string numero = pedido.SubItems[0].Text;
            txtOrdenEntrega.Text = ordenesEmitidas.ContainsKey(numero) ? ordenesEmitidas[numero] : "";

            HabilitarSeccionesPorModalidad(pedido.SubItems[2].Text);
        }

        // La modalidad define qué secciones se usan: bultos (fulfillment) o revisión de palé (palé cerrado).
        private void HabilitarSeccionesPorModalidad(string modalidad)
        {
            bool fulfillment = modalidad == ModalidadFulfillment;
            bool pale = modalidad == ModalidadPale;

            txtIdBulto.Enabled = fulfillment;
            cboSkuBulto.Enabled = fulfillment;
            txtCantBulto.Enabled = fulfillment;
            btnAgregarBulto.Enabled = fulfillment;

            txtIdPale.Enabled = pale;
            chkPaleConforme.Enabled = pale;
        }

        // ---------- Control de cantidades (D.3) ----------

        private static bool TryEntero(string texto, int minimo, out int valor)
        {
            valor = 0;
            string t = (texto ?? "").Trim();
            if (t.Length == 0 || !Regex.IsMatch(t, "^[0-9]+$")) return false;
            return int.TryParse(t, out valor) && valor >= minimo;
        }

        private void btnRegistrarControl_Click(object sender, EventArgs e)
        {
            if (!ExigirPedido()) return;

            if (lvControl.SelectedItems.Count == 0)
            {
                MostrarError("Seleccione el renglón del pedido a controlar.", lvControl);
                return;
            }

            int controlada;
            if (!TryEntero(txtCantidadControlada.Text, 0, out controlada))
            {
                MostrarError("Ingrese una cantidad controlada válida (número entero mayor o igual a 0, hasta 6 dígitos).", txtCantidadControlada);
                return;
            }

            ListViewItem renglon = lvControl.SelectedItems[0];
            int solicitada = int.Parse(renglon.SubItems[ColSolicitada].Text);
            string sku = renglon.SubItems[ColSku].Text;

            renglon.SubItems[ColControlada].Text = controlada.ToString();
            renglon.SubItems[ColDiferencia].Text = (controlada - solicitada).ToString();

            if (controlada != solicitada)
            {
                MostrarError("La cantidad controlada de " + sku + " (" + controlada + ") no coincide con la solicitada (" + solicitada + ").", txtCantidadControlada);
            }
        }

        // ---------- Bultos (D.4 / D.5) ----------

        private ListViewItem BuscarRenglon(string sku)
        {
            foreach (ListViewItem renglon in lvControl.Items)
                if (renglon.SubItems[ColSku].Text == sku) return renglon;
            return null;
        }

        private int CantidadEmpacada(string sku)
        {
            int total = 0;
            foreach (ListViewItem bulto in lvBultos.Items)
                if (bulto.SubItems[ColBultoSku].Text == sku)
                    total += int.Parse(bulto.SubItems[ColBultoCantidad].Text);
            return total;
        }

        private void btnAgregarBulto_Click(object sender, EventArgs e)
        {
            if (!ExigirPedido()) return;

            string idBulto = txtIdBulto.Text.Trim();
            if (idBulto.Length == 0 || idBulto.Length > 20 || !PatronIdentificacion.IsMatch(idBulto))
            {
                MostrarError("Ingrese una identificación de bulto (hasta 20 caracteres, sin repetir). Solo letras, números y guion.", txtIdBulto);
                return;
            }

            string sku = cboSkuBulto.SelectedItem == null ? "" : cboSkuBulto.SelectedItem.ToString();
            if (sku.Length == 0)
            {
                MostrarError("Seleccione el SKU que contiene el bulto.", cboSkuBulto);
                return;
            }

            int cantidad;
            if (!TryEntero(txtCantBulto.Text, 1, out cantidad))
            {
                MostrarError("Ingrese una cantidad empacada válida (número entero mayor o igual a 1, hasta 6 dígitos).", txtCantBulto);
                return;
            }

            ListViewItem renglon = BuscarRenglon(sku);
            if (renglon == null)
            {
                MostrarError("El SKU " + sku + " no pertenece al pedido seleccionado.", cboSkuBulto);
                return;
            }

            foreach (ListViewItem bulto in lvBultos.Items)
            {
                if (string.Equals(bulto.SubItems[0].Text, idBulto, StringComparison.OrdinalIgnoreCase))
                {
                    MostrarError("La identificación de bulto " + idBulto + " ya fue ingresada en este pedido. Use una identificación distinta.", txtIdBulto);
                    return;
                }
            }

            int solicitada = int.Parse(renglon.SubItems[ColSolicitada].Text);
            if (CantidadEmpacada(sku) + cantidad > solicitada)
            {
                MostrarError("Las cantidades empacadas de " + sku + " no pueden superar las solicitadas (" + solicitada + ").", txtCantBulto);
                return;
            }

            lvBultos.Items.Add(new ListViewItem(new string[] { idBulto, sku, renglon.SubItems[1].Text, cantidad.ToString() }));
            txtIdBulto.Clear();
            txtCantBulto.Clear();
            txtIdBulto.Focus();
        }

        // ---------- Confirmación (D.6 a D.9) ----------

        private void btnConfirmarPreparacion_Click(object sender, EventArgs e)
        {
            if (!ExigirPedido()) return;

            ListViewItem pedido = PedidoSeleccionado();
            string numero = pedido.SubItems[0].Text;

            // La orden de entrega se emite una sola vez: si ya existe, solo se informa.
            if (pedido.SubItems[ColEstadoPedido].Text == EstadoPreparada)
            {
                MostrarInfo("La orden de entrega ya fue emitida: " + ordenesEmitidas[numero] + ".", "Orden de entrega");
                return;
            }

            string modalidad = pedido.SubItems[2].Text;

            // Cantidades controladas contra lo solicitado (D.3).
            foreach (ListViewItem renglon in lvControl.Items)
            {
                string sku = renglon.SubItems[ColSku].Text;
                string controlada = renglon.SubItems[ColControlada].Text;
                int solicitada = int.Parse(renglon.SubItems[ColSolicitada].Text);

                if (controlada.Length == 0)
                {
                    MostrarError("Registre la cantidad controlada de " + sku + " antes de confirmar.", lvControl);
                    return;
                }
                if (int.Parse(controlada) != solicitada)
                {
                    MostrarError("La cantidad controlada de " + sku + " (" + controlada + ") no coincide con la solicitada (" + solicitada + ").", lvControl);
                    return;
                }
            }

            if (modalidad == ModalidadFulfillment)
            {
                if (lvBultos.Items.Count == 0)
                {
                    MostrarError("Ingrese al menos un bulto con su contenido.", txtIdBulto);
                    return;
                }
                foreach (ListViewItem renglon in lvControl.Items)
                {
                    string sku = renglon.SubItems[ColSku].Text;
                    int solicitada = int.Parse(renglon.SubItems[ColSolicitada].Text);
                    int empacada = CantidadEmpacada(sku);

                    if (empacada > solicitada)
                    {
                        MostrarError("Las cantidades empacadas de " + sku + " no pueden superar las solicitadas (" + solicitada + ").", lvBultos);
                        return;
                    }
                    if (empacada < solicitada)
                    {
                        MostrarError("Las cantidades empacadas de " + sku + " no cubren lo solicitado (" + solicitada + ").", lvBultos);
                        return;
                    }
                }
            }
            else if (modalidad == ModalidadPale)
            {
                if (!string.Equals(txtIdPale.Text.Trim(), PaleAsignado, StringComparison.OrdinalIgnoreCase))
                {
                    MostrarError("El palé identificado no corresponde al pedido.", txtIdPale);
                    return;
                }
                if (!chkPaleConforme.Checked)
                {
                    MostrarError("Confirme la conformidad de la revisión del palé.", chkPaleConforme);
                    return;
                }
            }

            if (!chkListo.Checked)
            {
                MostrarError("Confirme que el pedido está completo y listo para Despacho.", chkListo);
                return;
            }

            // Todo validado: se emite la orden de entrega (P05).
            string orden = "OE-" + numero.Replace("OP-", "").PadLeft(9, '0');
            ordenesEmitidas[numero] = orden;
            pedido.SubItems[ColEstadoPedido].Text = EstadoPreparada;
            txtOrdenEntrega.Text = orden;

            MostrarInfo("Pedido " + numero + " preparado.\nOrden de entrega emitida: " + orden + ".", "Preparación confirmada");
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            if (!ExigirPedido()) return;

            string numero = PedidoSeleccionado().SubItems[0].Text;
            if (!ordenesEmitidas.ContainsKey(numero))
            {
                MostrarError("El pedido todavía no tiene una orden de entrega emitida.");
                return;
            }

            MostrarInfo("Orden de entrega: " + ordenesEmitidas[numero] + ".\nSe reimprime el documento existente.", "Reimpresión");
        }

        private void btnReportarIncidente_Click(object sender, EventArgs e)
        {
            if (!ExigirPedido()) return;

            string numero = PedidoSeleccionado().SubItems[0].Text;
            MostrarInfo("Incidente informado para el pedido " + numero + ".", "Incidente");
        }
    }
}
