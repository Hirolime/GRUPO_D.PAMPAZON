namespace GRUPO_D.PAMPAZON.CU4_RecepcionDespachoPedidos
{
    partial class RecepcionDespachoPedidosForm
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
            tabControlMain = new TabControl();
            tabRecepcion = new TabPage();
            tabDespacho = new TabPage();

            // Controles Pestaña 1
            lblTitulo1 = new Label();
            lblEmpresa1 = new Label();
            grpRecepcion = new GroupBox();
            lblFiltroEntrega = new Label();
            txtFiltroEntrega = new TextBox();
            btnBuscarRecepcion = new Button();
            btnLimpiarRecepcion = new Button();
            lblEntregasPreparadas = new Label();
            lvEntregasPreparadas = new ListView();
            colEntregasPreparadasNumero = new ColumnHeader();
            colEntregasPreparadasPedido = new ColumnHeader();
            colEntregasPreparadasBultos = new ColumnHeader();
            lblControlRecepcion = new Label();
            lvControlRecepcion = new ListView();
            colControlRecepcionSku = new ColumnHeader();
            colControlRecepcionProducto = new ColumnHeader();
            colControlRecepcionCantidad = new ColumnHeader();
            btnConfirmarRecepcion = new Button();

            // Controles Pestaña 2
            grpDespacho = new GroupBox();
            lblTransportista = new Label();
            txtTransportista = new TextBox();
            btnBuscarDespacho = new Button();
            lblEntregasEnDespacho = new Label();
            lvEntregasEnDespacho = new ListView();
            colOp = new ColumnHeader();
            colEstado = new ColumnHeader();
            btnCerrarDespacho = new Button();

            tabControlMain.SuspendLayout();
            tabRecepcion.SuspendLayout();
            tabDespacho.SuspendLayout();
            grpRecepcion.SuspendLayout();
            grpDespacho.SuspendLayout();
            SuspendLayout();

            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabRecepcion);
            tabControlMain.Controls.Add(tabDespacho);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(920, 540);
            tabControlMain.TabIndex = 0;

            // 
            // tabRecepcion
            // 
            tabRecepcion.Controls.Add(lblTitulo1);
            tabRecepcion.Controls.Add(lblEmpresa1);
            tabRecepcion.Controls.Add(grpRecepcion);
            tabRecepcion.Controls.Add(btnConfirmarRecepcion);
            tabRecepcion.Location = new Point(4, 24);
            tabRecepcion.Name = "tabRecepcion";
            tabRecepcion.Padding = new Padding(3);
            tabRecepcion.Size = new Size(912, 512);
            tabRecepcion.TabIndex = 0;
            tabRecepcion.Text = "Recepción de Pedidos";
            tabRecepcion.UseVisualStyleBackColor = true;

            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.Location = new Point(20, 10);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(184, 15);
            lblTitulo1.Text = "Recepción y Despacho de Pedidos";

            // 
            // lblEmpresa1
            // 
            lblEmpresa1.AutoSize = true;
            lblEmpresa1.Location = new Point(20, 30);
            lblEmpresa1.Name = "lblEmpresa1";
            lblEmpresa1.Size = new Size(71, 15);
            lblEmpresa1.Text = "PAMPAZON";

            // 
            // grpRecepcion
            // 
            grpRecepcion.Controls.Add(lblFiltroEntrega);
            grpRecepcion.Controls.Add(txtFiltroEntrega);
            grpRecepcion.Controls.Add(btnBuscarRecepcion);
            grpRecepcion.Controls.Add(btnLimpiarRecepcion);
            grpRecepcion.Controls.Add(lblEntregasPreparadas);
            grpRecepcion.Controls.Add(lvEntregasPreparadas);
            grpRecepcion.Controls.Add(lblControlRecepcion);
            grpRecepcion.Controls.Add(lvControlRecepcion);
            grpRecepcion.Location = new Point(20, 55);
            grpRecepcion.Name = "grpRecepcion";
            grpRecepcion.Size = new Size(865, 390);
            grpRecepcion.TabStop = false;
            grpRecepcion.Text = "Recepción de pedidos preparados";

            // 
            // lblFiltroEntrega
            // 
            lblFiltroEntrega.AutoSize = true;
            lblFiltroEntrega.Location = new Point(14, 25);
            lblFiltroEntrega.Text = "N.º de orden de entrega";

            // 
            // txtFiltroEntrega
            // 
            txtFiltroEntrega.Location = new Point(14, 45);
            txtFiltroEntrega.Name = "txtFiltroEntrega";
            txtFiltroEntrega.Size = new Size(240, 23);

            // 
            // btnBuscarRecepcion
            // 
            btnBuscarRecepcion.Location = new Point(270, 43);
            btnBuscarRecepcion.Name = "btnBuscarRecepcion";
            btnBuscarRecepcion.Size = new Size(110, 26);
            btnBuscarRecepcion.Text = "Buscar";

            // 
            // btnLimpiarRecepcion
            // 
            btnLimpiarRecepcion.Location = new Point(390, 43);
            btnLimpiarRecepcion.Name = "btnLimpiarRecepcion";
            btnLimpiarRecepcion.Size = new Size(110, 26);
            btnLimpiarRecepcion.Text = "Limpiar";

            // 
            // lblEntregasPreparadas
            // 
            lblEntregasPreparadas.AutoSize = true;
            lblEntregasPreparadas.Location = new Point(14, 85);
            lblEntregasPreparadas.Text = "Órdenes de entrega de pedidos preparados";

            // 
            // lvEntregasPreparadas
            // 
            lvEntregasPreparadas.Columns.AddRange(new ColumnHeader[] { colEntregasPreparadasNumero, colEntregasPreparadasPedido, colEntregasPreparadasBultos });
            lvEntregasPreparadas.FullRowSelect = true;
            lvEntregasPreparadas.GridLines = true;
            lvEntregasPreparadas.Location = new Point(14, 105);
            lvEntregasPreparadas.Name = "lvEntregasPreparadas";
            lvEntregasPreparadas.Size = new Size(835, 110);
            lvEntregasPreparadas.View = View.Details;

            colEntregasPreparadasNumero.Text = "N.º de orden de entrega";
            colEntregasPreparadasNumero.Width = 200;
            colEntregasPreparadasPedido.Text = "Pedido";
            colEntregasPreparadasPedido.Width = 150;
            colEntregasPreparadasBultos.Text = "Bultos";
            colEntregasPreparadasBultos.Width = 100;

            // 
            // lblControlRecepcion
            // 
            lblControlRecepcion.AutoSize = true;
            lblControlRecepcion.Location = new Point(14, 230);
            lblControlRecepcion.Text = "Control de bultos recibidos";

            // 
            // lvControlRecepcion
            // 
            lvControlRecepcion.Columns.AddRange(new ColumnHeader[] { colControlRecepcionSku, colControlRecepcionProducto, colControlRecepcionCantidad });
            lvControlRecepcion.FullRowSelect = true;
            lvControlRecepcion.GridLines = true;
            lvControlRecepcion.Location = new Point(14, 250);
            lvControlRecepcion.Name = "lvControlRecepcion";
            lvControlRecepcion.Size = new Size(835, 120);
            lvControlRecepcion.View = View.Details;

            colControlRecepcionSku.Text = "SKU";
            colControlRecepcionSku.Width = 120;
            colControlRecepcionProducto.Text = "Producto";
            colControlRecepcionProducto.Width = 350;
            colControlRecepcionCantidad.Text = "Cantidad según la orden";
            colControlRecepcionCantidad.Width = 180;

            // 
            // btnConfirmarRecepcion
            // 
            btnConfirmarRecepcion.Location = new Point(705, 455);
            btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            btnConfirmarRecepcion.Size = new Size(180, 30);
            btnConfirmarRecepcion.Text = "Confirmar recepción";

            // 
            // tabDespacho
            // 
            tabDespacho.Controls.Add(grpDespacho);
            tabDespacho.Location = new Point(4, 24);
            tabDespacho.Name = "tabDespacho";
            tabDespacho.Padding = new Padding(3);
            tabDespacho.Size = new Size(912, 512);
            tabDespacho.TabIndex = 1;
            tabDespacho.Text = "Retiro y Cierre del Despacho";
            tabDespacho.UseVisualStyleBackColor = true;

            // 
            // grpDespacho
            // 
            grpDespacho.Controls.Add(lblTransportista);
            grpDespacho.Controls.Add(txtTransportista);
            grpDespacho.Controls.Add(btnBuscarDespacho);
            grpDespacho.Controls.Add(lblEntregasEnDespacho);
            grpDespacho.Controls.Add(lvEntregasEnDespacho);
            grpDespacho.Controls.Add(btnCerrarDespacho);
            grpDespacho.Location = new Point(20, 20);
            grpDespacho.Name = "grpDespacho";
            grpDespacho.Size = new Size(865, 340);
            grpDespacho.TabStop = false;
            grpDespacho.Text = "Retiro y cierre del despacho";

            // 
            // lblTransportista
            // 
            lblTransportista.AutoSize = true;
            lblTransportista.Location = new Point(14, 30);
            lblTransportista.Text = "Identificación del transportista";

            // 
            // txtTransportista
            // 
            txtTransportista.Location = new Point(14, 50);
            txtTransportista.Name = "txtTransportista";
            txtTransportista.Size = new Size(250, 23);

            // 
            // btnBuscarDespacho
            // 
            btnBuscarDespacho.Location = new Point(280, 48);
            btnBuscarDespacho.Name = "btnBuscarDespacho";
            btnBuscarDespacho.Size = new Size(180, 26);
            btnBuscarDespacho.Text = "Buscar";

            // 
            // lblEntregasEnDespacho
            // 
            lblEntregasEnDespacho.AutoSize = true;
            lblEntregasEnDespacho.Location = new Point(14, 90);
            lblEntregasEnDespacho.Text = "Órdenes de entrega disponibles para el retiro";

            // 
            // lvEntregasEnDespacho
            // 
            lvEntregasEnDespacho.Columns.AddRange(new ColumnHeader[] { colOp, colEstado });
            lvEntregasEnDespacho.FullRowSelect = true;
            lvEntregasEnDespacho.GridLines = true;
            lvEntregasEnDespacho.Location = new Point(14, 110);
            lvEntregasEnDespacho.Name = "lvEntregasEnDespacho";
            lvEntregasEnDespacho.Size = new Size(835, 140);
            lvEntregasEnDespacho.View = View.Details;

            colOp.Text = "O.P.";
            colOp.Width = 250;
            colEstado.Text = "Estado";
            colEstado.Width = 250;

            // 
            // btnCerrarDespacho
            // 
            btnCerrarDespacho.Location = new Point(14, 270);
            btnCerrarDespacho.Name = "btnCerrarDespacho";
            btnCerrarDespacho.Size = new Size(835, 34);
            btnCerrarDespacho.Text = "Cerrar despacho";

            // 
            // RecepcionDespachoPedidosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 540);
            Controls.Add(tabControlMain);
            Name = "RecepcionDespachoPedidosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pampazon - Recepción y Despacho de Pedidos";
            tabControlMain.ResumeLayout(false);
            tabRecepcion.ResumeLayout(false);
            tabRecepcion.PerformLayout();
            tabDespacho.ResumeLayout(false);
            grpRecepcion.ResumeLayout(false);
            grpRecepcion.PerformLayout();
            grpDespacho.ResumeLayout(false);
            grpDespacho.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabRecepcion;
        private System.Windows.Forms.TabPage tabDespacho;

        // Pestaña 1
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblEmpresa1;
        private System.Windows.Forms.GroupBox grpRecepcion;
        private System.Windows.Forms.Label lblFiltroEntrega;
        private System.Windows.Forms.TextBox txtFiltroEntrega;
        private System.Windows.Forms.Button btnBuscarRecepcion;
        private System.Windows.Forms.Button btnLimpiarRecepcion;
        private System.Windows.Forms.Label lblEntregasPreparadas;
        private System.Windows.Forms.ListView lvEntregasPreparadas;
        private System.Windows.Forms.ColumnHeader colEntregasPreparadasNumero;
        private System.Windows.Forms.ColumnHeader colEntregasPreparadasPedido;
        private System.Windows.Forms.ColumnHeader colEntregasPreparadasBultos;
        private System.Windows.Forms.Label lblControlRecepcion;
        private System.Windows.Forms.ListView lvControlRecepcion;
        private System.Windows.Forms.ColumnHeader colControlRecepcionSku;
        private System.Windows.Forms.ColumnHeader colControlRecepcionProducto;
        private System.Windows.Forms.ColumnHeader colControlRecepcionCantidad;
        private System.Windows.Forms.Button btnConfirmarRecepcion;

        // Pestaña 2
        private System.Windows.Forms.GroupBox grpDespacho;
        private System.Windows.Forms.Label lblTransportista;
        private System.Windows.Forms.TextBox txtTransportista;
        private System.Windows.Forms.Button btnBuscarDespacho;
        private System.Windows.Forms.Label lblEntregasEnDespacho;
        private System.Windows.Forms.ListView lvEntregasEnDespacho;
        private System.Windows.Forms.ColumnHeader colOp;
        private System.Windows.Forms.ColumnHeader colEstado;
        private System.Windows.Forms.Button btnCerrarDespacho;
    }
}