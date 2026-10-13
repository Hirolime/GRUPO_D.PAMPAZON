namespace GRUPO_D.PAMPAZON.Empaquetado_y_Preparación_de_Mercaderias
{
    partial class EmpaquetadoPreparacionMercaderiasForm1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvPedidos = new DataGridView();
            dgvProductos = new DataGridView();
            lblModalidadDestino = new Label();
            lblBultos = new Label();
            numBultos = new NumericUpDown();
            chkPaleConforme = new CheckBox();
            btnConfirmarPreparacion = new Button();
            btnReportarIncidente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBultos).BeginInit();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(12, 12);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.Size = new Size(760, 150);
            dgvPedidos.TabIndex = 0;
            dgvPedidos.SelectionChanged += dgvPedidos_SelectionChanged;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 200);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(760, 130);
            dgvProductos.TabIndex = 2;
            // 
            // lblModalidadDestino
            // 
            lblModalidadDestino.AutoSize = true;
            lblModalidadDestino.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModalidadDestino.Location = new Point(12, 175);
            lblModalidadDestino.Name = "lblModalidadDestino";
            lblModalidadDestino.Size = new Size(231, 15);
            lblModalidadDestino.TabIndex = 1;
            lblModalidadDestino.Text = "Modalidad: - | Destino: - | Estado: -";
            // 
            // lblBultos
            // 
            lblBultos.AutoSize = true;
            lblBultos.Location = new Point(300, 346);
            lblBultos.Name = "lblBultos";
            lblBultos.Size = new Size(110, 15);
            lblBultos.TabIndex = 4;
            lblBultos.Text = "Cantidad de Bultos:";
            // 
            // numBultos
            // 
            numBultos.Location = new Point(405, 344);
            numBultos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numBultos.Name = "numBultos";
            numBultos.Size = new Size(60, 23);
            numBultos.TabIndex = 5;
            numBultos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkPaleConforme
            // 
            chkPaleConforme.AutoSize = true;
            chkPaleConforme.Location = new Point(12, 345);
            chkPaleConforme.Name = "chkPaleConforme";
            chkPaleConforme.Size = new Size(272, 19);
            chkPaleConforme.TabIndex = 3;
            chkPaleConforme.Text = "Conformidad de Revisión Visual (Palé Cerrado)";
            chkPaleConforme.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarPreparacion
            // 
            btnConfirmarPreparacion.BackColor = Color.LightGreen;
            btnConfirmarPreparacion.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarPreparacion.Location = new Point(12, 380);
            btnConfirmarPreparacion.Name = "btnConfirmarPreparacion";
            btnConfirmarPreparacion.Size = new Size(370, 40);
            btnConfirmarPreparacion.TabIndex = 6;
            btnConfirmarPreparacion.Text = "Empaquetar y Emitir P05";
            btnConfirmarPreparacion.UseVisualStyleBackColor = false;
            btnConfirmarPreparacion.Click += btnConfirmarPreparacion_Click;
            // 
            // btnReportarIncidente
            // 
            btnReportarIncidente.BackColor = Color.Moccasin;
            btnReportarIncidente.Location = new Point(400, 380);
            btnReportarIncidente.Name = "btnReportarIncidente";
            btnReportarIncidente.Size = new Size(372, 40);
            btnReportarIncidente.TabIndex = 7;
            btnReportarIncidente.Text = "Reportar Incidente (I04)";
            btnReportarIncidente.UseVisualStyleBackColor = false;
            btnReportarIncidente.Click += btnReportarIncidente_Click;
            // 
            // EmpaquetadoPreparacionMercaderiasForm1
            // 
            ClientSize = new Size(784, 436);
            Controls.Add(btnReportarIncidente);
            Controls.Add(btnConfirmarPreparacion);
            Controls.Add(numBultos);
            Controls.Add(lblBultos);
            Controls.Add(chkPaleConforme);
            Controls.Add(dgvProductos);
            Controls.Add(lblModalidadDestino);
            Controls.Add(dgvPedidos);
            Name = "EmpaquetadoPreparacionMercaderiasForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "P04 / P05 - Empaquetado y Preparación de Mercadería";
            Load += EmpaquetadoPreparacionMercaderiasForm1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBultos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblModalidadDestino;
        private System.Windows.Forms.Label lblBultos;
        private System.Windows.Forms.NumericUpDown numBultos;
        private System.Windows.Forms.CheckBox chkPaleConforme;
        private System.Windows.Forms.Button btnConfirmarPreparacion;
        private System.Windows.Forms.Button btnReportarIncidente;
    }
}