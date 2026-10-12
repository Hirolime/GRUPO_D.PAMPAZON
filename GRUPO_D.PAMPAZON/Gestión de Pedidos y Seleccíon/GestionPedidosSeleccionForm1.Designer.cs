namespace GRUPO_D.PAMPAZON.Gestión_de_Pedidos_y_Seleccíon
{
    partial class GestionPedidosSeleccionForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            gbUsuario = new GroupBox();
            lbDeposito = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            listBox1 = new ListBox();
            radioButton1 = new RadioButton();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            lbFecha = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            label4 = new Label();
            tabControl1 = new TabControl();
            tbOrdAsignadas = new TabPage();
            tbCortesSeleccion = new TabPage();
            gbBuscarOrdenes = new GroupBox();
            gbUsuario.SuspendLayout();
            tabControl1.SuspendLayout();
            tbOrdAsignadas.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(387, 36);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Pedidos y Selección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 45);
            label2.Name = "label2";
            label2.Size = new Size(224, 15);
            label2.TabIndex = 1;
            label2.Text = "PAMPAZON  |  Encargado de Preparación";
            // 
            // gbUsuario
            // 
            gbUsuario.Controls.Add(comboBox2);
            gbUsuario.Controls.Add(label4);
            gbUsuario.Controls.Add(dateTimePicker1);
            gbUsuario.Controls.Add(lbFecha);
            gbUsuario.Controls.Add(comboBox1);
            gbUsuario.Controls.Add(lbDeposito);
            gbUsuario.Location = new Point(10, 63);
            gbUsuario.Name = "gbUsuario";
            gbUsuario.Size = new Size(977, 67);
            gbUsuario.TabIndex = 3;
            gbUsuario.TabStop = false;
            gbUsuario.Text = "Usuario";
            // 
            // lbDeposito
            // 
            lbDeposito.AutoSize = true;
            lbDeposito.Location = new Point(19, 33);
            lbDeposito.Name = "lbDeposito";
            lbDeposito.Size = new Size(54, 15);
            lbDeposito.TabIndex = 0;
            lbDeposito.Text = "Deposito";
            // 
            // button1
            // 
            button1.Location = new Point(138, 369);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(428, 380);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 506);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(295, 467);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 7;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(610, 355);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(582, 474);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(82, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(253, 23);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Nombre de Deposito";
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Location = new Point(638, 33);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(38, 15);
            lbFecha.TabIndex = 11;
            lbFecha.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(682, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(272, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(395, 30);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(237, 23);
            comboBox2.TabIndex = 13;
            comboBox2.Text = "Usuario";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 33);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 12;
            label4.Text = "Usuario";
            label4.Click += this.label4_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbOrdAsignadas);
            tabControl1.Controls.Add(tbCortesSeleccion);
            tabControl1.Location = new Point(12, 136);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(975, 175);
            tabControl1.TabIndex = 10;
            // 
            // tbOrdAsignadas
            // 
            tbOrdAsignadas.Controls.Add(gbBuscarOrdenes);
            tbOrdAsignadas.Location = new Point(4, 24);
            tbOrdAsignadas.Name = "tbOrdAsignadas";
            tbOrdAsignadas.Padding = new Padding(3);
            tbOrdAsignadas.Size = new Size(967, 147);
            tbOrdAsignadas.TabIndex = 0;
            tbOrdAsignadas.Text = "Ordenes Asignadas";
            tbOrdAsignadas.UseVisualStyleBackColor = true;
            // 
            // tbCortesSeleccion
            // 
            tbCortesSeleccion.Location = new Point(4, 24);
            tbCortesSeleccion.Name = "tbCortesSeleccion";
            tbCortesSeleccion.Padding = new Padding(3);
            tbCortesSeleccion.Size = new Size(967, 147);
            tbCortesSeleccion.TabIndex = 1;
            tbCortesSeleccion.Text = "Cortes de Selección";
            tbCortesSeleccion.UseVisualStyleBackColor = true;
            // 
            // gbBuscarOrdenes
            // 
            gbBuscarOrdenes.Location = new Point(6, 6);
            gbBuscarOrdenes.Name = "gbBuscarOrdenes";
            gbBuscarOrdenes.Size = new Size(955, 128);
            gbBuscarOrdenes.TabIndex = 0;
            gbBuscarOrdenes.TabStop = false;
            gbBuscarOrdenes.Text = "Buscar Órdenes";
            // 
            // GestionPedidosSeleccionForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(999, 611);
            Controls.Add(tabControl1);
            Controls.Add(checkBox1);
            Controls.Add(radioButton1);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(gbUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionPedidosSeleccionForm1";
            Text = "Pampazon - Gestión de Pedidos y Selección";
            gbUsuario.ResumeLayout(false);
            gbUsuario.PerformLayout();
            tabControl1.ResumeLayout(false);
            tbOrdAsignadas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox gbUsuario;
        private Label lbDeposito;
        private Label lbFecha;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private ListBox listBox1;
        private RadioButton radioButton1;
        private CheckBox checkBox1;
        private ComboBox comboBox2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TabControl tabControl1;
        private TabPage tbOrdAsignadas;
        private GroupBox gbBuscarOrdenes;
        private TabPage tbCortesSeleccion;
    }
}