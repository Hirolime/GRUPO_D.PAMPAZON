namespace GRUPO_D.PAMPAZON.CU3_EmpaquetadoPreparacionEntregas
{
    partial class EmpaquetadoPreparacionEntregasForm
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

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblEmpresa = new Label();
            grpControlCantidades = new GroupBox();
            lvControlCantidades = new ListView();
            colControlCantidadesSku = new ColumnHeader();
            colControlCantidadesProducto = new ColumnHeader();
            colControlCantidadesSolicitada = new ColumnHeader();
            btnConfirmarPreparacion = new Button();

            grpControlCantidades.SuspendLayout();
            SuspendLayout();

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(24, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(222, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Empaquetado y Preparación de Entregas";
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(24, 45);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(71, 15);
            lblEmpresa.TabIndex = 1;
            lblEmpresa.Text = "PAMPAZON";
            // 
            // grpControlCantidades
            // 
            grpControlCantidades.Controls.Add(lvControlCantidades);
            grpControlCantidades.Location = new Point(24, 80);
            grpControlCantidades.Name = "grpControlCantidades";
            grpControlCantidades.Size = new Size(880, 240);
            grpControlCantidades.TabIndex = 2;
            grpControlCantidades.TabStop = false;
            grpControlCantidades.Text = "Control de productos recibidos de Almacén";
            // 
            // lvControlCantidades
            // 
            lvControlCantidades.Columns.AddRange(new ColumnHeader[] {
                colControlCantidadesSku,
                colControlCantidadesProducto,
                colControlCantidadesSolicitada
            });
            lvControlCantidades.FullRowSelect = true;
            lvControlCantidades.GridLines = true;
            lvControlCantidades.Location = new Point(14, 30);
            lvControlCantidades.Name = "lvControlCantidades";
            lvControlCantidades.Size = new Size(850, 190);
            lvControlCantidades.TabIndex = 0;
            lvControlCantidades.UseCompatibleStateImageBehavior = false;
            lvControlCantidades.View = View.Details;
            // 
            // colControlCantidadesSku
            // 
            colControlCantidadesSku.Text = "SKU";
            colControlCantidadesSku.Width = 120;
            // 
            // colControlCantidadesProducto
            // 
            colControlCantidadesProducto.Text = "Producto";
            colControlCantidadesProducto.Width = 350;
            // 
            // colControlCantidadesSolicitada
            // 
            colControlCantidadesSolicitada.Text = "Cantidad solicitada";
            colControlCantidadesSolicitada.Width = 180;
            // 
            // btnConfirmarPreparacion
            // 
            btnConfirmarPreparacion.Location = new Point(724, 340);
            btnConfirmarPreparacion.Name = "btnConfirmarPreparacion";
            btnConfirmarPreparacion.Size = new Size(180, 30);
            btnConfirmarPreparacion.TabIndex = 3;
            btnConfirmarPreparacion.Text = "Confirmar preparación";
            btnConfirmarPreparacion.UseVisualStyleBackColor = true;
            // 
            // EmpaquetadoPreparacionEntregasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 395);
            Controls.Add(lblTitulo);
            Controls.Add(lblEmpresa);
            Controls.Add(grpControlCantidades);
            Controls.Add(btnConfirmarPreparacion);
            Name = "EmpaquetadoPreparacionEntregasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pampazon - Empaquetado y Preparación de Entregas";
            grpControlCantidades.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.GroupBox grpControlCantidades;
        private System.Windows.Forms.ListView lvControlCantidades;
        private System.Windows.Forms.ColumnHeader colControlCantidadesSku;
        private System.Windows.Forms.ColumnHeader colControlCantidadesProducto;
        private System.Windows.Forms.ColumnHeader colControlCantidadesSolicitada;
        private System.Windows.Forms.Button btnConfirmarPreparacion;
    }
}