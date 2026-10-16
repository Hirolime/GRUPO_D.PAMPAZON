using System.Text.RegularExpressions;

namespace GRUPO_D.PAMPAZON.Comun
{
    /// <summary>
    /// Reglas de formato compartidas por las pantallas. Los límites de largo se validan acá
    /// (no con MaxLength) para usar solo las propiedades de controles vistas en la cátedra.
    /// </summary>
    internal static class Validaciones
    {
        public const int MaxDigitosCantidad = 6;
        public const int MaxLargoBusqueda = 30;
        public const int MaxLargoObservacion = 200;
        public const int MaxLargoIdentificacion = 20;
        public const int MaxLargoTransportista = 60;

        private static readonly Regex SoloDigitos = new Regex("^[0-9]+$");
        private static readonly Regex Identificacion = new Regex("^[A-Za-z0-9-]+$");

        /// <summary>
        /// Cantidad entera de hasta <see cref="MaxDigitosCantidad"/> dígitos, mayor o igual a <paramref name="minimo"/>.
        /// </summary>
        public static bool EsCantidad(string texto, int minimo, out int valor)
        {
            valor = 0;
            string t = texto.Trim();
            if (t.Length == 0 || t.Length > MaxDigitosCantidad || !SoloDigitos.IsMatch(t)) return false;
            return int.TryParse(t, out valor) && valor >= minimo;
        }

        /// <summary>Solo letras, números y guion, hasta <see cref="MaxLargoIdentificacion"/> caracteres.</summary>
        public static bool EsIdentificacion(string texto)
        {
            string t = texto.Trim();
            return t.Length > 0 && t.Length <= MaxLargoIdentificacion && Identificacion.IsMatch(t);
        }

        public static bool SuperaLargo(string texto, int maximo)
        {
            return texto.Trim().Length > maximo;
        }
    }
}
