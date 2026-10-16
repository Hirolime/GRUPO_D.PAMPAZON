using System;
using System.Drawing;
using System.Windows.Forms;

namespace GRUPO_D.PAMPAZON
{
    /// <summary>
    /// Hace que cada formulario ocupe exactamente el área de trabajo de la pantalla
    /// (sin pasarse por debajo de la barra de tareas) y se pueda recorrer con las
    /// barras de desplazamiento cuando el contenido no entra.
    /// </summary>
    internal static class AjustePantalla
    {
        public static void Aplicar(Form form)
        {
            form.AutoScroll = true;
            // Espacio extra al final para que el último control nunca quede pegado al borde.
            form.AutoScrollMargin = new Size(24, 80);
            form.MinimumSize = new Size(0, 0);
            form.StartPosition = FormStartPosition.Manual;
            form.WindowState = FormWindowState.Normal;
            form.Load += (s, e) => Ajustar(form);
            form.DpiChanged += (s, e) => Ajustar(form);
        }

        private static void Ajustar(Form form)
        {
            Rectangle area = Screen.FromControl(form).WorkingArea;
            form.Bounds = area;
        }
    }
}
