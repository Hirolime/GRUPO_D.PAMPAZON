namespace Pampazon.Prototipos
{
    partial class CortesSeleccionForm
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
            ListViewItem listViewItem11 = new ListViewItem(new string[] { "OP-000181", "Cliente Demo A", "Cliente", "Fulfillment", "2", "PENDIENTE" }, -1);
            ListViewItem listViewItem12 = new ListViewItem(new string[] { "OP-000182", "Cliente Demo A", "Cliente", "Fulfillment", "1", "PENDIENTE" }, -1);
            ListViewItem listViewItem13 = new ListViewItem(new string[] { "OP-000183", "Cliente Demo B", "Cliente", "Palé cerrado", "1", "PENDIENTE" }, -1);
            ListViewItem listViewItem19 = new ListViewItem(new string[] { "Cliente Demo A", "SKU-001", "Remera de algodón", "A-01-02", "120", "Unidad", "OP-000181 (80); OP-000182 (40)" }, -1);
            ListViewItem listViewItem20 = new ListViewItem(new string[] { "Cliente Demo A", "SKU-002", "Pantalón deportivo", "A-02-01", "30", "Unidad", "OP-000181 (30)" }, -1);
            lblTitulo = new Label();
            lblEmpresa = new Label();
            grpContexto = new GroupBox();
            lblDeposito = new Label();
            cboDeposito = new ComboBox();
            lblRol = new Label();
            lblFecha = new Label();
            dtpFechaTrabajo = new DateTimePicker();
            grpCorte = new GroupBox();
            groupBox1 = new GroupBox();
            rdoPrimerCorte = new RadioButton();
            rdoSegundoCorte = new RadioButton();
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
            grpContexto.SuspendLayout();
            grpCorte.SuspendLayout();
            groupBox1.SuspendLayout();
            grpPropuesta.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(24, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(890, 34);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Cortes de Selección";
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
            // grpCorte
            // 
            grpCorte.Controls.Add(groupBox1);
            grpCorte.Controls.Add(lblFechaCorte);
            grpCorte.Controls.Add(dtpFechaCorte);
            grpCorte.Controls.Add(chkSoloPendientes);
            grpCorte.Controls.Add(btnConsultarPendientes);
            grpCorte.Location = new Point(16, 190);
            grpCorte.Name = "grpCorte";
            grpCorte.Size = new Size(1250, 85);
            grpCorte.TabIndex = 57;
            grpCorte.TabStop = false;
            grpCorte.Text = "Datos del corte";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoPrimerCorte);
            groupBox1.Controls.Add(rdoSegundoCorte);
            groupBox1.Location = new Point(375, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 56);
            groupBox1.TabIndex = 89;
            groupBox1.TabStop = false;
            groupBox1.Text = "Corte Operativo";
            // 
            // rdoPrimerCorte
            // 
            rdoPrimerCorte.Checked = true;
            rdoPrimerCorte.Location = new Point(34, 22);
            rdoPrimerCorte.Name = "rdoPrimerCorte";
            rdoPrimerCorte.Size = new Size(138, 25);
            rdoPrimerCorte.TabIndex = 63;
            rdoPrimerCorte.TabStop = true;
            rdoPrimerCorte.Text = "Primer corte";
            // 
            // rdoSegundoCorte
            // 
            rdoSegundoCorte.Location = new Point(216, 22);
            rdoSegundoCorte.Name = "rdoSegundoCorte";
            rdoSegundoCorte.Size = new Size(156, 25);
            rdoSegundoCorte.TabIndex = 64;
            rdoSegundoCorte.Text = "Segundo corte";
            // 
            // lblFechaCorte
            // 
            lblFechaCorte.Location = new Point(14, 23);
            lblFechaCorte.Name = "lblFechaCorte";
            lblFechaCorte.Size = new Size(140, 24);
            lblFechaCorte.TabIndex = 58;
            lblFechaCorte.Text = "Fecha del corte";
            // 
            // dtpFechaCorte
            // 
            dtpFechaCorte.Format = DateTimePickerFormat.Short;
            dtpFechaCorte.Location = new Point(14, 46);
            dtpFechaCorte.Name = "dtpFechaCorte";
            dtpFechaCorte.Size = new Size(324, 23);
            dtpFechaCorte.TabIndex = 59;
            dtpFechaCorte.Value = new DateTime(2026, 10, 12, 0, 0, 0, 0);
            // 
            // chkSoloPendientes
            // 
            chkSoloPendientes.Checked = true;
            chkSoloPendientes.Enabled = false;
            chkSoloPendientes.Location = new Point(792, 46);
            chkSoloPendientes.Name = "chkSoloPendientes";
            chkSoloPendientes.Size = new Size(188, 25);
            chkSoloPendientes.TabIndex = 63;
            chkSoloPendientes.Text = "Solo órdenes PENDIENTES";
            // 
            // btnConsultarPendientes
            // 
            btnConsultarPendientes.Location = new Point(1015, 36);
            btnConsultarPendientes.Name = "btnConsultarPendientes";
            btnConsultarPendientes.Size = new Size(216, 34);
            btnConsultarPendientes.TabIndex = 64;
            btnConsultarPendientes.Text = "Consultar pendientes";
            // 
            // lblPendientes
            // 
            lblPendientes.Location = new Point(18, 287);
            lblPendientes.Name = "lblPendientes";
            lblPendientes.Size = new Size(1150, 24);
            lblPendientes.TabIndex = 65;
            lblPendientes.Text = "Órdenes pendientes · Seleccionar (Ctrl + clic) las que se incorporarán al corte";
            // 
            // lvPendientes
            // 
            lvPendientes.Columns.AddRange(new ColumnHeader[] { lvPendientesCol0, lvPendientesCol1, lvPendientesCol2, lvPendientesCol3, lvPendientesCol4, lvPendientesCol5 });
            lvPendientes.FullRowSelect = true;
            lvPendientes.GridLines = true;
            lvPendientes.Items.AddRange(new ListViewItem[] { listViewItem11, listViewItem12, listViewItem13 });
            lvPendientes.Location = new Point(18, 316);
            lvPendientes.MultiSelect = true;
            lvPendientes.Name = "lvPendientes";
            lvPendientes.Size = new Size(1248, 142);
            lvPendientes.TabIndex = 66;
            lvPendientes.UseCompatibleStateImageBehavior = false;
            lvPendientes.View = View.Details;
            // 
            // lvPendientesCol0
            // 
            lvPendientesCol0.Text = "N.º de orden";
            lvPendientesCol0.Width = 160;
            // 
            // lvPendientesCol1
            // 
            lvPendientesCol1.Text = "Cliente";
            lvPendientesCol1.Width = 250;
            // 
            // lvPendientesCol2
            // 
            lvPendientesCol2.Text = "Origen";
            lvPendientesCol2.Width = 175;
            // 
            // lvPendientesCol3
            // 
            lvPendientesCol3.Text = "Modalidad";
            lvPendientesCol3.Width = 160;
            // 
            // lvPendientesCol4
            // 
            lvPendientesCol4.Text = "Productos";
            lvPendientesCol4.Width = 100;
            // 
            // lvPendientesCol5
            // 
            lvPendientesCol5.Text = "Estado";
            lvPendientesCol5.Width = 180;
            // 
            // btnPrepararCorte
            // 
            btnPrepararCorte.Location = new Point(20, 478);
            btnPrepararCorte.Name = "btnPrepararCorte";
            btnPrepararCorte.Size = new Size(1246, 34);
            btnPrepararCorte.TabIndex = 73;
            btnPrepararCorte.Text = "Preparar corte";
            // 
            // grpPropuesta
            // 
            grpPropuesta.Controls.Add(lvPropuesta);
            grpPropuesta.Location = new Point(16, 518);
            grpPropuesta.Name = "grpPropuesta";
            grpPropuesta.Size = new Size(1250, 212);
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
            lvPropuesta.Location = new Point(14, 26);
            lvPropuesta.MultiSelect = false;
            lvPropuesta.Name = "lvPropuesta";
            lvPropuesta.Size = new Size(1220, 180);
            lvPropuesta.TabIndex = 76;
            lvPropuesta.UseCompatibleStateImageBehavior = false;
            lvPropuesta.View = View.Details;
            // 
            // lvPropuestaCol0
            // 
            lvPropuestaCol0.Text = "Cliente";
            lvPropuestaCol0.Width = 180;
            // 
            // lvPropuestaCol1
            // 
            lvPropuestaCol1.Text = "SKU";
            lvPropuestaCol1.Width = 100;
            // 
            // lvPropuestaCol2
            // 
            lvPropuestaCol2.Text = "Producto";
            lvPropuestaCol2.Width = 220;
            // 
            // lvPropuestaCol3
            // 
            lvPropuestaCol3.Text = "Ubicación";
            lvPropuestaCol3.Width = 115;
            // 
            // lvPropuestaCol4
            // 
            lvPropuestaCol4.Text = "Cantidad";
            lvPropuestaCol4.Width = 100;
            // 
            // lvPropuestaCol5
            // 
            lvPropuestaCol5.Text = "Unidad";
            lvPropuestaCol5.Width = 100;
            // 
            // lvPropuestaCol6
            // 
            lvPropuestaCol6.Text = "Pedidos de origen";
            lvPropuestaCol6.Width = 250;
            // 
            // btnConfirmarCorte
            // 
            btnConfirmarCorte.Location = new Point(20, 753);
            btnConfirmarCorte.Name = "btnConfirmarCorte";
            btnConfirmarCorte.Size = new Size(418, 34);
            btnConfirmarCorte.TabIndex = 86;
            btnConfirmarCorte.Text = "Confirmar y generar selección";
            // 
            // btnVerOrdenes
            // 
            btnVerOrdenes.Enabled = false;
            btnVerOrdenes.Location = new Point(442, 753);
            btnVerOrdenes.Name = "btnVerOrdenes";
            btnVerOrdenes.Size = new Size(402, 34);
            btnVerOrdenes.TabIndex = 87;
            btnVerOrdenes.Text = "Ver órdenes generadas";
            // 
            // btnDescartar
            // 
            btnDescartar.Location = new Point(851, 753);
            btnDescartar.Name = "btnDescartar";
            btnDescartar.Size = new Size(414, 34);
            btnDescartar.TabIndex = 88;
            btnDescartar.Text = "Descartar propuesta";
            // 
            // CortesSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 901);
            Controls.Add(lblTitulo);
            Controls.Add(lblEmpresa);
            Controls.Add(grpContexto);
            Controls.Add(grpCorte);
            Controls.Add(lblPendientes);
            Controls.Add(lvPendientes);
            Controls.Add(btnPrepararCorte);
            Controls.Add(grpPropuesta);
            Controls.Add(btnConfirmarCorte);
            Controls.Add(btnVerOrdenes);
            Controls.Add(btnDescartar);
            Name = "CortesSeleccionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pampazon - Cortes de Selección";
            grpContexto.ResumeLayout(false);
            grpCorte.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            grpPropuesta.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpCorte;
        private GroupBox groupBox1;
        private RadioButton rdoPrimerCorte;
        private RadioButton rdoSegundoCorte;
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
    }
}
