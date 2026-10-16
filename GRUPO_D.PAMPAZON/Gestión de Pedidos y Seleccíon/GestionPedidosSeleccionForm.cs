using System;
using GRUPO_D.PAMPAZON;
using System.Windows.Forms;

namespace Pampazon.Prototipos
{
    public partial class GestionPedidosSeleccionForm : Form
    {
        public GestionPedidosSeleccionForm()
        {
            InitializeComponent();
            AjustePantalla.Aplicar(this);

            cboDeposito.SelectedItem = "GBA";
            btnIrCortes.Click += btnIrCortes_Click;
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        // Los cortes de selección están en su propio formulario.
        private void btnIrCortes_Click(object sender, EventArgs e)
        {
            using (CortesSeleccionForm cortes = new CortesSeleccionForm())
            {
                cortes.ShowDialog(this);
            }
        }
    }
}
