using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GRUPO_D.PAMPAZON.Comun;

namespace GRUPO_D.PAMPAZON.CU3_EmpaquetadoPreparacionEntregas
{
    public partial class EmpaquetadoPreparacionEntregasForm : Form
    {
        private class Renglon
        {
            public string Sku { get; set; } = "";
            public string Producto { get; set; } = "";
            public int Solicitada { get; set; }
        }

        private class Pedido
        {
            public string Numero { get; set; } = "";
            public List<Renglon> Renglones { get; set; } = new List<Renglon>();
        }

        private Pedido? pedidoActual;

        public EmpaquetadoPreparacionEntregasForm()
        {
            InitializeComponent();

            btnConfirmarPreparacion.Click += btnConfirmarPreparacion_Click;

            CargarPedidoDePrueba();
            MostrarPedido();
        }

        private void CargarPedidoDePrueba()
        {
            pedidoActual = new Pedido
            {
                Numero = "OP-000181",
                Renglones = new List<Renglon>
                {
                    new Renglon { Sku = "SKU-001", Producto = "Remera de algodón", Solicitada = 80 },
                    new Renglon { Sku = "SKU-002", Producto = "Pantalón deportivo", Solicitada = 30 }
                }
            };
        }

        private void MostrarPedido()
        {
            if (pedidoActual == null) return;

            lvControlCantidades.Items.Clear();
            foreach (Renglon r in pedidoActual.Renglones)
            {
                ListViewItem fila = new ListViewItem(new string[]
                {
                    r.Sku,
                    r.Producto,
                    r.Solicitada.ToString()
                });
                fila.Tag = r;
                lvControlCantidades.Items.Add(fila);
            }
        }

        private void btnConfirmarPreparacion_Click(object? sender, EventArgs e)
        {
            if (pedidoActual == null) return;

            Mensajes.Info($"Preparación confirmada para el pedido {pedidoActual.Numero}.", "Confirmación");
            this.Close();
        }
    }
}