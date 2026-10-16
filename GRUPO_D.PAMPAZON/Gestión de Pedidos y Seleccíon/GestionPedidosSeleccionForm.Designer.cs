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
            lblTitulo = new Label();
            lblEmpresa = new Label();
            grpContexto = new GroupBox();
            lblDeposito = new Label();
            cboDeposito = new ComboBox();
            lblRol = new Label();
            lblFecha = new Label();
            dtpFechaTrabajo = new DateTimePicker();
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
            btnIrCortes = new Button();
            grpContexto.SuspendLayout();
            grpFiltros.SuspendLayout();
            grpDetalle.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(24, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(890, 34);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Gestión de Pedidos y Selección";
            // 
            // lblEmpresa
            // 
            lblEmpresa.Location = new Point(26, 48);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(1050, 22);
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
            grpContexto.Location = new Point(16, 84);
            grpContexto.Name = "grpContexto";
            grpContexto.Size = new Size(1288, 72);
            grpContexto.TabIndex = 4;
            grpContexto.TabStop = false;
            grpContexto.Text = "Contexto de trabajo";
            // 
            // lblDeposito
            // 
            lblDeposito.Location = new Point(16, 30);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(68, 24);
            lblDeposito.TabIndex = 5;
            lblDeposito.Text = "Depósito";
            // 
            // cboDeposito
            // 
            cboDeposito.Enabled = false;
            cboDeposito.Items.AddRange(new object[] { "GBA" });
            cboDeposito.Location = new Point(90, 26);
            cboDeposito.Name = "cboDeposito";
            cboDeposito.Size = new Size(372, 23);
            cboDeposito.TabIndex = 6;
            // 
            // lblRol
            // 
            lblRol.Location = new Point(480, 29);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(210, 24);
            lblRol.TabIndex = 7;
            lblRol.Text = "Rol: Encargado de Preparación";
            // 
            // lblFecha
            // 
            lblFecha.Location = new Point(700, 30);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(72, 24);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha";
            // 
            // dtpFechaTrabajo
            // 
            dtpFechaTrabajo.Enabled = false;
            dtpFechaTrabajo.Format = DateTimePickerFormat.Short;
            dtpFechaTrabajo.Location = new Point(779, 26);
            dtpFechaTrabajo.Name = "dtpFechaTrabajo";
            dtpFechaTrabajo.Size = new Size(488, 23);
            dtpFechaTrabajo.TabIndex = 9;
            dtpFechaTrabajo.Value = new DateTime(2026, 10, 12, 0, 0, 0, 0);
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
            grpFiltros.Location = new Point(16, 190);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(1250, 80);
            grpFiltros.TabIndex = 14;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Buscar órdenes";
            // 
            // lblBuscarOrden
            // 
            lblBuscarOrden.Location = new Point(14, 22);
            lblBuscarOrden.Name = "lblBuscarOrden";
            lblBuscarOrden.Size = new Size(135, 24);
            lblBuscarOrden.TabIndex = 15;
            lblBuscarOrden.Text = "N.º de orden";
            // 
            // txtBuscarOrden
            // 
            txtBuscarOrden.Location = new Point(14, 45);
            txtBuscarOrden.Name = "txtBuscarOrden";
            txtBuscarOrden.Size = new Size(150, 23);
            txtBuscarOrden.TabIndex = 16;
            // 
            // lblCliente
            // 
            lblCliente.Location = new Point(182, 22);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(230, 24);
            lblCliente.TabIndex = 17;
            lblCliente.Text = "Cliente";
            // 
            // cboCliente
            // 
            cboCliente.Items.AddRange(new object[] { "Todos los clientes", "Cliente Demo A", "Cliente Demo B" });
            cboCliente.Location = new Point(182, 45);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(265, 23);
            cboCliente.TabIndex = 18;
            // 
            // lblOrigen
            // 
            lblOrigen.Location = new Point(464, 22);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(110, 24);
            lblOrigen.TabIndex = 19;
            lblOrigen.Text = "Origen";
            // 
            // cboOrigen
            // 
            cboOrigen.Items.AddRange(new object[] { "Todos", "Cliente", "Traslado interno" });
            cboOrigen.Location = new Point(464, 45);
            cboOrigen.Name = "cboOrigen";
            cboOrigen.Size = new Size(175, 23);
            cboOrigen.TabIndex = 20;
            // 
            // lblDesde
            // 
            lblDesde.Location = new Point(658, 22);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(139, 24);
            lblDesde.TabIndex = 21;
            lblDesde.Text = "Fecha de asignación";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(658, 45);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(145, 23);
            dtpDesde.TabIndex = 22;
            dtpDesde.Value = new DateTime(2026, 10, 12, 0, 0, 0, 0);
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(828, 38);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(216, 34);
            btnBuscar.TabIndex = 23;
            btnBuscar.Text = "Buscar";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1050, 38);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(200, 34);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            // 
            // lblListaAsignadas
            // 
            lblListaAsignadas.Location = new Point(18, 282);
            lblListaAsignadas.Name = "lblListaAsignadas";
            lblListaAsignadas.Size = new Size(950, 24);
            lblListaAsignadas.TabIndex = 25;
            lblListaAsignadas.Text = "Órdenes asignadas al depósito";
            // 
            // lvAsignadas
            // 
            lvAsignadas.Columns.AddRange(new ColumnHeader[] { lvAsignadasCol0, lvAsignadasCol1, lvAsignadasCol2, lvAsignadasCol3, lvAsignadasCol4, lvAsignadasCol5, lvAsignadasCol6 });
            lvAsignadas.FullRowSelect = true;
            lvAsignadas.GridLines = true;
            lvAsignadas.Items.AddRange(new ListViewItem[] { listViewItem14, listViewItem15, listViewItem16 });
            lvAsignadas.Location = new Point(18, 312);
            lvAsignadas.MultiSelect = false;
            lvAsignadas.Name = "lvAsignadas";
            lvAsignadas.Size = new Size(1248, 137);
            lvAsignadas.TabIndex = 26;
            lvAsignadas.UseCompatibleStateImageBehavior = false;
            lvAsignadas.View = View.Details;
            // 
            // lvAsignadasCol0
            // 
            lvAsignadasCol0.Text = "N.º de orden";
            lvAsignadasCol0.Width = 115;
            // 
            // lvAsignadasCol1
            // 
            lvAsignadasCol1.Text = "Asignación";
            lvAsignadasCol1.Width = 115;
            // 
            // lvAsignadasCol2
            // 
            lvAsignadasCol2.Text = "Cliente";
            lvAsignadasCol2.Width = 225;
            // 
            // lvAsignadasCol3
            // 
            lvAsignadasCol3.Text = "Origen";
            lvAsignadasCol3.Width = 165;
            // 
            // lvAsignadasCol4
            // 
            lvAsignadasCol4.Text = "Modalidad";
            lvAsignadasCol4.Width = 150;
            // 
            // lvAsignadasCol5
            // 
            lvAsignadasCol5.Text = "Productos";
            lvAsignadasCol5.Width = 100;
            // 
            // lvAsignadasCol6
            // 
            lvAsignadasCol6.Text = "Estado";
            lvAsignadasCol6.Width = 155;
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
            grpDetalle.Location = new Point(16, 462);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(1250, 253);
            grpDetalle.TabIndex = 34;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle de la orden OP-000184";
            // 
            // lblDetalleCliente
            // 
            lblDetalleCliente.Location = new Point(14, 27);
            lblDetalleCliente.Name = "lblDetalleCliente";
            lblDetalleCliente.Size = new Size(80, 24);
            lblDetalleCliente.TabIndex = 35;
            lblDetalleCliente.Text = "Cliente";
            // 
            // txtDetalleCliente
            // 
            txtDetalleCliente.Location = new Point(95, 23);
            txtDetalleCliente.Name = "txtDetalleCliente";
            txtDetalleCliente.Enabled = false;
            txtDetalleCliente.Size = new Size(220, 23);
            txtDetalleCliente.TabIndex = 36;
            txtDetalleCliente.Text = "Cliente Demo A";
            // 
            // lblContrato
            // 
            lblContrato.Location = new Point(335, 27);
            lblContrato.Name = "lblContrato";
            lblContrato.Size = new Size(78, 24);
            lblContrato.TabIndex = 37;
            lblContrato.Text = "Contrato";
            // 
            // txtContrato
            // 
            txtContrato.Location = new Point(415, 23);
            txtContrato.Name = "txtContrato";
            txtContrato.Enabled = false;
            txtContrato.Size = new Size(150, 23);
            txtContrato.TabIndex = 38;
            txtContrato.Text = "CT-000028";
            // 
            // lblModalidad
            // 
            lblModalidad.Location = new Point(585, 27);
            lblModalidad.Name = "lblModalidad";
            lblModalidad.Size = new Size(90, 24);
            lblModalidad.TabIndex = 39;
            lblModalidad.Text = "Modalidad";
            // 
            // txtModalidad
            // 
            txtModalidad.Location = new Point(680, 23);
            txtModalidad.Name = "txtModalidad";
            txtModalidad.Enabled = false;
            txtModalidad.Size = new Size(150, 23);
            txtModalidad.TabIndex = 40;
            txtModalidad.Text = "Fulfillment";
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(850, 27);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(65, 24);
            lblEstado.TabIndex = 41;
            lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(920, 23);
            txtEstado.Name = "txtEstado";
            txtEstado.Enabled = false;
            txtEstado.Size = new Size(314, 23);
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
            lvDisponibilidad.Location = new Point(14, 67);
            lvDisponibilidad.MultiSelect = false;
            lvDisponibilidad.Name = "lvDisponibilidad";
            lvDisponibilidad.Size = new Size(1220, 118);
            lvDisponibilidad.TabIndex = 43;
            lvDisponibilidad.UseCompatibleStateImageBehavior = false;
            lvDisponibilidad.View = View.Details;
            // 
            // lvDisponibilidadCol0
            // 
            lvDisponibilidadCol0.Text = "SKU";
            lvDisponibilidadCol0.Width = 120;
            // 
            // lvDisponibilidadCol1
            // 
            lvDisponibilidadCol1.Text = "Producto";
            lvDisponibilidadCol1.Width = 305;
            // 
            // lvDisponibilidadCol2
            // 
            lvDisponibilidadCol2.Text = "Unidad";
            lvDisponibilidadCol2.Width = 110;
            // 
            // lvDisponibilidadCol3
            // 
            lvDisponibilidadCol3.Text = "Solicitado";
            lvDisponibilidadCol3.Width = 120;
            // 
            // lvDisponibilidadCol4
            // 
            lvDisponibilidadCol4.Text = "Disponible";
            lvDisponibilidadCol4.Width = 120;
            // 
            // lvDisponibilidadCol5
            // 
            lvDisponibilidadCol5.Text = "Validación";
            lvDisponibilidadCol5.Width = 200;
            // 
            // lblStockRegla
            // 
            lblStockRegla.Location = new Point(14, 192);
            lblStockRegla.Name = "lblStockRegla";
            lblStockRegla.Size = new Size(1190, 24);
            lblStockRegla.TabIndex = 50;
            lblStockRegla.Text = "Disponible: mercadería aceptada y no comprometida del cliente en este depósito.";
            // 
            // lblValidacion
            // 
            lblValidacion.Location = new Point(14, 220);
            lblValidacion.Name = "lblValidacion";
            lblValidacion.Size = new Size(1190, 24);
            lblValidacion.TabIndex = 51;
            lblValidacion.Text = "Validación pendiente. Al aceptar se compromete el stock, sin descontar las existencias físicas.";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(20, 721);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(418, 34);
            btnValidar.TabIndex = 52;
            btnValidar.Text = "Validar disponibilidad";
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Location = new Point(452, 721);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(445, 34);
            btnAceptar.TabIndex = 53;
            btnAceptar.Text = "Aceptar y comprometer";
            // 
            // btnRechazar
            // 
            btnRechazar.Enabled = false;
            btnRechazar.Location = new Point(904, 721);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(362, 34);
            btnRechazar.TabIndex = 54;
            btnRechazar.Text = "Rechazar por falta de stock";
            // 
            // lblMotivo
            // 
            lblMotivo.Location = new Point(20, 773);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(150, 24);
            lblMotivo.TabIndex = 55;
            lblMotivo.Text = "Motivo del rechazo";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(178, 770);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Enabled = false;
            txtMotivo.Size = new Size(1088, 23);
            txtMotivo.TabIndex = 56;
            txtMotivo.Text = "Se completará con los productos y cantidades faltantes.";
            // 
            // btnIrCortes
            // 
            btnIrCortes.Location = new Point(1088, 30);
            btnIrCortes.Name = "btnIrCortes";
            btnIrCortes.Size = new Size(216, 34);
            btnIrCortes.TabIndex = 10;
            btnIrCortes.Text = "Cortes de selección";
            // 
            // GestionPedidosSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 901);
            Controls.Add(lblTitulo);
            Controls.Add(lblEmpresa);
            Controls.Add(grpContexto);
            Controls.Add(grpFiltros);
            Controls.Add(lblListaAsignadas);
            Controls.Add(lvAsignadas);
            Controls.Add(grpDetalle);
            Controls.Add(btnValidar);
            Controls.Add(btnAceptar);
            Controls.Add(btnRechazar);
            Controls.Add(lblMotivo);
            Controls.Add(txtMotivo);
            Controls.Add(btnIrCortes);
            Name = "GestionPedidosSeleccionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pampazon - Gestión de Pedidos y Selección";
            grpContexto.ResumeLayout(false);
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
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
        private System.Windows.Forms.Button btnIrCortes;
    }
}
