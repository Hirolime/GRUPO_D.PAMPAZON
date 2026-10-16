using System.Windows.Forms;

namespace GRUPO_D.PAMPAZON.Comun
{
    /// <summary>
    /// Mensajes al usuario, iguales en todas las pantallas.
    /// </summary>
    internal static class Mensajes
    {
        public const string TituloDatosIncorrectos = "Datos incorrectos";

        /// <summary>Informa un dato incorrecto y, si se indica, deja el foco en el control a corregir.</summary>
        public static void Error(string mensaje, Control? foco = null)
        {
            MessageBox.Show(mensaje, TituloDatosIncorrectos, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (foco != null) foco.Focus();
        }

        public static void Info(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
