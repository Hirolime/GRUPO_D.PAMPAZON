namespace GRUPO_D.PAMPAZON.Comun
{
    /// <summary>Estados de la orden de preparación (pedido) a lo largo de CU1 a CU4.</summary>
    internal static class EstadoPedido
    {
        public const string Asignada = "ASIGNADA";
        public const string Pendiente = "PENDIENTE";
        public const string Rechazada = "RECHAZADA";
        public const string Seleccionada = "SELECCIONADA";
        public const string EnPreparacion = "EN PREPARACIÓN";
        public const string Preparada = "PREPARADA";
        public const string EnDespacho = "EN DESPACHO";
        public const string Despachada = "DESPACHADA";
    }

    /// <summary>Estados de la orden de selección (CU1 la emite, CU2 la cumple).</summary>
    internal static class EstadoOrdenSeleccion
    {
        public const string Emitida = "EMITIDA";
        public const string Cumplida = "CUMPLIDA";
    }

    internal static class Modalidad
    {
        public const string Fulfillment = "Fulfillment";
        public const string PaleCerrado = "Palé cerrado";
    }

    internal static class Origen
    {
        public const string Cliente = "Cliente";
        public const string TrasladoInterno = "Traslado interno";
    }

    internal static class Formatos
    {
        public const string Fecha = "dd/MM/yyyy";
        public const string DepositoActual = "GBA";
    }

    /// <summary>
    /// Numeración de documentos: prefijo de dos letras, guion y 6 dígitos (OP-000181, OS-000073, OE-000051, RE-000051).
    /// </summary>
    internal static class Numeracion
    {
        public const string OrdenSeleccion = "OS";
        public const string OrdenEntrega = "OE";
        public const string Remito = "RE";
        public const string GuiaTraslado = "GT";

        public static string Nuevo(string prefijo, int numero)
        {
            return prefijo + "-" + numero.ToString("D6", System.Globalization.CultureInfo.InvariantCulture);
        }

        /// <summary>Mismo número con otro prefijo: OP-000181 → OE-000181.</summary>
        public static string CambiarPrefijo(string numero, string prefijo)
        {
            return prefijo + numero.Substring(numero.IndexOf('-'));
        }
    }
}
