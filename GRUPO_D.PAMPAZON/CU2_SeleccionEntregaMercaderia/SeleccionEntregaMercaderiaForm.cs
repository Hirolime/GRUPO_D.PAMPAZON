using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GRUPO_D.PAMPAZON.Comun;

namespace GRUPO_D.PAMPAZON.CU2_SeleccionEntregaMercaderia
{
    public partial class SeleccionEntregaMercaderiaForm : Form
    {
        private class Renglon
        {
            public string Sku { get; set; } = ""; public string Producto { get; set; } = "";
            public string Ubicacion { get; set; } = "";
            public int Requerida { get; set; }
        }

        private class OrdenSeleccion
        {
            public string Numero { get; set; } = "";
            public string Modalidad { get; set; } = "";
            public string Corte { get; set; } = "";
            public string EmitidaPor { get; set; } = "";
            public List<Renglon> Renglones { get; set; } = new List<Renglon>();
        }

        private OrdenSeleccion? ordenActual;

        public SeleccionEntregaMercaderiaForm()
        {
            InitializeComponent();

            btnConfirmarEntrega.Click += btnConfirmarEntrega_Click;

            CargarOrdenDePrueba();
            MostrarOrden();
        }

        private void CargarOrdenDePrueba()
        {
            ordenActual = new OrdenSeleccion
            {
                Numero = "OS-000071",
                Modalidad = Modalidad.Fulfillment,
                Corte = "Segundo",
                EmitidaPor = "Jefe de Preparación",
                Renglones = new List<Renglon>
                {
                    new Renglon { Sku = "SKU-001", Producto = "Remera de algodón", Ubicacion = "12-43-2", Requerida = 120 },
                    new Renglon { Sku = "SKU-002", Producto = "Pantalón deportivo", Ubicacion = "12-44-1", Requerida = 30 }
                }
            };
        }

        private void MostrarOrden()
        {
            if (ordenActual == null) return;

            txtOrdenSeleccion.Text = ordenActual.Numero;
            txtModalidad.Text = ordenActual.Modalidad;
            txtCorte.Text = ordenActual.Corte;
            txtEmitidaPor.Text = ordenActual.EmitidaPor;

            lvRenglones.Items.Clear();
            foreach (Renglon r in ordenActual.Renglones)
            {
                ListViewItem fila = new ListViewItem(new string[]
                {
                    r.Sku,
                    r.Producto,
                    r.Ubicacion,
                    r.Requerida.ToString()
                });
                fila.Tag = r;
                lvRenglones.Items.Add(fila);
            }
        }

        private void btnConfirmarEntrega_Click(object? sender, EventArgs e)
        {
            if (ordenActual == null) return;

            Mensajes.Info($"Entrega confirmada para la Orden de Selección {ordenActual.Numero}.", "Confirmación");
            this.Close();
        }
    }
}