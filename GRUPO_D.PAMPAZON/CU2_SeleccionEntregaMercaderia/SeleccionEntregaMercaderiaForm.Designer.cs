namespace GRUPO_D.PAMPAZON.CU2_SeleccionEntregaMercaderia
{
    partial class SeleccionEntregaMercaderiaForm
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
            grpOrdenesSeleccion = new GroupBox();
            lvOrdenesSeleccion = new ListView();
            colOrdenesSeleccionNumero = new ColumnHeader();
            colOrdenesSeleccionFechaCorte = new ColumnHeader();
            colOrdenesSeleccionCorte = new ColumnHeader();
            colOrdenesSeleccionModalidad = new ColumnHeader();
            colOrdenesSeleccionPedidos = new ColumnHeader();
            colOrdenesSeleccionRenglones = new ColumnHeader();
            colOrdenesSeleccionEstado = new ColumnHeader();
            grpDetalleSeleccion = new GroupBox();
            lblOrdenSeleccion = new Label();
            txtOrdenSeleccion = new TextBox();
            lblModalidad = new Label();
            txtModalidad = new TextBox();
            lblCorte = new Label();
            txtCorte = new TextBox();
            lblEmitidaPor = new Label();
            txtEmitidaPor = new TextBox();
            lvRenglones = new ListView();
            colRenglonesCliente = new ColumnHeader();
            colRenglonesSku = new ColumnHeader();
            colRenglonesProducto = new ColumnHeader();
            colRenglonesUbicacion = new ColumnHeader();
            colRenglonesRequerida = new ColumnHeader();
            colRenglonesRetirada = new ColumnHeader();
            colRenglonesReparto = new ColumnHeader();
            lblCantidadRetirada = new Label();
            txtCantidadRetirada = new TextBox();
            btnRegistrarRetiro = new Button();
            lblAyudaRetiro = new Label();
            grpConfirmacion = new GroupBox();
            lblObservacion = new Label();
            txtObservacion = new TextBox();
            chkEntregaPreparacion = new CheckBox();
            lblServicio = new Label();
            txtServicio = new TextBox();
            btnConfirmarEntrega = new Button();
            btnReportarIncidente = new Button();
            grpContexto.SuspendLayout();
            grpOrdenesSeleccion.SuspendLayout();
            grpDetalleSeleccion.SuspendLayout();
            grpConfirmacion.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Text = "Selección y Entrega de Mercadería";
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
            lblRol.Text = "Rol: Operario de Almacén";
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
            // grpOrdenesSeleccion
            // 
            grpOrdenesSeleccion.Controls.Add(lvOrdenesSeleccion);
            grpOrdenesSeleccion.TabStop = false;
            grpOrdenesSeleccion.Text = "Órdenes de selección pendientes de cumplir";
            grpOrdenesSeleccion.Location = new Point(16, 170);
            grpOrdenesSeleccion.Name = "grpOrdenesSeleccion";
            grpOrdenesSeleccion.Size = new Size(1288, 200);
            grpOrdenesSeleccion.TabIndex = 8;
            // 
            // lvOrdenesSeleccion
            // 
            lvOrdenesSeleccion.Columns.AddRange(new ColumnHeader[] { colOrdenesSeleccionNumero, colOrdenesSeleccionFechaCorte, colOrdenesSeleccionCorte, colOrdenesSeleccionModalidad, colOrdenesSeleccionPedidos, colOrdenesSeleccionRenglones, colOrdenesSeleccionEstado });
            lvOrdenesSeleccion.FullRowSelect = true;
            lvOrdenesSeleccion.GridLines = true;
            lvOrdenesSeleccion.Location = new Point(12, 26);
            lvOrdenesSeleccion.Name = "lvOrdenesSeleccion";
            lvOrdenesSeleccion.Size = new Size(1262, 162);
            lvOrdenesSeleccion.TabIndex = 9;
            lvOrdenesSeleccion.UseCompatibleStateImageBehavior = false;
            lvOrdenesSeleccion.View = View.Details;
            // 
            // colOrdenesSeleccionNumero
            // 
            colOrdenesSeleccionNumero.Text = "N.º de selección";
            colOrdenesSeleccionNumero.Width = 130;
            // 
            // colOrdenesSeleccionFechaCorte
            // 
            colOrdenesSeleccionFechaCorte.Text = "Fecha de corte";
            colOrdenesSeleccionFechaCorte.Width = 120;
            // 
            // colOrdenesSeleccionCorte
            // 
            colOrdenesSeleccionCorte.Text = "Corte";
            colOrdenesSeleccionCorte.Width = 90;
            // 
            // colOrdenesSeleccionModalidad
            // 
            colOrdenesSeleccionModalidad.Text = "Modalidad";
            colOrdenesSeleccionModalidad.Width = 140;
            // 
            // colOrdenesSeleccionPedidos
            // 
            colOrdenesSeleccionPedidos.Text = "Pedidos vinculados";
            colOrdenesSeleccionPedidos.Width = 140;
            // 
            // colOrdenesSeleccionRenglones
            // 
            colOrdenesSeleccionRenglones.Text = "Renglones";
            colOrdenesSeleccionRenglones.Width = 100;
            // 
            // colOrdenesSeleccionEstado
            // 
            colOrdenesSeleccionEstado.Text = "Estado";
            colOrdenesSeleccionEstado.Width = 150;
            // 
            // grpDetalleSeleccion
            // 
            grpDetalleSeleccion.Controls.Add(lblOrdenSeleccion);
            grpDetalleSeleccion.Controls.Add(txtOrdenSeleccion);
            grpDetalleSeleccion.Controls.Add(lblModalidad);
            grpDetalleSeleccion.Controls.Add(txtModalidad);
            grpDetalleSeleccion.Controls.Add(lblCorte);
            grpDetalleSeleccion.Controls.Add(txtCorte);
            grpDetalleSeleccion.Controls.Add(lblEmitidaPor);
            grpDetalleSeleccion.Controls.Add(txtEmitidaPor);
            grpDetalleSeleccion.Controls.Add(lvRenglones);
            grpDetalleSeleccion.Controls.Add(lblCantidadRetirada);
            grpDetalleSeleccion.Controls.Add(txtCantidadRetirada);
            grpDetalleSeleccion.Controls.Add(btnRegistrarRetiro);
            grpDetalleSeleccion.Controls.Add(lblAyudaRetiro);
            grpDetalleSeleccion.TabStop = false;
            grpDetalleSeleccion.Text = "Detalle de la selección";
            grpDetalleSeleccion.Location = new Point(16, 382);
            grpDetalleSeleccion.Name = "grpDetalleSeleccion";
            grpDetalleSeleccion.Size = new Size(1288, 332);
            grpDetalleSeleccion.TabIndex = 10;
            // 
            // lblOrdenSeleccion
            // 
            lblOrdenSeleccion.Text = "Orden de selección";
            lblOrdenSeleccion.Location = new Point(14, 26);
            lblOrdenSeleccion.Name = "lblOrdenSeleccion";
            lblOrdenSeleccion.Size = new Size(131, 20);
            lblOrdenSeleccion.TabIndex = 11;
            // 
            // txtOrdenSeleccion
            // 
            txtOrdenSeleccion.Enabled = false;
            txtOrdenSeleccion.Location = new Point(14, 48);
            txtOrdenSeleccion.Name = "txtOrdenSeleccion";
            txtOrdenSeleccion.Size = new Size(150, 23);
            txtOrdenSeleccion.TabIndex = 12;
            // 
            // lblModalidad
            // 
            lblModalidad.Text = "Modalidad";
            lblModalidad.Location = new Point(184, 26);
            lblModalidad.Name = "lblModalidad";
            lblModalidad.Size = new Size(140, 20);
            lblModalidad.TabIndex = 13;
            // 
            // txtModalidad
            // 
            txtModalidad.Enabled = false;
            txtModalidad.Location = new Point(184, 48);
            txtModalidad.Name = "txtModalidad";
            txtModalidad.Size = new Size(160, 23);
            txtModalidad.TabIndex = 14;
            // 
            // lblCorte
            // 
            lblCorte.Text = "Corte";
            lblCorte.Location = new Point(364, 26);
            lblCorte.Name = "lblCorte";
            lblCorte.Size = new Size(140, 20);
            lblCorte.TabIndex = 15;
            // 
            // txtCorte
            // 
            txtCorte.Enabled = false;
            txtCorte.Location = new Point(364, 48);
            txtCorte.Name = "txtCorte";
            txtCorte.Size = new Size(120, 23);
            txtCorte.TabIndex = 16;
            // 
            // lblEmitidaPor
            // 
            lblEmitidaPor.Text = "Emitida por (Jefe de Preparación)";
            lblEmitidaPor.Location = new Point(504, 26);
            lblEmitidaPor.Name = "lblEmitidaPor";
            lblEmitidaPor.Size = new Size(239, 20);
            lblEmitidaPor.TabIndex = 17;
            // 
            // txtEmitidaPor
            // 
            txtEmitidaPor.Enabled = false;
            txtEmitidaPor.Location = new Point(504, 48);
            txtEmitidaPor.Name = "txtEmitidaPor";
            txtEmitidaPor.Size = new Size(260, 23);
            txtEmitidaPor.TabIndex = 18;
            // 
            // lvRenglones
            // 
            lvRenglones.Columns.AddRange(new ColumnHeader[] { colRenglonesCliente, colRenglonesSku, colRenglonesProducto, colRenglonesUbicacion, colRenglonesRequerida, colRenglonesRetirada, colRenglonesReparto });
            lvRenglones.FullRowSelect = true;
            lvRenglones.GridLines = true;
            lvRenglones.Location = new Point(12, 86);
            lvRenglones.Name = "lvRenglones";
            lvRenglones.Size = new Size(1262, 170);
            lvRenglones.TabIndex = 19;
            lvRenglones.UseCompatibleStateImageBehavior = false;
            lvRenglones.View = View.Details;
            // 
            // colRenglonesCliente
            // 
            colRenglonesCliente.Text = "Cliente";
            colRenglonesCliente.Width = 190;
            // 
            // colRenglonesSku
            // 
            colRenglonesSku.Text = "SKU";
            colRenglonesSku.Width = 90;
            // 
            // colRenglonesProducto
            // 
            colRenglonesProducto.Text = "Producto";
            colRenglonesProducto.Width = 220;
            // 
            // colRenglonesUbicacion
            // 
            colRenglonesUbicacion.Text = "Ubicación (X-Y-Z)";
            colRenglonesUbicacion.Width = 130;
            // 
            // colRenglonesRequerida
            // 
            colRenglonesRequerida.Text = "Cantidad requerida";
            colRenglonesRequerida.Width = 130;
            // 
            // colRenglonesRetirada
            // 
            colRenglonesRetirada.Text = "Cantidad retirada";
            colRenglonesRetirada.Width = 130;
            // 
            // colRenglonesReparto
            // 
            colRenglonesReparto.Text = "Reparto entre órdenes de preparación";
            colRenglonesReparto.Width = 330;
            // 
            // lblCantidadRetirada
            // 
            lblCantidadRetirada.Text = "Cantidad retirada del renglón";
            lblCantidadRetirada.Location = new Point(14, 266);
            lblCantidadRetirada.Name = "lblCantidadRetirada";
            lblCantidadRetirada.Size = new Size(180, 20);
            lblCantidadRetirada.TabIndex = 20;
            // 
            // txtCantidadRetirada
            // 
            txtCantidadRetirada.Location = new Point(14, 288);
            txtCantidadRetirada.Name = "txtCantidadRetirada";
            txtCantidadRetirada.Size = new Size(140, 23);
            txtCantidadRetirada.TabIndex = 21;
            // 
            // btnRegistrarRetiro
            // 
            btnRegistrarRetiro.Text = "Registrar cantidad retirada";
            btnRegistrarRetiro.Location = new Point(200, 282);
            btnRegistrarRetiro.Name = "btnRegistrarRetiro";
            btnRegistrarRetiro.Size = new Size(260, 34);
            btnRegistrarRetiro.TabIndex = 22;
            // 
            // lblAyudaRetiro
            // 
            lblAyudaRetiro.Text = "Elija un renglón, ingrese la cantidad retirada. Debe coincidir con la requerida.";
            lblAyudaRetiro.Location = new Point(480, 290);
            lblAyudaRetiro.Name = "lblAyudaRetiro";
            lblAyudaRetiro.Size = new Size(800, 24);
            lblAyudaRetiro.TabIndex = 23;
            // 
            // grpConfirmacion
            // 
            grpConfirmacion.Controls.Add(lblObservacion);
            grpConfirmacion.Controls.Add(txtObservacion);
            grpConfirmacion.Controls.Add(chkEntregaPreparacion);
            grpConfirmacion.Controls.Add(lblServicio);
            grpConfirmacion.Controls.Add(txtServicio);
            grpConfirmacion.Controls.Add(btnConfirmarEntrega);
            grpConfirmacion.Controls.Add(btnReportarIncidente);
            grpConfirmacion.TabStop = false;
            grpConfirmacion.Text = "Confirmación de la entrega";
            grpConfirmacion.Location = new Point(16, 726);
            grpConfirmacion.Name = "grpConfirmacion";
            grpConfirmacion.Size = new Size(1288, 140);
            grpConfirmacion.TabIndex = 24;
            // 
            // lblObservacion
            // 
            lblObservacion.Text = "Observación de diferencia (hasta 200 caracteres)";
            lblObservacion.Location = new Point(14, 22);
            lblObservacion.Name = "lblObservacion";
            lblObservacion.Size = new Size(345, 20);
            lblObservacion.TabIndex = 25;
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(14, 44);
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(560, 76);
            txtObservacion.TabIndex = 26;
            // 
            // chkEntregaPreparacion
            // 
            chkEntregaPreparacion.Text = "La mercadería fue entregada a la sección Preparación";
            chkEntregaPreparacion.Location = new Point(600, 26);
            chkEntregaPreparacion.Name = "chkEntregaPreparacion";
            chkEntregaPreparacion.Size = new Size(395, 24);
            chkEntregaPreparacion.TabIndex = 27;
            // 
            // lblServicio
            // 
            lblServicio.Text = "Servicio a registrar";
            lblServicio.Location = new Point(600, 70);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(146, 20);
            lblServicio.TabIndex = 28;
            // 
            // txtServicio
            // 
            txtServicio.Enabled = false;
            txtServicio.Location = new Point(756, 66);
            txtServicio.Name = "txtServicio";
            txtServicio.Size = new Size(200, 23);
            txtServicio.TabIndex = 29;
            // 
            // btnConfirmarEntrega
            // 
            btnConfirmarEntrega.Text = "Confirmar entrega";
            btnConfirmarEntrega.Location = new Point(1010, 26);
            btnConfirmarEntrega.Name = "btnConfirmarEntrega";
            btnConfirmarEntrega.Size = new Size(260, 34);
            btnConfirmarEntrega.TabIndex = 30;
            // 
            // btnReportarIncidente
            // 
            btnReportarIncidente.Text = "Reportar incidente";
            btnReportarIncidente.Location = new Point(1010, 70);
            btnReportarIncidente.Name = "btnReportarIncidente";
            btnReportarIncidente.Size = new Size(260, 34);
            btnReportarIncidente.TabIndex = 31;
            // 
            // SeleccionEntregaMercaderiaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 901);
            Controls.Add(lblTitulo);
            Controls.Add(lblEmpresa);
            Controls.Add(grpContexto);
            Controls.Add(grpOrdenesSeleccion);
            Controls.Add(grpDetalleSeleccion);
            Controls.Add(grpConfirmacion);
            Name = "SeleccionEntregaMercaderiaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pampazon - Selección y Entrega de Mercadería";
            grpConfirmacion.ResumeLayout(false);
            grpDetalleSeleccion.ResumeLayout(false);
            grpOrdenesSeleccion.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpOrdenesSeleccion;
        private System.Windows.Forms.ListView lvOrdenesSeleccion;
        private System.Windows.Forms.ColumnHeader colOrdenesSeleccionNumero;
        private System.Windows.Forms.ColumnHeader colOrdenesSeleccionFechaCorte;
        private System.Windows.Forms.ColumnHeader colOrdenesSeleccionCorte;
        private System.Windows.Forms.ColumnHeader colOrdenesSeleccionModalidad;
        private System.Windows.Forms.ColumnHeader colOrdenesSeleccionPedidos;
        private System.Windows.Forms.ColumnHeader colOrdenesSeleccionRenglones;
        private System.Windows.Forms.ColumnHeader colOrdenesSeleccionEstado;
        private System.Windows.Forms.GroupBox grpDetalleSeleccion;
        private System.Windows.Forms.Label lblOrdenSeleccion;
        private System.Windows.Forms.TextBox txtOrdenSeleccion;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.TextBox txtModalidad;
        private System.Windows.Forms.Label lblCorte;
        private System.Windows.Forms.TextBox txtCorte;
        private System.Windows.Forms.Label lblEmitidaPor;
        private System.Windows.Forms.TextBox txtEmitidaPor;
        private System.Windows.Forms.ListView lvRenglones;
        private System.Windows.Forms.ColumnHeader colRenglonesCliente;
        private System.Windows.Forms.ColumnHeader colRenglonesSku;
        private System.Windows.Forms.ColumnHeader colRenglonesProducto;
        private System.Windows.Forms.ColumnHeader colRenglonesUbicacion;
        private System.Windows.Forms.ColumnHeader colRenglonesRequerida;
        private System.Windows.Forms.ColumnHeader colRenglonesRetirada;
        private System.Windows.Forms.ColumnHeader colRenglonesReparto;
        private System.Windows.Forms.Label lblCantidadRetirada;
        private System.Windows.Forms.TextBox txtCantidadRetirada;
        private System.Windows.Forms.Button btnRegistrarRetiro;
        private System.Windows.Forms.Label lblAyudaRetiro;
        private System.Windows.Forms.GroupBox grpConfirmacion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.CheckBox chkEntregaPreparacion;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.Button btnConfirmarEntrega;
        private System.Windows.Forms.Button btnReportarIncidente;
    }
}
