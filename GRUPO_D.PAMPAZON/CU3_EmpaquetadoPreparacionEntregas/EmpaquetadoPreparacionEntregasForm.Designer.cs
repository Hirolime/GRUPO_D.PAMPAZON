namespace GRUPO_D.PAMPAZON.CU3_EmpaquetadoPreparacionEntregas
{
    partial class EmpaquetadoPreparacionEntregasForm
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
            grpPedidosEnPreparacion = new GroupBox();
            lvPedidosEnPreparacion = new ListView();
            colPedidosEnPreparacionNumero = new ColumnHeader();
            colPedidosEnPreparacionCliente = new ColumnHeader();
            colPedidosEnPreparacionModalidad = new ColumnHeader();
            colPedidosEnPreparacionDestino = new ColumnHeader();
            colPedidosEnPreparacionSelecciones = new ColumnHeader();
            colPedidosEnPreparacionEstado = new ColumnHeader();
            grpDatosPedido = new GroupBox();
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblModalidad = new Label();
            txtModalidad = new TextBox();
            lblDestino = new Label();
            txtDestino = new TextBox();
            grpControlCantidades = new GroupBox();
            lvControlCantidades = new ListView();
            colControlCantidadesSku = new ColumnHeader();
            colControlCantidadesProducto = new ColumnHeader();
            colControlCantidadesSolicitada = new ColumnHeader();
            colControlCantidadesEntregada = new ColumnHeader();
            colControlCantidadesControlada = new ColumnHeader();
            colControlCantidadesDiferencia = new ColumnHeader();
            lblCantidadControlada = new Label();
            txtCantidadControlada = new TextBox();
            btnRegistrarControl = new Button();
            grpFulfillment = new GroupBox();
            lblIdentificacionBulto = new Label();
            txtIdentificacionBulto = new TextBox();
            lblSkuBulto = new Label();
            cboSkuBulto = new ComboBox();
            lblCantidadBulto = new Label();
            txtCantidadBulto = new TextBox();
            btnAgregarBulto = new Button();
            lvBultos = new ListView();
            colBultosIdentificacion = new ColumnHeader();
            colBultosSku = new ColumnHeader();
            colBultosProducto = new ColumnHeader();
            colBultosCantidad = new ColumnHeader();
            grpPale = new GroupBox();
            lblIdentificacionPale = new Label();
            txtIdentificacionPale = new TextBox();
            chkPaleConforme = new CheckBox();
            grpCierre = new GroupBox();
            chkListoDespacho = new CheckBox();
            lblOrdenEntrega = new Label();
            txtOrdenEntrega = new TextBox();
            btnConfirmarPreparacion = new Button();
            btnReimprimirOrdenEntrega = new Button();
            btnReportarIncidente = new Button();
            grpContexto.SuspendLayout();
            grpPedidosEnPreparacion.SuspendLayout();
            grpDatosPedido.SuspendLayout();
            grpControlCantidades.SuspendLayout();
            grpFulfillment.SuspendLayout();
            grpPale.SuspendLayout();
            grpCierre.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Text = "Empaquetado y Preparación de Entregas";
            lblTitulo.Location = new Point(24, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(890, 34);
            lblTitulo.TabIndex = 0;
            // 
            // lblEmpresa
            // 
            lblEmpresa.Text = "PAMPAZON";
            lblEmpresa.Location = new Point(26, 48);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(1050, 22);
            lblEmpresa.TabIndex = 1;
            // 
            // grpContexto
            // 
            grpContexto.Controls.Add(lblDeposito);
            grpContexto.Controls.Add(cboDeposito);
            grpContexto.Controls.Add(lblRol);
            grpContexto.Controls.Add(lblFechaTrabajo);
            grpContexto.Controls.Add(dtpFechaTrabajo);
            grpContexto.TabStop = false;
            grpContexto.Text = "Contexto de trabajo";
            grpContexto.Location = new Point(16, 84);
            grpContexto.Name = "grpContexto";
            grpContexto.Size = new Size(1288, 72);
            grpContexto.TabIndex = 2;
            // 
            // lblDeposito
            // 
            lblDeposito.Text = "Depósito";
            lblDeposito.Location = new Point(16, 30);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(68, 24);
            lblDeposito.TabIndex = 3;
            // 
            // cboDeposito
            // 
            cboDeposito.Enabled = false;
            cboDeposito.Items.AddRange(new object[] { "GBA" });
            cboDeposito.Location = new Point(90, 26);
            cboDeposito.Name = "cboDeposito";
            cboDeposito.Size = new Size(372, 23);
            cboDeposito.TabIndex = 4;
            // 
            // lblRol
            // 
            lblRol.Text = "Rol: Operario de Preparación";
            lblRol.Location = new Point(480, 29);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(260, 24);
            lblRol.TabIndex = 5;
            // 
            // lblFechaTrabajo
            // 
            lblFechaTrabajo.Text = "Fecha";
            lblFechaTrabajo.Location = new Point(780, 30);
            lblFechaTrabajo.Name = "lblFechaTrabajo";
            lblFechaTrabajo.Size = new Size(72, 24);
            lblFechaTrabajo.TabIndex = 6;
            // 
            // dtpFechaTrabajo
            // 
            dtpFechaTrabajo.Enabled = false;
            dtpFechaTrabajo.Format = DateTimePickerFormat.Short;
            dtpFechaTrabajo.Value = new DateTime(2026, 10, 12, 0, 0, 0, 0);
            dtpFechaTrabajo.Location = new Point(856, 26);
            dtpFechaTrabajo.Name = "dtpFechaTrabajo";
            dtpFechaTrabajo.Size = new Size(410, 23);
            dtpFechaTrabajo.TabIndex = 7;
            // 
            // grpPedidosEnPreparacion
            // 
            grpPedidosEnPreparacion.Controls.Add(lvPedidosEnPreparacion);
            grpPedidosEnPreparacion.TabStop = false;
            grpPedidosEnPreparacion.Text = "Pedidos en preparación";
            grpPedidosEnPreparacion.Location = new Point(16, 170);
            grpPedidosEnPreparacion.Name = "grpPedidosEnPreparacion";
            grpPedidosEnPreparacion.Size = new Size(1288, 170);
            grpPedidosEnPreparacion.TabIndex = 8;
            // 
            // lvPedidosEnPreparacion
            // 
            lvPedidosEnPreparacion.Columns.AddRange(new ColumnHeader[] { colPedidosEnPreparacionNumero, colPedidosEnPreparacionCliente, colPedidosEnPreparacionModalidad, colPedidosEnPreparacionDestino, colPedidosEnPreparacionSelecciones, colPedidosEnPreparacionEstado });
            lvPedidosEnPreparacion.FullRowSelect = true;
            lvPedidosEnPreparacion.GridLines = true;
            lvPedidosEnPreparacion.Location = new Point(12, 26);
            lvPedidosEnPreparacion.Name = "lvPedidosEnPreparacion";
            lvPedidosEnPreparacion.Size = new Size(1262, 132);
            lvPedidosEnPreparacion.TabIndex = 9;
            lvPedidosEnPreparacion.UseCompatibleStateImageBehavior = false;
            lvPedidosEnPreparacion.View = View.Details;
            // 
            // colPedidosEnPreparacionNumero
            // 
            colPedidosEnPreparacionNumero.Text = "N.º de pedido";
            colPedidosEnPreparacionNumero.Width = 120;
            // 
            // colPedidosEnPreparacionCliente
            // 
            colPedidosEnPreparacionCliente.Text = "Cliente";
            colPedidosEnPreparacionCliente.Width = 220;
            // 
            // colPedidosEnPreparacionModalidad
            // 
            colPedidosEnPreparacionModalidad.Text = "Modalidad";
            colPedidosEnPreparacionModalidad.Width = 150;
            // 
            // colPedidosEnPreparacionDestino
            // 
            colPedidosEnPreparacionDestino.Text = "Destino";
            colPedidosEnPreparacionDestino.Width = 300;
            // 
            // colPedidosEnPreparacionSelecciones
            // 
            colPedidosEnPreparacionSelecciones.Text = "Selecciones";
            colPedidosEnPreparacionSelecciones.Width = 120;
            // 
            // colPedidosEnPreparacionEstado
            // 
            colPedidosEnPreparacionEstado.Text = "Estado";
            colPedidosEnPreparacionEstado.Width = 170;
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
            grpDatosPedido.Location = new Point(16, 350);
            grpDatosPedido.Name = "grpDatosPedido";
            grpDatosPedido.Size = new Size(1288, 66);
            grpDatosPedido.TabIndex = 10;
            // 
            // lblCliente
            // 
            lblCliente.Text = "Cliente";
            lblCliente.Location = new Point(14, 28);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(60, 20);
            lblCliente.TabIndex = 11;
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(76, 24);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(250, 23);
            txtCliente.TabIndex = 12;
            // 
            // lblModalidad
            // 
            lblModalidad.Text = "Modalidad";
            lblModalidad.Location = new Point(350, 28);
            lblModalidad.Name = "lblModalidad";
            lblModalidad.Size = new Size(80, 20);
            lblModalidad.TabIndex = 13;
            // 
            // txtModalidad
            // 
            txtModalidad.Enabled = false;
            txtModalidad.Location = new Point(434, 24);
            txtModalidad.Name = "txtModalidad";
            txtModalidad.Size = new Size(170, 23);
            txtModalidad.TabIndex = 14;
            // 
            // lblDestino
            // 
            lblDestino.Text = "Destino";
            lblDestino.Location = new Point(630, 28);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(60, 20);
            lblDestino.TabIndex = 15;
            // 
            // txtDestino
            // 
            txtDestino.Enabled = false;
            txtDestino.Location = new Point(694, 24);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(300, 23);
            txtDestino.TabIndex = 16;
            // 
            // grpControlCantidades
            // 
            grpControlCantidades.Controls.Add(lvControlCantidades);
            grpControlCantidades.Controls.Add(lblCantidadControlada);
            grpControlCantidades.Controls.Add(txtCantidadControlada);
            grpControlCantidades.Controls.Add(btnRegistrarControl);
            grpControlCantidades.TabStop = false;
            grpControlCantidades.Text = "Control de productos recibidos de Almacén";
            grpControlCantidades.Location = new Point(16, 426);
            grpControlCantidades.Name = "grpControlCantidades";
            grpControlCantidades.Size = new Size(1288, 170);
            grpControlCantidades.TabIndex = 17;
            // 
            // lvControlCantidades
            // 
            lvControlCantidades.Columns.AddRange(new ColumnHeader[] { colControlCantidadesSku, colControlCantidadesProducto, colControlCantidadesSolicitada, colControlCantidadesEntregada, colControlCantidadesControlada, colControlCantidadesDiferencia });
            lvControlCantidades.FullRowSelect = true;
            lvControlCantidades.GridLines = true;
            lvControlCantidades.Location = new Point(12, 24);
            lvControlCantidades.Name = "lvControlCantidades";
            lvControlCantidades.Size = new Size(1262, 96);
            lvControlCantidades.TabIndex = 18;
            lvControlCantidades.UseCompatibleStateImageBehavior = false;
            lvControlCantidades.View = View.Details;
            // 
            // colControlCantidadesSku
            // 
            colControlCantidadesSku.Text = "SKU";
            colControlCantidadesSku.Width = 100;
            // 
            // colControlCantidadesProducto
            // 
            colControlCantidadesProducto.Text = "Producto";
            colControlCantidadesProducto.Width = 260;
            // 
            // colControlCantidadesSolicitada
            // 
            colControlCantidadesSolicitada.Text = "Cantidad solicitada";
            colControlCantidadesSolicitada.Width = 150;
            // 
            // colControlCantidadesEntregada
            // 
            colControlCantidadesEntregada.Text = "Entregada por Almacén";
            colControlCantidadesEntregada.Width = 170;
            // 
            // colControlCantidadesControlada
            // 
            colControlCantidadesControlada.Text = "Cantidad controlada";
            colControlCantidadesControlada.Width = 150;
            // 
            // colControlCantidadesDiferencia
            // 
            colControlCantidadesDiferencia.Text = "Diferencia";
            colControlCantidadesDiferencia.Width = 120;
            // 
            // lblCantidadControlada
            // 
            lblCantidadControlada.Text = "Cantidad controlada";
            lblCantidadControlada.Location = new Point(14, 134);
            lblCantidadControlada.Name = "lblCantidadControlada";
            lblCantidadControlada.Size = new Size(135, 20);
            lblCantidadControlada.TabIndex = 19;
            // 
            // txtCantidadControlada
            // 
            txtCantidadControlada.Location = new Point(150, 130);
            txtCantidadControlada.Name = "txtCantidadControlada";
            txtCantidadControlada.Size = new Size(120, 23);
            txtCantidadControlada.TabIndex = 20;
            // 
            // btnRegistrarControl
            // 
            btnRegistrarControl.Text = "Registrar control";
            btnRegistrarControl.Location = new Point(290, 126);
            btnRegistrarControl.Name = "btnRegistrarControl";
            btnRegistrarControl.Size = new Size(260, 30);
            btnRegistrarControl.TabIndex = 21;
            // 
            // grpFulfillment
            // 
            grpFulfillment.Controls.Add(lblIdentificacionBulto);
            grpFulfillment.Controls.Add(txtIdentificacionBulto);
            grpFulfillment.Controls.Add(lblSkuBulto);
            grpFulfillment.Controls.Add(cboSkuBulto);
            grpFulfillment.Controls.Add(lblCantidadBulto);
            grpFulfillment.Controls.Add(txtCantidadBulto);
            grpFulfillment.Controls.Add(btnAgregarBulto);
            grpFulfillment.Controls.Add(lvBultos);
            grpFulfillment.TabStop = false;
            grpFulfillment.Text = "Bultos (modalidad fulfillment)";
            grpFulfillment.Location = new Point(16, 606);
            grpFulfillment.Name = "grpFulfillment";
            grpFulfillment.Size = new Size(820, 250);
            grpFulfillment.TabIndex = 22;
            // 
            // lblIdentificacionBulto
            // 
            lblIdentificacionBulto.Text = "Identificación del bulto";
            lblIdentificacionBulto.Location = new Point(14, 26);
            lblIdentificacionBulto.Name = "lblIdentificacionBulto";
            lblIdentificacionBulto.Size = new Size(200, 20);
            lblIdentificacionBulto.TabIndex = 23;
            // 
            // txtIdentificacionBulto
            // 
            txtIdentificacionBulto.Location = new Point(14, 48);
            txtIdentificacionBulto.Name = "txtIdentificacionBulto";
            txtIdentificacionBulto.Size = new Size(200, 23);
            txtIdentificacionBulto.TabIndex = 24;
            // 
            // lblSkuBulto
            // 
            lblSkuBulto.Text = "SKU";
            lblSkuBulto.Location = new Point(14, 80);
            lblSkuBulto.Name = "lblSkuBulto";
            lblSkuBulto.Size = new Size(200, 20);
            lblSkuBulto.TabIndex = 25;
            // 
            // cboSkuBulto
            // 
            cboSkuBulto.Location = new Point(14, 102);
            cboSkuBulto.Name = "cboSkuBulto";
            cboSkuBulto.Size = new Size(200, 23);
            cboSkuBulto.TabIndex = 26;
            // 
            // lblCantidadBulto
            // 
            lblCantidadBulto.Text = "Cantidad empacada";
            lblCantidadBulto.Location = new Point(14, 134);
            lblCantidadBulto.Name = "lblCantidadBulto";
            lblCantidadBulto.Size = new Size(200, 20);
            lblCantidadBulto.TabIndex = 27;
            // 
            // txtCantidadBulto
            // 
            txtCantidadBulto.Location = new Point(14, 156);
            txtCantidadBulto.Name = "txtCantidadBulto";
            txtCantidadBulto.Size = new Size(100, 23);
            txtCantidadBulto.TabIndex = 28;
            // 
            // btnAgregarBulto
            // 
            btnAgregarBulto.Text = "Agregar al bulto";
            btnAgregarBulto.Location = new Point(14, 196);
            btnAgregarBulto.Name = "btnAgregarBulto";
            btnAgregarBulto.Size = new Size(200, 34);
            btnAgregarBulto.TabIndex = 29;
            // 
            // lvBultos
            // 
            lvBultos.Columns.AddRange(new ColumnHeader[] { colBultosIdentificacion, colBultosSku, colBultosProducto, colBultosCantidad });
            lvBultos.FullRowSelect = true;
            lvBultos.GridLines = true;
            lvBultos.Location = new Point(230, 26);
            lvBultos.Name = "lvBultos";
            lvBultos.Size = new Size(576, 204);
            lvBultos.TabIndex = 30;
            lvBultos.UseCompatibleStateImageBehavior = false;
            lvBultos.View = View.Details;
            // 
            // colBultosIdentificacion
            // 
            colBultosIdentificacion.Text = "Bulto";
            colBultosIdentificacion.Width = 140;
            // 
            // colBultosSku
            // 
            colBultosSku.Text = "SKU";
            colBultosSku.Width = 120;
            // 
            // colBultosProducto
            // 
            colBultosProducto.Text = "Producto";
            colBultosProducto.Width = 200;
            // 
            // colBultosCantidad
            // 
            colBultosCantidad.Text = "Cantidad";
            colBultosCantidad.Width = 100;
            // 
            // grpPale
            // 
            grpPale.Controls.Add(lblIdentificacionPale);
            grpPale.Controls.Add(txtIdentificacionPale);
            grpPale.Controls.Add(chkPaleConforme);
            grpPale.TabStop = false;
            grpPale.Text = "Revisión de palé (modalidad palé cerrado)";
            grpPale.Location = new Point(846, 606);
            grpPale.Name = "grpPale";
            grpPale.Size = new Size(458, 100);
            grpPale.TabIndex = 31;
            // 
            // lblIdentificacionPale
            // 
            lblIdentificacionPale.Text = "Identificación del palé";
            lblIdentificacionPale.Location = new Point(14, 24);
            lblIdentificacionPale.Name = "lblIdentificacionPale";
            lblIdentificacionPale.Size = new Size(200, 20);
            lblIdentificacionPale.TabIndex = 32;
            // 
            // txtIdentificacionPale
            // 
            txtIdentificacionPale.Location = new Point(14, 44);
            txtIdentificacionPale.Name = "txtIdentificacionPale";
            txtIdentificacionPale.Size = new Size(260, 23);
            txtIdentificacionPale.TabIndex = 33;
            // 
            // chkPaleConforme
            // 
            chkPaleConforme.Text = "Revisión conforme (embalaje del palé)";
            chkPaleConforme.Location = new Point(14, 72);
            chkPaleConforme.Name = "chkPaleConforme";
            chkPaleConforme.Size = new Size(420, 22);
            chkPaleConforme.TabIndex = 34;
            // 
            // grpCierre
            // 
            grpCierre.Controls.Add(chkListoDespacho);
            grpCierre.Controls.Add(lblOrdenEntrega);
            grpCierre.Controls.Add(txtOrdenEntrega);
            grpCierre.Controls.Add(btnConfirmarPreparacion);
            grpCierre.Controls.Add(btnReimprimirOrdenEntrega);
            grpCierre.Controls.Add(btnReportarIncidente);
            grpCierre.TabStop = false;
            grpCierre.Text = "Cierre de la preparación";
            grpCierre.Location = new Point(846, 716);
            grpCierre.Name = "grpCierre";
            grpCierre.Size = new Size(458, 140);
            grpCierre.TabIndex = 35;
            // 
            // chkListoDespacho
            // 
            chkListoDespacho.Text = "Pedido completo y listo para Despacho";
            chkListoDespacho.Location = new Point(14, 22);
            chkListoDespacho.Name = "chkListoDespacho";
            chkListoDespacho.Size = new Size(420, 24);
            chkListoDespacho.TabIndex = 36;
            // 
            // lblOrdenEntrega
            // 
            lblOrdenEntrega.Text = "Orden de entrega";
            lblOrdenEntrega.Location = new Point(14, 60);
            lblOrdenEntrega.Name = "lblOrdenEntrega";
            lblOrdenEntrega.Size = new Size(118, 20);
            lblOrdenEntrega.TabIndex = 37;
            // 
            // txtOrdenEntrega
            // 
            txtOrdenEntrega.Enabled = false;
            txtOrdenEntrega.Location = new Point(140, 56);
            txtOrdenEntrega.Name = "txtOrdenEntrega";
            txtOrdenEntrega.Size = new Size(200, 23);
            txtOrdenEntrega.TabIndex = 38;
            // 
            // btnConfirmarPreparacion
            // 
            btnConfirmarPreparacion.Text = "Confirmar preparación";
            btnConfirmarPreparacion.Location = new Point(14, 96);
            btnConfirmarPreparacion.Name = "btnConfirmarPreparacion";
            btnConfirmarPreparacion.Size = new Size(200, 34);
            btnConfirmarPreparacion.TabIndex = 39;
            // 
            // btnReimprimirOrdenEntrega
            // 
            btnReimprimirOrdenEntrega.Text = "Reimprimir";
            btnReimprimirOrdenEntrega.Location = new Point(222, 96);
            btnReimprimirOrdenEntrega.Name = "btnReimprimirOrdenEntrega";
            btnReimprimirOrdenEntrega.Size = new Size(110, 34);
            btnReimprimirOrdenEntrega.TabIndex = 40;
            // 
            // btnReportarIncidente
            // 
            btnReportarIncidente.Text = "Incidente";
            btnReportarIncidente.Location = new Point(340, 96);
            btnReportarIncidente.Name = "btnReportarIncidente";
            btnReportarIncidente.Size = new Size(104, 34);
            btnReportarIncidente.TabIndex = 41;
            // 
            // EmpaquetadoPreparacionEntregasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 901);
            Controls.Add(lblTitulo);
            Controls.Add(lblEmpresa);
            Controls.Add(grpContexto);
            Controls.Add(grpPedidosEnPreparacion);
            Controls.Add(grpDatosPedido);
            Controls.Add(grpControlCantidades);
            Controls.Add(grpFulfillment);
            Controls.Add(grpPale);
            Controls.Add(grpCierre);
            Name = "EmpaquetadoPreparacionEntregasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pampazon - Empaquetado y Preparación de Entregas";
            grpCierre.ResumeLayout(false);
            grpPale.ResumeLayout(false);
            grpFulfillment.ResumeLayout(false);
            grpControlCantidades.ResumeLayout(false);
            grpDatosPedido.ResumeLayout(false);
            grpPedidosEnPreparacion.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblFechaTrabajo;
        private System.Windows.Forms.DateTimePicker dtpFechaTrabajo;
        private System.Windows.Forms.GroupBox grpPedidosEnPreparacion;
        private System.Windows.Forms.ListView lvPedidosEnPreparacion;
        private System.Windows.Forms.ColumnHeader colPedidosEnPreparacionNumero;
        private System.Windows.Forms.ColumnHeader colPedidosEnPreparacionCliente;
        private System.Windows.Forms.ColumnHeader colPedidosEnPreparacionModalidad;
        private System.Windows.Forms.ColumnHeader colPedidosEnPreparacionDestino;
        private System.Windows.Forms.ColumnHeader colPedidosEnPreparacionSelecciones;
        private System.Windows.Forms.ColumnHeader colPedidosEnPreparacionEstado;
        private System.Windows.Forms.GroupBox grpDatosPedido;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.GroupBox grpControlCantidades;
        private System.Windows.Forms.ListView lvControlCantidades;
        private System.Windows.Forms.ColumnHeader colControlCantidadesSku;
        private System.Windows.Forms.ColumnHeader colControlCantidadesProducto;
        private System.Windows.Forms.ColumnHeader colControlCantidadesSolicitada;
        private System.Windows.Forms.ColumnHeader colControlCantidadesEntregada;
        private System.Windows.Forms.ColumnHeader colControlCantidadesControlada;
        private System.Windows.Forms.ColumnHeader colControlCantidadesDiferencia;
        private System.Windows.Forms.Label lblCantidadControlada;
        private System.Windows.Forms.TextBox txtCantidadControlada;
        private System.Windows.Forms.Button btnRegistrarControl;
        private System.Windows.Forms.GroupBox grpFulfillment;
        private System.Windows.Forms.Label lblIdentificacionBulto;
        private System.Windows.Forms.TextBox txtIdentificacionBulto;
        private System.Windows.Forms.Label lblSkuBulto;
        private System.Windows.Forms.ComboBox cboSkuBulto;
        private System.Windows.Forms.Label lblCantidadBulto;
        private System.Windows.Forms.TextBox txtCantidadBulto;
        private System.Windows.Forms.Button btnAgregarBulto;
        private System.Windows.Forms.ListView lvBultos;
        private System.Windows.Forms.ColumnHeader colBultosIdentificacion;
        private System.Windows.Forms.ColumnHeader colBultosSku;
        private System.Windows.Forms.ColumnHeader colBultosProducto;
        private System.Windows.Forms.ColumnHeader colBultosCantidad;
        private System.Windows.Forms.GroupBox grpPale;
        private System.Windows.Forms.Label lblIdentificacionPale;
        private System.Windows.Forms.TextBox txtIdentificacionPale;
        private System.Windows.Forms.CheckBox chkPaleConforme;
        private System.Windows.Forms.GroupBox grpCierre;
        private System.Windows.Forms.CheckBox chkListoDespacho;
        private System.Windows.Forms.Label lblOrdenEntrega;
        private System.Windows.Forms.TextBox txtOrdenEntrega;
        private System.Windows.Forms.Button btnConfirmarPreparacion;
        private System.Windows.Forms.Button btnReimprimirOrdenEntrega;
        private System.Windows.Forms.Button btnReportarIncidente;
    }
}
