namespace GRUPO_D.PAMPAZON.Seleccion_y_entrega_de_Mercaderias
{
    partial class SeleccionEntregaMercaderiasForm1
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
            ListViewItem item_lvSelecciones_0 = new ListViewItem(new string[] { "OS-000071", "14/10/2026", "Segundo", "Fulfillment", "2", "2", "EMITIDA" }, -1);
            ListViewItem item_lvSelecciones_1 = new ListViewItem(new string[] { "OS-000072", "14/10/2026", "Segundo", "Palé cerrado", "1", "1", "EMITIDA" }, -1);
            ListViewItem item_lvRenglones_0 = new ListViewItem(new string[] { "Cliente Demo A", "SKU-001", "Remera de algodón", "12-43-2", "120", "", "OP-000181 (80); OP-000182 (40)" }, -1);
            ListViewItem item_lvRenglones_1 = new ListViewItem(new string[] { "Cliente Demo A", "SKU-002", "Pantalón deportivo", "12-44-1", "30", "", "OP-000181 (30)" }, -1);
            lblTitulo = new Label();
            lblEmpresa = new Label();
            grpContexto = new GroupBox();
            lblDeposito = new Label();
            cboDeposito = new ComboBox();
            lblRol = new Label();
            lblFecha = new Label();
            dtpFechaTrabajo = new DateTimePicker();
            grpSelecciones = new GroupBox();
            lvSelecciones = new ListView();
            lvSeleccionesCol0 = new ColumnHeader();
            lvSeleccionesCol1 = new ColumnHeader();
            lvSeleccionesCol2 = new ColumnHeader();
            lvSeleccionesCol3 = new ColumnHeader();
            lvSeleccionesCol4 = new ColumnHeader();
            lvSeleccionesCol5 = new ColumnHeader();
            lvSeleccionesCol6 = new ColumnHeader();
            grpDetalleSeleccion = new GroupBox();
            lblOrdenSeleccion = new Label();
            txtOrdenSeleccion = new TextBox();
            lblModalidadSel = new Label();
            txtModalidadSel = new TextBox();
            lblCorteSel = new Label();
            txtCorteSel = new TextBox();
            lblEmitidaPor = new Label();
            txtEmitidaPor = new TextBox();
            lvRenglones = new ListView();
            lvRenglonesCol0 = new ColumnHeader();
            lvRenglonesCol1 = new ColumnHeader();
            lvRenglonesCol2 = new ColumnHeader();
            lvRenglonesCol3 = new ColumnHeader();
            lvRenglonesCol4 = new ColumnHeader();
            lvRenglonesCol5 = new ColumnHeader();
            lvRenglonesCol6 = new ColumnHeader();
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
            grpSelecciones.SuspendLayout();
            grpDetalleSeleccion.SuspendLayout();
            grpConfirmacion.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Text = "Selección y Entrega de Mercadería";
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1320, 50);
            lblTitulo.TabIndex = 0;
            // 
            // lblEmpresa
            // 
            lblEmpresa.Text = "PAMPAZON  |  Operario de Almacén";
            lblEmpresa.Location = new Point(0, 50);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(1320, 26);
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
            // lblFecha
            // 
            lblFecha.Text = "Fecha";
            lblFecha.Location = new Point(780, 30);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(72, 24);
            lblFecha.TabIndex = 6;
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
            // grpSelecciones
            // 
            grpSelecciones.Controls.Add(lvSelecciones);
            grpSelecciones.TabStop = false;
            grpSelecciones.Text = "Órdenes de selección pendientes de cumplir";
            grpSelecciones.Location = new Point(16, 170);
            grpSelecciones.Name = "grpSelecciones";
            grpSelecciones.Size = new Size(1288, 200);
            grpSelecciones.TabIndex = 8;
            // 
            // lvSelecciones
            // 
            lvSelecciones.Columns.AddRange(new ColumnHeader[] { lvSeleccionesCol0, lvSeleccionesCol1, lvSeleccionesCol2, lvSeleccionesCol3, lvSeleccionesCol4, lvSeleccionesCol5, lvSeleccionesCol6 });
            lvSelecciones.FullRowSelect = true;
            lvSelecciones.GridLines = true;
            lvSelecciones.Items.AddRange(new ListViewItem[] { item_lvSelecciones_0, item_lvSelecciones_1 });
            lvSelecciones.Location = new Point(12, 26);
            lvSelecciones.Name = "lvSelecciones";
            lvSelecciones.Size = new Size(1262, 162);
            lvSelecciones.TabIndex = 9;
            lvSelecciones.UseCompatibleStateImageBehavior = false;
            lvSelecciones.View = View.Details;
            // 
            // lvSeleccionesCol0
            // 
            lvSeleccionesCol0.Text = "N.º de selección";
            lvSeleccionesCol0.Width = 130;
            // 
            // lvSeleccionesCol1
            // 
            lvSeleccionesCol1.Text = "Fecha de corte";
            lvSeleccionesCol1.Width = 120;
            // 
            // lvSeleccionesCol2
            // 
            lvSeleccionesCol2.Text = "Corte";
            lvSeleccionesCol2.Width = 90;
            // 
            // lvSeleccionesCol3
            // 
            lvSeleccionesCol3.Text = "Modalidad";
            lvSeleccionesCol3.Width = 140;
            // 
            // lvSeleccionesCol4
            // 
            lvSeleccionesCol4.Text = "Pedidos vinculados";
            lvSeleccionesCol4.Width = 140;
            // 
            // lvSeleccionesCol5
            // 
            lvSeleccionesCol5.Text = "Renglones";
            lvSeleccionesCol5.Width = 100;
            // 
            // lvSeleccionesCol6
            // 
            lvSeleccionesCol6.Text = "Estado";
            lvSeleccionesCol6.Width = 150;
            // 
            // grpDetalleSeleccion
            // 
            grpDetalleSeleccion.Controls.Add(lblOrdenSeleccion);
            grpDetalleSeleccion.Controls.Add(txtOrdenSeleccion);
            grpDetalleSeleccion.Controls.Add(lblModalidadSel);
            grpDetalleSeleccion.Controls.Add(txtModalidadSel);
            grpDetalleSeleccion.Controls.Add(lblCorteSel);
            grpDetalleSeleccion.Controls.Add(txtCorteSel);
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
            // lblModalidadSel
            // 
            lblModalidadSel.Text = "Modalidad";
            lblModalidadSel.Location = new Point(184, 26);
            lblModalidadSel.Name = "lblModalidadSel";
            lblModalidadSel.Size = new Size(140, 20);
            lblModalidadSel.TabIndex = 13;
            // 
            // txtModalidadSel
            // 
            txtModalidadSel.Enabled = false;
            txtModalidadSel.Location = new Point(184, 48);
            txtModalidadSel.Name = "txtModalidadSel";
            txtModalidadSel.Size = new Size(160, 23);
            txtModalidadSel.TabIndex = 14;
            // 
            // lblCorteSel
            // 
            lblCorteSel.Text = "Corte";
            lblCorteSel.Location = new Point(364, 26);
            lblCorteSel.Name = "lblCorteSel";
            lblCorteSel.Size = new Size(140, 20);
            lblCorteSel.TabIndex = 15;
            // 
            // txtCorteSel
            // 
            txtCorteSel.Enabled = false;
            txtCorteSel.Location = new Point(364, 48);
            txtCorteSel.Name = "txtCorteSel";
            txtCorteSel.Size = new Size(120, 23);
            txtCorteSel.TabIndex = 16;
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
            lvRenglones.Columns.AddRange(new ColumnHeader[] { lvRenglonesCol0, lvRenglonesCol1, lvRenglonesCol2, lvRenglonesCol3, lvRenglonesCol4, lvRenglonesCol5, lvRenglonesCol6 });
            lvRenglones.FullRowSelect = true;
            lvRenglones.GridLines = true;
            lvRenglones.Items.AddRange(new ListViewItem[] { item_lvRenglones_0, item_lvRenglones_1 });
            lvRenglones.Location = new Point(12, 86);
            lvRenglones.Name = "lvRenglones";
            lvRenglones.Size = new Size(1262, 170);
            lvRenglones.TabIndex = 19;
            lvRenglones.UseCompatibleStateImageBehavior = false;
            lvRenglones.View = View.Details;
            // 
            // lvRenglonesCol0
            // 
            lvRenglonesCol0.Text = "Cliente";
            lvRenglonesCol0.Width = 190;
            // 
            // lvRenglonesCol1
            // 
            lvRenglonesCol1.Text = "SKU";
            lvRenglonesCol1.Width = 90;
            // 
            // lvRenglonesCol2
            // 
            lvRenglonesCol2.Text = "Producto";
            lvRenglonesCol2.Width = 220;
            // 
            // lvRenglonesCol3
            // 
            lvRenglonesCol3.Text = "Ubicación (X-Y-Z)";
            lvRenglonesCol3.Width = 130;
            // 
            // lvRenglonesCol4
            // 
            lvRenglonesCol4.Text = "Cantidad requerida";
            lvRenglonesCol4.Width = 130;
            // 
            // lvRenglonesCol5
            // 
            lvRenglonesCol5.Text = "Cantidad retirada";
            lvRenglonesCol5.Width = 130;
            // 
            // lvRenglonesCol6
            // 
            lvRenglonesCol6.Text = "Reparto entre órdenes de preparación";
            lvRenglonesCol6.Width = 330;
            // 
            // lblCantidadRetirada
            // 
            lblCantidadRetirada.Text = "Cantidad retirada del renglón";
            lblCantidadRetirada.Location = new Point(14, 266);
            lblCantidadRetirada.Name = "lblCantidadRetirada";
            lblCantidadRetirada.Size = new Size(210, 20);
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
            // SeleccionEntregaMercaderiasForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 901);
            Controls.Add(lblTitulo);
            Controls.Add(lblEmpresa);
            Controls.Add(grpContexto);
            Controls.Add(grpSelecciones);
            Controls.Add(grpDetalleSeleccion);
            Controls.Add(grpConfirmacion);
            Name = "SeleccionEntregaMercaderiasForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pampazon - Selección y Entrega de Mercadería";
            grpConfirmacion.ResumeLayout(false);
            grpDetalleSeleccion.ResumeLayout(false);
            grpSelecciones.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpSelecciones;
        private System.Windows.Forms.ListView lvSelecciones;
        private System.Windows.Forms.ColumnHeader lvSeleccionesCol0;
        private System.Windows.Forms.ColumnHeader lvSeleccionesCol1;
        private System.Windows.Forms.ColumnHeader lvSeleccionesCol2;
        private System.Windows.Forms.ColumnHeader lvSeleccionesCol3;
        private System.Windows.Forms.ColumnHeader lvSeleccionesCol4;
        private System.Windows.Forms.ColumnHeader lvSeleccionesCol5;
        private System.Windows.Forms.ColumnHeader lvSeleccionesCol6;
        private System.Windows.Forms.GroupBox grpDetalleSeleccion;
        private System.Windows.Forms.Label lblOrdenSeleccion;
        private System.Windows.Forms.TextBox txtOrdenSeleccion;
        private System.Windows.Forms.Label lblModalidadSel;
        private System.Windows.Forms.TextBox txtModalidadSel;
        private System.Windows.Forms.Label lblCorteSel;
        private System.Windows.Forms.TextBox txtCorteSel;
        private System.Windows.Forms.Label lblEmitidaPor;
        private System.Windows.Forms.TextBox txtEmitidaPor;
        private System.Windows.Forms.ListView lvRenglones;
        private System.Windows.Forms.ColumnHeader lvRenglonesCol0;
        private System.Windows.Forms.ColumnHeader lvRenglonesCol1;
        private System.Windows.Forms.ColumnHeader lvRenglonesCol2;
        private System.Windows.Forms.ColumnHeader lvRenglonesCol3;
        private System.Windows.Forms.ColumnHeader lvRenglonesCol4;
        private System.Windows.Forms.ColumnHeader lvRenglonesCol5;
        private System.Windows.Forms.ColumnHeader lvRenglonesCol6;
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
