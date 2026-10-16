using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GRUPO_D.PAMPAZON.Comun;

namespace GRUPO_D.PAMPAZON.CU1_GestionPedidosSeleccion
{
    /// <summary>
    /// CU1 - Gestión de pedidos y selección, en un solo formulario:
    /// a la izquierda P01 Validar/aceptar orden de preparación y P02 Rechazar por falta de stock (campos A.1 a A.6);
    /// a la derecha P03 Generar órdenes de selección por corte (campos B.1 a B.4).
    /// Las órdenes aceptadas pasan a PENDIENTE y quedan disponibles para el corte.
    /// </summary>
    public partial class GestionPedidosSeleccionForm : Form
    {
        private const string TodosLosClientes = "Todos los clientes";
        private const string TodosLosOrigenes = "Todos";

        private static readonly Regex PatronContrato = new Regex(@"^CT-\d{6}$");
        private static readonly Regex PatronUbicacion = new Regex(@"^\d+-\d+-\d+$");

        // ---------- Datos de prueba del prototipo (en el sistema real vienen de la base) ----------

        private class Renglon
        {
            public string Sku = "";
            public string Producto = "";
            public string Unidad = "Unidad";
            public int Cantidad;
        }

        private class Orden
        {
            public string Numero = "";
            public DateTime Asignacion;
            public string Cliente = "";
            public string Origen = "";
            public string Modalidad = "";
            public string Contrato = "";
            public string Estado = EstadoPedido.Asignada;
            public List<Renglon> Renglones = new List<Renglon>();
        }

        private class PropuestaSeleccion
        {
            public DateTime Fecha;
            public string Corte = "";
            public List<Orden> Ordenes = new List<Orden>();
        }

        private readonly List<Orden> ordenes = new List<Orden>();
        private readonly Dictionary<string, int> stockFisico = new Dictionary<string, int>();
        private readonly Dictionary<string, int> stockComprometido = new Dictionary<string, int>();
        // Ubicación de estiba (X-Y-Z) de cada SKU.
        private readonly Dictionary<string, string> ubicaciones = new Dictionary<string, string>();

        // Estado de la validación de la orden asignada elegida (P01 / P02).
        private bool validada;
        private List<string> faltantes = new List<string>();
        private readonly string textoValidacionInicial;
        private readonly string textoMotivoInicial;

        // Estado del corte (P03).
        private PropuestaSeleccion? propuesta;
        private int ultimaOrdenSeleccion = 72;
        private readonly List<string> ordenesSeleccionGeneradas = new List<string>();

        public GestionPedidosSeleccionForm()
        {
            InitializeComponent();

            cboDeposito.SelectedItem = Formatos.DepositoActual;
            cboFiltroCliente.SelectedItem = TodosLosClientes;
            cboFiltroOrigen.SelectedItem = TodosLosOrigenes;
            textoValidacionInicial = lblResultadoValidacion.Text;
            textoMotivoInicial = txtMotivoRechazo.Text;

            CargarDatosPrueba();

            // P01 / P02
            chkFiltroFechaAsignacion.CheckedChanged += chkFiltroFechaAsignacion_CheckedChanged;
            btnBuscar.Click += btnBuscar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            lvOrdenesAsignadas.SelectedIndexChanged += lvOrdenesAsignadas_SelectedIndexChanged;
            btnValidarDisponibilidad.Click += btnValidarDisponibilidad_Click;
            btnAceptarOrden.Click += btnAceptarOrden_Click;
            btnRechazarOrden.Click += btnRechazarOrden_Click;

            // P03
            btnConsultarPendientes.Click += btnConsultarPendientes_Click;
            btnPrepararCorte.Click += btnPrepararCorte_Click;
            btnConfirmarCorte.Click += btnConfirmarCorte_Click;
            btnVerOrdenesSeleccion.Click += btnVerOrdenesSeleccion_Click;
            btnDescartarPropuesta.Click += btnDescartarPropuesta_Click;

            MostrarOrdenesAsignadas(OrdenesEn(EstadoPedido.Asignada));
            LimpiarDetalle();
            MostrarOrdenesPendientes();
        }

        private void CargarDatosPrueba()
        {
            stockFisico["SKU-001"] = 148;
            stockFisico["SKU-002"] = 65;
            ubicaciones["SKU-001"] = "12-43-2";
            ubicaciones["SKU-002"] = "12-44-1";

            // Órdenes ya aceptadas (PENDIENTE): esperan el corte.
            ordenes.Add(new Orden
            {
                Numero = "OP-000181", Asignacion = new DateTime(2026, 10, 11), Cliente = "Cliente Demo A", Origen = Origen.Cliente,
                Modalidad = Modalidad.Fulfillment, Contrato = "CT-000028", Estado = EstadoPedido.Pendiente,
                Renglones = new List<Renglon>
                {
                    new Renglon { Sku = "SKU-001", Producto = "Remera de algodón", Cantidad = 80 },
                    new Renglon { Sku = "SKU-002", Producto = "Pantalón deportivo", Cantidad = 30 }
                }
            });
            ordenes.Add(new Orden
            {
                Numero = "OP-000182", Asignacion = new DateTime(2026, 10, 11), Cliente = "Cliente Demo A", Origen = Origen.Cliente,
                Modalidad = Modalidad.Fulfillment, Contrato = "CT-000028", Estado = EstadoPedido.Pendiente,
                Renglones = new List<Renglon> { new Renglon { Sku = "SKU-001", Producto = "Remera de algodón", Cantidad = 40 } }
            });
            ordenes.Add(new Orden
            {
                Numero = "OP-000183", Asignacion = new DateTime(2026, 10, 11), Cliente = "Cliente Demo B", Origen = Origen.Cliente,
                Modalidad = Modalidad.PaleCerrado, Contrato = "CT-000029", Estado = EstadoPedido.Pendiente,
                Renglones = new List<Renglon> { new Renglon { Sku = "SKU-002", Producto = "Pantalón deportivo", Cantidad = 20 } }
            });

            // Órdenes asignadas al depósito: esperan la validación (P01 / P02).
            ordenes.Add(new Orden
            {
                Numero = "OP-000184", Asignacion = new DateTime(2026, 10, 12), Cliente = "Cliente Demo A", Origen = Origen.Cliente,
                Modalidad = Modalidad.Fulfillment, Contrato = "CT-000028",
                Renglones = new List<Renglon>
                {
                    new Renglon { Sku = "SKU-001", Producto = "Remera de algodón", Cantidad = 20 },
                    new Renglon { Sku = "SKU-002", Producto = "Pantalón deportivo", Cantidad = 10 }
                }
            });
            ordenes.Add(new Orden
            {
                Numero = "OP-000185", Asignacion = new DateTime(2026, 10, 12), Cliente = "Cliente Demo B", Origen = Origen.Cliente,
                Modalidad = Modalidad.PaleCerrado, Contrato = "CT-000029",
                Renglones = new List<Renglon> { new Renglon { Sku = "SKU-001", Producto = "Remera de algodón", Cantidad = 100 } }
            });
            ordenes.Add(new Orden
            {
                Numero = "TR-000026", Asignacion = new DateTime(2026, 10, 12), Cliente = "Cliente Demo A", Origen = Origen.TrasladoInterno,
                Modalidad = Modalidad.PaleCerrado, Contrato = "CT-000028",
                Renglones = new List<Renglon> { new Renglon { Sku = "SKU-002", Producto = "Pantalón deportivo", Cantidad = 20 } }
            });

            // El stock comprometido es el de las órdenes ya aceptadas.
            foreach (string sku in stockFisico.Keys) stockComprometido[sku] = 0;
            foreach (Orden o in OrdenesEn(EstadoPedido.Pendiente))
                foreach (Renglon r in o.Renglones) stockComprometido[r.Sku] += r.Cantidad;
        }

        private IEnumerable<Orden> OrdenesEn(string estado)
        {
            return ordenes.Where(o => o.Estado == estado);
        }

        private int Disponible(string sku)
        {
            return stockFisico[sku] - stockComprometido[sku];
        }

        // =====================================================================
        // P01 / P02 - Órdenes asignadas
        // =====================================================================

        // ---------- Búsqueda (A.1 a A.4) ----------

        private void MostrarOrdenesAsignadas(IEnumerable<Orden> lista)
        {
            lvOrdenesAsignadas.Items.Clear();
            foreach (Orden o in lista)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    o.Numero, o.Asignacion.ToString(Formatos.Fecha, CultureInfo.InvariantCulture), o.Cliente, o.Origen,
                    o.Modalidad, o.Renglones.Count.ToString(), o.Estado
                });
                item.Tag = o;
                lvOrdenesAsignadas.Items.Add(item);
            }
        }

        // La fecha de asignación solo filtra si se marca la casilla.
        private void chkFiltroFechaAsignacion_CheckedChanged(object? sender, EventArgs e)
        {
            dtpFiltroFechaAsignacion.Enabled = chkFiltroFechaAsignacion.Checked;
        }

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            IEnumerable<Orden> asignadas = OrdenesEn(EstadoPedido.Asignada);

            string numero = txtFiltroOrden.Text.Trim();
            if (Validaciones.SuperaLargo(numero, Validaciones.MaxLargoBusqueda))
            {
                Mensajes.Error("El número de orden admite hasta 30 caracteres.", txtFiltroOrden);
                return;
            }
            if (numero.Length > 0)
            {
                asignadas = asignadas.Where(o => o.Numero.IndexOf(numero, StringComparison.OrdinalIgnoreCase) >= 0);
                if (!asignadas.Any())
                {
                    MostrarOrdenesAsignadas(asignadas);
                    LimpiarDetalle();
                    Mensajes.Error("No se encontraron órdenes asignadas con ese número.", txtFiltroOrden);
                    return;
                }
            }

            if (!(cboFiltroCliente.SelectedItem is string cliente))
            {
                Mensajes.Error("Seleccione un cliente de la lista.", cboFiltroCliente);
                return;
            }
            if (cliente != TodosLosClientes)
                asignadas = asignadas.Where(o => o.Cliente == cliente);

            if (!(cboFiltroOrigen.SelectedItem is string origen))
            {
                Mensajes.Error("Seleccione un origen de la lista.", cboFiltroOrigen);
                return;
            }
            if (origen != TodosLosOrigenes)
                asignadas = asignadas.Where(o => o.Origen == origen);

            if (chkFiltroFechaAsignacion.Checked)
            {
                DateTime desde = dtpFiltroFechaAsignacion.Value.Date;
                asignadas = asignadas.Where(o => o.Asignacion.Date >= desde);
            }

            List<Orden> resultado = asignadas.ToList();
            MostrarOrdenesAsignadas(resultado);
            LimpiarDetalle();
            if (resultado.Count == 0)
                Mensajes.Info("No hay órdenes asignadas que cumplan los filtros indicados.", "Búsqueda");
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            txtFiltroOrden.Clear();
            cboFiltroCliente.SelectedItem = TodosLosClientes;
            cboFiltroOrigen.SelectedItem = TodosLosOrigenes;
            chkFiltroFechaAsignacion.Checked = false;
            MostrarOrdenesAsignadas(OrdenesEn(EstadoPedido.Asignada));
            LimpiarDetalle();
        }

        // ---------- Orden elegida (A.5) y disponibilidad (A.6) ----------

        private Orden? OrdenAsignadaElegida()
        {
            return lvOrdenesAsignadas.SelectedItems.Count == 0 ? null : (Orden)lvOrdenesAsignadas.SelectedItems[0].Tag!;
        }

        private Orden? ExigirOrdenAsignada()
        {
            Orden? orden = OrdenAsignadaElegida();
            if (orden == null)
                Mensajes.Error("Seleccione una orden asignada para validar.", lvOrdenesAsignadas);
            return orden;
        }

        // Muestra la orden en el detalle; sin orden, lo deja vacío. En ambos casos la validación queda pendiente.
        private void MostrarDetalle(Orden? orden)
        {
            validada = false;
            faltantes = new List<string>();
            grpDetalleOrden.Text = orden == null ? "Detalle de la orden" : "Detalle de la orden " + orden.Numero;
            txtCliente.Text = orden?.Cliente ?? "";
            txtContrato.Text = orden?.Contrato ?? "";
            txtModalidad.Text = orden?.Modalidad ?? "";
            txtEstado.Text = orden?.Estado ?? "";

            lvDisponibilidad.Items.Clear();
            if (orden != null)
            {
                foreach (Renglon r in orden.Renglones)
                {
                    lvDisponibilidad.Items.Add(new ListViewItem(new string[]
                    {
                        r.Sku, r.Producto, r.Unidad, r.Cantidad.ToString(), Disponible(r.Sku).ToString(), "Pendiente de validar"
                    }));
                }
            }

            lblResultadoValidacion.Text = textoValidacionInicial;
            txtMotivoRechazo.Text = textoMotivoInicial;
        }

        private void LimpiarDetalle()
        {
            MostrarDetalle(null);
        }

        private void lvOrdenesAsignadas_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Orden? orden = OrdenAsignadaElegida();
            if (orden != null) MostrarDetalle(orden);
        }

        // Calcula la disponibilidad de cada renglón y actualiza la lista. Devuelve los faltantes.
        private List<string> CalcularDisponibilidad(Orden orden)
        {
            List<string> faltas = new List<string>();
            for (int i = 0; i < orden.Renglones.Count; i++)
            {
                Renglon r = orden.Renglones[i];
                int disponible = Disponible(r.Sku);
                ListViewItem fila = lvDisponibilidad.Items[i];
                fila.SubItems[colDisponibilidadDisponible.Index].Text = disponible.ToString();
                if (disponible >= r.Cantidad)
                {
                    fila.SubItems[colDisponibilidadValidacion.Index].Text = "Disponible";
                }
                else
                {
                    fila.SubItems[colDisponibilidadValidacion.Index].Text = "Faltan " + (r.Cantidad - disponible);
                    faltas.Add("Stock insuficiente para el SKU " + r.Sku + ": solicitado " + r.Cantidad + ", disponible " + disponible + ".");
                }
            }
            return faltas;
        }

        private void btnValidarDisponibilidad_Click(object? sender, EventArgs e)
        {
            Orden? orden = ExigirOrdenAsignada();
            if (orden == null) return;

            // El contrato debe estar informado y tener el formato CT-######.
            if (!PatronContrato.IsMatch(orden.Contrato))
            {
                Mensajes.Error("Los datos de la orden no son compatibles con el contrato.");
                return;
            }

            faltantes = CalcularDisponibilidad(orden);
            validada = true;

            if (faltantes.Count == 0)
            {
                lblResultadoValidacion.Text = "Disponibilidad validada: el stock cubre todos los renglones. Ya puede aceptar la orden.";
                txtMotivoRechazo.Text = textoMotivoInicial;
            }
            else
            {
                lblResultadoValidacion.Text = faltantes[0] + (faltantes.Count > 1 ? " (y " + (faltantes.Count - 1) + " más)" : "");
                txtMotivoRechazo.Text = "Stock insuficiente. " + string.Join(" ", faltantes);
                Mensajes.Error(string.Join(Environment.NewLine, faltantes));
            }
        }

        // ---------- Aceptar (P01) ----------

        private void btnAceptarOrden_Click(object? sender, EventArgs e)
        {
            Orden? orden = ExigirOrdenAsignada();
            if (orden == null) return;

            if (!validada)
            {
                Mensajes.Error("Valide la disponibilidad antes de aceptar la orden.", btnValidarDisponibilidad);
                return;
            }

            // Se revalida: el stock pudo cambiar desde la validación.
            faltantes = CalcularDisponibilidad(orden);
            if (faltantes.Count > 0)
            {
                Mensajes.Error(string.Join(Environment.NewLine, faltantes));
                return;
            }

            // Se compromete el stock; el físico no cambia hasta que Almacén retire la mercadería.
            foreach (Renglon r in orden.Renglones) stockComprometido[r.Sku] += r.Cantidad;
            orden.Estado = EstadoPedido.Pendiente;

            string resumen = string.Join(Environment.NewLine, orden.Renglones.Select(r =>
                r.Sku + ": físico " + stockFisico[r.Sku] + ", comprometido " + stockComprometido[r.Sku] + ", disponible " + Disponible(r.Sku)));

            MostrarOrdenesAsignadas(OrdenesEn(EstadoPedido.Asignada));
            LimpiarDetalle();
            MostrarOrdenesPendientes();
            Mensajes.Info("Orden " + orden.Numero + " aceptada. Estado: " + EstadoPedido.Pendiente + "." + Environment.NewLine +
                          "Ya figura en las órdenes pendientes del corte." + Environment.NewLine + Environment.NewLine + resumen, "Orden aceptada");
        }

        // ---------- Rechazar por falta de stock (P02) ----------

        private void btnRechazarOrden_Click(object? sender, EventArgs e)
        {
            Orden? orden = ExigirOrdenAsignada();
            if (orden == null) return;

            if (!validada)
            {
                Mensajes.Error("Valide la disponibilidad antes de rechazar la orden.", btnValidarDisponibilidad);
                return;
            }

            faltantes = CalcularDisponibilidad(orden);
            if (faltantes.Count == 0)
            {
                Mensajes.Error("La orden tiene stock suficiente: no corresponde rechazarla por falta de stock.");
                return;
            }

            // El rechazo no compromete stock.
            orden.Estado = EstadoPedido.Rechazada;
            string motivo = "Stock insuficiente. " + string.Join(" ", faltantes);

            MostrarOrdenesAsignadas(OrdenesEn(EstadoPedido.Asignada));
            LimpiarDetalle();
            Mensajes.Info("Orden " + orden.Numero + " rechazada. Estado: " + EstadoPedido.Rechazada + "." + Environment.NewLine +
                          "Motivo: " + motivo + Environment.NewLine + "Se registró el aviso al cliente. No se comprometió stock.", "Orden rechazada");
        }

        // =====================================================================
        // P03 - Cortes de selección
        // =====================================================================

        // ---------- Órdenes pendientes (B.3) ----------

        private void MostrarOrdenesPendientes()
        {
            lvOrdenesPendientes.Items.Clear();
            foreach (Orden o in OrdenesEn(EstadoPedido.Pendiente))
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    o.Numero, o.Cliente, o.Origen, o.Modalidad, o.Renglones.Count.ToString(), o.Estado
                });
                item.Tag = o;
                lvOrdenesPendientes.Items.Add(item);
            }
        }

        private void btnConsultarPendientes_Click(object? sender, EventArgs e)
        {
            MostrarOrdenesPendientes();
            if (lvOrdenesPendientes.Items.Count == 0)
                Mensajes.Info("No hay órdenes pendientes para incluir en un corte.", "Pendientes");
        }

        // ---------- Preparar corte (B.1 a B.4) ----------

        private void btnPrepararCorte_Click(object? sender, EventArgs e)
        {
            if (!rdoPrimerCorte.Checked && !rdoSegundoCorte.Checked)
            {
                Mensajes.Error("Seleccione el número de corte.", rdoPrimerCorte);
                return;
            }

            if (dtpFechaCorte.Value.Year < 2000)
            {
                Mensajes.Error("Ingrese una fecha de corte válida.", dtpFechaCorte);
                return;
            }

            if (lvOrdenesPendientes.SelectedItems.Count == 0)
            {
                Mensajes.Error("Seleccione al menos un pedido pendiente para el corte.", lvOrdenesPendientes);
                return;
            }

            List<Orden> elegidas = lvOrdenesPendientes.SelectedItems.Cast<ListViewItem>().Select(i => (Orden)i.Tag!).ToList();

            // Se revalida que sigan PENDIENTES.
            if (elegidas.Any(o => o.Estado != EstadoPedido.Pendiente))
            {
                MostrarOrdenesPendientes();
                Mensajes.Error("Seleccione al menos un pedido pendiente para el corte.", lvOrdenesPendientes);
                return;
            }

            // Se agrupa por cliente y producto (misma ubicación de estiba) y se conserva el reparto por pedido.
            var grupos = elegidas
                .SelectMany(o => o.Renglones.Select(r => new { Orden = o, Renglon = r }))
                .GroupBy(x => new { x.Orden.Cliente, x.Renglon.Sku })
                .OrderBy(g => g.Key.Cliente).ThenBy(g => g.Key.Sku)
                .ToList();

            List<ListViewItem> filas = new List<ListViewItem>();
            foreach (var g in grupos)
            {
                string sku = g.Key.Sku;
                if (!ubicaciones.TryGetValue(sku, out string? ubicacion) || !PatronUbicacion.IsMatch(ubicacion))
                {
                    Mensajes.Error("No se puede seleccionar el SKU " + sku + ": falta ubicación o compromiso.");
                    return;
                }

                Renglon primero = g.First().Renglon;
                int total = g.Sum(x => x.Renglon.Cantidad);
                string reparto = string.Join("; ", g.Select(x => x.Orden.Numero + " (" + x.Renglon.Cantidad + ")"));
                filas.Add(new ListViewItem(new string[]
                {
                    g.Key.Cliente, sku, primero.Producto, ubicacion, total.ToString(), primero.Unidad, reparto
                }));
            }

            lvPropuestaSeleccion.Items.Clear();
            foreach (ListViewItem fila in filas) lvPropuestaSeleccion.Items.Add(fila);

            propuesta = new PropuestaSeleccion
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
                Mensajes.Error("Prepare el corte antes de confirmar la selección.", btnPrepararCorte);
                return;
            }

            // Se revalida que ningún pedido haya cambiado de estado desde la propuesta.
            if (propuesta.Ordenes.Any(o => o.Estado != EstadoPedido.Pendiente))
            {
                DescartarPropuesta();
                MostrarOrdenesPendientes();
                Mensajes.Error("Seleccione al menos un pedido pendiente para el corte.", lvOrdenesPendientes);
                return;
            }

            // Se genera una orden de selección por modalidad.
            List<string> generadas = new List<string>();
            foreach (var porModalidad in propuesta.Ordenes.GroupBy(o => o.Modalidad).OrderBy(g => g.Key))
            {
                ultimaOrdenSeleccion++;
                string numero = Numeracion.Nuevo(Numeracion.OrdenSeleccion, ultimaOrdenSeleccion);
                string pedidos = string.Join(", ", porModalidad.Select(o => o.Numero));
                generadas.Add(numero + " · " + propuesta.Fecha.ToString(Formatos.Fecha, CultureInfo.InvariantCulture) + " · " +
                              propuesta.Corte + " corte · " + porModalidad.Key + " · pedidos: " + pedidos);
            }

            foreach (Orden o in propuesta.Ordenes) o.Estado = EstadoPedido.Seleccionada;
            ordenesSeleccionGeneradas.AddRange(generadas);

            DescartarPropuesta();
            MostrarOrdenesPendientes();
            btnVerOrdenesSeleccion.Enabled = true;

            Mensajes.Info("Selección generada." + Environment.NewLine + Environment.NewLine +
                          string.Join(Environment.NewLine, generadas) + Environment.NewLine + Environment.NewLine +
                          "Los pedidos incluidos pasaron a " + EstadoPedido.Seleccionada + ".", "Selección generada");
        }

        private void btnVerOrdenesSeleccion_Click(object? sender, EventArgs e)
        {
            if (ordenesSeleccionGeneradas.Count == 0)
            {
                Mensajes.Info("Todavía no se generó ninguna orden de selección.", "Órdenes generadas");
                return;
            }
            Mensajes.Info(string.Join(Environment.NewLine, ordenesSeleccionGeneradas), "Órdenes de selección generadas");
        }

        // ---------- Descartar ----------

        private void DescartarPropuesta()
        {
            propuesta = null;
            lvPropuestaSeleccion.Items.Clear();
        }

        private void btnDescartarPropuesta_Click(object? sender, EventArgs e)
        {
            if (propuesta == null)
            {
                Mensajes.Info("No hay una propuesta de selección para descartar.", "Descartar propuesta");
                return;
            }
            DescartarPropuesta();
        }
    }
}
