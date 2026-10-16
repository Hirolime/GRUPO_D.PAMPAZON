namespace GRUPO_D.PAMPAZON.CU4_RecepcionDespachoPedidos
{
    partial class RecepcionDespachoPedidosForm
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
            grpRecepcion = new GroupBox();
            lblFiltroEntrega = new Label();
            txtFiltroEntrega = new TextBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            lblEntregasPreparadas = new Label();
            lvEntregasPreparadas = new ListView();
            colEntregasPreparadasNumero = new ColumnHeader();
            colEntregasPreparadasPedido = new ColumnHeader();
            colEntregasPreparadasCliente = new ColumnHeader();
            colEntregasPreparadasOrigen = new ColumnHeader();
            colEntregasPreparadasDestino = new ColumnHeader();
            colEntregasPreparadasBultos = new ColumnHeader();
            colEntregasPreparadasEstado = new ColumnHeader();
            lblControlRecepcion = new Label();
            lvControlRecepcion = new ListView();
            colControlRecepcionSku = new ColumnHeader();
            colControlRecepcionProducto = new ColumnHeader();
            colControlRecepcionCantidad = new ColumnHeader();
            colControlRecepcionRecibida = new ColumnHeader();
            colControlRecepcionDiferencia = new ColumnHeader();
            lblCantidadRecibida = new Label();
            txtCantidadRecibida = new TextBox();
            btnRegistrarRecepcion = new Button();
            lblObservacionRecepcion = new Label();
            txtObservacionRecepcion = new TextBox();
            chkRecepcionCompleta = new CheckBox();
            btnConfirmarRecepcion = new Button();
            btnReportarIncidenteRecepcion = new Button();
            grpDespacho = new GroupBox();
            lblEntregasEnDespacho = new Label();
            lvEntregasEnDespacho = new ListView();
            colEntregasEnDespachoNumero = new ColumnHeader();
            colEntregasEnDespachoPedido = new ColumnHeader();
            colEntregasEnDespachoCliente = new ColumnHeader();
            colEntregasEnDespachoOrigen = new ColumnHeader();
            colEntregasEnDespachoDestino = new ColumnHeader();
            colEntregasEnDespachoBultos = new ColumnHeader();
            colEntregasEnDespachoEstado = new ColumnHeader();
            lblTransportista = new Label();
            txtTransportista = new TextBox();
            lblFlete = new Label();
            txtFlete = new TextBox();
            lblFechaRetiro = new Label();
            dtpFechaRetiro = new DateTimePicker();
            lblDocumento = new Label();
            txtDocumento = new TextBox();
            btnEmitirDocumento = new Button();
            chkConformidadRetiro = new CheckBox();
            lblAyudaDespacho = new Label();
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
            lblRol.Text = "Rol: Operario de Despacho";
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
            // grpRecepcion
            // 
            grpRecepcion.Controls.Add(lblFiltroEntrega);
            grpRecepcion.Controls.Add(txtFiltroEntrega);
            grpRecepcion.Controls.Add(btnBuscar);
            grpRecepcion.Controls.Add(btnLimpiar);
            grpRecepcion.Controls.Add(lblEntregasPreparadas);
            grpRecepcion.Controls.Add(lvEntregasPreparadas);
            grpRecepcion.Controls.Add(lblControlRecepcion);
            grpRecepcion.Controls.Add(lvControlRecepcion);
            grpRecepcion.Controls.Add(lblCantidadRecibida);
            grpRecepcion.Controls.Add(txtCantidadRecibida);
            grpRecepcion.Controls.Add(btnRegistrarRecepcion);
            grpRecepcion.Controls.Add(lblObservacionRecepcion);
            grpRecepcion.Controls.Add(txtObservacionRecepcion);
            grpRecepcion.Controls.Add(chkRecepcionCompleta);
            grpRecepcion.Controls.Add(btnConfirmarRecepcion);
            grpRecepcion.Controls.Add(btnReportarIncidenteRecepcion);
            grpRecepcion.TabStop = false;
            grpRecepcion.Text = "Recepción de pedidos preparados";
            grpRecepcion.Location = new Point(16, 164);
            grpRecepcion.Name = "grpRecepcion";
            grpRecepcion.Size = new Size(636, 610);
            grpRecepcion.TabIndex = 8;
            // 
            // lblFiltroEntrega
            // 
            lblFiltroEntrega.Text = "N.º de orden de entrega";
            lblFiltroEntrega.Location = new Point(12, 26);
            lblFiltroEntrega.Name = "lblFiltroEntrega";
            lblFiltroEntrega.Size = new Size(200, 20);
            lblFiltroEntrega.TabIndex = 9;
            // 
            // txtFiltroEntrega
            // 
            txtFiltroEntrega.Location = new Point(12, 48);
            txtFiltroEntrega.Name = "txtFiltroEntrega";
            txtFiltroEntrega.Size = new Size(200, 23);
            txtFiltroEntrega.TabIndex = 10;
            // 
            // btnBuscar
            // 
            btnBuscar.Text = "Buscar";
            btnBuscar.Location = new Point(224, 42);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(196, 34);
            btnBuscar.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Location = new Point(428, 42);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(196, 34);
            btnLimpiar.TabIndex = 12;
            // 
            // lblEntregasPreparadas
            // 
            lblEntregasPreparadas.Text = "Órdenes de entrega de pedidos preparados";
            lblEntregasPreparadas.Location = new Point(12, 90);
            lblEntregasPreparadas.Name = "lblEntregasPreparadas";
            lblEntregasPreparadas.Size = new Size(612, 20);
            lblEntregasPreparadas.TabIndex = 13;
            // 
            // lvEntregasPreparadas
            // 
            lvEntregasPreparadas.Columns.AddRange(new ColumnHeader[] { colEntregasPreparadasNumero, colEntregasPreparadasPedido, colEntregasPreparadasCliente, colEntregasPreparadasOrigen, colEntregasPreparadasDestino, colEntregasPreparadasBultos, colEntregasPreparadasEstado });
            lvEntregasPreparadas.FullRowSelect = true;
            lvEntregasPreparadas.GridLines = true;
            lvEntregasPreparadas.Location = new Point(12, 112);
            lvEntregasPreparadas.Name = "lvEntregasPreparadas";
            lvEntregasPreparadas.Size = new Size(612, 130);
            lvEntregasPreparadas.TabIndex = 14;
            lvEntregasPreparadas.UseCompatibleStateImageBehavior = false;
            lvEntregasPreparadas.View = View.Details;
            // 
            // colEntregasPreparadasNumero
            // 
            colEntregasPreparadasNumero.Text = "N.º de orden de entrega";
            colEntregasPreparadasNumero.Width = 135;
            // 
            // colEntregasPreparadasPedido
            // 
            colEntregasPreparadasPedido.Text = "Pedido";
            colEntregasPreparadasPedido.Width = 75;
            // 
            // colEntregasPreparadasCliente
            // 
            colEntregasPreparadasCliente.Text = "Cliente";
            colEntregasPreparadasCliente.Width = 98;
            // 
            // colEntregasPreparadasOrigen
            // 
            colEntregasPreparadasOrigen.Text = "Origen";
            colEntregasPreparadasOrigen.Width = 95;
            // 
            // colEntregasPreparadasDestino
            // 
            colEntregasPreparadasDestino.Text = "Destino";
            colEntregasPreparadasDestino.Width = 75;
            // 
            // colEntregasPreparadasBultos
            // 
            colEntregasPreparadasBultos.Text = "Bultos";
            colEntregasPreparadasBultos.Width = 45;
            // 
            // colEntregasPreparadasEstado
            // 
            colEntregasPreparadasEstado.Text = "Estado";
            colEntregasPreparadasEstado.Width = 85;
            // 
            // lblControlRecepcion
            // 
            lblControlRecepcion.Text = "Control de bultos recibidos";
            lblControlRecepcion.Location = new Point(12, 252);
            lblControlRecepcion.Name = "lblControlRecepcion";
            lblControlRecepcion.Size = new Size(612, 20);
            lblControlRecepcion.TabIndex = 15;
            // 
            // lvControlRecepcion
            // 
            lvControlRecepcion.Columns.AddRange(new ColumnHeader[] { colControlRecepcionSku, colControlRecepcionProducto, colControlRecepcionCantidad, colControlRecepcionRecibida, colControlRecepcionDiferencia });
            lvControlRecepcion.FullRowSelect = true;
            lvControlRecepcion.GridLines = true;
            lvControlRecepcion.Location = new Point(12, 274);
            lvControlRecepcion.Name = "lvControlRecepcion";
            lvControlRecepcion.Size = new Size(612, 120);
            lvControlRecepcion.TabIndex = 16;
            lvControlRecepcion.UseCompatibleStateImageBehavior = false;
            lvControlRecepcion.View = View.Details;
            // 
            // colControlRecepcionSku
            // 
            colControlRecepcionSku.Text = "SKU";
            colControlRecepcionSku.Width = 75;
            // 
            // colControlRecepcionProducto
            // 
            colControlRecepcionProducto.Text = "Producto";
            colControlRecepcionProducto.Width = 160;
            // 
            // colControlRecepcionCantidad
            // 
            colControlRecepcionCantidad.Text = "Cantidad según la orden";
            colControlRecepcionCantidad.Width = 150;
            // 
            // colControlRecepcionRecibida
            // 
            colControlRecepcionRecibida.Text = "Cantidad recibida";
            colControlRecepcionRecibida.Width = 115;
            // 
            // colControlRecepcionDiferencia
            // 
            colControlRecepcionDiferencia.Text = "Diferencia";
            colControlRecepcionDiferencia.Width = 90;
            // 
            // lblCantidadRecibida
            // 
            lblCantidadRecibida.Text = "Cantidad recibida";
            lblCantidadRecibida.Location = new Point(12, 404);
            lblCantidadRecibida.Name = "lblCantidadRecibida";
            lblCantidadRecibida.Size = new Size(180, 20);
            lblCantidadRecibida.TabIndex = 17;
            // 
            // txtCantidadRecibida
            // 
            txtCantidadRecibida.Location = new Point(12, 426);
            txtCantidadRecibida.Name = "txtCantidadRecibida";
            txtCantidadRecibida.Size = new Size(140, 23);
            txtCantidadRecibida.TabIndex = 18;
            // 
            // btnRegistrarRecepcion
            // 
            btnRegistrarRecepcion.Text = "Registrar cantidad recibida";
            btnRegistrarRecepcion.Location = new Point(200, 420);
            btnRegistrarRecepcion.Name = "btnRegistrarRecepcion";
            btnRegistrarRecepcion.Size = new Size(260, 34);
            btnRegistrarRecepcion.TabIndex = 19;
            // 
            // lblObservacionRecepcion
            // 
            lblObservacionRecepcion.Text = "Observación de recepción (hasta 200 caracteres)";
            lblObservacionRecepcion.Location = new Point(12, 466);
            lblObservacionRecepcion.Name = "lblObservacionRecepcion";
            lblObservacionRecepcion.Size = new Size(400, 20);
            lblObservacionRecepcion.TabIndex = 20;
            // 
            // txtObservacionRecepcion
            // 
            txtObservacionRecepcion.Location = new Point(12, 488);
            txtObservacionRecepcion.Name = "txtObservacionRecepcion";
            txtObservacionRecepcion.Size = new Size(612, 23);
            txtObservacionRecepcion.TabIndex = 21;
            // 
            // chkRecepcionCompleta
            // 
            chkRecepcionCompleta.Text = "Los preparados se recibieron completos y conformes";
            chkRecepcionCompleta.Location = new Point(12, 522);
            chkRecepcionCompleta.Name = "chkRecepcionCompleta";
            chkRecepcionCompleta.Size = new Size(500, 24);
            chkRecepcionCompleta.TabIndex = 22;
            // 
            // btnConfirmarRecepcion
            // 
            btnConfirmarRecepcion.Text = "Confirmar recepción";
            btnConfirmarRecepcion.Location = new Point(12, 560);
            btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            btnConfirmarRecepcion.Size = new Size(300, 34);
            btnConfirmarRecepcion.TabIndex = 23;
            // 
            // btnReportarIncidenteRecepcion
            // 
            btnReportarIncidenteRecepcion.Text = "Reportar incidente";
            btnReportarIncidenteRecepcion.Location = new Point(320, 560);
            btnReportarIncidenteRecepcion.Name = "btnReportarIncidenteRecepcion";
            btnReportarIncidenteRecepcion.Size = new Size(304, 34);
            btnReportarIncidenteRecepcion.TabIndex = 24;
            // 
            // grpDespacho
            // 
            grpDespacho.Controls.Add(lblEntregasEnDespacho);
            grpDespacho.Controls.Add(lvEntregasEnDespacho);
            grpDespacho.Controls.Add(lblTransportista);
            grpDespacho.Controls.Add(txtTransportista);
            grpDespacho.Controls.Add(lblFlete);
            grpDespacho.Controls.Add(txtFlete);
            grpDespacho.Controls.Add(lblFechaRetiro);
            grpDespacho.Controls.Add(dtpFechaRetiro);
            grpDespacho.Controls.Add(lblDocumento);
            grpDespacho.Controls.Add(txtDocumento);
            grpDespacho.Controls.Add(btnEmitirDocumento);
            grpDespacho.Controls.Add(chkConformidadRetiro);
            grpDespacho.Controls.Add(lblAyudaDespacho);
            grpDespacho.Controls.Add(btnCerrarDespacho);
            grpDespacho.Controls.Add(btnReportarIncidenteDespacho);
            grpDespacho.TabStop = false;
            grpDespacho.Text = "Retiro y cierre del despacho";
            grpDespacho.Location = new Point(668, 164);
            grpDespacho.Name = "grpDespacho";
            grpDespacho.Size = new Size(636, 610);
            grpDespacho.TabIndex = 25;
            // 
            // lblEntregasEnDespacho
            // 
            lblEntregasEnDespacho.Text = "Órdenes de entrega disponibles para el retiro";
            lblEntregasEnDespacho.Location = new Point(12, 26);
            lblEntregasEnDespacho.Name = "lblEntregasEnDespacho";
            lblEntregasEnDespacho.Size = new Size(612, 20);
            lblEntregasEnDespacho.TabIndex = 26;
            // 
            // lvEntregasEnDespacho
            // 
            lvEntregasEnDespacho.Columns.AddRange(new ColumnHeader[] { colEntregasEnDespachoNumero, colEntregasEnDespachoPedido, colEntregasEnDespachoCliente, colEntregasEnDespachoOrigen, colEntregasEnDespachoDestino, colEntregasEnDespachoBultos, colEntregasEnDespachoEstado });
            lvEntregasEnDespacho.FullRowSelect = true;
            lvEntregasEnDespacho.GridLines = true;
            lvEntregasEnDespacho.Location = new Point(12, 48);
            lvEntregasEnDespacho.Name = "lvEntregasEnDespacho";
            lvEntregasEnDespacho.Size = new Size(612, 130);
            lvEntregasEnDespacho.TabIndex = 27;
            lvEntregasEnDespacho.UseCompatibleStateImageBehavior = false;
            lvEntregasEnDespacho.View = View.Details;
            // 
            // colEntregasEnDespachoNumero
            // 
            colEntregasEnDespachoNumero.Text = "N.º de orden de entrega";
            colEntregasEnDespachoNumero.Width = 135;
            // 
            // colEntregasEnDespachoPedido
            // 
            colEntregasEnDespachoPedido.Text = "Pedido";
            colEntregasEnDespachoPedido.Width = 75;
            // 
            // colEntregasEnDespachoCliente
            // 
            colEntregasEnDespachoCliente.Text = "Cliente";
            colEntregasEnDespachoCliente.Width = 98;
            // 
            // colEntregasEnDespachoOrigen
            // 
            colEntregasEnDespachoOrigen.Text = "Origen";
            colEntregasEnDespachoOrigen.Width = 95;
            // 
            // colEntregasEnDespachoDestino
            // 
            colEntregasEnDespachoDestino.Text = "Destino";
            colEntregasEnDespachoDestino.Width = 75;
            // 
            // colEntregasEnDespachoBultos
            // 
            colEntregasEnDespachoBultos.Text = "Bultos";
            colEntregasEnDespachoBultos.Width = 45;
            // 
            // colEntregasEnDespachoEstado
            // 
            colEntregasEnDespachoEstado.Text = "Estado";
            colEntregasEnDespachoEstado.Width = 85;
            // 
            // lblTransportista
            // 
            lblTransportista.Text = "Identificación del transportista";
            lblTransportista.Location = new Point(12, 190);
            lblTransportista.Name = "lblTransportista";
            lblTransportista.Size = new Size(300, 20);
            lblTransportista.TabIndex = 28;
            // 
            // txtTransportista
            // 
            txtTransportista.Location = new Point(12, 212);
            txtTransportista.Name = "txtTransportista";
            txtTransportista.Size = new Size(300, 23);
            txtTransportista.TabIndex = 29;
            // 
            // lblFlete
            // 
            lblFlete.Text = "Referencia del flete (traslados)";
            lblFlete.Location = new Point(324, 190);
            lblFlete.Name = "lblFlete";
            lblFlete.Size = new Size(300, 20);
            lblFlete.TabIndex = 30;
            // 
            // txtFlete
            // 
            txtFlete.Location = new Point(324, 212);
            txtFlete.Name = "txtFlete";
            txtFlete.Size = new Size(300, 23);
            txtFlete.TabIndex = 31;
            // 
            // lblFechaRetiro
            // 
            lblFechaRetiro.Text = "Fecha de retiro";
            lblFechaRetiro.Location = new Point(12, 246);
            lblFechaRetiro.Name = "lblFechaRetiro";
            lblFechaRetiro.Size = new Size(170, 20);
            lblFechaRetiro.TabIndex = 32;
            // 
            // dtpFechaRetiro
            // 
            dtpFechaRetiro.Format = DateTimePickerFormat.Short;
            dtpFechaRetiro.Value = new DateTime(2026, 10, 12, 0, 0, 0, 0);
            dtpFechaRetiro.Location = new Point(12, 268);
            dtpFechaRetiro.Name = "dtpFechaRetiro";
            dtpFechaRetiro.Size = new Size(170, 23);
            dtpFechaRetiro.TabIndex = 33;
            // 
            // lblDocumento
            // 
            lblDocumento.Text = "Documento de salida";
            lblDocumento.Location = new Point(196, 246);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(196, 20);
            lblDocumento.TabIndex = 34;
            // 
            // txtDocumento
            // 
            txtDocumento.Enabled = false;
            txtDocumento.Location = new Point(196, 268);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(196, 23);
            txtDocumento.TabIndex = 35;
            // 
            // btnEmitirDocumento
            // 
            btnEmitirDocumento.Text = "Emitir remito / guía de traslado";
            btnEmitirDocumento.Location = new Point(404, 262);
            btnEmitirDocumento.Name = "btnEmitirDocumento";
            btnEmitirDocumento.Size = new Size(220, 34);
            btnEmitirDocumento.TabIndex = 36;
            // 
            // chkConformidadRetiro
            // 
            chkConformidadRetiro.Text = "El transportista presta conformidad de retiro";
            chkConformidadRetiro.Location = new Point(12, 308);
            chkConformidadRetiro.Name = "chkConformidadRetiro";
            chkConformidadRetiro.Size = new Size(600, 24);
            chkConformidadRetiro.TabIndex = 37;
            // 
            // lblAyudaDespacho
            // 
            lblAyudaDespacho.Text = "Emitir o imprimir el documento no descuenta stock. El egreso se registra una sola vez al cerrar el despacho.";
            lblAyudaDespacho.Location = new Point(12, 338);
            lblAyudaDespacho.Name = "lblAyudaDespacho";
            lblAyudaDespacho.Size = new Size(612, 40);
            lblAyudaDespacho.TabIndex = 38;
            // 
            // btnCerrarDespacho
            // 
            btnCerrarDespacho.Text = "Cerrar despacho";
            btnCerrarDespacho.Location = new Point(12, 388);
            btnCerrarDespacho.Name = "btnCerrarDespacho";
            btnCerrarDespacho.Size = new Size(300, 34);
            btnCerrarDespacho.TabIndex = 39;
            // 
            // btnReportarIncidenteDespacho
            // 
            btnReportarIncidenteDespacho.Text = "Reportar incidente";
            btnReportarIncidenteDespacho.Location = new Point(320, 388);
            btnReportarIncidenteDespacho.Name = "btnReportarIncidenteDespacho";
            btnReportarIncidenteDespacho.Size = new Size(304, 34);
            btnReportarIncidenteDespacho.TabIndex = 40;
            // 
            // RecepcionDespachoPedidosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 901);
            Controls.Add(lblTitulo);
            Controls.Add(lblEmpresa);
            Controls.Add(grpContexto);
            Controls.Add(grpRecepcion);
            Controls.Add(grpDespacho);
            Name = "RecepcionDespachoPedidosForm";
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
        private System.Windows.Forms.Label lblFechaTrabajo;
        private System.Windows.Forms.DateTimePicker dtpFechaTrabajo;
        private System.Windows.Forms.GroupBox grpRecepcion;
        private System.Windows.Forms.Label lblFiltroEntrega;
        private System.Windows.Forms.TextBox txtFiltroEntrega;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblEntregasPreparadas;
        private System.Windows.Forms.ListView lvEntregasPreparadas;
        private System.Windows.Forms.ColumnHeader colEntregasPreparadasNumero;
        private System.Windows.Forms.ColumnHeader colEntregasPreparadasPedido;
        private System.Windows.Forms.ColumnHeader colEntregasPreparadasCliente;
        private System.Windows.Forms.ColumnHeader colEntregasPreparadasOrigen;
        private System.Windows.Forms.ColumnHeader colEntregasPreparadasDestino;
        private System.Windows.Forms.ColumnHeader colEntregasPreparadasBultos;
        private System.Windows.Forms.ColumnHeader colEntregasPreparadasEstado;
        private System.Windows.Forms.Label lblControlRecepcion;
        private System.Windows.Forms.ListView lvControlRecepcion;
        private System.Windows.Forms.ColumnHeader colControlRecepcionSku;
        private System.Windows.Forms.ColumnHeader colControlRecepcionProducto;
        private System.Windows.Forms.ColumnHeader colControlRecepcionCantidad;
        private System.Windows.Forms.ColumnHeader colControlRecepcionRecibida;
        private System.Windows.Forms.ColumnHeader colControlRecepcionDiferencia;
        private System.Windows.Forms.Label lblCantidadRecibida;
        private System.Windows.Forms.TextBox txtCantidadRecibida;
        private System.Windows.Forms.Button btnRegistrarRecepcion;
        private System.Windows.Forms.Label lblObservacionRecepcion;
        private System.Windows.Forms.TextBox txtObservacionRecepcion;
        private System.Windows.Forms.CheckBox chkRecepcionCompleta;
        private System.Windows.Forms.Button btnConfirmarRecepcion;
        private System.Windows.Forms.Button btnReportarIncidenteRecepcion;
        private System.Windows.Forms.GroupBox grpDespacho;
        private System.Windows.Forms.Label lblEntregasEnDespacho;
        private System.Windows.Forms.ListView lvEntregasEnDespacho;
        private System.Windows.Forms.ColumnHeader colEntregasEnDespachoNumero;
        private System.Windows.Forms.ColumnHeader colEntregasEnDespachoPedido;
        private System.Windows.Forms.ColumnHeader colEntregasEnDespachoCliente;
        private System.Windows.Forms.ColumnHeader colEntregasEnDespachoOrigen;
        private System.Windows.Forms.ColumnHeader colEntregasEnDespachoDestino;
        private System.Windows.Forms.ColumnHeader colEntregasEnDespachoBultos;
        private System.Windows.Forms.ColumnHeader colEntregasEnDespachoEstado;
        private System.Windows.Forms.Label lblTransportista;
        private System.Windows.Forms.TextBox txtTransportista;
        private System.Windows.Forms.Label lblFlete;
        private System.Windows.Forms.TextBox txtFlete;
        private System.Windows.Forms.Label lblFechaRetiro;
        private System.Windows.Forms.DateTimePicker dtpFechaRetiro;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnEmitirDocumento;
        private System.Windows.Forms.CheckBox chkConformidadRetiro;
        private System.Windows.Forms.Label lblAyudaDespacho;
        private System.Windows.Forms.Button btnCerrarDespacho;
        private System.Windows.Forms.Button btnReportarIncidenteDespacho;
    }
}
