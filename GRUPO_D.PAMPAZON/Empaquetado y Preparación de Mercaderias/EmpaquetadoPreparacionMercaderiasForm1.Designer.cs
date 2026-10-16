namespace GRUPO_D.PAMPAZON.Empaquetado_y_Preparación_de_Mercaderias
{
    partial class EmpaquetadoPreparacionMercaderiasForm1
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
            ListViewItem item_lvPedidosEnPreparacion_0 = new ListViewItem(new string[] { "OP-000181", "Cliente Demo A", "Fulfillment", "Destino demo A", "Completas", "EN PREPARACIÓN" }, -1);
            ListViewItem item_lvPedidosEnPreparacion_1 = new ListViewItem(new string[] { "OP-000183", "Cliente Demo B", "Palé cerrado", "Destino demo B", "Completas", "EN PREPARACIÓN" }, -1);
            ListViewItem item_lvControl_0 = new ListViewItem(new string[] { "SKU-001", "Remera de algodón", "80", "80", "", "" }, -1);
            ListViewItem item_lvBultos_0 = new ListViewItem(new string[] { "B-001", "SKU-001", "Remera de algodón", "50" }, -1);
            lblTitulo = new Label();
            lblEmpresa = new Label();
            grpContexto = new GroupBox();
            lblDeposito = new Label();
            cboDeposito = new ComboBox();
            lblRol = new Label();
            lblFecha = new Label();
            dtpFechaTrabajo = new DateTimePicker();
            grpPedidos = new GroupBox();
            lvPedidosEnPreparacion = new ListView();
            lvPedidosEnPreparacionCol0 = new ColumnHeader();
            lvPedidosEnPreparacionCol1 = new ColumnHeader();
            lvPedidosEnPreparacionCol2 = new ColumnHeader();
            lvPedidosEnPreparacionCol3 = new ColumnHeader();
            lvPedidosEnPreparacionCol4 = new ColumnHeader();
            lvPedidosEnPreparacionCol5 = new ColumnHeader();
            grpDatosPedido = new GroupBox();
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblModalidad = new Label();
            txtModalidad = new TextBox();
            lblDestino = new Label();
            txtDestino = new TextBox();
            grpControl = new GroupBox();
            lvControl = new ListView();
            lvControlCol0 = new ColumnHeader();
            lvControlCol1 = new ColumnHeader();
            lvControlCol2 = new ColumnHeader();
            lvControlCol3 = new ColumnHeader();
            lvControlCol4 = new ColumnHeader();
            lvControlCol5 = new ColumnHeader();
            lblCantidadControlada = new Label();
            txtCantidadControlada = new TextBox();
            btnRegistrarControl = new Button();
            grpFulfillment = new GroupBox();
            lblIdBulto = new Label();
            txtIdBulto = new TextBox();
            lblSkuBulto = new Label();
            cboSkuBulto = new ComboBox();
            lblCantBulto = new Label();
            txtCantBulto = new TextBox();
            btnAgregarBulto = new Button();
            lvBultos = new ListView();
            lvBultosCol0 = new ColumnHeader();
            lvBultosCol1 = new ColumnHeader();
            lvBultosCol2 = new ColumnHeader();
            lvBultosCol3 = new ColumnHeader();
            grpPale = new GroupBox();
            lblIdPale = new Label();
            txtIdPale = new TextBox();
            chkPaleConforme = new CheckBox();
            grpCierre = new GroupBox();
            chkListo = new CheckBox();
            lblOrdenEntrega = new Label();
            txtOrdenEntrega = new TextBox();
            btnConfirmarPreparacion = new Button();
            btnReimprimir = new Button();
            btnReportarIncidente = new Button();
            grpContexto.SuspendLayout();
            grpPedidos.SuspendLayout();
            grpDatosPedido.SuspendLayout();
            grpControl.SuspendLayout();
            grpFulfillment.SuspendLayout();
            grpPale.SuspendLayout();
            grpCierre.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Text = "Empaquetado y Preparación de Entregas";
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
            lblEmpresa.Text = "PAMPAZON  |  Operario de Preparación";
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
            lblRol.Text = "Rol: Operario de Preparación";
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
            // grpPedidos
            // 
            grpPedidos.Controls.Add(lvPedidosEnPreparacion);
            grpPedidos.TabStop = false;
            grpPedidos.Text = "Pedidos en preparación";
            grpPedidos.Location = new Point(13, 170);
            grpPedidos.Name = "grpPedidos";
            grpPedidos.Size = new Size(1030, 170);
            grpPedidos.TabIndex = 8;
            // 
            // lvPedidosEnPreparacion
            // 
            lvPedidosEnPreparacion.Columns.AddRange(new ColumnHeader[] { lvPedidosEnPreparacionCol0, lvPedidosEnPreparacionCol1, lvPedidosEnPreparacionCol2, lvPedidosEnPreparacionCol3, lvPedidosEnPreparacionCol4, lvPedidosEnPreparacionCol5 });
            lvPedidosEnPreparacion.FullRowSelect = true;
            lvPedidosEnPreparacion.GridLines = true;
            lvPedidosEnPreparacion.Items.AddRange(new ListViewItem[] { item_lvPedidosEnPreparacion_0, item_lvPedidosEnPreparacion_1 });
            lvPedidosEnPreparacion.Location = new Point(10, 26);
            lvPedidosEnPreparacion.Name = "lvPedidosEnPreparacion";
            lvPedidosEnPreparacion.Size = new Size(1010, 132);
            lvPedidosEnPreparacion.TabIndex = 9;
            lvPedidosEnPreparacion.UseCompatibleStateImageBehavior = false;
            lvPedidosEnPreparacion.View = View.Details;
            // 
            // lvPedidosEnPreparacionCol0
            // 
            lvPedidosEnPreparacionCol0.Text = "N.º de pedido";
            lvPedidosEnPreparacionCol0.Width = 96;
            // 
            // lvPedidosEnPreparacionCol1
            // 
            lvPedidosEnPreparacionCol1.Text = "Cliente";
            lvPedidosEnPreparacionCol1.Width = 176;
            // 
            // lvPedidosEnPreparacionCol2
            // 
            lvPedidosEnPreparacionCol2.Text = "Modalidad";
            lvPedidosEnPreparacionCol2.Width = 120;
            // 
            // lvPedidosEnPreparacionCol3
            // 
            lvPedidosEnPreparacionCol3.Text = "Destino";
            lvPedidosEnPreparacionCol3.Width = 240;
            // 
            // lvPedidosEnPreparacionCol4
            // 
            lvPedidosEnPreparacionCol4.Text = "Selecciones";
            lvPedidosEnPreparacionCol4.Width = 96;
            // 
            // lvPedidosEnPreparacionCol5
            // 
            lvPedidosEnPreparacionCol5.Text = "Estado";
            lvPedidosEnPreparacionCol5.Width = 136;
            // 
            // grpDatosPedido
            // 
            grpDatosPedido.Controls.Add(lblCliente);
            grpDatosPedido.Controls.Add(txtCliente);
            grpDatosPedido.Controls.Add(lblModalidad);
            grpDatosPedido.Controls.Add(txtModalidad);
            grpDatosPedido.Controls.Add(lblDestino);
            grpDatosPedido.Controls.Add(txtDestino);
            grpDatosPedido.TabStop = false;
            grpDatosPedido.Text = "Datos del pedido";
            grpDatosPedido.Location = new Point(13, 350);
            grpDatosPedido.Name = "grpDatosPedido";
            grpDatosPedido.Size = new Size(1030, 66);
            grpDatosPedido.TabIndex = 10;
            // 
            // lblCliente
            // 
            lblCliente.Text = "Cliente";
            lblCliente.Location = new Point(11, 28);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(48, 20);
            lblCliente.TabIndex = 11;
            // 
            // txtCliente
            // 
            txtCliente.ReadOnly = true;
            txtCliente.Location = new Point(61, 24);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(200, 23);
            txtCliente.TabIndex = 12;
            // 
            // lblModalidad
            // 
            lblModalidad.Text = "Modalidad";
            lblModalidad.Location = new Point(280, 28);
            lblModalidad.Name = "lblModalidad";
            lblModalidad.Size = new Size(64, 20);
            lblModalidad.TabIndex = 13;
            // 
            // txtModalidad
            // 
            txtModalidad.ReadOnly = true;
            txtModalidad.Location = new Point(347, 24);
            txtModalidad.Name = "txtModalidad";
            txtModalidad.Size = new Size(136, 23);
            txtModalidad.TabIndex = 14;
            // 
            // lblDestino
            // 
            lblDestino.Text = "Destino";
            lblDestino.Location = new Point(504, 28);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(48, 20);
            lblDestino.TabIndex = 15;
            // 
            // txtDestino
            // 
            txtDestino.ReadOnly = true;
            txtDestino.Location = new Point(555, 24);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(240, 23);
            txtDestino.TabIndex = 16;
            // 
            // grpControl
            // 
            grpControl.Controls.Add(lvControl);
            grpControl.Controls.Add(lblCantidadControlada);
            grpControl.Controls.Add(txtCantidadControlada);
            grpControl.Controls.Add(btnRegistrarControl);
            grpControl.TabStop = false;
            grpControl.Text = "Control de productos recibidos de Almacén";
            grpControl.Location = new Point(13, 426);
            grpControl.Name = "grpControl";
            grpControl.Size = new Size(1030, 170);
            grpControl.TabIndex = 17;
            // 
            // lvControl
            // 
            lvControl.Columns.AddRange(new ColumnHeader[] { lvControlCol0, lvControlCol1, lvControlCol2, lvControlCol3, lvControlCol4, lvControlCol5 });
            lvControl.FullRowSelect = true;
            lvControl.GridLines = true;
            lvControl.Items.AddRange(new ListViewItem[] { item_lvControl_0 });
            lvControl.Location = new Point(10, 24);
            lvControl.Name = "lvControl";
            lvControl.Size = new Size(1010, 96);
            lvControl.TabIndex = 18;
            lvControl.UseCompatibleStateImageBehavior = false;
            lvControl.View = View.Details;
            // 
            // lvControlCol0
            // 
            lvControlCol0.Text = "SKU";
            lvControlCol0.Width = 80;
            // 
            // lvControlCol1
            // 
            lvControlCol1.Text = "Producto";
            lvControlCol1.Width = 208;
            // 
            // lvControlCol2
            // 
            lvControlCol2.Text = "Cantidad solicitada";
            lvControlCol2.Width = 120;
            // 
            // lvControlCol3
            // 
            lvControlCol3.Text = "Entregada por Almacén";
            lvControlCol3.Width = 136;
            // 
            // lvControlCol4
            // 
            lvControlCol4.Text = "Cantidad controlada";
            lvControlCol4.Width = 120;
            // 
            // lvControlCol5
            // 
            lvControlCol5.Text = "Diferencia";
            lvControlCol5.Width = 96;
            // 
            // lblCantidadControlada
            // 
            lblCantidadControlada.Text = "Cantidad controlada";
            lblCantidadControlada.Location = new Point(11, 134);
            lblCantidadControlada.Name = "lblCantidadControlada";
            lblCantidadControlada.Size = new Size(108, 20);
            lblCantidadControlada.TabIndex = 19;
            // 
            // txtCantidadControlada
            // 
            txtCantidadControlada.Location = new Point(120, 130);
            txtCantidadControlada.Name = "txtCantidadControlada";
            txtCantidadControlada.Size = new Size(96, 23);
            txtCantidadControlada.TabIndex = 20;
            // 
            // btnRegistrarControl
            // 
            btnRegistrarControl.BackColor = Color.FromArgb(35, 80, 124);
            btnRegistrarControl.FlatStyle = FlatStyle.Flat;
            btnRegistrarControl.ForeColor = Color.White;
            btnRegistrarControl.Text = "Registrar control";
            btnRegistrarControl.UseVisualStyleBackColor = false;
            btnRegistrarControl.Location = new Point(232, 126);
            btnRegistrarControl.Name = "btnRegistrarControl";
            btnRegistrarControl.Size = new Size(208, 30);
            btnRegistrarControl.TabIndex = 21;
            // 
            // grpFulfillment
            // 
            grpFulfillment.Controls.Add(lblIdBulto);
            grpFulfillment.Controls.Add(txtIdBulto);
            grpFulfillment.Controls.Add(lblSkuBulto);
            grpFulfillment.Controls.Add(cboSkuBulto);
            grpFulfillment.Controls.Add(lblCantBulto);
            grpFulfillment.Controls.Add(txtCantBulto);
            grpFulfillment.Controls.Add(btnAgregarBulto);
            grpFulfillment.Controls.Add(lvBultos);
            grpFulfillment.TabStop = false;
            grpFulfillment.Text = "Bultos (modalidad fulfillment)";
            grpFulfillment.Location = new Point(13, 606);
            grpFulfillment.Name = "grpFulfillment";
            grpFulfillment.Size = new Size(656, 250);
            grpFulfillment.TabIndex = 22;
            // 
            // lblIdBulto
            // 
            lblIdBulto.Text = "Identificación del bulto";
            lblIdBulto.Location = new Point(11, 26);
            lblIdBulto.Name = "lblIdBulto";
            lblIdBulto.Size = new Size(160, 20);
            lblIdBulto.TabIndex = 23;
            // 
            // txtIdBulto
            // 
            txtIdBulto.MaxLength = 20;
            txtIdBulto.Location = new Point(11, 48);
            txtIdBulto.Name = "txtIdBulto";
            txtIdBulto.Size = new Size(160, 23);
            txtIdBulto.TabIndex = 24;
            // 
            // lblSkuBulto
            // 
            lblSkuBulto.Text = "SKU";
            lblSkuBulto.Location = new Point(11, 80);
            lblSkuBulto.Name = "lblSkuBulto";
            lblSkuBulto.Size = new Size(160, 20);
            lblSkuBulto.TabIndex = 25;
            // 
            // cboSkuBulto
            // 
            cboSkuBulto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSkuBulto.Items.AddRange(new object[] { "SKU-001", "SKU-002" });
            cboSkuBulto.SelectedIndex = 0;
            cboSkuBulto.Location = new Point(11, 102);
            cboSkuBulto.Name = "cboSkuBulto";
            cboSkuBulto.Size = new Size(160, 23);
            cboSkuBulto.TabIndex = 26;
            // 
            // lblCantBulto
            // 
            lblCantBulto.Text = "Cantidad empacada";
            lblCantBulto.Location = new Point(11, 134);
            lblCantBulto.Name = "lblCantBulto";
            lblCantBulto.Size = new Size(160, 20);
            lblCantBulto.TabIndex = 27;
            // 
            // txtCantBulto
            // 
            txtCantBulto.Location = new Point(11, 156);
            txtCantBulto.Name = "txtCantBulto";
            txtCantBulto.Size = new Size(80, 23);
            txtCantBulto.TabIndex = 28;
            // 
            // btnAgregarBulto
            // 
            btnAgregarBulto.BackColor = Color.FromArgb(35, 80, 124);
            btnAgregarBulto.FlatStyle = FlatStyle.Flat;
            btnAgregarBulto.ForeColor = Color.White;
            btnAgregarBulto.Text = "Agregar al bulto";
            btnAgregarBulto.UseVisualStyleBackColor = false;
            btnAgregarBulto.Location = new Point(11, 196);
            btnAgregarBulto.Name = "btnAgregarBulto";
            btnAgregarBulto.Size = new Size(160, 34);
            btnAgregarBulto.TabIndex = 29;
            // 
            // lvBultos
            // 
            lvBultos.Columns.AddRange(new ColumnHeader[] { lvBultosCol0, lvBultosCol1, lvBultosCol2, lvBultosCol3 });
            lvBultos.FullRowSelect = true;
            lvBultos.GridLines = true;
            lvBultos.Items.AddRange(new ListViewItem[] { item_lvBultos_0 });
            lvBultos.Location = new Point(184, 26);
            lvBultos.Name = "lvBultos";
            lvBultos.Size = new Size(461, 204);
            lvBultos.TabIndex = 30;
            lvBultos.UseCompatibleStateImageBehavior = false;
            lvBultos.View = View.Details;
            // 
            // lvBultosCol0
            // 
            lvBultosCol0.Text = "Bulto";
            lvBultosCol0.Width = 112;
            // 
            // lvBultosCol1
            // 
            lvBultosCol1.Text = "SKU";
            lvBultosCol1.Width = 96;
            // 
            // lvBultosCol2
            // 
            lvBultosCol2.Text = "Producto";
            lvBultosCol2.Width = 160;
            // 
            // lvBultosCol3
            // 
            lvBultosCol3.Text = "Cantidad";
            lvBultosCol3.Width = 80;
            // 
            // grpPale
            // 
            grpPale.Controls.Add(lblIdPale);
            grpPale.Controls.Add(txtIdPale);
            grpPale.Controls.Add(chkPaleConforme);
            grpPale.TabStop = false;
            grpPale.Text = "Revisión de palé (modalidad palé cerrado)";
            grpPale.Location = new Point(677, 606);
            grpPale.Name = "grpPale";
            grpPale.Size = new Size(366, 100);
            grpPale.TabIndex = 31;
            // 
            // lblIdPale
            // 
            lblIdPale.Text = "Identificación del palé";
            lblIdPale.Location = new Point(11, 24);
            lblIdPale.Name = "lblIdPale";
            lblIdPale.Size = new Size(160, 20);
            lblIdPale.TabIndex = 32;
            // 
            // txtIdPale
            // 
            txtIdPale.MaxLength = 20;
            txtIdPale.Location = new Point(11, 44);
            txtIdPale.Name = "txtIdPale";
            txtIdPale.Size = new Size(208, 23);
            txtIdPale.TabIndex = 33;
            // 
            // chkPaleConforme
            // 
            chkPaleConforme.Text = "Revisión conforme (embalaje del palé)";
            chkPaleConforme.UseVisualStyleBackColor = true;
            chkPaleConforme.Location = new Point(11, 72);
            chkPaleConforme.Name = "chkPaleConforme";
            chkPaleConforme.Size = new Size(336, 22);
            chkPaleConforme.TabIndex = 34;
            // 
            // grpCierre
            // 
            grpCierre.Controls.Add(chkListo);
            grpCierre.Controls.Add(lblOrdenEntrega);
            grpCierre.Controls.Add(txtOrdenEntrega);
            grpCierre.Controls.Add(btnConfirmarPreparacion);
            grpCierre.Controls.Add(btnReimprimir);
            grpCierre.Controls.Add(btnReportarIncidente);
            grpCierre.TabStop = false;
            grpCierre.Text = "Cierre de la preparación";
            grpCierre.Location = new Point(677, 716);
            grpCierre.Name = "grpCierre";
            grpCierre.Size = new Size(366, 140);
            grpCierre.TabIndex = 35;
            // 
            // chkListo
            // 
            chkListo.Text = "Pedido completo y listo para Despacho";
            chkListo.UseVisualStyleBackColor = true;
            chkListo.Location = new Point(11, 22);
            chkListo.Name = "chkListo";
            chkListo.Size = new Size(336, 24);
            chkListo.TabIndex = 36;
            // 
            // lblOrdenEntrega
            // 
            lblOrdenEntrega.Text = "Orden de entrega";
            lblOrdenEntrega.Location = new Point(11, 60);
            lblOrdenEntrega.Name = "lblOrdenEntrega";
            lblOrdenEntrega.Size = new Size(94, 20);
            lblOrdenEntrega.TabIndex = 37;
            // 
            // txtOrdenEntrega
            // 
            txtOrdenEntrega.ReadOnly = true;
            txtOrdenEntrega.Location = new Point(112, 56);
            txtOrdenEntrega.Name = "txtOrdenEntrega";
            txtOrdenEntrega.Size = new Size(160, 23);
            txtOrdenEntrega.TabIndex = 38;
            // 
            // btnConfirmarPreparacion
            // 
            btnConfirmarPreparacion.BackColor = Color.FromArgb(35, 80, 124);
            btnConfirmarPreparacion.FlatStyle = FlatStyle.Flat;
            btnConfirmarPreparacion.ForeColor = Color.White;
            btnConfirmarPreparacion.Text = "Confirmar preparación";
            btnConfirmarPreparacion.UseVisualStyleBackColor = false;
            btnConfirmarPreparacion.Location = new Point(11, 96);
            btnConfirmarPreparacion.Name = "btnConfirmarPreparacion";
            btnConfirmarPreparacion.Size = new Size(160, 34);
            btnConfirmarPreparacion.TabIndex = 39;
            // 
            // btnReimprimir
            // 
            btnReimprimir.Text = "Reimprimir";
            btnReimprimir.UseVisualStyleBackColor = true;
            btnReimprimir.Location = new Point(178, 96);
            btnReimprimir.Name = "btnReimprimir";
            btnReimprimir.Size = new Size(88, 34);
            btnReimprimir.TabIndex = 40;
            // 
            // btnReportarIncidente
            // 
            btnReportarIncidente.Text = "Incidente";
            btnReportarIncidente.UseVisualStyleBackColor = true;
            btnReportarIncidente.Location = new Point(272, 96);
            btnReportarIncidente.Name = "btnReportarIncidente";
            btnReportarIncidente.Size = new Size(83, 34);
            btnReportarIncidente.TabIndex = 41;
            // 
            // EmpaquetadoPreparacionMercaderiasForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1067, 901);
            Controls.Add(lblTitulo);
            Controls.Add(lblEmpresa);
            Controls.Add(grpContexto);
            Controls.Add(grpPedidos);
            Controls.Add(grpDatosPedido);
            Controls.Add(grpControl);
            Controls.Add(grpFulfillment);
            Controls.Add(grpPale);
            Controls.Add(grpCierre);
            Font = new Font("Segoe UI", 9F);
            AutoScroll = true;
            AutoScrollMinSize = new Size(1067, 901);
            MinimumSize = new Size(640, 480);
            Name = "EmpaquetadoPreparacionMercaderiasForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pampazon - Empaquetado y Preparación de Entregas";
            grpCierre.ResumeLayout(false);
            grpPale.ResumeLayout(false);
            grpFulfillment.ResumeLayout(false);
            grpControl.ResumeLayout(false);
            grpDatosPedido.ResumeLayout(false);
            grpPedidos.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpPedidos;
        private System.Windows.Forms.ListView lvPedidosEnPreparacion;
        private System.Windows.Forms.ColumnHeader lvPedidosEnPreparacionCol0;
        private System.Windows.Forms.ColumnHeader lvPedidosEnPreparacionCol1;
        private System.Windows.Forms.ColumnHeader lvPedidosEnPreparacionCol2;
        private System.Windows.Forms.ColumnHeader lvPedidosEnPreparacionCol3;
        private System.Windows.Forms.ColumnHeader lvPedidosEnPreparacionCol4;
        private System.Windows.Forms.ColumnHeader lvPedidosEnPreparacionCol5;
        private System.Windows.Forms.GroupBox grpDatosPedido;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.ListView lvControl;
        private System.Windows.Forms.ColumnHeader lvControlCol0;
        private System.Windows.Forms.ColumnHeader lvControlCol1;
        private System.Windows.Forms.ColumnHeader lvControlCol2;
        private System.Windows.Forms.ColumnHeader lvControlCol3;
        private System.Windows.Forms.ColumnHeader lvControlCol4;
        private System.Windows.Forms.ColumnHeader lvControlCol5;
        private System.Windows.Forms.Label lblCantidadControlada;
        private System.Windows.Forms.TextBox txtCantidadControlada;
        private System.Windows.Forms.Button btnRegistrarControl;
        private System.Windows.Forms.GroupBox grpFulfillment;
        private System.Windows.Forms.Label lblIdBulto;
        private System.Windows.Forms.TextBox txtIdBulto;
        private System.Windows.Forms.Label lblSkuBulto;
        private System.Windows.Forms.ComboBox cboSkuBulto;
        private System.Windows.Forms.Label lblCantBulto;
        private System.Windows.Forms.TextBox txtCantBulto;
        private System.Windows.Forms.Button btnAgregarBulto;
        private System.Windows.Forms.ListView lvBultos;
        private System.Windows.Forms.ColumnHeader lvBultosCol0;
        private System.Windows.Forms.ColumnHeader lvBultosCol1;
        private System.Windows.Forms.ColumnHeader lvBultosCol2;
        private System.Windows.Forms.ColumnHeader lvBultosCol3;
        private System.Windows.Forms.GroupBox grpPale;
        private System.Windows.Forms.Label lblIdPale;
        private System.Windows.Forms.TextBox txtIdPale;
        private System.Windows.Forms.CheckBox chkPaleConforme;
        private System.Windows.Forms.GroupBox grpCierre;
        private System.Windows.Forms.CheckBox chkListo;
        private System.Windows.Forms.Label lblOrdenEntrega;
        private System.Windows.Forms.TextBox txtOrdenEntrega;
        private System.Windows.Forms.Button btnConfirmarPreparacion;
        private System.Windows.Forms.Button btnReimprimir;
        private System.Windows.Forms.Button btnReportarIncidente;
    }
}
