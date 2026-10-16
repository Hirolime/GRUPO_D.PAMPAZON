namespace GRUPO_D.PAMPAZON.Recepción_y_Despacho_de_Pedidos
{
    partial class RecepcionDespachoPedidosForm1
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
            ListViewItem item_lvPreparadas_0 = new ListViewItem(new string[] { "OE-000051", "OP-000181", "Cliente Demo A", "Cliente", "Destino demo A", "2", "PREPARADA" }, -1);
            ListViewItem item_lvPreparadas_1 = new ListViewItem(new string[] { "OE-000052", "TR-000026", "Cliente Demo A", "Traslado interno", "Destino demo B", "1", "PREPARADA" }, -1);
            ListViewItem item_lvControlRecepcion_0 = new ListViewItem(new string[] { "SKU-001", "Remera de algodón", "80", "", "" }, -1);
            ListViewItem item_lvEnDespacho_0 = new ListViewItem(new string[] { "OE-000051", "OP-000181", "Cliente Demo A", "Cliente", "Destino demo A", "2", "EN DESPACHO" }, -1);
            ListViewItem item_lvEnDespacho_1 = new ListViewItem(new string[] { "OE-000052", "TR-000026", "Cliente Demo A", "Traslado interno", "Destino demo B", "1", "EN DESPACHO" }, -1);
            lblTitulo = new Label();
            lblEmpresa = new Label();
            grpContexto = new GroupBox();
            lblDeposito = new Label();
            cboDeposito = new ComboBox();
            lblRol = new Label();
            lblFecha = new Label();
            dtpFechaTrabajo = new DateTimePicker();
            grpRecepcion = new GroupBox();
            lblBuscarEntrega = new Label();
            txtBuscarEntrega = new TextBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            lblListaPreparadas = new Label();
            lvPreparadas = new ListView();
            lvPreparadasCol0 = new ColumnHeader();
            lvPreparadasCol1 = new ColumnHeader();
            lvPreparadasCol2 = new ColumnHeader();
            lvPreparadasCol3 = new ColumnHeader();
            lvPreparadasCol4 = new ColumnHeader();
            lvPreparadasCol5 = new ColumnHeader();
            lvPreparadasCol6 = new ColumnHeader();
            lblControlBultos = new Label();
            lvControlRecepcion = new ListView();
            lvControlRecepcionCol0 = new ColumnHeader();
            lvControlRecepcionCol1 = new ColumnHeader();
            lvControlRecepcionCol2 = new ColumnHeader();
            lvControlRecepcionCol3 = new ColumnHeader();
            lvControlRecepcionCol4 = new ColumnHeader();
            lblCantidadRecibida = new Label();
            txtCantidadRecibida = new TextBox();
            btnRegistrarRecepcion = new Button();
            lblObsRecepcion = new Label();
            txtObsRecepcion = new TextBox();
            chkRecepcionCompleta = new CheckBox();
            btnConfirmarRecepcion = new Button();
            btnReportarIncidenteRecepcion = new Button();
            grpDespacho = new GroupBox();
            lblListaEnDespacho = new Label();
            lvEnDespacho = new ListView();
            lvEnDespachoCol0 = new ColumnHeader();
            lvEnDespachoCol1 = new ColumnHeader();
            lvEnDespachoCol2 = new ColumnHeader();
            lvEnDespachoCol3 = new ColumnHeader();
            lvEnDespachoCol4 = new ColumnHeader();
            lvEnDespachoCol5 = new ColumnHeader();
            lvEnDespachoCol6 = new ColumnHeader();
            lblTransportista = new Label();
            txtTransportista = new TextBox();
            lblFlete = new Label();
            txtFlete = new TextBox();
            lblFechaRetiro = new Label();
            dtpRetiro = new DateTimePicker();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            btnEmitirDocumento = new Button();
            chkConformidad = new CheckBox();
            lblAvisoDespacho = new Label();
            btnCerrarDespacho = new Button();
            btnReportarIncidenteDespacho = new Button();
            grpContexto.SuspendLayout();
            grpRecepcion.SuspendLayout();
            grpDespacho.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Text = "Recepción y Despacho de Pedidos";
            lblTitulo.BackColor = Color.FromArgb(35, 80, 124);
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Padding = new Padding(24, 0, 0, 0);
            lblTitulo.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1056, 50);
            lblTitulo.TabIndex = 0;
            // 
            // lblEmpresa
            // 
            lblEmpresa.Text = "PAMPAZON  |  Operario de Despacho";
            lblEmpresa.BackColor = Color.FromArgb(35, 80, 124);
            lblEmpresa.TextAlign = ContentAlignment.MiddleLeft;
            lblEmpresa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmpresa.Padding = new Padding(26, 0, 0, 0);
            lblEmpresa.ForeColor = Color.White;
            lblEmpresa.Location = new Point(0, 50);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(1056, 26);
            lblEmpresa.TabIndex = 1;
            // 
            // grpContexto
            // 
            grpContexto.Controls.Add(lblDeposito);
            grpContexto.Controls.Add(cboDeposito);
            grpContexto.Controls.Add(lblRol);
            grpContexto.Controls.Add(lblFecha);
            grpContexto.Controls.Add(dtpFechaTrabajo);
            grpContexto.TabStop = false;
            grpContexto.Text = "Contexto de trabajo";
            grpContexto.Location = new Point(13, 84);
            grpContexto.Name = "grpContexto";
            grpContexto.Size = new Size(1030, 72);
            grpContexto.TabIndex = 2;
            // 
            // lblDeposito
            // 
            lblDeposito.Text = "Depósito";
            lblDeposito.Location = new Point(13, 30);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(54, 24);
            lblDeposito.TabIndex = 3;
            // 
            // cboDeposito
            // 
            cboDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDeposito.Enabled = false;
            cboDeposito.Items.AddRange(new object[] { "GBA" });
            cboDeposito.SelectedIndex = 0;
            cboDeposito.Location = new Point(72, 26);
            cboDeposito.Name = "cboDeposito";
            cboDeposito.Size = new Size(298, 23);
            cboDeposito.TabIndex = 4;
            // 
            // lblRol
            // 
            lblRol.Text = "Rol: Operario de Despacho";
            lblRol.Location = new Point(384, 29);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(208, 24);
            lblRol.TabIndex = 5;
            // 
            // lblFecha
            // 
            lblFecha.Text = "Fecha";
            lblFecha.Location = new Point(624, 30);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(58, 24);
            lblFecha.TabIndex = 6;
            // 
            // dtpFechaTrabajo
            // 
            dtpFechaTrabajo.Enabled = false;
            dtpFechaTrabajo.Format = DateTimePickerFormat.Short;
            dtpFechaTrabajo.Value = new DateTime(2026, 10, 12, 0, 0, 0, 0);
            dtpFechaTrabajo.Location = new Point(685, 26);
            dtpFechaTrabajo.Name = "dtpFechaTrabajo";
            dtpFechaTrabajo.Size = new Size(328, 23);
            dtpFechaTrabajo.TabIndex = 7;
            // 
            // grpRecepcion
            // 
            grpRecepcion.Controls.Add(lblBuscarEntrega);
            grpRecepcion.Controls.Add(txtBuscarEntrega);
            grpRecepcion.Controls.Add(btnBuscar);
            grpRecepcion.Controls.Add(btnLimpiar);
            grpRecepcion.Controls.Add(lblListaPreparadas);
            grpRecepcion.Controls.Add(lvPreparadas);
            grpRecepcion.Controls.Add(lblControlBultos);
            grpRecepcion.Controls.Add(lvControlRecepcion);
            grpRecepcion.Controls.Add(lblCantidadRecibida);
            grpRecepcion.Controls.Add(txtCantidadRecibida);
            grpRecepcion.Controls.Add(btnRegistrarRecepcion);
            grpRecepcion.Controls.Add(lblObsRecepcion);
            grpRecepcion.Controls.Add(txtObsRecepcion);
            grpRecepcion.Controls.Add(chkRecepcionCompleta);
            grpRecepcion.Controls.Add(btnConfirmarRecepcion);
            grpRecepcion.Controls.Add(btnReportarIncidenteRecepcion);
            grpRecepcion.TabStop = false;
            grpRecepcion.Text = "Recepción de pedidos preparados";
            grpRecepcion.Location = new Point(13, 170);
            grpRecepcion.Name = "grpRecepcion";
            grpRecepcion.Size = new Size(1030, 570);
            grpRecepcion.TabIndex = 8;
            // 
            // lblBuscarEntrega
            // 
            lblBuscarEntrega.Text = "N.º de orden de entrega";
            lblBuscarEntrega.Location = new Point(11, 26);
            lblBuscarEntrega.Name = "lblBuscarEntrega";
            lblBuscarEntrega.Size = new Size(160, 22);
            lblBuscarEntrega.TabIndex = 9;
            // 
            // txtBuscarEntrega
            // 
            txtBuscarEntrega.MaxLength = 30;
            txtBuscarEntrega.Location = new Point(11, 48);
            txtBuscarEntrega.Name = "txtBuscarEntrega";
            txtBuscarEntrega.Size = new Size(160, 23);
            txtBuscarEntrega.TabIndex = 10;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(35, 80, 124);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Location = new Point(184, 42);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(128, 34);
            btnBuscar.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Location = new Point(320, 42);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(128, 34);
            btnLimpiar.TabIndex = 12;
            // 
            // lblListaPreparadas
            // 
            lblListaPreparadas.Text = "Órdenes de entrega de pedidos preparados";
            lblListaPreparadas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblListaPreparadas.Location = new Point(11, 90);
            lblListaPreparadas.Name = "lblListaPreparadas";
            lblListaPreparadas.Size = new Size(560, 22);
            lblListaPreparadas.TabIndex = 13;
            // 
            // lvPreparadas
            // 
            lvPreparadas.Columns.AddRange(new ColumnHeader[] { lvPreparadasCol0, lvPreparadasCol1, lvPreparadasCol2, lvPreparadasCol3, lvPreparadasCol4, lvPreparadasCol5, lvPreparadasCol6 });
            lvPreparadas.FullRowSelect = true;
            lvPreparadas.GridLines = true;
            lvPreparadas.Items.AddRange(new ListViewItem[] { item_lvPreparadas_0, item_lvPreparadas_1 });
            lvPreparadas.Location = new Point(11, 114);
            lvPreparadas.Name = "lvPreparadas";
            lvPreparadas.Size = new Size(1006, 110);
            lvPreparadas.TabIndex = 14;
            lvPreparadas.UseCompatibleStateImageBehavior = false;
            lvPreparadas.View = View.Details;
            // 
            // lvPreparadasCol0
            // 
            lvPreparadasCol0.Text = "N.º de orden de entrega";
            lvPreparadasCol0.Width = 128;
            // 
            // lvPreparadasCol1
            // 
            lvPreparadasCol1.Text = "Pedido";
            lvPreparadasCol1.Width = 88;
            // 
            // lvPreparadasCol2
            // 
            lvPreparadasCol2.Text = "Cliente";
            lvPreparadasCol2.Width = 176;
            // 
            // lvPreparadasCol3
            // 
            lvPreparadasCol3.Text = "Origen";
            lvPreparadasCol3.Width = 120;
            // 
            // lvPreparadasCol4
            // 
            lvPreparadasCol4.Text = "Destino";
            lvPreparadasCol4.Width = 200;
            // 
            // lvPreparadasCol5
            // 
            lvPreparadasCol5.Text = "Bultos";
            lvPreparadasCol5.Width = 72;
            // 
            // lvPreparadasCol6
            // 
            lvPreparadasCol6.Text = "Estado";
            lvPreparadasCol6.Width = 112;
            // 
            // lblControlBultos
            // 
            lblControlBultos.Text = "Control de bultos recibidos";
            lblControlBultos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblControlBultos.Location = new Point(11, 234);
            lblControlBultos.Name = "lblControlBultos";
            lblControlBultos.Size = new Size(560, 22);
            lblControlBultos.TabIndex = 15;
            // 
            // lvControlRecepcion
            // 
            lvControlRecepcion.Columns.AddRange(new ColumnHeader[] { lvControlRecepcionCol0, lvControlRecepcionCol1, lvControlRecepcionCol2, lvControlRecepcionCol3, lvControlRecepcionCol4 });
            lvControlRecepcion.FullRowSelect = true;
            lvControlRecepcion.GridLines = true;
            lvControlRecepcion.Items.AddRange(new ListViewItem[] { item_lvControlRecepcion_0 });
            lvControlRecepcion.Location = new Point(11, 258);
            lvControlRecepcion.Name = "lvControlRecepcion";
            lvControlRecepcion.Size = new Size(1006, 100);
            lvControlRecepcion.TabIndex = 16;
            lvControlRecepcion.UseCompatibleStateImageBehavior = false;
            lvControlRecepcion.View = View.Details;
            // 
            // lvControlRecepcionCol0
            // 
            lvControlRecepcionCol0.Text = "SKU";
            lvControlRecepcionCol0.Width = 88;
            // 
            // lvControlRecepcionCol1
            // 
            lvControlRecepcionCol1.Text = "Producto";
            lvControlRecepcionCol1.Width = 240;
            // 
            // lvControlRecepcionCol2
            // 
            lvControlRecepcionCol2.Text = "Cantidad según la orden";
            lvControlRecepcionCol2.Width = 160;
            // 
            // lvControlRecepcionCol3
            // 
            lvControlRecepcionCol3.Text = "Cantidad recibida";
            lvControlRecepcionCol3.Width = 136;
            // 
            // lvControlRecepcionCol4
            // 
            lvControlRecepcionCol4.Text = "Diferencia";
            lvControlRecepcionCol4.Width = 112;
            // 
            // lblCantidadRecibida
            // 
            lblCantidadRecibida.Text = "Cantidad recibida";
            lblCantidadRecibida.Location = new Point(11, 368);
            lblCantidadRecibida.Name = "lblCantidadRecibida";
            lblCantidadRecibida.Size = new Size(144, 20);
            lblCantidadRecibida.TabIndex = 17;
            // 
            // txtCantidadRecibida
            // 
            txtCantidadRecibida.Location = new Point(11, 390);
            txtCantidadRecibida.Name = "txtCantidadRecibida";
            txtCantidadRecibida.Size = new Size(112, 23);
            txtCantidadRecibida.TabIndex = 18;
            // 
            // btnRegistrarRecepcion
            // 
            btnRegistrarRecepcion.BackColor = Color.FromArgb(35, 80, 124);
            btnRegistrarRecepcion.FlatStyle = FlatStyle.Flat;
            btnRegistrarRecepcion.ForeColor = Color.White;
            btnRegistrarRecepcion.Text = "Registrar cantidad recibida";
            btnRegistrarRecepcion.UseVisualStyleBackColor = false;
            btnRegistrarRecepcion.Location = new Point(160, 384);
            btnRegistrarRecepcion.Name = "btnRegistrarRecepcion";
            btnRegistrarRecepcion.Size = new Size(208, 34);
            btnRegistrarRecepcion.TabIndex = 19;
            // 
            // lblObsRecepcion
            // 
            lblObsRecepcion.Text = "Observación de recepción (hasta 200 caracteres)";
            lblObsRecepcion.Location = new Point(11, 428);
            lblObsRecepcion.Name = "lblObsRecepcion";
            lblObsRecepcion.Size = new Size(320, 20);
            lblObsRecepcion.TabIndex = 20;
            // 
            // txtObsRecepcion
            // 
            txtObsRecepcion.Multiline = true;
            txtObsRecepcion.MaxLength = 200;
            txtObsRecepcion.Location = new Point(11, 450);
            txtObsRecepcion.Name = "txtObsRecepcion";
            txtObsRecepcion.Size = new Size(560, 56);
            txtObsRecepcion.TabIndex = 21;
            // 
            // chkRecepcionCompleta
            // 
            chkRecepcionCompleta.Text = "Los preparados se recibieron completos y conformes";
            chkRecepcionCompleta.UseVisualStyleBackColor = true;
            chkRecepcionCompleta.Location = new Point(592, 452);
            chkRecepcionCompleta.Name = "chkRecepcionCompleta";
            chkRecepcionCompleta.Size = new Size(400, 24);
            chkRecepcionCompleta.TabIndex = 22;
            // 
            // btnConfirmarRecepcion
            // 
            btnConfirmarRecepcion.BackColor = Color.FromArgb(35, 80, 124);
            btnConfirmarRecepcion.FlatStyle = FlatStyle.Flat;
            btnConfirmarRecepcion.ForeColor = Color.White;
            btnConfirmarRecepcion.Text = "Confirmar recepción";
            btnConfirmarRecepcion.UseVisualStyleBackColor = false;
            btnConfirmarRecepcion.Location = new Point(11, 516);
            btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            btnConfirmarRecepcion.Size = new Size(334, 34);
            btnConfirmarRecepcion.TabIndex = 23;
            // 
            // btnReportarIncidenteRecepcion
            // 
            btnReportarIncidenteRecepcion.Text = "Reportar incidente";
            btnReportarIncidenteRecepcion.UseVisualStyleBackColor = true;
            btnReportarIncidenteRecepcion.Location = new Point(352, 516);
            btnReportarIncidenteRecepcion.Name = "btnReportarIncidenteRecepcion";
            btnReportarIncidenteRecepcion.Size = new Size(240, 34);
            btnReportarIncidenteRecepcion.TabIndex = 24;
            // 
            // grpDespacho
            // 
            grpDespacho.Controls.Add(lblListaEnDespacho);
            grpDespacho.Controls.Add(lvEnDespacho);
            grpDespacho.Controls.Add(lblTransportista);
            grpDespacho.Controls.Add(txtTransportista);
            grpDespacho.Controls.Add(lblFlete);
            grpDespacho.Controls.Add(txtFlete);
            grpDespacho.Controls.Add(lblFechaRetiro);
            grpDespacho.Controls.Add(dtpRetiro);
            grpDespacho.Controls.Add(lblDocumento);
            grpDespacho.Controls.Add(txtDocumento);
            grpDespacho.Controls.Add(btnEmitirDocumento);
            grpDespacho.Controls.Add(chkConformidad);
            grpDespacho.Controls.Add(lblAvisoDespacho);
            grpDespacho.Controls.Add(btnCerrarDespacho);
            grpDespacho.Controls.Add(btnReportarIncidenteDespacho);
            grpDespacho.TabStop = false;
            grpDespacho.Text = "Retiro y cierre del despacho";
            grpDespacho.Location = new Point(13, 752);
            grpDespacho.Name = "grpDespacho";
            grpDespacho.Size = new Size(1030, 440);
            grpDespacho.TabIndex = 25;
            // 
            // lblListaEnDespacho
            // 
            lblListaEnDespacho.Text = "Órdenes de entrega disponibles para el retiro";
            lblListaEnDespacho.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblListaEnDespacho.Location = new Point(11, 26);
            lblListaEnDespacho.Name = "lblListaEnDespacho";
            lblListaEnDespacho.Size = new Size(560, 22);
            lblListaEnDespacho.TabIndex = 26;
            // 
            // lvEnDespacho
            // 
            lvEnDespacho.Columns.AddRange(new ColumnHeader[] { lvEnDespachoCol0, lvEnDespachoCol1, lvEnDespachoCol2, lvEnDespachoCol3, lvEnDespachoCol4, lvEnDespachoCol5, lvEnDespachoCol6 });
            lvEnDespacho.FullRowSelect = true;
            lvEnDespacho.GridLines = true;
            lvEnDespacho.Items.AddRange(new ListViewItem[] { item_lvEnDespacho_0, item_lvEnDespacho_1 });
            lvEnDespacho.Location = new Point(11, 50);
            lvEnDespacho.Name = "lvEnDespacho";
            lvEnDespacho.Size = new Size(1006, 110);
            lvEnDespacho.TabIndex = 27;
            lvEnDespacho.UseCompatibleStateImageBehavior = false;
            lvEnDespacho.View = View.Details;
            // 
            // lvEnDespachoCol0
            // 
            lvEnDespachoCol0.Text = "N.º de orden de entrega";
            lvEnDespachoCol0.Width = 128;
            // 
            // lvEnDespachoCol1
            // 
            lvEnDespachoCol1.Text = "Pedido";
            lvEnDespachoCol1.Width = 88;
            // 
            // lvEnDespachoCol2
            // 
            lvEnDespachoCol2.Text = "Cliente";
            lvEnDespachoCol2.Width = 176;
            // 
            // lvEnDespachoCol3
            // 
            lvEnDespachoCol3.Text = "Origen";
            lvEnDespachoCol3.Width = 120;
            // 
            // lvEnDespachoCol4
            // 
            lvEnDespachoCol4.Text = "Destino";
            lvEnDespachoCol4.Width = 200;
            // 
            // lvEnDespachoCol5
            // 
            lvEnDespachoCol5.Text = "Bultos";
            lvEnDespachoCol5.Width = 72;
            // 
            // lvEnDespachoCol6
            // 
            lvEnDespachoCol6.Text = "Estado";
            lvEnDespachoCol6.Width = 112;
            // 
            // lblTransportista
            // 
            lblTransportista.Text = "Identificación del transportista";
            lblTransportista.Location = new Point(11, 172);
            lblTransportista.Name = "lblTransportista";
            lblTransportista.Size = new Size(240, 20);
            lblTransportista.TabIndex = 28;
            // 
            // txtTransportista
            // 
            txtTransportista.MaxLength = 60;
            txtTransportista.Location = new Point(11, 194);
            txtTransportista.Name = "txtTransportista";
            txtTransportista.Size = new Size(256, 23);
            txtTransportista.TabIndex = 29;
            // 
            // lblFlete
            // 
            lblFlete.Text = "Referencia del flete (traslados)";
            lblFlete.Location = new Point(288, 172);
            lblFlete.Name = "lblFlete";
            lblFlete.Size = new Size(208, 20);
            lblFlete.TabIndex = 30;
            // 
            // txtFlete
            // 
            txtFlete.MaxLength = 20;
            txtFlete.Location = new Point(288, 194);
            txtFlete.Name = "txtFlete";
            txtFlete.Size = new Size(192, 23);
            txtFlete.TabIndex = 31;
            // 
            // lblFechaRetiro
            // 
            lblFechaRetiro.Text = "Fecha de retiro";
            lblFechaRetiro.Location = new Point(504, 172);
            lblFechaRetiro.Name = "lblFechaRetiro";
            lblFechaRetiro.Size = new Size(160, 20);
            lblFechaRetiro.TabIndex = 32;
            // 
            // dtpRetiro
            // 
            dtpRetiro.Format = DateTimePickerFormat.Short;
            dtpRetiro.Value = new DateTime(2026, 10, 12, 0, 0, 0, 0);
            dtpRetiro.Location = new Point(504, 194);
            dtpRetiro.Name = "dtpRetiro";
            dtpRetiro.Size = new Size(136, 23);
            dtpRetiro.TabIndex = 33;
            // 
            // lblDocumento
            // 
            lblDocumento.Text = "Documento de salida";
            lblDocumento.Location = new Point(11, 232);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(160, 20);
            lblDocumento.TabIndex = 34;
            // 
            // txtDocumento
            // 
            txtDocumento.ReadOnly = true;
            txtDocumento.Location = new Point(11, 254);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(192, 23);
            txtDocumento.TabIndex = 35;
            // 
            // btnEmitirDocumento
            // 
            btnEmitirDocumento.BackColor = Color.FromArgb(35, 80, 124);
            btnEmitirDocumento.FlatStyle = FlatStyle.Flat;
            btnEmitirDocumento.ForeColor = Color.White;
            btnEmitirDocumento.Text = "Emitir remito / guía de traslado";
            btnEmitirDocumento.UseVisualStyleBackColor = false;
            btnEmitirDocumento.Location = new Point(216, 248);
            btnEmitirDocumento.Name = "btnEmitirDocumento";
            btnEmitirDocumento.Size = new Size(240, 34);
            btnEmitirDocumento.TabIndex = 36;
            // 
            // chkConformidad
            // 
            chkConformidad.Text = "El transportista presta conformidad de retiro";
            chkConformidad.UseVisualStyleBackColor = true;
            chkConformidad.Location = new Point(11, 298);
            chkConformidad.Name = "chkConformidad";
            chkConformidad.Size = new Size(480, 24);
            chkConformidad.TabIndex = 37;
            // 
            // lblAvisoDespacho
            // 
            lblAvisoDespacho.Text = "Emitir o imprimir el documento no descuenta stock. El egreso se registra una sola vez al cerrar el despacho.";
            lblAvisoDespacho.Location = new Point(11, 330);
            lblAvisoDespacho.Name = "lblAvisoDespacho";
            lblAvisoDespacho.Size = new Size(960, 24);
            lblAvisoDespacho.TabIndex = 38;
            // 
            // btnCerrarDespacho
            // 
            btnCerrarDespacho.BackColor = Color.FromArgb(35, 80, 124);
            btnCerrarDespacho.FlatStyle = FlatStyle.Flat;
            btnCerrarDespacho.ForeColor = Color.White;
            btnCerrarDespacho.Text = "Cerrar despacho";
            btnCerrarDespacho.UseVisualStyleBackColor = false;
            btnCerrarDespacho.Location = new Point(11, 376);
            btnCerrarDespacho.Name = "btnCerrarDespacho";
            btnCerrarDespacho.Size = new Size(334, 34);
            btnCerrarDespacho.TabIndex = 39;
            // 
            // btnReportarIncidenteDespacho
            // 
            btnReportarIncidenteDespacho.Text = "Reportar incidente";
            btnReportarIncidenteDespacho.UseVisualStyleBackColor = true;
            btnReportarIncidenteDespacho.Location = new Point(352, 376);
            btnReportarIncidenteDespacho.Name = "btnReportarIncidenteDespacho";
            btnReportarIncidenteDespacho.Size = new Size(240, 34);
            btnReportarIncidenteDespacho.TabIndex = 40;
            // 
            // RecepcionDespachoPedidosForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1067, 901);
            Controls.Add(lblTitulo);
            Controls.Add(lblEmpresa);
            Controls.Add(grpContexto);
            Controls.Add(grpRecepcion);
            Controls.Add(grpDespacho);
            Font = new Font("Segoe UI", 9F);
            AutoScroll = true;
            AutoScrollMinSize = new Size(1067, 1210);
            MinimumSize = new Size(640, 480);
            Name = "RecepcionDespachoPedidosForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pampazon - Recepción y Despacho de Pedidos";
            grpDespacho.ResumeLayout(false);
            grpRecepcion.ResumeLayout(false);
            grpContexto.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.GroupBox grpContexto;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.ComboBox cboDeposito;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaTrabajo;
        private System.Windows.Forms.GroupBox grpRecepcion;
        private System.Windows.Forms.Label lblBuscarEntrega;
        private System.Windows.Forms.TextBox txtBuscarEntrega;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblListaPreparadas;
        private System.Windows.Forms.ListView lvPreparadas;
        private System.Windows.Forms.ColumnHeader lvPreparadasCol0;
        private System.Windows.Forms.ColumnHeader lvPreparadasCol1;
        private System.Windows.Forms.ColumnHeader lvPreparadasCol2;
        private System.Windows.Forms.ColumnHeader lvPreparadasCol3;
        private System.Windows.Forms.ColumnHeader lvPreparadasCol4;
        private System.Windows.Forms.ColumnHeader lvPreparadasCol5;
        private System.Windows.Forms.ColumnHeader lvPreparadasCol6;
        private System.Windows.Forms.Label lblControlBultos;
        private System.Windows.Forms.ListView lvControlRecepcion;
        private System.Windows.Forms.ColumnHeader lvControlRecepcionCol0;
        private System.Windows.Forms.ColumnHeader lvControlRecepcionCol1;
        private System.Windows.Forms.ColumnHeader lvControlRecepcionCol2;
        private System.Windows.Forms.ColumnHeader lvControlRecepcionCol3;
        private System.Windows.Forms.ColumnHeader lvControlRecepcionCol4;
        private System.Windows.Forms.Label lblCantidadRecibida;
        private System.Windows.Forms.TextBox txtCantidadRecibida;
        private System.Windows.Forms.Button btnRegistrarRecepcion;
        private System.Windows.Forms.Label lblObsRecepcion;
        private System.Windows.Forms.TextBox txtObsRecepcion;
        private System.Windows.Forms.CheckBox chkRecepcionCompleta;
        private System.Windows.Forms.Button btnConfirmarRecepcion;
        private System.Windows.Forms.Button btnReportarIncidenteRecepcion;
        private System.Windows.Forms.GroupBox grpDespacho;
        private System.Windows.Forms.Label lblListaEnDespacho;
        private System.Windows.Forms.ListView lvEnDespacho;
        private System.Windows.Forms.ColumnHeader lvEnDespachoCol0;
        private System.Windows.Forms.ColumnHeader lvEnDespachoCol1;
        private System.Windows.Forms.ColumnHeader lvEnDespachoCol2;
        private System.Windows.Forms.ColumnHeader lvEnDespachoCol3;
        private System.Windows.Forms.ColumnHeader lvEnDespachoCol4;
        private System.Windows.Forms.ColumnHeader lvEnDespachoCol5;
        private System.Windows.Forms.ColumnHeader lvEnDespachoCol6;
        private System.Windows.Forms.Label lblTransportista;
        private System.Windows.Forms.TextBox txtTransportista;
        private System.Windows.Forms.Label lblFlete;
        private System.Windows.Forms.TextBox txtFlete;
        private System.Windows.Forms.Label lblFechaRetiro;
        private System.Windows.Forms.DateTimePicker dtpRetiro;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnEmitirDocumento;
        private System.Windows.Forms.CheckBox chkConformidad;
        private System.Windows.Forms.Label lblAvisoDespacho;
        private System.Windows.Forms.Button btnCerrarDespacho;
        private System.Windows.Forms.Button btnReportarIncidenteDespacho;
    }
}
