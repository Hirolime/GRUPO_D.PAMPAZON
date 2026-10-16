using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GRUPO_D.PAMPAZON.Comun;

namespace GRUPO_D.PAMPAZON.CU4_RecepcionDespachoPedidos
{
    /// <summary>
    /// CU4 - Recepción y despacho de pedidos (E01 Recibir pedido preparado, E03 Entregar mercadería y cerrar despacho,
    /// con E02, E04 y E05). Validaciones de datos según la planilla de apoyo (campos E.1 a E.5 y F.1 a F.6).
    /// Los controles y su diseño están en el Designer; acá se conectan los eventos y se validan los datos.
    /// </summary>
    public partial class RecepcionDespachoPedidosForm : Form
    {
        private const int MaxLargoFlete = 20;

        // Prototipo: en el sistema real los transportistas autorizados salen del contrato o del flete confirmado (E02).
        private static readonly string[] TransportistasAutorizados = { "Transportista Demo 1", "Transportista Demo 2" };

        // ---------- Datos de prueba del prototipo (en el sistema real vienen de la base) ----------

        private class Renglon
        {
            public string Sku = "";
            public string Producto = "";
            public int Cantidad;
            public int? Recibida;
        }

        private class OrdenEntrega
        {
            public string Numero = "";
            public string Pedido = "";
            public string Cliente = "";
            public string Origen = "";
            public string Destino = "";
            public int Bultos;
            public string Estado = EstadoPedido.Preparada;
            public string Observacion = "";
            public string Documento = "";
            public List<Renglon> Renglones = new List<Renglon>();
        }

        private readonly List<OrdenEntrega> ordenesEntrega = new List<OrdenEntrega>();

        public RecepcionDespachoPedidosForm()
        {
            InitializeComponent();

            cboDeposito.SelectedItem = Formatos.DepositoActual;

            CargarDatosPrueba();

            btnBuscar.Click += btnBuscar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            lvEntregasPreparadas.SelectedIndexChanged += lvEntregasPreparadas_SelectedIndexChanged;
            btnRegistrarRecepcion.Click += btnRegistrarRecepcion_Click;
            btnConfirmarRecepcion.Click += btnConfirmarRecepcion_Click;
            btnReportarIncidenteRecepcion.Click += btnReportarIncidenteRecepcion_Click;

            lvEntregasEnDespacho.SelectedIndexChanged += lvEntregasEnDespacho_SelectedIndexChanged;
            btnEmitirDocumento.Click += btnEmitirDocumento_Click;
            btnCerrarDespacho.Click += btnCerrarDespacho_Click;
            btnReportarIncidenteDespacho.Click += btnReportarIncidenteDespacho_Click;

            MostrarEntregasPreparadas(ordenesEntrega);
            lvControlRecepcion.Items.Clear();
            MostrarEntregasEnDespacho();
        }

        private void CargarDatosPrueba()
        {
            ordenesEntrega.Add(new OrdenEntrega
            {
                Numero = "OE-000051", Pedido = "OP-000181", Cliente = "Cliente Demo A", Origen = Origen.Cliente, Destino = "Destino demo A", Bultos = 2,
                Renglones = new List<Renglon>
                {
                    new Renglon { Sku = "SKU-001", Producto = "Remera de algodón", Cantidad = 80 },
                    new Renglon { Sku = "SKU-002", Producto = "Pantalón deportivo", Cantidad = 30 }
                }
            });
            ordenesEntrega.Add(new OrdenEntrega
            {
                Numero = "OE-000052", Pedido = "TR-000026", Cliente = "Cliente Demo A", Origen = Origen.TrasladoInterno, Destino = "Destino demo B", Bultos = 1,
                Renglones = new List<Renglon> { new Renglon { Sku = "SKU-002", Producto = "Pantalón deportivo", Cantidad = 20 } }
            });
        }

        private static ListViewItem FilaOrdenEntrega(OrdenEntrega o)
        {
            ListViewItem item = new ListViewItem(new string[] { o.Numero, o.Pedido, o.Cliente, o.Origen, o.Destino, o.Bultos.ToString(), o.Estado });
            item.Tag = o;
            return item;
        }

        // ---------- Búsqueda (E.1) ----------

        private void MostrarEntregasPreparadas(IEnumerable<OrdenEntrega> lista)
        {
            lvEntregasPreparadas.Items.Clear();
            foreach (OrdenEntrega o in lista) lvEntregasPreparadas.Items.Add(FilaOrdenEntrega(o));
        }

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            string texto = txtFiltroEntrega.Text.Trim();
            if (texto.Length == 0)
            {
                MostrarEntregasPreparadas(ordenesEntrega);
                return;
            }
            if (Validaciones.SuperaLargo(texto, Validaciones.MaxLargoBusqueda))
            {
                Mensajes.Error("El número de orden de entrega admite hasta 30 caracteres.", txtFiltroEntrega);
                return;
            }

            List<OrdenEntrega> encontradas = ordenesEntrega.Where(o => o.Numero.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            MostrarEntregasPreparadas(encontradas);
            lvControlRecepcion.Items.Clear();
            if (encontradas.Count == 0)
                Mensajes.Error("La orden de entrega no existe o pertenece a otro depósito.", txtFiltroEntrega);
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            txtFiltroEntrega.Clear();
            MostrarEntregasPreparadas(ordenesEntrega);
            lvControlRecepcion.Items.Clear();
        }

        // ---------- Orden a recibir (E.2) ----------

        private OrdenEntrega? EntregaARecibir()
        {
            return lvEntregasPreparadas.SelectedItems.Count == 0 ? null : (OrdenEntrega)lvEntregasPreparadas.SelectedItems[0].Tag!;
        }

        private OrdenEntrega? ExigirEntregaARecibir()
        {
            OrdenEntrega? orden = EntregaARecibir();
            if (orden == null)
                Mensajes.Error("Seleccione una orden de entrega.", lvEntregasPreparadas);
            return orden;
        }

        private void lvEntregasPreparadas_SelectedIndexChanged(object? sender, EventArgs e)
        {
            OrdenEntrega? orden = EntregaARecibir();
            if (orden == null) return;

            lvControlRecepcion.Items.Clear();
            foreach (Renglon r in orden.Renglones)
            {
                string recibida = r.Recibida.HasValue ? r.Recibida.Value.ToString() : "";
                string diferencia = r.Recibida.HasValue ? (r.Recibida.Value - r.Cantidad).ToString() : "";
                ListViewItem fila = new ListViewItem(new string[] { r.Sku, r.Producto, r.Cantidad.ToString(), recibida, diferencia });
                fila.Tag = r;
                lvControlRecepcion.Items.Add(fila);
            }
            txtCantidadRecibida.Clear();
            txtObservacionRecepcion.Text = orden.Observacion;
            chkRecepcionCompleta.Checked = false;
        }

        // ---------- Cantidad recibida por renglón (E.3) ----------

        private void btnRegistrarRecepcion_Click(object? sender, EventArgs e)
        {
            OrdenEntrega? orden = ExigirEntregaARecibir();
            if (orden == null) return;

            if (orden.Estado != EstadoPedido.Preparada)
            {
                Mensajes.Info("La orden de entrega " + orden.Numero + " ya fue recibida. Estado: " + orden.Estado + ".", "Recepción existente");
                return;
            }

            if (lvControlRecepcion.SelectedItems.Count == 0)
            {
                Mensajes.Error("Seleccione el renglón al que corresponde la cantidad recibida.", lvControlRecepcion);
                return;
            }

            int recibida;
            if (!Validaciones.EsCantidad(txtCantidadRecibida.Text, 0, out recibida))
            {
                Mensajes.Error("Ingrese una cantidad recibida válida (número entero mayor o igual a 0, hasta 6 dígitos).", txtCantidadRecibida);
                return;
            }

            ListViewItem fila = lvControlRecepcion.SelectedItems[0];
            Renglon renglon = (Renglon)fila.Tag!;
            renglon.Recibida = recibida;
            fila.SubItems[colControlRecepcionRecibida.Index].Text = recibida.ToString();
            fila.SubItems[colControlRecepcionDiferencia.Index].Text = (recibida - renglon.Cantidad).ToString();

            if (recibida != renglon.Cantidad)
                Mensajes.Error("Los bultos recibidos no coinciden con la orden de entrega.", txtCantidadRecibida);
            else
                txtCantidadRecibida.Clear();
        }

        // ---------- Confirmar recepción (E.2 a E.5) ----------

        private void btnConfirmarRecepcion_Click(object? sender, EventArgs e)
        {
            OrdenEntrega? orden = ExigirEntregaARecibir();
            if (orden == null) return;

            // La recepción se registra una sola vez: si ya existe, solo se informa.
            if (orden.Estado != EstadoPedido.Preparada)
            {
                Mensajes.Info("La orden de entrega " + orden.Numero + " ya fue recibida. Estado: " + orden.Estado + ".", "Recepción existente");
                return;
            }

            if (orden.Renglones.Any(r => !r.Recibida.HasValue))
            {
                Mensajes.Error("Ingrese la cantidad recibida de cada renglón.", lvControlRecepcion);
                return;
            }

            if (orden.Renglones.Any(r => r.Recibida!.Value != r.Cantidad))
            {
                string observacion = txtObservacionRecepcion.Text.Trim();
                if (observacion.Length == 0 || Validaciones.SuperaLargo(observacion, Validaciones.MaxLargoObservacion))
                {
                    Mensajes.Error("Describa la diferencia observada (hasta 200 caracteres).", txtObservacionRecepcion);
                    return;
                }
                // La observación queda registrada y el pedido sigue PREPARADA.
                orden.Observacion = observacion;
                Mensajes.Error("Los bultos recibidos no coinciden con la orden de entrega.", lvControlRecepcion);
                return;
            }

            if (!chkRecepcionCompleta.Checked)
            {
                Mensajes.Error("Confirme la recepción completa de los preparados.", chkRecepcionCompleta);
                return;
            }

            orden.Estado = EstadoPedido.EnDespacho;
            lvEntregasPreparadas.SelectedItems[0].SubItems[colEntregasPreparadasEstado.Index].Text = orden.Estado;
            MostrarEntregasEnDespacho();

            Mensajes.Info("Orden de entrega " + orden.Numero + " recibida. Pedido " + orden.Pedido + " " + EstadoPedido.EnDespacho + "." + Environment.NewLine +
                          "El stock de almacén no cambia.", "Recepción confirmada");
        }

        private void btnReportarIncidenteRecepcion_Click(object? sender, EventArgs e)
        {
            OrdenEntrega? orden = ExigirEntregaARecibir();
            if (orden == null) return;

            Mensajes.Info("Incidente informado para la orden de entrega " + orden.Numero + ".", "Incidente");
        }

        // ---------- Despacho: orden a despachar (F.1) ----------

        private void MostrarEntregasEnDespacho()
        {
            OrdenEntrega? elegida = EntregaADespachar();
            lvEntregasEnDespacho.Items.Clear();
            foreach (OrdenEntrega o in ordenesEntrega.Where(x => x.Estado == EstadoPedido.EnDespacho || x.Estado == EstadoPedido.Despachada))
            {
                ListViewItem item = FilaOrdenEntrega(o);
                lvEntregasEnDespacho.Items.Add(item);
                if (o == elegida) item.Selected = true;
            }
        }

        private OrdenEntrega? EntregaADespachar()
        {
            return lvEntregasEnDespacho.SelectedItems.Count == 0 ? null : (OrdenEntrega)lvEntregasEnDespacho.SelectedItems[0].Tag!;
        }

        private OrdenEntrega? ExigirEntregaADespachar()
        {
            OrdenEntrega? orden = EntregaADespachar();
            if (orden == null)
                Mensajes.Error("Seleccione una orden de entrega a despachar.", lvEntregasEnDespacho);
            return orden;
        }

        private void lvEntregasEnDespacho_SelectedIndexChanged(object? sender, EventArgs e)
        {
            OrdenEntrega? orden = EntregaADespachar();
            if (orden == null) return;

            txtDocumento.Text = orden.Documento;
            chkConformidadRetiro.Checked = false;
        }

        // Valida transportista (F.2) y flete (F.3). Devuelve true si son correctos.
        private bool ValidarTransporte(OrdenEntrega orden)
        {
            string transportista = txtTransportista.Text.Trim();
            if (transportista.Length == 0)
            {
                Mensajes.Error("Ingrese la identificación del transportista.", txtTransportista);
                return false;
            }
            if (Validaciones.SuperaLargo(transportista, Validaciones.MaxLargoTransportista))
            {
                Mensajes.Error("La identificación del transportista admite hasta 60 caracteres.", txtTransportista);
                return false;
            }
            if (!TransportistasAutorizados.Contains(transportista, StringComparer.OrdinalIgnoreCase))
            {
                Mensajes.Error("El transportista no está autorizado para este retiro.", txtTransportista);
                return false;
            }

            string flete = txtFlete.Text.Trim();
            if (orden.Origen == Origen.TrasladoInterno && flete.Length == 0)
            {
                Mensajes.Error("Ingrese la referencia del flete confirmado.", txtFlete);
                return false;
            }
            if (Validaciones.SuperaLargo(flete, MaxLargoFlete))
            {
                Mensajes.Error("La referencia del flete admite hasta 20 caracteres.", txtFlete);
                return false;
            }
            return true;
        }

        // ---------- Emitir documento de salida (F.4 / E04) ----------

        private void btnEmitirDocumento_Click(object? sender, EventArgs e)
        {
            OrdenEntrega? orden = ExigirEntregaADespachar();
            if (orden == null) return;

            if (!ValidarTransporte(orden)) return;

            // Reimprimir no registra otro egreso: si ya existe el documento, solo se muestra.
            if (orden.Documento.Length > 0)
            {
                txtDocumento.Text = orden.Documento;
                Mensajes.Info("El documento de salida ya fue emitido: " + orden.Documento + "." + Environment.NewLine + "Se reimprime el existente.", "Documento de salida");
                return;
            }

            bool traslado = orden.Origen == Origen.TrasladoInterno;
            orden.Documento = Numeracion.CambiarPrefijo(orden.Numero, traslado ? Numeracion.GuiaTraslado : Numeracion.Remito);
            txtDocumento.Text = orden.Documento;

            string tipo = traslado ? "Guía de traslado" : "Remito de entrega";
            Mensajes.Info(tipo + " emitido: " + orden.Documento + "." + Environment.NewLine + "Emitirlo no descuenta stock.", "Documento de salida");
        }

        // ---------- Cerrar despacho (F.1 a F.6 / E05) ----------

        private void btnCerrarDespacho_Click(object? sender, EventArgs e)
        {
            OrdenEntrega? orden = ExigirEntregaADespachar();
            if (orden == null) return;

            // El egreso se registra una sola vez: si ya está DESPACHADA, solo se muestra el comprobante.
            if (orden.Estado == EstadoPedido.Despachada)
            {
                Mensajes.Info("La orden de entrega " + orden.Numero + " ya fue despachada. Comprobante: " + orden.Documento + ".", "Despacho cerrado");
                return;
            }

            if (!ValidarTransporte(orden)) return;

            if (orden.Documento.Length == 0)
            {
                Mensajes.Error("Emita el documento de salida antes de cerrar el despacho.", btnEmitirDocumento);
                return;
            }

            if (!chkConformidadRetiro.Checked)
            {
                Mensajes.Error("Registre la conformidad de retiro del transportista.", chkConformidadRetiro);
                return;
            }

            if (dtpFechaRetiro.Value.Date > DateTime.Today)
            {
                Mensajes.Error("La fecha de retiro no puede ser posterior a hoy.", dtpFechaRetiro);
                return;
            }

            orden.Estado = EstadoPedido.Despachada;
            MostrarEntregasEnDespacho();
            foreach (ListViewItem fila in lvEntregasPreparadas.Items)
                if (fila.Tag == orden) fila.SubItems[colEntregasPreparadasEstado.Index].Text = orden.Estado;

            Mensajes.Info("Despacho cerrado. Pedido " + orden.Pedido + " " + EstadoPedido.Despachada + "." + Environment.NewLine +
                          "Egreso registrado una sola vez. El stock de almacén no cambia.", "Despacho cerrado");
        }

        private void btnReportarIncidenteDespacho_Click(object? sender, EventArgs e)
        {
            OrdenEntrega? orden = ExigirEntregaADespachar();
            if (orden == null) return;

            Mensajes.Info("Incidente informado para la orden de entrega " + orden.Numero + ".", "Incidente");
        }
    }
}
