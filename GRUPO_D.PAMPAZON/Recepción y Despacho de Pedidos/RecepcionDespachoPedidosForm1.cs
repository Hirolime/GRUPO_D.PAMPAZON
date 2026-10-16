using System;
using GRUPO_D.PAMPAZON;
using System.Windows.Forms;

namespace GRUPO_D.PAMPAZON.Recepción_y_Despacho_de_Pedidos
{
    public partial class RecepcionDespachoPedidosForm1 : Form
    {
        public RecepcionDespachoPedidosForm1()
        {
            InitializeComponent();
            AjustePantalla.Aplicar(this);

            cboDeposito.SelectedItem = "GBA";
        }
    }
}
