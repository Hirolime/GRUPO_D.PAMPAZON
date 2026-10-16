using GRUPO_D.PAMPAZON.CU1_GestionPedidosSeleccion;

namespace GRUPO_D.PAMPAZON
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  Para probar otra pantalla, cambiar el formulario de Application.Run:
        ///  CU2_SeleccionEntregaMercaderia.SeleccionEntregaMercaderiaForm,
        ///  CU3_EmpaquetadoPreparacionEntregas.EmpaquetadoPreparacionEntregasForm o
        ///  CU4_RecepcionDespachoPedidos.RecepcionDespachoPedidosForm.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new GestionPedidosSeleccionForm());
        }
    }
}
