using GRUPO_D.PAMPAZON.Empaquetado_y_Preparación_de_Mercaderias;
using Pampazon.Prototipos;

namespace GRUPO_D.PAMPAZON
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
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