namespace GRUPO_D.PAMPAZON.CU2_SeleccionEntregaMercaderia
{
    partial class SeleccionEntregaMercaderiaForm
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
            colRenglonesSku = new ColumnHeader();
            colRenglonesProducto = new ColumnHeader();
            colRenglonesUbicacion = new ColumnHeader();
            colRenglonesRequerida = new ColumnHeader();
            btnConfirmarEntrega = new Button();

            grpDetalleSeleccion.SuspendLayout();
            SuspendLayout();

            // 
            // lblTitulo
            // 
            lblTitulo.BorderStyle = BorderStyle.FixedSingle;
            lblTitulo.Location = new Point(24, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(620, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Selección y Entrega de Mercadería";
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(24, 48);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(71, 15);
            lblEmpresa.TabIndex = 1;
            lblEmpresa.Text = "PAMPAZON";
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
            grpDetalleSeleccion.Location = new Point(24, 110);
            grpDetalleSeleccion.Name = "grpDetalleSeleccion";
            grpDetalleSeleccion.Size = new Size(880, 280);
            grpDetalleSeleccion.TabIndex = 2;
            grpDetalleSeleccion.TabStop = false;
            grpDetalleSeleccion.Text = "Detalle de la selección";
            // 
            // lblOrdenSeleccion
            // 
            lblOrdenSeleccion.AutoSize = true;
            lblOrdenSeleccion.Location = new Point(14, 26);
            lblOrdenSeleccion.Name = "lblOrdenSeleccion";
            lblOrdenSeleccion.Size = new Size(111, 15);
            lblOrdenSeleccion.TabIndex = 0;
            lblOrdenSeleccion.Text = "Orden de selección";
            // 
            // txtOrdenSeleccion
            // 
            txtOrdenSeleccion.Enabled = false;
            txtOrdenSeleccion.Location = new Point(14, 48);
            txtOrdenSeleccion.Name = "txtOrdenSeleccion";
            txtOrdenSeleccion.Size = new Size(100, 23);
            txtOrdenSeleccion.TabIndex = 1;
            // 
            // lblModalidad
            // 
            lblModalidad.AutoSize = true;
            lblModalidad.Location = new Point(130, 26);
            lblModalidad.Name = "lblModalidad";
            lblModalidad.Size = new Size(64, 15);
            lblModalidad.TabIndex = 2;
            lblModalidad.Text = "Modalidad";
            // 
            // txtModalidad
            // 
            txtModalidad.Enabled = false;
            txtModalidad.Location = new Point(130, 48);
            txtModalidad.Name = "txtModalidad";
            txtModalidad.Size = new Size(110, 23);
            txtModalidad.TabIndex = 3;
            // 
            // lblCorte
            // 
            lblCorte.AutoSize = true;
            lblCorte.Location = new Point(250, 26);
            lblCorte.Name = "lblCorte";
            lblCorte.Size = new Size(36, 15);
            lblCorte.TabIndex = 4;
            lblCorte.Text = "Corte";
            // 
            // txtCorte
            // 
            txtCorte.Enabled = false;
            txtCorte.Location = new Point(250, 48);
            txtCorte.Name = "txtCorte";
            txtCorte.Size = new Size(80, 23);
            txtCorte.TabIndex = 5;
            // 
            // lblEmitidaPor
            // 
            lblEmitidaPor.AutoSize = true;
            lblEmitidaPor.Location = new Point(340, 26);
            lblEmitidaPor.Name = "lblEmitidaPor";
            lblEmitidaPor.Size = new Size(174, 15);
            lblEmitidaPor.TabIndex = 6;
            lblEmitidaPor.Text = "Emitida por (Jefe de Preparación)";
            // 
            // txtEmitidaPor
            // 
            txtEmitidaPor.Enabled = false;
            txtEmitidaPor.Location = new Point(340, 48);
            txtEmitidaPor.Name = "txtEmitidaPor";
            txtEmitidaPor.Size = new Size(180, 23);
            txtEmitidaPor.TabIndex = 7;
            // 
            // lvRenglones
            // 
            lvRenglones.Columns.AddRange(new ColumnHeader[] {
                colRenglonesSku,
                colRenglonesProducto,
                colRenglonesUbicacion,
                colRenglonesRequerida
            });
            lvRenglones.FullRowSelect = true;
            lvRenglones.GridLines = true;
            lvRenglones.Location = new Point(14, 85);
            lvRenglones.Name = "lvRenglones";
            lvRenglones.Size = new Size(850, 180);
            lvRenglones.TabIndex = 8;
            lvRenglones.UseCompatibleStateImageBehavior = false;
            lvRenglones.View = View.Details;
            // 
            // colRenglonesSku
            // 
            colRenglonesSku.Text = "SKU";
            colRenglonesSku.Width = 100;
            // 
            // colRenglonesProducto
            // 
            colRenglonesProducto.Text = "Producto";
            colRenglonesProducto.Width = 280;
            // 
            // colRenglonesUbicacion
            // 
            colRenglonesUbicacion.Text = "Ubicación (X-Y-Z)";
            colRenglonesUbicacion.Width = 150;
            // 
            // colRenglonesRequerida
            // 
            colRenglonesRequerida.Text = "Cantidad requerida";
            colRenglonesRequerida.Width = 140;
            // 
            // btnConfirmarEntrega
            // 
            btnConfirmarEntrega.Location = new Point(724, 405);
            btnConfirmarEntrega.Name = "btnConfirmarEntrega";
            btnConfirmarEntrega.Size = new Size(180, 30);
            btnConfirmarEntrega.TabIndex = 3;
            btnConfirmarEntrega.Text = "Confirmar entrega";
            btnConfirmarEntrega.UseVisualStyleBackColor = true;
            // 
            // SeleccionEntregaMercaderiaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 455);
            Controls.Add(lblTitulo);
            Controls.Add(lblEmpresa);
            Controls.Add(grpDetalleSeleccion);
            Controls.Add(btnConfirmarEntrega);
            Name = "SeleccionEntregaMercaderiaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pampazon - Selección y Entrega de Mercadería";
            grpDetalleSeleccion.ResumeLayout(false);
            grpDetalleSeleccion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmpresa;
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
        private System.Windows.Forms.ColumnHeader colRenglonesSku;
        private System.Windows.Forms.ColumnHeader colRenglonesProducto;
        private System.Windows.Forms.ColumnHeader colRenglonesUbicacion;
        private System.Windows.Forms.ColumnHeader colRenglonesRequerida;
        private System.Windows.Forms.Button btnConfirmarEntrega;
    }
}