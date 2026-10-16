namespace GRUPO_D.PAMPAZON.CU1_GestionPedidosSeleccion
{
    partial class GestionPedidosSeleccionForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        #region Código generado para el diseñador
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblEmpresa = new Label();
            grpContexto = new GroupBox();
            lblDeposito = new Label();
            cboDeposito = new ComboBox();
            lblRol = new Label();
            lblFechaTrabajo = new Label();
            dtpFechaTrabajo = new DateTimePicker();
            grpValidacionOrdenes = new GroupBox();
            grpFiltros = new GroupBox();
            lblFiltroOrden = new Label();
            txtFiltroOrden = new TextBox();
            lblFiltroCliente = new Label();
            cboFiltroCliente = new ComboBox();
            lblFiltroOrigen = new Label();
            cboFiltroOrigen = new ComboBox();
            chkFiltroFechaAsignacion = new CheckBox();
            dtpFiltroFechaAsignacion = new DateTimePicker();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            lblOrdenesAsignadas = new Label();
            lvOrdenesAsignadas = new ListView();
            colOrdenesAsignadasNumero = new ColumnHeader();
            colOrdenesAsignadasAsignacion = new ColumnHeader();
            colOrdenesAsignadasCliente = new ColumnHeader();
            colOrdenesAsignadasOrigen = new ColumnHeader();
            colOrdenesAsignadasModalidad = new ColumnHeader();
            colOrdenesAsignadasProductos = new ColumnHeader();
            colOrdenesAsignadasEstado = new ColumnHeader();
            grpDetalleOrden = new GroupBox();
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblContrato = new Label();
            txtContrato = new TextBox();
            lblModalidad = new Label();
            txtModalidad = new TextBox();
            lblEstado = new Label();
            txtEstado = new TextBox();
            lvDisponibilidad = new ListView();
            colDisponibilidadSku = new ColumnHeader();
            colDisponibilidadProducto = new ColumnHeader();
            colDisponibilidadUnidad = new ColumnHeader();
            colDisponibilidadSolicitado = new ColumnHeader();
            colDisponibilidadDisponible = new ColumnHeader();
            colDisponibilidadValidacion = new ColumnHeader();
            lblAyudaStock = new Label();
            lblResultadoValidacion = new Label();
            btnValidarDisponibilidad = new Button();
            btnAceptarOrden = new Button();
            btnRechazarOrden = new Button();
            lblMotivoRechazo = new Label();
            txtMotivoRechazo = new TextBox();
            grpCortesSeleccion = new GroupBox();
            grpDatosCorte = new GroupBox();
            lblFechaCorte = new Label();
            dtpFechaCorte = new DateTimePicker();
            grpCorteOperativo = new GroupBox();
            rdoPrimerCorte = new RadioButton();
            rdoSegundoCorte = new RadioButton();
            chkSoloPendientes = new CheckBox();
            btnConsultarPendientes = new Button();
            lblOrdenesPendientes = new Label();
            lvOrdenesPendientes = new ListView();
            colOrdenesPendientesNumero = new ColumnHeader();
            colOrdenesPendientesCliente = new ColumnHeader();
            colOrdenesPendientesOrigen = new ColumnHeader();
            colOrdenesPendientesModalidad = new ColumnHeader();
            colOrdenesPendientesProductos = new ColumnHeader();
            colOrdenesPendientesEstado = new ColumnHeader();
            btnPrepararCorte = new Button();
            grpPropuestaSeleccion = new GroupBox();
            lvPropuestaSeleccion = new ListView();
            colPropuestaSeleccionCliente = new ColumnHeader();
            colPropuestaSeleccionSku = new ColumnHeader();
            colPropuestaSeleccionProducto = new ColumnHeader();
            colPropuestaSeleccionUbicacion = new ColumnHeader();
            colPropuestaSeleccionCantidad = new ColumnHeader();
            colPropuestaSeleccionUnidad = new ColumnHeader();
            colPropuestaSeleccionPedidos = new ColumnHeader();
            btnConfirmarCorte = new Button();
            btnVerOrdenesSeleccion = new Button();
            btnDescartarPropuesta = new Button();
            grpContexto.SuspendLayout();
            grpValidacionOrdenes.SuspendLayout();
            grpFiltros.SuspendLayout();
            grpDetalleOrden.SuspendLayout();
            grpCortesSeleccion.SuspendLayout();
            grpDatosCorte.SuspendLayout();
            grpCorteOperativo.SuspendLayout();
            grpPropuestaSeleccion.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(24, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(890, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Pedidos y Selección";
            // 
            // lblEmpresa
            // 
            lblEmpresa.Location = new Point(26, 48);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(1050, 22);
            lblEmpresa.TabIndex = 1;
            lblEmpresa.Text = "PAMPAZON";
            // 
            // grpContexto
            // 
            grpContexto.Controls.Add(lblDeposito);
            grpContexto.Controls.Add(cboDeposito);
            grpContexto.Controls.Add(lblRol);
            grpContexto.Controls.Add(lblFechaTrabajo);
            grpContexto.Controls.Add(dtpFechaTrabajo);
            grpContexto.Location = new Point(16, 84);
            grpContexto.Name = "grpContexto";
            grpContexto.Size = new Size(1288, 72);
            grpContexto.TabIndex = 2;
            grpContexto.TabStop = false;
            grpContexto.Text = "Contexto de trabajo";
            // 
            // lblDeposito
            // 
            lblDeposito.Location = new Point(16, 30);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(68, 24);
            lblDeposito.TabIndex = 0;
            lblDeposito.Text = "Depósito";
            // 
            // cboDeposito
            // 
            cboDeposito.Enabled = false;
            cboDeposito.Items.AddRange(new object[] { "GBA" });
            cboDeposito.Location = new Point(90, 26);
            cboDeposito.Name = "cboDeposito";
            cboDeposito.Size = new Size(372, 23);
            cboDeposito.TabIndex = 1;
            // 
            // lblRol
            // 
            lblRol.Location = new Point(480, 29);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(210, 24);
            lblRol.TabIndex = 2;
            lblRol.Text = "Rol: Encargado de Preparación";
            // 
            // lblFechaTrabajo
            // 
            lblFechaTrabajo.Location = new Point(700, 30);
            lblFechaTrabajo.Name = "lblFechaTrabajo";
            lblFechaTrabajo.Size = new Size(72, 24);
            lblFechaTrabajo.TabIndex = 3;
            lblFechaTrabajo.Text = "Fecha";
            // 
            // dtpFechaTrabajo
            // 
            dtpFechaTrabajo.Enabled = false;
            dtpFechaTrabajo.Format = DateTimePickerFormat.Short;
            dtpFechaTrabajo.Location = new Point(779, 26);
            dtpFechaTrabajo.Name = "dtpFechaTrabajo";
            dtpFechaTrabajo.Size = new Size(493, 23);
            dtpFechaTrabajo.TabIndex = 4;
            dtpFechaTrabajo.Value = new DateTime(2026, 10, 12, 0, 0, 0, 0);
            // 
            // grpValidacionOrdenes
            // 
            grpValidacionOrdenes.Controls.Add(grpFiltros);
            grpValidacionOrdenes.Controls.Add(lblOrdenesAsignadas);
            grpValidacionOrdenes.Controls.Add(lvOrdenesAsignadas);
            grpValidacionOrdenes.Controls.Add(grpDetalleOrden);
            grpValidacionOrdenes.Controls.Add(btnValidarDisponibilidad);
            grpValidacionOrdenes.Controls.Add(btnAceptarOrden);
            grpValidacionOrdenes.Controls.Add(btnRechazarOrden);
            grpValidacionOrdenes.Controls.Add(lblMotivoRechazo);
            grpValidacionOrdenes.Controls.Add(txtMotivoRechazo);
            grpValidacionOrdenes.Location = new Point(16, 164);
            grpValidacionOrdenes.Name = "grpValidacionOrdenes";
            grpValidacionOrdenes.Size = new Size(636, 713);
            grpValidacionOrdenes.TabIndex = 3;
            grpValidacionOrdenes.TabStop = false;
            grpValidacionOrdenes.Text = "Órdenes asignadas · Validar, aceptar o rechazar (P01 / P02)";
            // 
            // grpFiltros
            // 
            grpFiltros.Controls.Add(lblFiltroOrden);
            grpFiltros.Controls.Add(txtFiltroOrden);
            grpFiltros.Controls.Add(lblFiltroCliente);
            grpFiltros.Controls.Add(cboFiltroCliente);
            grpFiltros.Controls.Add(lblFiltroOrigen);
            grpFiltros.Controls.Add(cboFiltroOrigen);
            grpFiltros.Controls.Add(chkFiltroFechaAsignacion);
            grpFiltros.Controls.Add(dtpFiltroFechaAsignacion);
            grpFiltros.Controls.Add(btnBuscar);
            grpFiltros.Controls.Add(btnLimpiar);
            grpFiltros.Location = new Point(12, 24);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(612, 112);
            grpFiltros.TabIndex = 0;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Buscar órdenes";
            // 
            // lblFiltroOrden
            // 
            lblFiltroOrden.Location = new Point(12, 22);
            lblFiltroOrden.Name = "lblFiltroOrden";
            lblFiltroOrden.Size = new Size(130, 20);
            lblFiltroOrden.TabIndex = 0;
            lblFiltroOrden.Text = "N.º de orden";
            // 
            // txtFiltroOrden
            // 
            txtFiltroOrden.Location = new Point(12, 44);
            txtFiltroOrden.Name = "txtFiltroOrden";
            txtFiltroOrden.Size = new Size(130, 23);
            txtFiltroOrden.TabIndex = 1;
            // 
            // lblFiltroCliente
            // 
            lblFiltroCliente.Location = new Point(154, 22);
            lblFiltroCliente.Name = "lblFiltroCliente";
            lblFiltroCliente.Size = new Size(180, 20);
            lblFiltroCliente.TabIndex = 2;
            lblFiltroCliente.Text = "Cliente";
            // 
            // cboFiltroCliente
            // 
            cboFiltroCliente.Items.AddRange(new object[] { "Todos los clientes", "Cliente Demo A", "Cliente Demo B" });
            cboFiltroCliente.Location = new Point(154, 44);
            cboFiltroCliente.Name = "cboFiltroCliente";
            cboFiltroCliente.Size = new Size(180, 23);
            cboFiltroCliente.TabIndex = 3;
            // 
            // lblFiltroOrigen
            // 
            lblFiltroOrigen.Location = new Point(346, 22);
            lblFiltroOrigen.Name = "lblFiltroOrigen";
            lblFiltroOrigen.Size = new Size(130, 20);
            lblFiltroOrigen.TabIndex = 4;
            lblFiltroOrigen.Text = "Origen";
            // 
            // cboFiltroOrigen
            // 
            cboFiltroOrigen.Items.AddRange(new object[] { "Todos", "Cliente", "Traslado interno" });
            cboFiltroOrigen.Location = new Point(346, 44);
            cboFiltroOrigen.Name = "cboFiltroOrigen";
            cboFiltroOrigen.Size = new Size(130, 23);
            cboFiltroOrigen.TabIndex = 5;
            // 
            // chkFiltroFechaAsignacion
            // 
            chkFiltroFechaAsignacion.Location = new Point(488, 20);
            chkFiltroFechaAsignacion.Name = "chkFiltroFechaAsignacion";
            chkFiltroFechaAsignacion.Size = new Size(118, 22);
            chkFiltroFechaAsignacion.TabIndex = 6;
            chkFiltroFechaAsignacion.Text = "Asignada desde";
            // 
            // dtpFiltroFechaAsignacion
            // 
            dtpFiltroFechaAsignacion.Enabled = false;
            dtpFiltroFechaAsignacion.Format = DateTimePickerFormat.Short;
            dtpFiltroFechaAsignacion.Location = new Point(488, 44);
            dtpFiltroFechaAsignacion.Name = "dtpFiltroFechaAsignacion";
            dtpFiltroFechaAsignacion.Size = new Size(112, 23);
            dtpFiltroFechaAsignacion.TabIndex = 7;
            dtpFiltroFechaAsignacion.Value = new DateTime(2026, 10, 12, 0, 0, 0, 0);
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 74);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(296, 30);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(314, 74);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(286, 30);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            // 
            // lblOrdenesAsignadas
            // 
            lblOrdenesAsignadas.Location = new Point(12, 144);
            lblOrdenesAsignadas.Name = "lblOrdenesAsignadas";
            lblOrdenesAsignadas.Size = new Size(612, 20);
            lblOrdenesAsignadas.TabIndex = 1;
            lblOrdenesAsignadas.Text = "Órdenes asignadas al depósito";
            // 
            // lvOrdenesAsignadas
            // 
            lvOrdenesAsignadas.Columns.AddRange(new ColumnHeader[] { colOrdenesAsignadasNumero, colOrdenesAsignadasAsignacion, colOrdenesAsignadasCliente, colOrdenesAsignadasOrigen, colOrdenesAsignadasModalidad, colOrdenesAsignadasProductos, colOrdenesAsignadasEstado });
            lvOrdenesAsignadas.FullRowSelect = true;
            lvOrdenesAsignadas.GridLines = true;
            lvOrdenesAsignadas.Location = new Point(12, 166);
            lvOrdenesAsignadas.MultiSelect = false;
            lvOrdenesAsignadas.Name = "lvOrdenesAsignadas";
            lvOrdenesAsignadas.Size = new Size(612, 118);
            lvOrdenesAsignadas.TabIndex = 2;
            lvOrdenesAsignadas.UseCompatibleStateImageBehavior = false;
            lvOrdenesAsignadas.View = View.Details;
            // 
            // colOrdenesAsignadasNumero
            // 
            colOrdenesAsignadasNumero.Text = "N.º de orden";
            colOrdenesAsignadasNumero.Width = 85;
            // 
            // colOrdenesAsignadasAsignacion
            // 
            colOrdenesAsignadasAsignacion.Text = "Asignación";
            colOrdenesAsignadasAsignacion.Width = 80;
            // 
            // colOrdenesAsignadasCliente
            // 
            colOrdenesAsignadasCliente.Text = "Cliente";
            colOrdenesAsignadasCliente.Width = 108;
            // 
            // colOrdenesAsignadasOrigen
            // 
            colOrdenesAsignadasOrigen.Text = "Origen";
            colOrdenesAsignadasOrigen.Width = 105;
            // 
            // colOrdenesAsignadasModalidad
            // 
            colOrdenesAsignadasModalidad.Text = "Modalidad";
            colOrdenesAsignadasModalidad.Width = 90;
            // 
            // colOrdenesAsignadasProductos
            // 
            colOrdenesAsignadasProductos.Text = "Productos";
            colOrdenesAsignadasProductos.Width = 65;
            // 
            // colOrdenesAsignadasEstado
            // 
            colOrdenesAsignadasEstado.Text = "Estado";
            colOrdenesAsignadasEstado.Width = 75;
            // 
            // grpDetalleOrden
            // 
            grpDetalleOrden.Controls.Add(lblCliente);
            grpDetalleOrden.Controls.Add(txtCliente);
            grpDetalleOrden.Controls.Add(lblContrato);
            grpDetalleOrden.Controls.Add(txtContrato);
            grpDetalleOrden.Controls.Add(lblModalidad);
            grpDetalleOrden.Controls.Add(txtModalidad);
            grpDetalleOrden.Controls.Add(lblEstado);
            grpDetalleOrden.Controls.Add(txtEstado);
            grpDetalleOrden.Controls.Add(lvDisponibilidad);
            grpDetalleOrden.Controls.Add(lblAyudaStock);
            grpDetalleOrden.Controls.Add(lblResultadoValidacion);
            grpDetalleOrden.Location = new Point(12, 292);
            grpDetalleOrden.Name = "grpDetalleOrden";
            grpDetalleOrden.Size = new Size(612, 306);
            grpDetalleOrden.TabIndex = 3;
            grpDetalleOrden.TabStop = false;
            grpDetalleOrden.Text = "Detalle de la orden";
            // 
            // lblCliente
            // 
            lblCliente.Location = new Point(10, 27);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(60, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(74, 24);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(220, 23);
            txtCliente.TabIndex = 1;
            // 
            // lblContrato
            // 
            lblContrato.Location = new Point(312, 27);
            lblContrato.Name = "lblContrato";
            lblContrato.Size = new Size(60, 20);
            lblContrato.TabIndex = 2;
            lblContrato.Text = "Contrato";
            // 
            // txtContrato
            // 
            txtContrato.Enabled = false;
            txtContrato.Location = new Point(376, 24);
            txtContrato.Name = "txtContrato";
            txtContrato.Size = new Size(222, 23);
            txtContrato.TabIndex = 3;
            // 
            // lblModalidad
            // 
            lblModalidad.Location = new Point(10, 58);
            lblModalidad.Name = "lblModalidad";
            lblModalidad.Size = new Size(64, 20);
            lblModalidad.TabIndex = 4;
            lblModalidad.Text = "Modalidad";
            // 
            // txtModalidad
            // 
            txtModalidad.Enabled = false;
            txtModalidad.Location = new Point(74, 55);
            txtModalidad.Name = "txtModalidad";
            txtModalidad.Size = new Size(220, 23);
            txtModalidad.TabIndex = 5;
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(312, 58);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(60, 20);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Enabled = false;
            txtEstado.Location = new Point(376, 55);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(222, 23);
            txtEstado.TabIndex = 7;
            // 
            // lvDisponibilidad
            // 
            lvDisponibilidad.Columns.AddRange(new ColumnHeader[] { colDisponibilidadSku, colDisponibilidadProducto, colDisponibilidadUnidad, colDisponibilidadSolicitado, colDisponibilidadDisponible, colDisponibilidadValidacion });
            lvDisponibilidad.FullRowSelect = true;
            lvDisponibilidad.GridLines = true;
            lvDisponibilidad.Location = new Point(10, 88);
            lvDisponibilidad.MultiSelect = false;
            lvDisponibilidad.Name = "lvDisponibilidad";
            lvDisponibilidad.Size = new Size(592, 120);
            lvDisponibilidad.TabIndex = 8;
            lvDisponibilidad.UseCompatibleStateImageBehavior = false;
            lvDisponibilidad.View = View.Details;
            // 
            // colDisponibilidadSku
            // 
            colDisponibilidadSku.Text = "SKU";
            colDisponibilidadSku.Width = 70;
            // 
            // colDisponibilidadProducto
            // 
            colDisponibilidadProducto.Text = "Producto";
            colDisponibilidadProducto.Width = 158;
            // 
            // colDisponibilidadUnidad
            // 
            colDisponibilidadUnidad.Text = "Unidad";
            colDisponibilidadUnidad.Width = 60;
            // 
            // colDisponibilidadSolicitado
            // 
            colDisponibilidadSolicitado.Text = "Solicitado";
            colDisponibilidadSolicitado.Width = 75;
            // 
            // colDisponibilidadDisponible
            // 
            colDisponibilidadDisponible.Text = "Disponible";
            colDisponibilidadDisponible.Width = 75;
            // 
            // colDisponibilidadValidacion
            // 
            colDisponibilidadValidacion.Text = "Validación";
            colDisponibilidadValidacion.Width = 145;
            // 
            // lblAyudaStock
            // 
            lblAyudaStock.Location = new Point(10, 214);
            lblAyudaStock.Name = "lblAyudaStock";
            lblAyudaStock.Size = new Size(592, 20);
            lblAyudaStock.TabIndex = 9;
            lblAyudaStock.Text = "Disponible: mercadería aceptada y no comprometida del cliente en este depósito.";
            // 
            // lblResultadoValidacion
            // 
            lblResultadoValidacion.Location = new Point(10, 238);
            lblResultadoValidacion.Name = "lblResultadoValidacion";
            lblResultadoValidacion.Size = new Size(592, 58);
            lblResultadoValidacion.TabIndex = 10;
            lblResultadoValidacion.Text = "Validación pendiente. Al aceptar se compromete el stock, sin descontar las existencias físicas.";
            // 
            // btnValidarDisponibilidad
            // 
            btnValidarDisponibilidad.Location = new Point(12, 606);
            btnValidarDisponibilidad.Name = "btnValidarDisponibilidad";
            btnValidarDisponibilidad.Size = new Size(200, 34);
            btnValidarDisponibilidad.TabIndex = 4;
            btnValidarDisponibilidad.Text = "Validar disponibilidad";
            // 
            // btnAceptarOrden
            // 
            btnAceptarOrden.Location = new Point(218, 606);
            btnAceptarOrden.Name = "btnAceptarOrden";
            btnAceptarOrden.Size = new Size(200, 34);
            btnAceptarOrden.TabIndex = 5;
            btnAceptarOrden.Text = "Aceptar y comprometer";
            // 
            // btnRechazarOrden
            // 
            btnRechazarOrden.Location = new Point(424, 606);
            btnRechazarOrden.Name = "btnRechazarOrden";
            btnRechazarOrden.Size = new Size(200, 34);
            btnRechazarOrden.TabIndex = 6;
            btnRechazarOrden.Text = "Rechazar por falta de stock";
            // 
            // lblMotivoRechazo
            // 
            lblMotivoRechazo.Location = new Point(12, 652);
            lblMotivoRechazo.Name = "lblMotivoRechazo";
            lblMotivoRechazo.Size = new Size(612, 20);
            lblMotivoRechazo.TabIndex = 7;
            lblMotivoRechazo.Text = "Motivo del rechazo";
            // 
            // txtMotivoRechazo
            // 
            txtMotivoRechazo.Enabled = false;
            txtMotivoRechazo.Location = new Point(12, 674);
            txtMotivoRechazo.Name = "txtMotivoRechazo";
            txtMotivoRechazo.Size = new Size(612, 23);
            txtMotivoRechazo.TabIndex = 8;
            txtMotivoRechazo.Text = "Se completará con los productos y cantidades faltantes.";
            // 
            // grpCortesSeleccion
            // 
            grpCortesSeleccion.Controls.Add(grpDatosCorte);
            grpCortesSeleccion.Controls.Add(lblOrdenesPendientes);
            grpCortesSeleccion.Controls.Add(lvOrdenesPendientes);
            grpCortesSeleccion.Controls.Add(btnPrepararCorte);
            grpCortesSeleccion.Controls.Add(grpPropuestaSeleccion);
            grpCortesSeleccion.Controls.Add(btnConfirmarCorte);
            grpCortesSeleccion.Controls.Add(btnVerOrdenesSeleccion);
            grpCortesSeleccion.Controls.Add(btnDescartarPropuesta);
            grpCortesSeleccion.Location = new Point(668, 164);
            grpCortesSeleccion.Name = "grpCortesSeleccion";
            grpCortesSeleccion.Size = new Size(636, 713);
            grpCortesSeleccion.TabIndex = 4;
            grpCortesSeleccion.TabStop = false;
            grpCortesSeleccion.Text = "Cortes de selección · Generar órdenes de selección (P03)";
            // 
            // grpDatosCorte
            // 
            grpDatosCorte.Controls.Add(lblFechaCorte);
            grpDatosCorte.Controls.Add(dtpFechaCorte);
            grpDatosCorte.Controls.Add(grpCorteOperativo);
            grpDatosCorte.Controls.Add(chkSoloPendientes);
            grpDatosCorte.Controls.Add(btnConsultarPendientes);
            grpDatosCorte.Location = new Point(12, 24);
            grpDatosCorte.Name = "grpDatosCorte";
            grpDatosCorte.Size = new Size(612, 112);
            grpDatosCorte.TabIndex = 0;
            grpDatosCorte.TabStop = false;
            grpDatosCorte.Text = "Datos del corte";
            // 
            // lblFechaCorte
            // 
            lblFechaCorte.Location = new Point(12, 22);
            lblFechaCorte.Name = "lblFechaCorte";
            lblFechaCorte.Size = new Size(130, 20);
            lblFechaCorte.TabIndex = 0;
            lblFechaCorte.Text = "Fecha del corte";
            // 
            // dtpFechaCorte
            // 
            dtpFechaCorte.Format = DateTimePickerFormat.Short;
            dtpFechaCorte.Location = new Point(12, 44);
            dtpFechaCorte.Name = "dtpFechaCorte";
            dtpFechaCorte.Size = new Size(140, 23);
            dtpFechaCorte.TabIndex = 1;
            dtpFechaCorte.Value = new DateTime(2026, 10, 12, 0, 0, 0, 0);
            // 
            // grpCorteOperativo
            // 
            grpCorteOperativo.Controls.Add(rdoPrimerCorte);
            grpCorteOperativo.Controls.Add(rdoSegundoCorte);
            grpCorteOperativo.Location = new Point(164, 14);
            grpCorteOperativo.Name = "grpCorteOperativo";
            grpCorteOperativo.Size = new Size(250, 56);
            grpCorteOperativo.TabIndex = 2;
            grpCorteOperativo.TabStop = false;
            grpCorteOperativo.Text = "Corte operativo";
            // 
            // rdoPrimerCorte
            // 
            rdoPrimerCorte.Checked = true;
            rdoPrimerCorte.Location = new Point(14, 24);
            rdoPrimerCorte.Name = "rdoPrimerCorte";
            rdoPrimerCorte.Size = new Size(115, 24);
            rdoPrimerCorte.TabIndex = 0;
            rdoPrimerCorte.TabStop = true;
            rdoPrimerCorte.Text = "Primer corte";
            // 
            // rdoSegundoCorte
            // 
            rdoSegundoCorte.Location = new Point(132, 24);
            rdoSegundoCorte.Name = "rdoSegundoCorte";
            rdoSegundoCorte.Size = new Size(112, 24);
            rdoSegundoCorte.TabIndex = 1;
            rdoSegundoCorte.Text = "Segundo corte";
            // 
            // chkSoloPendientes
            // 
            chkSoloPendientes.Checked = true;
            chkSoloPendientes.Enabled = false;
            chkSoloPendientes.Location = new Point(426, 44);
            chkSoloPendientes.Name = "chkSoloPendientes";
            chkSoloPendientes.Size = new Size(186, 24);
            chkSoloPendientes.TabIndex = 3;
            chkSoloPendientes.Text = "Solo órdenes PENDIENTES";
            // 
            // btnConsultarPendientes
            // 
            btnConsultarPendientes.Location = new Point(12, 74);
            btnConsultarPendientes.Name = "btnConsultarPendientes";
            btnConsultarPendientes.Size = new Size(588, 30);
            btnConsultarPendientes.TabIndex = 4;
            btnConsultarPendientes.Text = "Consultar pendientes";
            // 
            // lblOrdenesPendientes
            // 
            lblOrdenesPendientes.Location = new Point(12, 144);
            lblOrdenesPendientes.Name = "lblOrdenesPendientes";
            lblOrdenesPendientes.Size = new Size(612, 20);
            lblOrdenesPendientes.TabIndex = 1;
            lblOrdenesPendientes.Text = "Órdenes pendientes · Seleccionar (Ctrl + clic) las que se incorporarán al corte";
            // 
            // lvOrdenesPendientes
            // 
            lvOrdenesPendientes.Columns.AddRange(new ColumnHeader[] { colOrdenesPendientesNumero, colOrdenesPendientesCliente, colOrdenesPendientesOrigen, colOrdenesPendientesModalidad, colOrdenesPendientesProductos, colOrdenesPendientesEstado });
            lvOrdenesPendientes.FullRowSelect = true;
            lvOrdenesPendientes.GridLines = true;
            lvOrdenesPendientes.Location = new Point(12, 166);
            lvOrdenesPendientes.MultiSelect = true;
            lvOrdenesPendientes.Name = "lvOrdenesPendientes";
            lvOrdenesPendientes.Size = new Size(612, 140);
            lvOrdenesPendientes.TabIndex = 2;
            lvOrdenesPendientes.UseCompatibleStateImageBehavior = false;
            lvOrdenesPendientes.View = View.Details;
            // 
            // colOrdenesPendientesNumero
            // 
            colOrdenesPendientesNumero.Text = "N.º de orden";
            colOrdenesPendientesNumero.Width = 95;
            // 
            // colOrdenesPendientesCliente
            // 
            colOrdenesPendientesCliente.Text = "Cliente";
            colOrdenesPendientesCliente.Width = 133;
            // 
            // colOrdenesPendientesOrigen
            // 
            colOrdenesPendientesOrigen.Text = "Origen";
            colOrdenesPendientesOrigen.Width = 115;
            // 
            // colOrdenesPendientesModalidad
            // 
            colOrdenesPendientesModalidad.Text = "Modalidad";
            colOrdenesPendientesModalidad.Width = 100;
            // 
            // colOrdenesPendientesProductos
            // 
            colOrdenesPendientesProductos.Text = "Productos";
            colOrdenesPendientesProductos.Width = 70;
            // 
            // colOrdenesPendientesEstado
            // 
            colOrdenesPendientesEstado.Text = "Estado";
            colOrdenesPendientesEstado.Width = 90;
            // 
            // btnPrepararCorte
            // 
            btnPrepararCorte.Location = new Point(12, 314);
            btnPrepararCorte.Name = "btnPrepararCorte";
            btnPrepararCorte.Size = new Size(612, 34);
            btnPrepararCorte.TabIndex = 3;
            btnPrepararCorte.Text = "Preparar corte";
            // 
            // grpPropuestaSeleccion
            // 
            grpPropuestaSeleccion.Controls.Add(lvPropuestaSeleccion);
            grpPropuestaSeleccion.Location = new Point(12, 356);
            grpPropuestaSeleccion.Name = "grpPropuestaSeleccion";
            grpPropuestaSeleccion.Size = new Size(612, 242);
            grpPropuestaSeleccion.TabIndex = 4;
            grpPropuestaSeleccion.TabStop = false;
            grpPropuestaSeleccion.Text = "Vista previa de la selección";
            // 
            // lvPropuestaSeleccion
            // 
            lvPropuestaSeleccion.Columns.AddRange(new ColumnHeader[] { colPropuestaSeleccionCliente, colPropuestaSeleccionSku, colPropuestaSeleccionProducto, colPropuestaSeleccionUbicacion, colPropuestaSeleccionCantidad, colPropuestaSeleccionUnidad, colPropuestaSeleccionPedidos });
            lvPropuestaSeleccion.FullRowSelect = true;
            lvPropuestaSeleccion.GridLines = true;
            lvPropuestaSeleccion.Location = new Point(10, 22);
            lvPropuestaSeleccion.MultiSelect = false;
            lvPropuestaSeleccion.Name = "lvPropuestaSeleccion";
            lvPropuestaSeleccion.Size = new Size(592, 210);
            lvPropuestaSeleccion.TabIndex = 0;
            lvPropuestaSeleccion.UseCompatibleStateImageBehavior = false;
            lvPropuestaSeleccion.View = View.Details;
            // 
            // colPropuestaSeleccionCliente
            // 
            colPropuestaSeleccionCliente.Text = "Cliente";
            colPropuestaSeleccionCliente.Width = 100;
            // 
            // colPropuestaSeleccionSku
            // 
            colPropuestaSeleccionSku.Text = "SKU";
            colPropuestaSeleccionSku.Width = 65;
            // 
            // colPropuestaSeleccionProducto
            // 
            colPropuestaSeleccionProducto.Text = "Producto";
            colPropuestaSeleccionProducto.Width = 113;
            // 
            // colPropuestaSeleccionUbicacion
            // 
            colPropuestaSeleccionUbicacion.Text = "Ubicación";
            colPropuestaSeleccionUbicacion.Width = 70;
            // 
            // colPropuestaSeleccionCantidad
            // 
            colPropuestaSeleccionCantidad.Text = "Cantidad";
            colPropuestaSeleccionCantidad.Width = 60;
            // 
            // colPropuestaSeleccionUnidad
            // 
            colPropuestaSeleccionUnidad.Text = "Unidad";
            colPropuestaSeleccionUnidad.Width = 55;
            // 
            // colPropuestaSeleccionPedidos
            // 
            colPropuestaSeleccionPedidos.Text = "Pedidos de origen";
            colPropuestaSeleccionPedidos.Width = 125;
            // 
            // btnConfirmarCorte
            // 
            btnConfirmarCorte.Location = new Point(12, 606);
            btnConfirmarCorte.Name = "btnConfirmarCorte";
            btnConfirmarCorte.Size = new Size(200, 34);
            btnConfirmarCorte.TabIndex = 5;
            btnConfirmarCorte.Text = "Confirmar y generar selección";
            // 
            // btnVerOrdenesSeleccion
            // 
            btnVerOrdenesSeleccion.Enabled = false;
            btnVerOrdenesSeleccion.Location = new Point(218, 606);
            btnVerOrdenesSeleccion.Name = "btnVerOrdenesSeleccion";
            btnVerOrdenesSeleccion.Size = new Size(200, 34);
            btnVerOrdenesSeleccion.TabIndex = 6;
            btnVerOrdenesSeleccion.Text = "Ver órdenes generadas";
            // 
            // btnDescartarPropuesta
            // 
            btnDescartarPropuesta.Location = new Point(424, 606);
            btnDescartarPropuesta.Name = "btnDescartarPropuesta";
            btnDescartarPropuesta.Size = new Size(200, 34);
            btnDescartarPropuesta.TabIndex = 7;
            btnDescartarPropuesta.Text = "Descartar propuesta";
            // 
            // GestionPedidosSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 901);
            Controls.Add(lblTitulo);
            Controls.Add(lblEmpresa);
            Controls.Add(grpContexto);
            Controls.Add(grpValidacionOrdenes);
            Controls.Add(grpCortesSeleccion);
            Name = "GestionPedidosSeleccionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pampazon - Gestión de Pedidos y Selección";
            grpContexto.ResumeLayout(false);
            grpValidacionOrdenes.ResumeLayout(false);
            grpValidacionOrdenes.PerformLayout();
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            grpDetalleOrden.ResumeLayout(false);
            grpDetalleOrden.PerformLayout();
            grpCortesSeleccion.ResumeLayout(false);
            grpDatosCorte.ResumeLayout(false);
            grpCorteOperativo.ResumeLayout(false);
            grpPropuestaSeleccion.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private Label lblTitulo;
        private Label lblEmpresa;
        private GroupBox grpContexto;
        private Label lblDeposito;
        private ComboBox cboDeposito;
        private Label lblRol;
        private Label lblFechaTrabajo;
        private DateTimePicker dtpFechaTrabajo;
        private GroupBox grpValidacionOrdenes;
        private GroupBox grpFiltros;
        private Label lblFiltroOrden;
        private TextBox txtFiltroOrden;
        private Label lblFiltroCliente;
        private ComboBox cboFiltroCliente;
        private Label lblFiltroOrigen;
        private ComboBox cboFiltroOrigen;
        private CheckBox chkFiltroFechaAsignacion;
        private DateTimePicker dtpFiltroFechaAsignacion;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Label lblOrdenesAsignadas;
        private ListView lvOrdenesAsignadas;
        private ColumnHeader colOrdenesAsignadasNumero;
        private ColumnHeader colOrdenesAsignadasAsignacion;
        private ColumnHeader colOrdenesAsignadasCliente;
        private ColumnHeader colOrdenesAsignadasOrigen;
        private ColumnHeader colOrdenesAsignadasModalidad;
        private ColumnHeader colOrdenesAsignadasProductos;
        private ColumnHeader colOrdenesAsignadasEstado;
        private GroupBox grpDetalleOrden;
        private Label lblCliente;
        private TextBox txtCliente;
        private Label lblContrato;
        private TextBox txtContrato;
        private Label lblModalidad;
        private TextBox txtModalidad;
        private Label lblEstado;
        private TextBox txtEstado;
        private ListView lvDisponibilidad;
        private ColumnHeader colDisponibilidadSku;
        private ColumnHeader colDisponibilidadProducto;
        private ColumnHeader colDisponibilidadUnidad;
        private ColumnHeader colDisponibilidadSolicitado;
        private ColumnHeader colDisponibilidadDisponible;
        private ColumnHeader colDisponibilidadValidacion;
        private Label lblAyudaStock;
        private Label lblResultadoValidacion;
        private Button btnValidarDisponibilidad;
        private Button btnAceptarOrden;
        private Button btnRechazarOrden;
        private Label lblMotivoRechazo;
        private TextBox txtMotivoRechazo;
        private GroupBox grpCortesSeleccion;
        private GroupBox grpDatosCorte;
        private Label lblFechaCorte;
        private DateTimePicker dtpFechaCorte;
        private GroupBox grpCorteOperativo;
        private RadioButton rdoPrimerCorte;
        private RadioButton rdoSegundoCorte;
        private CheckBox chkSoloPendientes;
        private Button btnConsultarPendientes;
        private Label lblOrdenesPendientes;
        private ListView lvOrdenesPendientes;
        private ColumnHeader colOrdenesPendientesNumero;
        private ColumnHeader colOrdenesPendientesCliente;
        private ColumnHeader colOrdenesPendientesOrigen;
        private ColumnHeader colOrdenesPendientesModalidad;
        private ColumnHeader colOrdenesPendientesProductos;
        private ColumnHeader colOrdenesPendientesEstado;
        private Button btnPrepararCorte;
        private GroupBox grpPropuestaSeleccion;
        private ListView lvPropuestaSeleccion;
        private ColumnHeader colPropuestaSeleccionCliente;
        private ColumnHeader colPropuestaSeleccionSku;
        private ColumnHeader colPropuestaSeleccionProducto;
        private ColumnHeader colPropuestaSeleccionUbicacion;
        private ColumnHeader colPropuestaSeleccionCantidad;
        private ColumnHeader colPropuestaSeleccionUnidad;
        private ColumnHeader colPropuestaSeleccionPedidos;
        private Button btnConfirmarCorte;
        private Button btnVerOrdenesSeleccion;
        private Button btnDescartarPropuesta;
    }
}
