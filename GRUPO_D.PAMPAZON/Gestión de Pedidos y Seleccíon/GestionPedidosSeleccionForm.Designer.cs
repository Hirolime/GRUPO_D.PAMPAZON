namespace Pampazon.Prototipos
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
            ListViewItem listViewItem14 = new ListViewItem(new string[] { "OP-000184", "12/10/2026", "Cliente Demo A", "Cliente", "Fulfillment", "2", "ASIGNADA" }, -1);
            ListViewItem listViewItem15 = new ListViewItem(new string[] { "OP-000185", "12/10/2026", "Cliente Demo B", "Cliente", "Palé cerrado", "1", "ASIGNADA" }, -1);
            ListViewItem listViewItem16 = new ListViewItem(new string[] { "TR-000026", "12/10/2026", "Cliente Demo A", "Traslado interno", "Palé cerrado", "1", "ASIGNADA" }, -1);
            ListViewItem listViewItem17 = new ListViewItem(new string[] { "SKU-001", "Remera de algodón", "Unidad", "80", "148", "Pendiente de validar" }, -1);
            ListViewItem listViewItem18 = new ListViewItem(new string[] { "SKU-002", "Pantalón deportivo", "Unidad", "30", "65", "Pendiente de validar" }, -1);
            ListViewItem listViewItem11 = new ListViewItem(new string[] { "OP-000181", "Cliente Demo A", "Cliente", "Fulfillment", "2", "PENDIENTE" }, -1);
            ListViewItem listViewItem12 = new ListViewItem(new string[] { "OP-000182", "Cliente Demo A", "Cliente", "Fulfillment", "1", "PENDIENTE" }, -1);
            ListViewItem listViewItem13 = new ListViewItem(new string[] { "OP-000183", "Cliente Demo B", "Cliente", "Palé cerrado", "1", "PENDIENTE" }, -1);
            ListViewItem listViewItem19 = new ListViewItem(new string[] { "Cliente Demo A", "SKU-001", "Remera de algodón", "A-01-02", "120", "Unidad", "OP-000181 (80); OP-000182 (40)" }, -1);
            ListViewItem listViewItem20 = new ListViewItem(new string[] { "Cliente Demo A", "SKU-002", "Pantalón deportivo", "A-02-01", "30", "Unidad", "OP-000181 (30)" }, -1);
            pnlEncabezado = new Panel();
            lblTitulo = new Label();
            lblEmpresa = new Label();
            grpContexto = new GroupBox();
            lblDeposito = new Label();
            cboDeposito = new ComboBox();
            lblRol = new Label();
            lblFecha = new Label();
            dtpFechaTrabajo = new DateTimePicker();
            tabGestion = new TabControl();
            tabAsignadas = new TabPage();
            grpFiltros = new GroupBox();
            lblBuscarOrden = new Label();
            txtBuscarOrden = new TextBox();
            lblCliente = new Label();
            cboCliente = new ComboBox();
            lblOrigen = new Label();
            cboOrigen = new ComboBox();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            lblListaAsignadas = new Label();
            lvAsignadas = new ListView();
            lvAsignadasCol0 = new ColumnHeader();
            lvAsignadasCol1 = new ColumnHeader();
            lvAsignadasCol2 = new ColumnHeader();
            lvAsignadasCol3 = new ColumnHeader();
            lvAsignadasCol4 = new ColumnHeader();
            lvAsignadasCol5 = new ColumnHeader();
            lvAsignadasCol6 = new ColumnHeader();
            grpDetalle = new GroupBox();
            lblDetalleCliente = new Label();
            txtDetalleCliente = new TextBox();
            lblContrato = new Label();
            txtContrato = new TextBox();
            lblModalidad = new Label();
            txtModalidad = new TextBox();
            lblEstado = new Label();
            txtEstado = new TextBox();
            lvDisponibilidad = new ListView();
            lvDisponibilidadCol0 = new ColumnHeader();
            lvDisponibilidadCol1 = new ColumnHeader();
            lvDisponibilidadCol2 = new ColumnHeader();
            lvDisponibilidadCol3 = new ColumnHeader();
            lvDisponibilidadCol4 = new ColumnHeader();
            lvDisponibilidadCol5 = new ColumnHeader();
            lblStockRegla = new Label();
            lblValidacion = new Label();
            btnValidar = new Button();
            btnAceptar = new Button();
            btnRechazar = new Button();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            tabCortes = new TabPage();
            grpCorte = new GroupBox();
            lblFechaCorte = new Label();
            dtpFechaCorte = new DateTimePicker();
            chkSoloPendientes = new CheckBox();
            btnConsultarPendientes = new Button();
            lblPendientes = new Label();
            lvPendientes = new ListView();
            lvPendientesCol0 = new ColumnHeader();
            lvPendientesCol1 = new ColumnHeader();
            lvPendientesCol2 = new ColumnHeader();
            lvPendientesCol3 = new ColumnHeader();
            lvPendientesCol4 = new ColumnHeader();
            lvPendientesCol5 = new ColumnHeader();
            btnPrepararCorte = new Button();
            grpPropuesta = new GroupBox();
            lvPropuesta = new ListView();
            lvPropuestaCol0 = new ColumnHeader();
            lvPropuestaCol1 = new ColumnHeader();
            lvPropuestaCol2 = new ColumnHeader();
            lvPropuestaCol3 = new ColumnHeader();
            lvPropuestaCol4 = new ColumnHeader();
            lvPropuestaCol5 = new ColumnHeader();
            lvPropuestaCol6 = new ColumnHeader();
            btnConfirmarCorte = new Button();
            btnVerOrdenes = new Button();
            btnDescartar = new Button();
            groupBox1 = new GroupBox();
            rdoPrimerCorte = new RadioButton();
            rdoSegundoCorte = new RadioButton();
            pnlEncabezado.SuspendLayout();
            grpContexto.SuspendLayout();
            tabGestion.SuspendLayout();
            tabAsignadas.SuspendLayout();
            grpFiltros.SuspendLayout();
            grpDetalle.SuspendLayout();
            tabCortes.SuspendLayout();
            grpCorte.SuspendLayout();
            grpPropuesta.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlEncabezado.BackColor = Color.FromArgb(35, 80, 124);
            pnlEncabezado.Controls.Add(lblTitulo);
            pnlEncabezado.Controls.Add(lblEmpresa);
            pnlEncabezado.Location = new Point(0, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(1056, 76);
            pnlEncabezado.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(19, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(712, 34);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Gestión de Pedidos y Selección";
            // 
            // lblEmpresa
            // 
            lblEmpresa.ForeColor = Color.White;
            lblEmpresa.Location = new Point(21, 48);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(840, 22);
            lblEmpresa.TabIndex = 3;
            lblEmpresa.Text = "PAMPAZON  |  Encargado de Preparación";
            // 
            // grpContexto
            // 
            grpContexto.Controls.Add(lblDeposito);
            grpContexto.Controls.Add(cboDeposito);
            grpContexto.Controls.Add(lblRol);
            grpContexto.Controls.Add(lblFecha);
            grpContexto.Controls.Add(dtpFechaTrabajo);
            grpContexto.Location = new Point(13, 84);
            grpContexto.Name = "grpContexto";
            grpContexto.Size = new Size(1030, 72);
            grpContexto.TabIndex = 4;
            grpContexto.TabStop = false;
            grpContexto.Text = "Contexto de trabajo";
            // 
            // lblDeposito
            // 
            lblDeposito.Location = new Point(13, 30);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(54, 24);
            lblDeposito.TabIndex = 5;
            lblDeposito.Text = "Depósito";
            // 
            // cboDeposito
            // 
            cboDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDeposito.Enabled = false;
            cboDeposito.Items.AddRange(new object[] { "GBA" });
            cboDeposito.Location = new Point(72, 26);
            cboDeposito.Name = "cboDeposito";
            cboDeposito.Size = new Size(298, 23);
            cboDeposito.TabIndex = 6;
            // 
            // lblRol
            // 
            lblRol.Location = new Point(384, 29);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(168, 24);
            lblRol.TabIndex = 7;
            lblRol.Text = "Rol: Encargado de Preparación";
            // 
            // lblFecha
            // 
            lblFecha.Location = new Point(560, 30);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(58, 24);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha";
            // 
            // dtpFechaTrabajo
            // 
            dtpFechaTrabajo.Enabled = false;
            dtpFechaTrabajo.Format = DateTimePickerFormat.Short;
            dtpFechaTrabajo.Location = new Point(623, 26);
            dtpFechaTrabajo.Name = "dtpFechaTrabajo";
            dtpFechaTrabajo.Size = new Size(390, 23);
            dtpFechaTrabajo.TabIndex = 9;
            dtpFechaTrabajo.Value = new DateTime(2026, 10, 12, 0, 0, 0, 0);
            // 
            // tabGestion
            // 
            tabGestion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabGestion.Controls.Add(tabAsignadas);
            tabGestion.Controls.Add(tabCortes);
            tabGestion.Location = new Point(13, 170);
            tabGestion.Name = "tabGestion";
            tabGestion.SelectedIndex = 0;
            tabGestion.Size = new Size(1030, 684);
            tabGestion.TabIndex = 11;
            // 
            // tabAsignadas
            // 
            tabAsignadas.Controls.Add(grpFiltros);
            tabAsignadas.Controls.Add(lblListaAsignadas);
            tabAsignadas.Controls.Add(lvAsignadas);
            tabAsignadas.Controls.Add(grpDetalle);
            tabAsignadas.Controls.Add(btnValidar);
            tabAsignadas.Controls.Add(btnAceptar);
            tabAsignadas.Controls.Add(btnRechazar);
            tabAsignadas.Controls.Add(lblMotivo);
            tabAsignadas.Controls.Add(txtMotivo);
            tabAsignadas.Location = new Point(3, 24);
            tabAsignadas.Name = "tabAsignadas";
            tabAsignadas.Size = new Size(1024, 656);
            tabAsignadas.TabIndex = 12;
            tabAsignadas.Text = "Órdenes asignadas";
            tabAsignadas.UseVisualStyleBackColor = true;
            // 
            // grpFiltros
            // 
            grpFiltros.Controls.Add(lblBuscarOrden);
            grpFiltros.Controls.Add(txtBuscarOrden);
            grpFiltros.Controls.Add(lblCliente);
            grpFiltros.Controls.Add(cboCliente);
            grpFiltros.Controls.Add(lblOrigen);
            grpFiltros.Controls.Add(cboOrigen);
            grpFiltros.Controls.Add(lblDesde);
            grpFiltros.Controls.Add(dtpDesde);
            grpFiltros.Controls.Add(btnBuscar);
            grpFiltros.Controls.Add(btnLimpiar);
            grpFiltros.Location = new Point(10, 10);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(1000, 80);
            grpFiltros.TabIndex = 14;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Buscar órdenes";
            // 
            // lblBuscarOrden
            // 
            lblBuscarOrden.Location = new Point(11, 22);
            lblBuscarOrden.Name = "lblBuscarOrden";
            lblBuscarOrden.Size = new Size(108, 24);
            lblBuscarOrden.TabIndex = 15;
            lblBuscarOrden.Text = "N.º de orden";
            // 
            // txtBuscarOrden
            // 
            txtBuscarOrden.Location = new Point(11, 45);
            txtBuscarOrden.Name = "txtBuscarOrden";
            txtBuscarOrden.Size = new Size(120, 23);
            txtBuscarOrden.TabIndex = 16;
            // 
            // lblCliente
            // 
            lblCliente.Location = new Point(146, 22);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(184, 24);
            lblCliente.TabIndex = 17;
            lblCliente.Text = "Cliente";
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.Items.AddRange(new object[] { "Todos los clientes", "Cliente Demo A", "Cliente Demo B" });
            cboCliente.Location = new Point(146, 45);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(212, 23);
            cboCliente.TabIndex = 18;
            // 
            // lblOrigen
            // 
            lblOrigen.Location = new Point(371, 22);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(88, 24);
            lblOrigen.TabIndex = 19;
            lblOrigen.Text = "Origen";
            // 
            // cboOrigen
            // 
            cboOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrigen.Items.AddRange(new object[] { "Todos", "Cliente", "Traslado interno" });
            cboOrigen.Location = new Point(371, 45);
            cboOrigen.Name = "cboOrigen";
            cboOrigen.Size = new Size(140, 23);
            cboOrigen.TabIndex = 20;
            // 
            // lblDesde
            // 
            lblDesde.Location = new Point(526, 22);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(111, 24);
            lblDesde.TabIndex = 21;
            lblDesde.Text = "Fecha de asignación";
            // 
            // dtpDesde
            // 
            dtpDesde.Checked = false;
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(526, 45);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.ShowCheckBox = true;
            dtpDesde.Size = new Size(116, 23);
            dtpDesde.TabIndex = 22;
            dtpDesde.Value = new DateTime(2026, 10, 12, 0, 0, 0, 0);
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(35, 80, 124);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(662, 38);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(173, 34);
            btnBuscar.TabIndex = 23;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(840, 38);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(160, 34);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblListaAsignadas
            // 
            lblListaAsignadas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblListaAsignadas.Location = new Point(11, 102);
            lblListaAsignadas.Name = "lblListaAsignadas";
            lblListaAsignadas.Size = new Size(760, 24);
            lblListaAsignadas.TabIndex = 25;
            lblListaAsignadas.Text = "Órdenes asignadas al depósito";
            // 
            // lvAsignadas
            // 
            lvAsignadas.Columns.AddRange(new ColumnHeader[] { lvAsignadasCol0, lvAsignadasCol1, lvAsignadasCol2, lvAsignadasCol3, lvAsignadasCol4, lvAsignadasCol5, lvAsignadasCol6 });
            lvAsignadas.FullRowSelect = true;
            lvAsignadas.GridLines = true;
            lvAsignadas.Items.AddRange(new ListViewItem[] { listViewItem14, listViewItem15, listViewItem16 });
            lvAsignadas.Location = new Point(11, 132);
            lvAsignadas.MultiSelect = false;
            lvAsignadas.Name = "lvAsignadas";
            lvAsignadas.Size = new Size(998, 137);
            lvAsignadas.TabIndex = 26;
            lvAsignadas.UseCompatibleStateImageBehavior = false;
            lvAsignadas.View = View.Details;
            // 
            // lvAsignadasCol0
            // 
            lvAsignadasCol0.Text = "N.º de orden";
            lvAsignadasCol0.Width = 92;
            // 
            // lvAsignadasCol1
            // 
            lvAsignadasCol1.Text = "Asignación";
            lvAsignadasCol1.Width = 92;
            // 
            // lvAsignadasCol2
            // 
            lvAsignadasCol2.Text = "Cliente";
            lvAsignadasCol2.Width = 180;
            // 
            // lvAsignadasCol3
            // 
            lvAsignadasCol3.Text = "Origen";
            lvAsignadasCol3.Width = 132;
            // 
            // lvAsignadasCol4
            // 
            lvAsignadasCol4.Text = "Modalidad";
            lvAsignadasCol4.Width = 120;
            // 
            // lvAsignadasCol5
            // 
            lvAsignadasCol5.Text = "Productos";
            lvAsignadasCol5.Width = 80;
            // 
            // lvAsignadasCol6
            // 
            lvAsignadasCol6.Text = "Estado";
            lvAsignadasCol6.Width = 124;
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(lblDetalleCliente);
            grpDetalle.Controls.Add(txtDetalleCliente);
            grpDetalle.Controls.Add(lblContrato);
            grpDetalle.Controls.Add(txtContrato);
            grpDetalle.Controls.Add(lblModalidad);
            grpDetalle.Controls.Add(txtModalidad);
            grpDetalle.Controls.Add(lblEstado);
            grpDetalle.Controls.Add(txtEstado);
            grpDetalle.Controls.Add(lvDisponibilidad);
            grpDetalle.Controls.Add(lblStockRegla);
            grpDetalle.Controls.Add(lblValidacion);
            grpDetalle.Location = new Point(10, 282);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(1000, 253);
            grpDetalle.TabIndex = 34;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle de la orden OP-000184";
            // 
            // lblDetalleCliente
            // 
            lblDetalleCliente.Location = new Point(11, 27);
            lblDetalleCliente.Name = "lblDetalleCliente";
            lblDetalleCliente.Size = new Size(64, 24);
            lblDetalleCliente.TabIndex = 35;
            lblDetalleCliente.Text = "Cliente";
            // 
            // txtDetalleCliente
            // 
            txtDetalleCliente.Location = new Point(76, 23);
            txtDetalleCliente.Name = "txtDetalleCliente";
            txtDetalleCliente.ReadOnly = true;
            txtDetalleCliente.Size = new Size(176, 23);
            txtDetalleCliente.TabIndex = 36;
            txtDetalleCliente.Text = "Cliente Demo A";
            // 
            // lblContrato
            // 
            lblContrato.Location = new Point(268, 27);
            lblContrato.Name = "lblContrato";
            lblContrato.Size = new Size(62, 24);
            lblContrato.TabIndex = 37;
            lblContrato.Text = "Contrato";
            // 
            // txtContrato
            // 
            txtContrato.Location = new Point(332, 23);
            txtContrato.Name = "txtContrato";
            txtContrato.ReadOnly = true;
            txtContrato.Size = new Size(120, 23);
            txtContrato.TabIndex = 38;
            txtContrato.Text = "CT-000028";
            // 
            // lblModalidad
            // 
            lblModalidad.Location = new Point(468, 27);
            lblModalidad.Name = "lblModalidad";
            lblModalidad.Size = new Size(72, 24);
            lblModalidad.TabIndex = 39;
            lblModalidad.Text = "Modalidad";
            // 
            // txtModalidad
            // 
            txtModalidad.Location = new Point(544, 23);
            txtModalidad.Name = "txtModalidad";
            txtModalidad.ReadOnly = true;
            txtModalidad.Size = new Size(120, 23);
            txtModalidad.TabIndex = 40;
            txtModalidad.Text = "Fulfillment";
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(680, 27);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(52, 24);
            lblEstado.TabIndex = 41;
            lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(736, 23);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(251, 23);
            txtEstado.TabIndex = 42;
            txtEstado.Text = "ASIGNADA";
            txtEstado.TextChanged += txtEstado_TextChanged;
            // 
            // lvDisponibilidad
            // 
            lvDisponibilidad.Columns.AddRange(new ColumnHeader[] { lvDisponibilidadCol0, lvDisponibilidadCol1, lvDisponibilidadCol2, lvDisponibilidadCol3, lvDisponibilidadCol4, lvDisponibilidadCol5 });
            lvDisponibilidad.FullRowSelect = true;
            lvDisponibilidad.GridLines = true;
            lvDisponibilidad.Items.AddRange(new ListViewItem[] { listViewItem17, listViewItem18 });
            lvDisponibilidad.Location = new Point(11, 67);
            lvDisponibilidad.MultiSelect = false;
            lvDisponibilidad.Name = "lvDisponibilidad";
            lvDisponibilidad.Size = new Size(976, 118);
            lvDisponibilidad.TabIndex = 43;
            lvDisponibilidad.UseCompatibleStateImageBehavior = false;
            lvDisponibilidad.View = View.Details;
            // 
            // lvDisponibilidadCol0
            // 
            lvDisponibilidadCol0.Text = "SKU";
            lvDisponibilidadCol0.Width = 96;
            // 
            // lvDisponibilidadCol1
            // 
            lvDisponibilidadCol1.Text = "Producto";
            lvDisponibilidadCol1.Width = 244;
            // 
            // lvDisponibilidadCol2
            // 
            lvDisponibilidadCol2.Text = "Unidad";
            lvDisponibilidadCol2.Width = 88;
            // 
            // lvDisponibilidadCol3
            // 
            lvDisponibilidadCol3.Text = "Solicitado";
            lvDisponibilidadCol3.Width = 96;
            // 
            // lvDisponibilidadCol4
            // 
            lvDisponibilidadCol4.Text = "Disponible";
            lvDisponibilidadCol4.Width = 96;
            // 
            // lvDisponibilidadCol5
            // 
            lvDisponibilidadCol5.Text = "Validación";
            lvDisponibilidadCol5.Width = 160;
            // 
            // lblStockRegla
            // 
            lblStockRegla.Location = new Point(11, 192);
            lblStockRegla.Name = "lblStockRegla";
            lblStockRegla.Size = new Size(952, 24);
            lblStockRegla.TabIndex = 50;
            lblStockRegla.Text = "Disponible: mercadería aceptada y no comprometida del cliente en este depósito.";
            // 
            // lblValidacion
            // 
            lblValidacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblValidacion.Location = new Point(11, 220);
            lblValidacion.Name = "lblValidacion";
            lblValidacion.Size = new Size(952, 24);
            lblValidacion.TabIndex = 51;
            lblValidacion.Text = "Validación pendiente. Al aceptar se compromete el stock, sin descontar las existencias físicas.";
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.FromArgb(35, 80, 124);
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.ForeColor = Color.White;
            btnValidar.Location = new Point(13, 541);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(334, 34);
            btnValidar.TabIndex = 52;
            btnValidar.Text = "Validar disponibilidad";
            btnValidar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Location = new Point(359, 541);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(356, 34);
            btnAceptar.TabIndex = 53;
            btnAceptar.Text = "Aceptar y comprometer";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnRechazar
            // 
            btnRechazar.Enabled = false;
            btnRechazar.Location = new Point(720, 541);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(290, 34);
            btnRechazar.TabIndex = 54;
            btnRechazar.Text = "Rechazar por falta de stock";
            btnRechazar.UseVisualStyleBackColor = true;
            // 
            // lblMotivo
            // 
            lblMotivo.Location = new Point(13, 593);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(120, 24);
            lblMotivo.TabIndex = 55;
            lblMotivo.Text = "Motivo del rechazo";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(139, 590);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.ReadOnly = true;
            txtMotivo.Size = new Size(870, 23);
            txtMotivo.TabIndex = 56;
            txtMotivo.Text = "Se completará con los productos y cantidades faltantes.";
            // 
            // tabCortes
            // 
            tabCortes.Controls.Add(grpCorte);
            tabCortes.Controls.Add(lblPendientes);
            tabCortes.Controls.Add(lvPendientes);
            tabCortes.Controls.Add(btnPrepararCorte);
            tabCortes.Controls.Add(grpPropuesta);
            tabCortes.Controls.Add(btnConfirmarCorte);
            tabCortes.Controls.Add(btnVerOrdenes);
            tabCortes.Controls.Add(btnDescartar);
            tabCortes.Location = new Point(3, 24);
            tabCortes.Name = "tabCortes";
            tabCortes.Size = new Size(1024, 656);
            tabCortes.TabIndex = 13;
            tabCortes.Text = "Cortes de selección";
            tabCortes.UseVisualStyleBackColor = true;
            // 
            // grpCorte
            // 
            grpCorte.Controls.Add(groupBox1);
            grpCorte.Controls.Add(lblFechaCorte);
            grpCorte.Controls.Add(dtpFechaCorte);
            grpCorte.Controls.Add(chkSoloPendientes);
            grpCorte.Controls.Add(btnConsultarPendientes);
            grpCorte.Location = new Point(10, 10);
            grpCorte.Name = "grpCorte";
            grpCorte.Size = new Size(1000, 85);
            grpCorte.TabIndex = 57;
            grpCorte.TabStop = false;
            grpCorte.Text = "Datos del corte";
            // 
            // lblFechaCorte
            // 
            lblFechaCorte.Location = new Point(11, 23);
            lblFechaCorte.Name = "lblFechaCorte";
            lblFechaCorte.Size = new Size(112, 24);
            lblFechaCorte.TabIndex = 58;
            lblFechaCorte.Text = "Fecha del corte";
            // 
            // dtpFechaCorte
            // 
            dtpFechaCorte.Format = DateTimePickerFormat.Short;
            dtpFechaCorte.Location = new Point(11, 46);
            dtpFechaCorte.Name = "dtpFechaCorte";
            dtpFechaCorte.Size = new Size(259, 23);
            dtpFechaCorte.TabIndex = 59;
            dtpFechaCorte.Value = new DateTime(2026, 10, 12, 0, 0, 0, 0);
            // 
            // chkSoloPendientes
            // 
            chkSoloPendientes.Checked = true;
            chkSoloPendientes.CheckState = CheckState.Checked;
            chkSoloPendientes.Enabled = false;
            chkSoloPendientes.Location = new Point(634, 46);
            chkSoloPendientes.Name = "chkSoloPendientes";
            chkSoloPendientes.Size = new Size(150, 25);
            chkSoloPendientes.TabIndex = 63;
            chkSoloPendientes.Text = "Solo órdenes PENDIENTES";
            // 
            // btnConsultarPendientes
            // 
            btnConsultarPendientes.BackColor = Color.FromArgb(35, 80, 124);
            btnConsultarPendientes.FlatStyle = FlatStyle.Flat;
            btnConsultarPendientes.ForeColor = Color.White;
            btnConsultarPendientes.Location = new Point(812, 36);
            btnConsultarPendientes.Name = "btnConsultarPendientes";
            btnConsultarPendientes.Size = new Size(173, 34);
            btnConsultarPendientes.TabIndex = 64;
            btnConsultarPendientes.Text = "Consultar pendientes";
            btnConsultarPendientes.UseVisualStyleBackColor = false;
            // 
            // lblPendientes
            // 
            lblPendientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPendientes.Location = new Point(11, 107);
            lblPendientes.Name = "lblPendientes";
            lblPendientes.Size = new Size(920, 24);
            lblPendientes.TabIndex = 65;
            lblPendientes.Text = "Órdenes pendientes · Marcar las que se incorporarán al corte";
            // 
            // lvPendientes
            // 
            lvPendientes.CheckBoxes = true;
            lvPendientes.Columns.AddRange(new ColumnHeader[] { lvPendientesCol0, lvPendientesCol1, lvPendientesCol2, lvPendientesCol3, lvPendientesCol4, lvPendientesCol5 });
            lvPendientes.FullRowSelect = true;
            lvPendientes.GridLines = true;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.StateImageIndex = 0;
            listViewItem13.StateImageIndex = 0;
            lvPendientes.Items.AddRange(new ListViewItem[] { listViewItem11, listViewItem12, listViewItem13 });
            lvPendientes.Location = new Point(11, 136);
            lvPendientes.MultiSelect = false;
            lvPendientes.Name = "lvPendientes";
            lvPendientes.Size = new Size(998, 142);
            lvPendientes.TabIndex = 66;
            lvPendientes.UseCompatibleStateImageBehavior = false;
            lvPendientes.View = View.Details;
            // 
            // lvPendientesCol0
            // 
            lvPendientesCol0.Text = "Incluir / Orden";
            lvPendientesCol0.Width = 128;
            // 
            // lvPendientesCol1
            // 
            lvPendientesCol1.Text = "Cliente";
            lvPendientesCol1.Width = 200;
            // 
            // lvPendientesCol2
            // 
            lvPendientesCol2.Text = "Origen";
            lvPendientesCol2.Width = 140;
            // 
            // lvPendientesCol3
            // 
            lvPendientesCol3.Text = "Modalidad";
            lvPendientesCol3.Width = 128;
            // 
            // lvPendientesCol4
            // 
            lvPendientesCol4.Text = "Productos";
            lvPendientesCol4.Width = 80;
            // 
            // lvPendientesCol5
            // 
            lvPendientesCol5.Text = "Estado";
            lvPendientesCol5.Width = 144;
            // 
            // btnPrepararCorte
            // 
            btnPrepararCorte.BackColor = Color.FromArgb(35, 80, 124);
            btnPrepararCorte.FlatStyle = FlatStyle.Flat;
            btnPrepararCorte.ForeColor = Color.White;
            btnPrepararCorte.Location = new Point(13, 298);
            btnPrepararCorte.Name = "btnPrepararCorte";
            btnPrepararCorte.Size = new Size(997, 34);
            btnPrepararCorte.TabIndex = 73;
            btnPrepararCorte.Text = "Preparar corte";
            btnPrepararCorte.UseVisualStyleBackColor = false;
            // 
            // grpPropuesta
            // 
            grpPropuesta.Controls.Add(lvPropuesta);
            grpPropuesta.Location = new Point(10, 338);
            grpPropuesta.Name = "grpPropuesta";
            grpPropuesta.Size = new Size(1000, 212);
            grpPropuesta.TabIndex = 75;
            grpPropuesta.TabStop = false;
            grpPropuesta.Text = "Vista previa de la selección";
            // 
            // lvPropuesta
            // 
            lvPropuesta.Columns.AddRange(new ColumnHeader[] { lvPropuestaCol0, lvPropuestaCol1, lvPropuestaCol2, lvPropuestaCol3, lvPropuestaCol4, lvPropuestaCol5, lvPropuestaCol6 });
            lvPropuesta.FullRowSelect = true;
            lvPropuesta.GridLines = true;
            lvPropuesta.Items.AddRange(new ListViewItem[] { listViewItem19, listViewItem20 });
            lvPropuesta.Location = new Point(11, 26);
            lvPropuesta.MultiSelect = false;
            lvPropuesta.Name = "lvPropuesta";
            lvPropuesta.Size = new Size(976, 180);
            lvPropuesta.TabIndex = 76;
            lvPropuesta.UseCompatibleStateImageBehavior = false;
            lvPropuesta.View = View.Details;
            // 
            // lvPropuestaCol0
            // 
            lvPropuestaCol0.Text = "Cliente";
            lvPropuestaCol0.Width = 144;
            // 
            // lvPropuestaCol1
            // 
            lvPropuestaCol1.Text = "SKU";
            lvPropuestaCol1.Width = 80;
            // 
            // lvPropuestaCol2
            // 
            lvPropuestaCol2.Text = "Producto";
            lvPropuestaCol2.Width = 176;
            // 
            // lvPropuestaCol3
            // 
            lvPropuestaCol3.Text = "Ubicación";
            lvPropuestaCol3.Width = 92;
            // 
            // lvPropuestaCol4
            // 
            lvPropuestaCol4.Text = "Cantidad";
            lvPropuestaCol4.Width = 80;
            // 
            // lvPropuestaCol5
            // 
            lvPropuestaCol5.Text = "Unidad";
            lvPropuestaCol5.Width = 80;
            // 
            // lvPropuestaCol6
            // 
            lvPropuestaCol6.Text = "Pedidos de origen";
            lvPropuestaCol6.Width = 200;
            // 
            // btnConfirmarCorte
            // 
            btnConfirmarCorte.BackColor = Color.FromArgb(35, 80, 124);
            btnConfirmarCorte.FlatStyle = FlatStyle.Flat;
            btnConfirmarCorte.ForeColor = Color.White;
            btnConfirmarCorte.Location = new Point(13, 573);
            btnConfirmarCorte.Name = "btnConfirmarCorte";
            btnConfirmarCorte.Size = new Size(334, 34);
            btnConfirmarCorte.TabIndex = 86;
            btnConfirmarCorte.Text = "Confirmar y generar selección";
            btnConfirmarCorte.UseVisualStyleBackColor = false;
            // 
            // btnVerOrdenes
            // 
            btnVerOrdenes.Enabled = false;
            btnVerOrdenes.Location = new Point(351, 573);
            btnVerOrdenes.Name = "btnVerOrdenes";
            btnVerOrdenes.Size = new Size(322, 34);
            btnVerOrdenes.TabIndex = 87;
            btnVerOrdenes.Text = "Ver órdenes generadas";
            btnVerOrdenes.UseVisualStyleBackColor = true;
            // 
            // btnDescartar
            // 
            btnDescartar.Location = new Point(678, 573);
            btnDescartar.Name = "btnDescartar";
            btnDescartar.Size = new Size(331, 34);
            btnDescartar.TabIndex = 88;
            btnDescartar.Text = "Descartar propuesta";
            btnDescartar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoPrimerCorte);
            groupBox1.Controls.Add(rdoSegundoCorte);
            groupBox1.Location = new Point(300, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 56);
            groupBox1.TabIndex = 89;
            groupBox1.TabStop = false;
            groupBox1.Text = "Corte Operativo";
            // 
            // rdoPrimerCorte
            // 
            rdoPrimerCorte.Checked = true;
            rdoPrimerCorte.Location = new Point(27, 22);
            rdoPrimerCorte.Name = "rdoPrimerCorte";
            rdoPrimerCorte.Size = new Size(110, 25);
            rdoPrimerCorte.TabIndex = 63;
            rdoPrimerCorte.TabStop = true;
            rdoPrimerCorte.Text = "Primer corte";
            // 
            // rdoSegundoCorte
            // 
            rdoSegundoCorte.Location = new Point(173, 22);
            rdoSegundoCorte.Name = "rdoSegundoCorte";
            rdoSegundoCorte.Size = new Size(125, 25);
            rdoSegundoCorte.TabIndex = 64;
            rdoSegundoCorte.Text = "Segundo corte";
            // 
            // GestionPedidosSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1067, 901);
            Controls.Add(pnlEncabezado);
            Controls.Add(grpContexto);
            Controls.Add(tabGestion);
            Font = new Font("Segoe UI", 9F);
            AutoScroll = true;
            AutoScrollMinSize = new Size(1067, 901);
            MinimumSize = new Size(640, 480);
            Name = "GestionPedidosSeleccionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pampazon - Gestión de Pedidos y Selección";
            pnlEncabezado.ResumeLayout(false);
            grpContexto.ResumeLayout(false);
            tabGestion.ResumeLayout(false);
            tabAsignadas.ResumeLayout(false);
            tabAsignadas.PerformLayout();
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            tabCortes.ResumeLayout(false);
            grpCorte.ResumeLayout(false);
            grpPropuesta.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.GroupBox grpContexto;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.ComboBox cboDeposito;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaTrabajo;
        private System.Windows.Forms.TabControl tabGestion;
        private System.Windows.Forms.TabPage tabAsignadas;
        private System.Windows.Forms.TabPage tabCortes;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblBuscarOrden;
        private System.Windows.Forms.TextBox txtBuscarOrden;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblListaAsignadas;
        private System.Windows.Forms.ListView lvAsignadas;
        private System.Windows.Forms.ColumnHeader lvAsignadasCol0;
        private System.Windows.Forms.ColumnHeader lvAsignadasCol1;
        private System.Windows.Forms.ColumnHeader lvAsignadasCol2;
        private System.Windows.Forms.ColumnHeader lvAsignadasCol3;
        private System.Windows.Forms.ColumnHeader lvAsignadasCol4;
        private System.Windows.Forms.ColumnHeader lvAsignadasCol5;
        private System.Windows.Forms.ColumnHeader lvAsignadasCol6;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.Label lblDetalleCliente;
        private System.Windows.Forms.TextBox txtDetalleCliente;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.TextBox txtContrato;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.ListView lvDisponibilidad;
        private System.Windows.Forms.ColumnHeader lvDisponibilidadCol0;
        private System.Windows.Forms.ColumnHeader lvDisponibilidadCol1;
        private System.Windows.Forms.ColumnHeader lvDisponibilidadCol2;
        private System.Windows.Forms.ColumnHeader lvDisponibilidadCol3;
        private System.Windows.Forms.ColumnHeader lvDisponibilidadCol4;
        private System.Windows.Forms.ColumnHeader lvDisponibilidadCol5;
        private System.Windows.Forms.Label lblStockRegla;
        private System.Windows.Forms.Label lblValidacion;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.GroupBox grpCorte;
        private System.Windows.Forms.Label lblFechaCorte;
        private System.Windows.Forms.DateTimePicker dtpFechaCorte;
        private System.Windows.Forms.CheckBox chkSoloPendientes;
        private System.Windows.Forms.Button btnConsultarPendientes;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.ListView lvPendientes;
        private System.Windows.Forms.ColumnHeader lvPendientesCol0;
        private System.Windows.Forms.ColumnHeader lvPendientesCol1;
        private System.Windows.Forms.ColumnHeader lvPendientesCol2;
        private System.Windows.Forms.ColumnHeader lvPendientesCol3;
        private System.Windows.Forms.ColumnHeader lvPendientesCol4;
        private System.Windows.Forms.ColumnHeader lvPendientesCol5;
        private System.Windows.Forms.Button btnPrepararCorte;
        private System.Windows.Forms.GroupBox grpPropuesta;
        private System.Windows.Forms.ListView lvPropuesta;
        private System.Windows.Forms.ColumnHeader lvPropuestaCol0;
        private System.Windows.Forms.ColumnHeader lvPropuestaCol1;
        private System.Windows.Forms.ColumnHeader lvPropuestaCol2;
        private System.Windows.Forms.ColumnHeader lvPropuestaCol3;
        private System.Windows.Forms.ColumnHeader lvPropuestaCol4;
        private System.Windows.Forms.ColumnHeader lvPropuestaCol5;
        private System.Windows.Forms.ColumnHeader lvPropuestaCol6;
        private System.Windows.Forms.Button btnConfirmarCorte;
        private System.Windows.Forms.Button btnVerOrdenes;
        private System.Windows.Forms.Button btnDescartar;
        private GroupBox groupBox1;
        private RadioButton rdoPrimerCorte;
        private RadioButton rdoSegundoCorte;
    }
}
