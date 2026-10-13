using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GRUPO_D.PAMPAZON.Empaquetado_y_Preparación_de_Mercaderias
{
    public partial class EmpaquetadoPreparacionMercaderiasForm1 : Form
    {
        public class DetallePedido
        {
            public string SKU { get; set; }
            public string Producto { get; set; }
            public int CantidadRequerida { get; set; }
            public int CantidadEntregadaAlmacen { get; set; }
        }

        public class Pedido
        {
            public int NumeroPedido { get; set; }
            public string Cliente { get; set; }
            public string Modalidad { get; set; }
            public string Destino { get; set; }
            public string EstadoPedido { get; set; }
            public string EstadoMercaderia { get; set; }
            public int Bultos { get; set; }
            public bool PaleRevisadoConforme { get; set; }
            public string OrdenEntregaP05 { get; set; }
            public List<DetallePedido> Items { get; set; }
        }

        private List<Pedido> listaPedidos = new List<Pedido>();

        public EmpaquetadoPreparacionMercaderiasForm1()
        {
            InitializeComponent();
        }

        private void EmpaquetadoPreparacionMercaderiasForm1_Load(object sender, EventArgs e)
        {
            CargarDatosPrueba();
            ActualizarGrid();
        }

        private void CargarDatosPrueba()
        {
            listaPedidos.Add(new Pedido
            {
                NumeroPedido = 1001,
                Cliente = "Pampazon Distribuidora",
                Modalidad = "Fulfillment",
                Destino = "Av. Corrientes 1234, CABA",
                EstadoPedido = "EN PREPARACIÓN",
                EstadoMercaderia = "En preparación",
                Items = new List<DetallePedido>
                {
                    new DetallePedido { SKU = "SKU-01", Producto = "Caja de Herramientas", CantidadRequerida = 5, CantidadEntregadaAlmacen = 5 },
                    new DetallePedido { SKU = "SKU-02", Producto = "Set de Brocas", CantidadRequerida = 10, CantidadEntregadaAlmacen = 10 }
                }
            });

            listaPedidos.Add(new Pedido
            {
                NumeroPedido = 1002,
                Cliente = "Logística Central",
                Modalidad = "Palé Cerrado",
                Destino = "Ruta 9 Km 40, Pilar",
                EstadoPedido = "EN PREPARACIÓN",
                EstadoMercaderia = "En preparación",
                Items = new List<DetallePedido>
                {
                    new DetallePedido { SKU = "PAL-99", Producto = "Palé Cemento Industrial", CantidadRequerida = 1, CantidadEntregadaAlmacen = 1 }
                }
            });
        }

        private void ActualizarGrid()
        {
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = listaPedidos;
        }

        private void dgvPedidos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow == null) return;

            Pedido ped = (Pedido)dgvPedidos.CurrentRow.DataBoundItem;

            lblModalidadDestino.Text = $"Modalidad: {ped.Modalidad} | Destino: {ped.Destino} | Estado: {ped.EstadoPedido}";

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = ped.Items;

            chkPaleConforme.Visible = (ped.Modalidad == "Palé Cerrado");
            chkPaleConforme.Checked = ped.PaleRevisadoConforme;
            numBultos.Value = ped.Bultos > 0 ? ped.Bultos : 1;
        }

        private void btnConfirmarPreparacion_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow == null) return;
            Pedido ped = (Pedido)dgvPedidos.CurrentRow.DataBoundItem;

            if (ped.EstadoPedido == "PREPARADA" || ped.EstadoPedido == "EN DESPACHO")
            {
                MessageBox.Show($"La orden de entrega P05 ya fue emitida previamente.\nDocumento vinculado: {ped.OrdenEntregaP05}\nReimprimiendo documento existente.",
                                "Consulta/Reimpresión P05", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ped.Modalidad == "Palé Cerrado")
            {
                if (!chkPaleConforme.Checked)
                {
                    MessageBox.Show("Para Palé Cerrado debe confirmar la revisión visual antes del pase.", "Control de Palé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ped.PaleRevisadoConforme = true;
            }
            else
            {
                foreach (var item in ped.Items)
                {
                    if (item.CantidadEntregadaAlmacen < item.CantidadRequerida)
                    {
                        MessageBox.Show($"Diferencia detectada en SKU {item.SKU}. El pedido seguirá EN PREPARACIÓN.", "Error de Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (numBultos.Value <= 0)
            {
                MessageBox.Show("Indique una cantidad válida de bultos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ped.Bultos = (int)numBultos.Value;
            ped.EstadoPedido = "PREPARADA";
            ped.EstadoMercaderia = "Preparado";
            ped.OrdenEntregaP05 = $"OE-P05-{ped.NumeroPedido}-{DateTime.Now:yyyyMMdd}";

            ActualizarGrid();

            MessageBox.Show($"¡Preparación Exitosa!\n\nOrden P05 Emitida: {ped.OrdenEntregaP05}\nBultos: {ped.Bultos}\nEstado: PREPARADA\nMercadería dejada a disposición de Despacho.",
                            "P05 - Pase a Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReportarIncidente_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow == null) return;
            Pedido ped = (Pedido)dgvPedidos.CurrentRow.DataBoundItem;

            MessageBox.Show($"Incidente I04 registrado para el Pedido #{ped.NumeroPedido}.\nObservación notificada.", "Comunicación I04", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
