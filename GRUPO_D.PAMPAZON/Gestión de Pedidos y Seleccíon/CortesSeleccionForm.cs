using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pampazon.Prototipos
{
    /// <summary>
    /// CU1 - Cortes de selección (P03 Generar órdenes de selección por corte).
    /// Validaciones de datos según la planilla de apoyo (campos B.1 a B.4).
    /// </summary>
    public partial class CortesSeleccionForm : Form
    {
        // Columnas de los ListView (ver Designer)
        private const int ColPendNumero = 0;

        private const string EstadoPendiente = "PENDIENTE";
        private const string EstadoSeleccionada = "SELECCIONADA";

        private static readonly Regex PatronUbicacion = new Regex(@"^\d+-\d+-\d+$");

        // ---------- Datos de prueba del prototipo (en el sistema real vienen de la base) ----------

        private class Linea
        {
            public string Sku = "";
            public string Producto = "";
            public int Cantidad;
        }

        private class Orden
        {
            public string Numero = "";
            public string Cliente = "";
            public string Origen = "";
            public string Modalidad = "";
            public string Estado = EstadoPendiente;
            public List<Linea> Lineas = new List<Linea>();
        }

        private class Propuesta
        {
            public DateTime Fecha;
            public string Corte = "";
            public List<Orden> Ordenes = new List<Orden>();
        }

        private readonly List<Orden> ordenes = new List<Orden>();

        // Ubicación de estiba (X-Y-Z) de cada SKU.
        private readonly Dictionary<string, string> ubicaciones = new Dictionary<string, string>();

        private Propuesta? propuesta;
        private int ultimaSeleccion = 72;
        private readonly List<string> seleccionesGeneradas = new List<string>();

        public CortesSeleccionForm()
        {
            InitializeComponent();

            cboDeposito.SelectedItem = "GBA";

            CargarDatosPrueba();

            btnConsultarPendientes.Click += btnConsultarPendientes_Click;
            btnPrepararCorte.Click += btnPrepararCorte_Click;
            btnConfirmarCorte.Click += btnConfirmarCorte_Click;
            btnVerOrdenes.Click += btnVerOrdenes_Click;
            btnDescartar.Click += btnDescartar_Click;

            CargarPendientes();
            lvPropuesta.Items.Clear();
        }

        private void CargarDatosPrueba()
        {
            ubicaciones["SKU-001"] = "12-43-2";
            ubicaciones["SKU-002"] = "12-44-1";

            ordenes.Add(new Orden
            {
                Numero = "OP-000181", Cliente = "Cliente Demo A", Origen = "Cliente", Modalidad = "Fulfillment",
                Lineas = new List<Linea>
                {
                    new Linea { Sku = "SKU-001", Producto = "Remera de algodón", Cantidad = 80 },
                    new Linea { Sku = "SKU-002", Producto = "Pantalón deportivo", Cantidad = 30 }
                }
            });
            ordenes.Add(new Orden
            {
                Numero = "OP-000182", Cliente = "Cliente Demo A", Origen = "Cliente", Modalidad = "Fulfillment",
                Lineas = new List<Linea> { new Linea { Sku = "SKU-001", Producto = "Remera de algodón", Cantidad = 40 } }
            });
            ordenes.Add(new Orden
            {
                Numero = "OP-000183", Cliente = "Cliente Demo B", Origen = "Cliente", Modalidad = "Palé cerrado",
                Lineas = new List<Linea> { new Linea { Sku = "SKU-002", Producto = "Pantalón deportivo", Cantidad = 20 } }
            });
        }

        // ---------- Mensajes ----------

        private void MostrarError(string mensaje, Control? foco = null)
        {
            MessageBox.Show(mensaje, "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (foco != null) foco.Focus();
        }

        private void MostrarInfo(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ---------- Pedidos pendientes (B.3) ----------

        private void CargarPendientes()
        {
            lvPendientes.Items.Clear();
            foreach (Orden o in ordenes.Where(x => x.Estado == EstadoPendiente))
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    o.Numero, o.Cliente, o.Origen, o.Modalidad, o.Lineas.Count.ToString(), o.Estado
                });
                item.Tag = o;
                lvPendientes.Items.Add(item);
            }
        }

        private void btnConsultarPendientes_Click(object? sender, EventArgs e)
        {
            CargarPendientes();
            if (lvPendientes.Items.Count == 0)
                MostrarInfo("No hay órdenes pendientes para incluir en un corte.", "Pendientes");
        }

        // ---------- Preparar corte (B.1 a B.4) ----------

        private void btnPrepararCorte_Click(object? sender, EventArgs e)
        {
            if (!rdoPrimerCorte.Checked && !rdoSegundoCorte.Checked)
            {
                MostrarError("Seleccione el número de corte.", rdoPrimerCorte);
                return;
            }

            if (dtpFechaCorte.Value.Year < 2000)
            {
                MostrarError("Ingrese una fecha de corte válida.", dtpFechaCorte);
                return;
            }

            if (lvPendientes.SelectedItems.Count == 0)
            {
                MostrarError("Seleccione al menos un pedido pendiente para el corte.", lvPendientes);
                return;
            }

            List<Orden> elegidas = lvPendientes.SelectedItems.Cast<ListViewItem>().Select(i => (Orden)i.Tag!).ToList();

            // Se revalida que sigan PENDIENTES.
            if (elegidas.Any(o => o.Estado != EstadoPendiente))
            {
                CargarPendientes();
                MostrarError("Seleccione al menos un pedido pendiente para el corte.", lvPendientes);
                return;
            }

            // Se agrupa por cliente y producto (misma ubicación de estiba) y se conserva el reparto por pedido.
            var grupos = elegidas
                .SelectMany(o => o.Lineas.Select(l => new { Orden = o, Linea = l }))
                .GroupBy(x => new { x.Orden.Cliente, x.Linea.Sku })
                .OrderBy(g => g.Key.Cliente).ThenBy(g => g.Key.Sku)
                .ToList();

            List<ListViewItem> filas = new List<ListViewItem>();
            foreach (var g in grupos)
            {
                string sku = g.Key.Sku;
                string ubicacion;
                if (!ubicaciones.TryGetValue(sku, out ubicacion!) || !PatronUbicacion.IsMatch(ubicacion))
                {
                    MostrarError("No se puede seleccionar el SKU " + sku + ": falta ubicación o compromiso.");
                    return;
                }

                int total = g.Sum(x => x.Linea.Cantidad);
                string reparto = string.Join("; ", g.Select(x => x.Orden.Numero + " (" + x.Linea.Cantidad + ")"));
                filas.Add(new ListViewItem(new string[]
                {
                    g.Key.Cliente, sku, g.First().Linea.Producto, ubicacion, total.ToString(), "Unidad", reparto
                }));
            }

            lvPropuesta.Items.Clear();
            foreach (ListViewItem fila in filas) lvPropuesta.Items.Add(fila);

            propuesta = new Propuesta
            {
                Fecha = dtpFechaCorte.Value.Date,
                Corte = rdoPrimerCorte.Checked ? "Primer" : "Segundo",
                Ordenes = elegidas
            };
        }

        // ---------- Confirmar y generar selección ----------

        private void btnConfirmarCorte_Click(object? sender, EventArgs e)
        {
            if (propuesta == null)
            {
                MostrarError("Prepare el corte antes de confirmar la selección.", btnPrepararCorte);
                return;
            }

            // Se revalida que ningún pedido haya cambiado de estado desde la propuesta.
            if (propuesta.Ordenes.Any(o => o.Estado != EstadoPendiente))
            {
                DescartarPropuesta();
                CargarPendientes();
                MostrarError("Seleccione al menos un pedido pendiente para el corte.", lvPendientes);
                return;
            }

            // Se genera una orden de selección por modalidad.
            List<string> generadas = new List<string>();
            foreach (var porModalidad in propuesta.Ordenes.GroupBy(o => o.Modalidad).OrderBy(g => g.Key))
            {
                ultimaSeleccion++;
                string numero = "OS-" + ultimaSeleccion.ToString("D6", CultureInfo.InvariantCulture);
                string pedidos = string.Join(", ", porModalidad.Select(o => o.Numero));
                generadas.Add(numero + " · " + propuesta.Fecha.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + " · " +
                              propuesta.Corte + " corte · " + porModalidad.Key + " · pedidos: " + pedidos);
            }

            foreach (Orden o in propuesta.Ordenes) o.Estado = EstadoSeleccionada;
            seleccionesGeneradas.AddRange(generadas);

            DescartarPropuesta();
            CargarPendientes();
            btnVerOrdenes.Enabled = true;

            MostrarInfo("Selección generada." + Environment.NewLine + Environment.NewLine +
                        string.Join(Environment.NewLine, generadas) + Environment.NewLine + Environment.NewLine +
                        "Los pedidos incluidos pasaron a " + EstadoSeleccionada + ".", "Selección generada");
        }

        private void btnVerOrdenes_Click(object? sender, EventArgs e)
        {
            if (seleccionesGeneradas.Count == 0)
            {
                MostrarInfo("Todavía no se generó ninguna orden de selección.", "Órdenes generadas");
                return;
            }
            MostrarInfo(string.Join(Environment.NewLine, seleccionesGeneradas), "Órdenes de selección generadas");
        }

        // ---------- Descartar ----------

        private void DescartarPropuesta()
        {
            propuesta = null;
            lvPropuesta.Items.Clear();
        }

        private void btnDescartar_Click(object? sender, EventArgs e)
        {
            if (propuesta == null)
            {
                MostrarInfo("No hay una propuesta de selección para descartar.", "Descartar propuesta");
                return;
            }
            DescartarPropuesta();
        }
    }
}
