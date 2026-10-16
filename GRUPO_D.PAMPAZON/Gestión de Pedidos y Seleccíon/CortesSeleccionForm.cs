using System;
using GRUPO_D.PAMPAZON;
using System.Windows.Forms;

namespace Pampazon.Prototipos
{
    public partial class CortesSeleccionForm : Form
    {
        public CortesSeleccionForm()
        {
            InitializeComponent();
            AjustePantalla.Aplicar(this);

            cboDeposito.SelectedItem = "GBA";
        }
    }
}
