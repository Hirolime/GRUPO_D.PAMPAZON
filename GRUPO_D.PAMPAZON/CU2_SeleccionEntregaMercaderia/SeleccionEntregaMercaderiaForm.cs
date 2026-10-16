using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GRUPO_D.PAMPAZON.Comun;

namespace GRUPO_D.PAMPAZON.CU2_SeleccionEntregaMercaderia
{
    /// <summary>
    /// CU2 - Selección y entrega de mercadería (A02 Seleccionar y entregar mercadería, I03 Registrar servicio a cobrar).
    /// Validaciones de datos según la planilla de apoyo (campos C.1 a C.6).
    /// Los controles y su diseño están en el Designer; acá se conectan los eventos y se validan los datos.
    /// </summary>
    public partial class SeleccionEntregaMercaderiaForm : Form
    {
        // ---------- Datos de prueba del prototipo (en el sistema real vienen de la base) ----------

        private class Renglon
        {
            public string Cliente = "";
            public string Sku = "";
            public string Producto = "";
            public string Ubicacion = "";
            public int Requerida;
            public string Reparto = "";
        }

        private class OrdenSeleccion
        {
            public string Numero = "";
            public string FechaCorte = "";
            public string Corte = "";
            public string Modalidad = "";
            public int Pedidos;
            public string Estado = EstadoOrdenSeleccion.Emitida;
            public string Servicio = "";
            public List<Renglon> Renglones = new List<Renglon>();
        }

        private readonly List<OrdenSeleccion> ordenesSeleccion = new List<OrdenSeleccion>();
        private readonly Dictionary<string, int> stockFisico = new Dictionary<string, int>();
        private readonly Dictionary<string, int> stockComprometido = new Dictionary<string, int>();

        public SeleccionEntregaMercaderiaForm()
        {
            InitializeComponent();

            cboDeposito.SelectedItem = Formatos.DepositoActual;

            CargarDatosPrueba();

            lvOrdenesSeleccion.SelectedIndexChanged += lvOrdenesSeleccion_SelectedIndexChanged;
            btnRegistrarRetiro.Click += btnRegistrarRetiro_Click;
            btnConfirmarEntrega.Click += btnConfirmarEntrega_Click;
            btnReportarIncidente.Click += btnReportarIncidente_Click;

            MostrarOrdenesSeleccion();
            LimpiarDetalle();
        }

        private void CargarDatosPrueba()
        {
            // Comprometido = renglones de las órdenes de selección emitidas (120 y 50).
            stockFisico["SKU-001"] = 148; stockComprometido["SKU-001"] = 120;
            stockFisico["SKU-002"] = 65; stockComprometido["SKU-002"] = 50;

            ordenesSeleccion.Add(new OrdenSeleccion
            {
                Numero = "OS-000071", FechaCorte = "14/10/2026", Corte = "Segundo", Modalidad = Modalidad.Fulfillment, Pedidos = 2,
                Renglones = new List<Renglon>
                {
                    new Renglon { Cliente = "Cliente Demo A", Sku = "SKU-001", Producto = "Remera de algodón", Ubicacion = "12-43-2", Requerida = 120, Reparto = "OP-000181 (80); OP-000182 (40)" },
                    new Renglon { Cliente = "Cliente Demo A", Sku = "SKU-002", Producto = "Pantalón deportivo", Ubicacion = "12-44-1", Requerida = 30, Reparto = "OP-000181 (30)" }
                }
            });
            ordenesSeleccion.Add(new OrdenSeleccion
            {
                Numero = "OS-000072", FechaCorte = "14/10/2026", Corte = "Segundo", Modalidad = Modalidad.PaleCerrado, Pedidos = 1,
                Renglones = new List<Renglon>
                {
                    new Renglon { Cliente = "Cliente Demo B", Sku = "SKU-002", Producto = "Pantalón deportivo", Ubicacion = "12-44-1", Requerida = 20, Reparto = "OP-000183 (20)" }
                }
            });
        }

        // ---------- Orden de selección elegida (C.1 / C.2) ----------

        private void MostrarOrdenesSeleccion()
        {
            lvOrdenesSeleccion.Items.Clear();
            foreach (OrdenSeleccion s in ordenesSeleccion)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    s.Numero, s.FechaCorte, s.Corte, s.Modalidad, s.Pedidos.ToString(), s.Renglones.Count.ToString(), s.Estado
                });
                item.Tag = s;
                lvOrdenesSeleccion.Items.Add(item);
            }
        }

        private OrdenSeleccion? OrdenSeleccionElegida()
        {
            return lvOrdenesSeleccion.SelectedItems.Count == 0 ? null : (OrdenSeleccion)lvOrdenesSeleccion.SelectedItems[0].Tag!;
        }

        private OrdenSeleccion? ExigirOrdenSeleccion()
        {
            OrdenSeleccion? orden = OrdenSeleccionElegida();
            if (orden == null)
                Mensajes.Error("Seleccione una orden de selección.", lvOrdenesSeleccion);
            return orden;
        }

        private void LimpiarDetalle()
        {
            txtOrdenSeleccion.Text = "";
            txtModalidad.Text = "";
            txtCorte.Text = "";
            txtEmitidaPor.Text = "";
            txtServicio.Text = "";
            lvRenglones.Items.Clear();
            txtCantidadRetirada.Clear();
            txtObservacion.Clear();
            chkEntregaPreparacion.Checked = false;
        }

        private void lvOrdenesSeleccion_SelectedIndexChanged(object? sender, EventArgs e)
        {
            OrdenSeleccion? orden = OrdenSeleccionElegida();
            if (orden == null) return;

            LimpiarDetalle();
            txtOrdenSeleccion.Text = orden.Numero;
            txtModalidad.Text = orden.Modalidad;
            txtCorte.Text = orden.Corte;
            txtEmitidaPor.Text = "Jefe de Preparación";
            txtServicio.Text = orden.Servicio;

            foreach (Renglon r in orden.Renglones)
            {
                ListViewItem fila = new ListViewItem(new string[]
                {
                    r.Cliente, r.Sku, r.Producto, r.Ubicacion, r.Requerida.ToString(),
                    orden.Estado == EstadoOrdenSeleccion.Cumplida ? r.Requerida.ToString() : "", r.Reparto
                });
                fila.Tag = r;
                lvRenglones.Items.Add(fila);
            }
        }

        // ---------- Cantidad retirada por renglón (C.3) ----------

        private static string MensajeDiferencia(Renglon r)
        {
            return "La cantidad retirada de " + r.Sku + " en " + r.Ubicacion + " debe coincidir con la requerida (" + r.Requerida + ").";
        }

        private void btnRegistrarRetiro_Click(object? sender, EventArgs e)
        {
            OrdenSeleccion? orden = ExigirOrdenSeleccion();
            if (orden == null) return;

            if (orden.Estado == EstadoOrdenSeleccion.Cumplida)
            {
                Mensajes.Info("La orden de selección " + orden.Numero + " ya fue cumplida. No se vuelve a registrar el retiro.", "Selección cumplida");
                return;
            }

            if (lvRenglones.SelectedItems.Count == 0)
            {
                Mensajes.Error("Seleccione el renglón al que corresponde la cantidad retirada.", lvRenglones);
                return;
            }

            string texto = txtCantidadRetirada.Text.Trim();
            int retirada = 0;
            if (texto.Length > 0 && !Validaciones.EsCantidad(texto, 0, out retirada))
            {
                Mensajes.Error("Ingrese una cantidad retirada válida (número entero mayor o igual a 0, hasta 6 dígitos).", txtCantidadRetirada);
                return;
            }
            if (texto.Length == 0 || retirada == 0)
            {
                Mensajes.Error("Ingrese la cantidad retirada de cada renglón.", txtCantidadRetirada);
                return;
            }

            ListViewItem fila = lvRenglones.SelectedItems[0];
            Renglon renglon = (Renglon)fila.Tag!;
            fila.SubItems[colRenglonesRetirada.Index].Text = retirada.ToString();

            if (retirada != renglon.Requerida)
                Mensajes.Error(MensajeDiferencia(renglon), txtCantidadRetirada);
            else
                txtCantidadRetirada.Clear();
        }

        // ---------- Confirmar entrega (C.1, C.3, C.4, C.5, C.6) ----------

        private void btnConfirmarEntrega_Click(object? sender, EventArgs e)
        {
            OrdenSeleccion? orden = ExigirOrdenSeleccion();
            if (orden == null) return;

            // El cumplimiento se registra una sola vez: si ya existe, solo se informa.
            if (orden.Estado == EstadoOrdenSeleccion.Cumplida)
            {
                Mensajes.Info("La orden de selección " + orden.Numero + " ya fue cumplida. Servicio registrado: " + orden.Servicio + ".", "Selección cumplida");
                return;
            }

            // Cada renglón debe tener su cantidad retirada registrada.
            foreach (ListViewItem fila in lvRenglones.Items)
            {
                if (fila.SubItems[colRenglonesRetirada.Index].Text.Length == 0)
                {
                    Mensajes.Error("Ingrese la cantidad retirada de cada renglón.", lvRenglones);
                    return;
                }
            }

            // La cantidad retirada debe coincidir con la requerida.
            string observacion = txtObservacion.Text.Trim();
            foreach (ListViewItem fila in lvRenglones.Items)
            {
                Renglon r = (Renglon)fila.Tag!;
                if (int.Parse(fila.SubItems[colRenglonesRetirada.Index].Text) != r.Requerida)
                {
                    string mensaje = MensajeDiferencia(r);
                    if (observacion.Length == 0)
                        mensaje += Environment.NewLine + "Describa la diferencia observada (hasta 200 caracteres).";
                    Mensajes.Error(mensaje, observacion.Length == 0 ? txtObservacion : lvRenglones);
                    return;
                }
            }

            if (Validaciones.SuperaLargo(observacion, Validaciones.MaxLargoObservacion))
            {
                Mensajes.Error("Describa la diferencia observada (hasta 200 caracteres).", txtObservacion);
                return;
            }

            if (!chkEntregaPreparacion.Checked)
            {
                Mensajes.Error("Confirme la entrega de la mercadería a Preparación.", chkEntregaPreparacion);
                return;
            }

            // Se descuenta el stock físico y se libera el compromiso.
            foreach (Renglon r in orden.Renglones)
            {
                stockFisico[r.Sku] -= r.Requerida;
                stockComprometido[r.Sku] -= r.Requerida;
            }

            orden.Estado = EstadoOrdenSeleccion.Cumplida;
            // Servicio a cobrar según la operación (supuesto del prototipo: Fulfillment / Out).
            orden.Servicio = orden.Modalidad == Modalidad.Fulfillment ? "Fulfillment" : "Out";
            txtServicio.Text = orden.Servicio;
            lvOrdenesSeleccion.SelectedItems[0].SubItems[colOrdenesSeleccionEstado.Index].Text = orden.Estado;

            string resumen = string.Join(Environment.NewLine, orden.Renglones.Select(r =>
                r.Sku + ": físico " + stockFisico[r.Sku] + ", comprometido " + stockComprometido[r.Sku] +
                ", disponible " + (stockFisico[r.Sku] - stockComprometido[r.Sku])));

            Mensajes.Info("Selección " + orden.Numero + " cumplida. Los pedidos vinculados pasan a " + EstadoPedido.EnPreparacion + "." + Environment.NewLine +
                          "Servicio registrado: " + orden.Servicio + "." + Environment.NewLine + Environment.NewLine + resumen,
                          "Entrega confirmada");
        }

        private void btnReportarIncidente_Click(object? sender, EventArgs e)
        {
            OrdenSeleccion? orden = ExigirOrdenSeleccion();
            if (orden == null) return;

            Mensajes.Info("Incidente informado para la orden de selección " + orden.Numero + ".", "Incidente");
        }
    }
}
