using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GRUPO_D.PAMPAZON.Comun;

namespace GRUPO_D.PAMPAZON.CU3_EmpaquetadoPreparacionEntregas
{
    /// <summary>
    /// CU3 - Empaquetado y preparación de entregas (P04 Empaquetar, P05 Emitir orden de entrega).
    /// Validaciones de datos según la planilla de apoyo (campos D.1 a D.9).
    /// Los controles y su diseño están en el Designer; acá se conectan los eventos y se validan los datos.
    /// </summary>
    public partial class EmpaquetadoPreparacionEntregasForm : Form
    {
        // ---------- Datos de prueba del prototipo (en el sistema real vienen de la base) ----------

        private class Renglon
        {
            public string Sku = "";
            public string Producto = "";
            public int Solicitada;
            public int Entregada;
            public int? Controlada;
        }

        private class Bulto
        {
            public string Identificacion = "";
            public string Sku = "";
            public string Producto = "";
            public int Cantidad;
        }

        private class Pedido
        {
            public string Numero = "";
            public string Cliente = "";
            public string Modalidad = "";
            public string Destino = "";
            public string Selecciones = "Completas";
            public string Estado = EstadoPedido.EnPreparacion;
            // Código del palé que viene de la orden de selección (D.6); vacío en fulfillment.
            public string Pale = "";
            public string OrdenEntrega = "";
            public List<Renglon> Renglones = new List<Renglon>();
            public List<Bulto> Bultos = new List<Bulto>();
        }

        private readonly List<Pedido> pedidos = new List<Pedido>();

        public EmpaquetadoPreparacionEntregasForm()
        {
            InitializeComponent();

            cboDeposito.SelectedItem = Formatos.DepositoActual;

            CargarDatosPrueba();

            lvPedidosEnPreparacion.SelectedIndexChanged += lvPedidosEnPreparacion_SelectedIndexChanged;
            btnRegistrarControl.Click += btnRegistrarControl_Click;
            btnAgregarBulto.Click += btnAgregarBulto_Click;
            btnConfirmarPreparacion.Click += btnConfirmarPreparacion_Click;
            btnReimprimirOrdenEntrega.Click += btnReimprimirOrdenEntrega_Click;
            btnReportarIncidente.Click += btnReportarIncidente_Click;

            MostrarPedidos();
            MostrarPedido(null);
        }

        private void CargarDatosPrueba()
        {
            pedidos.Add(new Pedido
            {
                Numero = "OP-000181", Cliente = "Cliente Demo A", Modalidad = Modalidad.Fulfillment, Destino = "Destino demo A",
                Renglones = new List<Renglon>
                {
                    new Renglon { Sku = "SKU-001", Producto = "Remera de algodón", Solicitada = 80, Entregada = 80 },
                    new Renglon { Sku = "SKU-002", Producto = "Pantalón deportivo", Solicitada = 30, Entregada = 30 }
                }
            });
            pedidos.Add(new Pedido
            {
                Numero = "OP-000183", Cliente = "Cliente Demo B", Modalidad = Modalidad.PaleCerrado, Destino = "Destino demo B", Pale = "PAL-000183",
                Renglones = new List<Renglon> { new Renglon { Sku = "SKU-002", Producto = "Pantalón deportivo", Solicitada = 20, Entregada = 20 } }
            });
        }

        // ---------- Pedido elegido (D.1 / D.2) ----------

        private void MostrarPedidos()
        {
            lvPedidosEnPreparacion.Items.Clear();
            foreach (Pedido p in pedidos)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Numero, p.Cliente, p.Modalidad, p.Destino, p.Selecciones, p.Estado });
                item.Tag = p;
                lvPedidosEnPreparacion.Items.Add(item);
            }
        }

        private Pedido? PedidoElegido()
        {
            return lvPedidosEnPreparacion.SelectedItems.Count == 0 ? null : (Pedido)lvPedidosEnPreparacion.SelectedItems[0].Tag!;
        }

        private Pedido? ExigirPedido()
        {
            Pedido? pedido = PedidoElegido();
            if (pedido == null)
                Mensajes.Error("Seleccione un pedido para preparar.", lvPedidosEnPreparacion);
            return pedido;
        }

        private void lvPedidosEnPreparacion_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Pedido? pedido = PedidoElegido();
            if (pedido != null) MostrarPedido(pedido);
        }

        // Muestra los datos, el control y los bultos del pedido; sin pedido, deja la pantalla vacía.
        private void MostrarPedido(Pedido? pedido)
        {
            txtCliente.Text = pedido?.Cliente ?? "";
            txtModalidad.Text = pedido?.Modalidad ?? "";
            txtDestino.Text = pedido?.Destino ?? "";
            txtOrdenEntrega.Text = pedido?.OrdenEntrega ?? "";

            lvControlCantidades.Items.Clear();
            cboSkuBulto.Items.Clear();
            if (pedido != null)
            {
                foreach (Renglon r in pedido.Renglones)
                {
                    ListViewItem fila = new ListViewItem(new string[]
                    {
                        r.Sku, r.Producto, r.Solicitada.ToString(), r.Entregada.ToString(),
                        r.Controlada.HasValue ? r.Controlada.Value.ToString() : "",
                        r.Controlada.HasValue ? (r.Controlada.Value - r.Solicitada).ToString() : ""
                    });
                    fila.Tag = r;
                    lvControlCantidades.Items.Add(fila);
                    cboSkuBulto.Items.Add(r.Sku);
                }
                if (cboSkuBulto.Items.Count > 0) cboSkuBulto.SelectedItem = cboSkuBulto.Items[0];
            }
            MostrarBultos(pedido);

            txtCantidadControlada.Clear();
            txtIdentificacionBulto.Clear();
            txtCantidadBulto.Clear();
            txtIdentificacionPale.Clear();
            chkPaleConforme.Checked = false;
            chkListoDespacho.Checked = false;

            HabilitarSeccionesPorModalidad(pedido?.Modalidad);
        }

        private void MostrarBultos(Pedido? pedido)
        {
            lvBultos.Items.Clear();
            if (pedido == null) return;
            foreach (Bulto b in pedido.Bultos)
                lvBultos.Items.Add(new ListViewItem(new string[] { b.Identificacion, b.Sku, b.Producto, b.Cantidad.ToString() }));
        }

        // La modalidad define qué secciones se usan: bultos (fulfillment) o revisión de palé (palé cerrado).
        private void HabilitarSeccionesPorModalidad(string? modalidad)
        {
            bool fulfillment = modalidad == Modalidad.Fulfillment;
            bool pale = modalidad == Modalidad.PaleCerrado;

            txtIdentificacionBulto.Enabled = fulfillment;
            cboSkuBulto.Enabled = fulfillment;
            txtCantidadBulto.Enabled = fulfillment;
            btnAgregarBulto.Enabled = fulfillment;

            txtIdentificacionPale.Enabled = pale;
            chkPaleConforme.Enabled = pale;
        }

        // ---------- Control de cantidades (D.3) ----------

        private static string MensajeControlDistinto(Renglon r)
        {
            return "La cantidad controlada de " + r.Sku + " (" + r.Controlada + ") no coincide con la solicitada (" + r.Solicitada + ").";
        }

        private void btnRegistrarControl_Click(object? sender, EventArgs e)
        {
            if (ExigirPedido() == null) return;

            if (lvControlCantidades.SelectedItems.Count == 0)
            {
                Mensajes.Error("Seleccione el renglón del pedido a controlar.", lvControlCantidades);
                return;
            }

            int controlada;
            if (!Validaciones.EsCantidad(txtCantidadControlada.Text, 0, out controlada))
            {
                Mensajes.Error("Ingrese una cantidad controlada válida (número entero mayor o igual a 0, hasta 6 dígitos).", txtCantidadControlada);
                return;
            }

            ListViewItem fila = lvControlCantidades.SelectedItems[0];
            Renglon renglon = (Renglon)fila.Tag!;
            renglon.Controlada = controlada;
            fila.SubItems[colControlCantidadesControlada.Index].Text = controlada.ToString();
            fila.SubItems[colControlCantidadesDiferencia.Index].Text = (controlada - renglon.Solicitada).ToString();

            if (controlada != renglon.Solicitada)
                Mensajes.Error(MensajeControlDistinto(renglon), txtCantidadControlada);
        }

        // ---------- Bultos (D.4 / D.5) ----------

        private static int CantidadEmpacada(Pedido pedido, string sku)
        {
            return pedido.Bultos.Where(b => b.Sku == sku).Sum(b => b.Cantidad);
        }

        private void btnAgregarBulto_Click(object? sender, EventArgs e)
        {
            Pedido? pedido = ExigirPedido();
            if (pedido == null) return;

            string idBulto = txtIdentificacionBulto.Text.Trim();
            if (!Validaciones.EsIdentificacion(idBulto))
            {
                Mensajes.Error("Ingrese una identificación de bulto (hasta 20 caracteres, sin repetir). Solo letras, números y guion.", txtIdentificacionBulto);
                return;
            }

            if (!(cboSkuBulto.SelectedItem is string sku))
            {
                Mensajes.Error("Seleccione el SKU que contiene el bulto.", cboSkuBulto);
                return;
            }

            int cantidad;
            if (!Validaciones.EsCantidad(txtCantidadBulto.Text, 1, out cantidad))
            {
                Mensajes.Error("Ingrese una cantidad empacada válida (número entero mayor o igual a 1, hasta 6 dígitos).", txtCantidadBulto);
                return;
            }

            Renglon? renglon = pedido.Renglones.FirstOrDefault(r => r.Sku == sku);
            if (renglon == null)
            {
                Mensajes.Error("El SKU " + sku + " no pertenece al pedido seleccionado.", cboSkuBulto);
                return;
            }

            if (pedido.Bultos.Any(b => string.Equals(b.Identificacion, idBulto, StringComparison.OrdinalIgnoreCase)))
            {
                Mensajes.Error("La identificación de bulto " + idBulto + " ya fue ingresada en este pedido. Use una identificación distinta.", txtIdentificacionBulto);
                return;
            }

            if (CantidadEmpacada(pedido, sku) + cantidad > renglon.Solicitada)
            {
                Mensajes.Error("Las cantidades empacadas de " + sku + " no pueden superar las solicitadas (" + renglon.Solicitada + ").", txtCantidadBulto);
                return;
            }

            pedido.Bultos.Add(new Bulto { Identificacion = idBulto, Sku = sku, Producto = renglon.Producto, Cantidad = cantidad });
            MostrarBultos(pedido);
            txtIdentificacionBulto.Clear();
            txtCantidadBulto.Clear();
            txtIdentificacionBulto.Focus();
        }

        // ---------- Confirmación (D.6 a D.9) ----------

        private void btnConfirmarPreparacion_Click(object? sender, EventArgs e)
        {
            Pedido? pedido = ExigirPedido();
            if (pedido == null) return;

            // La orden de entrega se emite una sola vez: si ya existe, solo se informa.
            if (pedido.Estado == EstadoPedido.Preparada)
            {
                Mensajes.Info("La orden de entrega ya fue emitida: " + pedido.OrdenEntrega + ".", "Orden de entrega");
                return;
            }

            // Cantidades controladas contra lo solicitado (D.3).
            foreach (Renglon r in pedido.Renglones)
            {
                if (!r.Controlada.HasValue)
                {
                    Mensajes.Error("Registre la cantidad controlada de " + r.Sku + " antes de confirmar.", lvControlCantidades);
                    return;
                }
                if (r.Controlada.Value != r.Solicitada)
                {
                    Mensajes.Error(MensajeControlDistinto(r), lvControlCantidades);
                    return;
                }
            }

            if (pedido.Modalidad == Modalidad.Fulfillment)
            {
                if (pedido.Bultos.Count == 0)
                {
                    Mensajes.Error("Ingrese al menos un bulto con su contenido.", txtIdentificacionBulto);
                    return;
                }
                foreach (Renglon r in pedido.Renglones)
                {
                    int empacada = CantidadEmpacada(pedido, r.Sku);
                    if (empacada > r.Solicitada)
                    {
                        Mensajes.Error("Las cantidades empacadas de " + r.Sku + " no pueden superar las solicitadas (" + r.Solicitada + ").", lvBultos);
                        return;
                    }
                    if (empacada < r.Solicitada)
                    {
                        Mensajes.Error("Las cantidades empacadas de " + r.Sku + " no cubren lo solicitado (" + r.Solicitada + ").", lvBultos);
                        return;
                    }
                }
            }
            else if (pedido.Modalidad == Modalidad.PaleCerrado)
            {
                if (!string.Equals(txtIdentificacionPale.Text.Trim(), pedido.Pale, StringComparison.OrdinalIgnoreCase))
                {
                    Mensajes.Error("El palé identificado no corresponde al pedido.", txtIdentificacionPale);
                    return;
                }
                if (!chkPaleConforme.Checked)
                {
                    Mensajes.Error("Confirme la conformidad de la revisión del palé.", chkPaleConforme);
                    return;
                }
            }

            if (!chkListoDespacho.Checked)
            {
                Mensajes.Error("Confirme que el pedido está completo y listo para Despacho.", chkListoDespacho);
                return;
            }

            // Todo validado: se emite la orden de entrega (P05).
            pedido.OrdenEntrega = Numeracion.CambiarPrefijo(pedido.Numero, Numeracion.OrdenEntrega);
            pedido.Estado = EstadoPedido.Preparada;
            lvPedidosEnPreparacion.SelectedItems[0].SubItems[colPedidosEnPreparacionEstado.Index].Text = pedido.Estado;
            txtOrdenEntrega.Text = pedido.OrdenEntrega;

            Mensajes.Info("Pedido " + pedido.Numero + " preparado." + Environment.NewLine +
                          "Orden de entrega emitida: " + pedido.OrdenEntrega + ".", "Preparación confirmada");
        }

        private void btnReimprimirOrdenEntrega_Click(object? sender, EventArgs e)
        {
            Pedido? pedido = ExigirPedido();
            if (pedido == null) return;

            if (pedido.OrdenEntrega.Length == 0)
            {
                Mensajes.Error("El pedido todavía no tiene una orden de entrega emitida.");
                return;
            }

            Mensajes.Info("Orden de entrega: " + pedido.OrdenEntrega + "." + Environment.NewLine + "Se reimprime el documento existente.", "Reimpresión");
        }

        private void btnReportarIncidente_Click(object? sender, EventArgs e)
        {
            Pedido? pedido = ExigirPedido();
            if (pedido == null) return;

            Mensajes.Info("Incidente informado para el pedido " + pedido.Numero + ".", "Incidente");
        }
    }
}
