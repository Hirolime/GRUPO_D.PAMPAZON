using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GRUPO_D.PAMPAZON.Comun;

namespace GRUPO_D.PAMPAZON.CU4_RecepcionDespachoPedidos
{
    public partial class RecepcionDespachoPedidosForm : Form
    {
        private class Renglon
        {
            public string Sku { get; set; } = "";
            public string Producto { get; set; } = "";
            public int Cantidad { get; set; }
        }

        private class OrdenEntrega
        {
            public string Numero { get; set; } = "";
            public string Pedido { get; set; } = "";
            public int Bultos { get; set; }
            public List<Renglon> Renglones { get; set; } = new List<Renglon>();
        }

        private class OrdenDespacho
        {
            public string Op { get; set; } = "";
            public string Estado { get; set; } = "";
            public string Transportista { get; set; } = "";
        }

        private readonly List<OrdenEntrega> ordenesEntrega = new List<OrdenEntrega>();
        private readonly List<OrdenDespacho> ordenesDespacho = new List<OrdenDespacho>();

        public RecepcionDespachoPedidosForm()
        {
            InitializeComponent();

            CargarDatosPrueba();

            // Eventos Pestaña 1
            btnBuscarRecepcion.Click += btnBuscarRecepcion_Click;
            btnLimpiarRecepcion.Click += btnLimpiarRecepcion_Click;
            lvEntregasPreparadas.SelectedIndexChanged += lvEntregasPreparadas_SelectedIndexChanged;
            btnConfirmarRecepcion.Click += btnConfirmarRecepcion_Click;

            // Eventos Pestaña 2
            btnBuscarDespacho.Click += btnBuscarDespacho_Click;
            btnCerrarDespacho.Click += btnCerrarDespacho_Click;

            MostrarEntregasPreparadas(ordenesEntrega);
            MostrarOrdenesDespacho(ordenesDespacho);
        }

        private void CargarDatosPrueba()
        {
            ordenesEntrega.Add(new OrdenEntrega
            {
                Numero = "OE-000051",
                Pedido = "OP-000181",
                Bultos = 2,
                Renglones = new List<Renglon>
                {
                    new Renglon { Sku = "SKU-001", Producto = "Remera de algodón", Cantidad = 80 },
                    new Renglon { Sku = "SKU-002", Producto = "Pantalón deportivo", Cantidad = 30 }
                }
            });

            ordenesDespacho.Add(new OrdenDespacho { Op = "OP-000181", Estado = EstadoPedido.EnDespacho, Transportista = "TRANS-01" });
            ordenesDespacho.Add(new OrdenDespacho { Op = "OP-000183", Estado = EstadoPedido.EnDespacho, Transportista = "TRANS-02" });
        }

        // --- Pestaña 1: Recepción ---
        private void MostrarEntregasPreparadas(IEnumerable<OrdenEntrega> lista)
        {
            lvEntregasPreparadas.Items.Clear();
            foreach (OrdenEntrega o in lista)
            {
                ListViewItem item = new ListViewItem(new string[] { o.Numero, o.Pedido, o.Bultos.ToString() });
                item.Tag = o;
                lvEntregasPreparadas.Items.Add(item);
            }
        }

        private void btnBuscarRecepcion_Click(object? sender, EventArgs e)
        {
            string texto = txtFiltroEntrega.Text.Trim();
            if (texto.Length == 0)
            {
                MostrarEntregasPreparadas(ordenesEntrega);
                return;
            }

            var encontradas = ordenesEntrega.Where(o => o.Numero.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            MostrarEntregasPreparadas(encontradas);
            lvControlRecepcion.Items.Clear();
        }

        private void btnLimpiarRecepcion_Click(object? sender, EventArgs e)
        {
            txtFiltroEntrega.Clear();
            MostrarEntregasPreparadas(ordenesEntrega);
            lvControlRecepcion.Items.Clear();
        }

        private void lvEntregasPreparadas_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lvEntregasPreparadas.SelectedItems.Count == 0) return;

            OrdenEntrega orden = (OrdenEntrega)lvEntregasPreparadas.SelectedItems[0].Tag!;
            lvControlRecepcion.Items.Clear();

            foreach (Renglon r in orden.Renglones)
            {
                ListViewItem fila = new ListViewItem(new string[] { r.Sku, r.Producto, r.Cantidad.ToString() });
                fila.Tag = r;
                lvControlRecepcion.Items.Add(fila);
            }
        }

        private void btnConfirmarRecepcion_Click(object? sender, EventArgs e)
        {
            if (lvEntregasPreparadas.SelectedItems.Count == 0)
            {
                Mensajes.Error("Seleccione una orden de entrega.", lvEntregasPreparadas);
                return;
            }

            OrdenEntrega orden = (OrdenEntrega)lvEntregasPreparadas.SelectedItems[0].Tag!;
            Mensajes.Info($"Recepción confirmada para la Orden de Entrega {orden.Numero}.", "Confirmación");
        }

        // --- Pestaña 2: Despacho ---
        private void MostrarOrdenesDespacho(IEnumerable<OrdenDespacho> lista)
        {
            lvEntregasEnDespacho.Items.Clear();
            foreach (OrdenDespacho o in lista)
            {
                ListViewItem item = new ListViewItem(new string[] { o.Op, o.Estado });
                item.Tag = o;
                lvEntregasEnDespacho.Items.Add(item);
            }
        }

        private void btnBuscarDespacho_Click(object? sender, EventArgs e)
        {
            string transportista = txtTransportista.Text.Trim();
            if (transportista.Length == 0)
            {
                MostrarOrdenesDespacho(ordenesDespacho);
                return;
            }

            var encontradas = ordenesDespacho.Where(o => o.Transportista.IndexOf(transportista, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            MostrarOrdenesDespacho(encontradas);
        }

        private void btnCerrarDespacho_Click(object? sender, EventArgs e)
        {
            if (lvEntregasEnDespacho.SelectedItems.Count == 0)
            {
                Mensajes.Error("Seleccione una orden para cerrar el despacho.", lvEntregasEnDespacho);
                return;
            }

            OrdenDespacho orden = (OrdenDespacho)lvEntregasEnDespacho.SelectedItems[0].Tag!;
            Mensajes.Info($"Despacho cerrado exitosamente para la orden {orden.Op}.", "Despacho Cerrado");
        }
    }
}