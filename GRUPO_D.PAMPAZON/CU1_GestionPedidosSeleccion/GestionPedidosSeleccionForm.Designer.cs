
namespace GRUPO_D.PAMPAZON.CU1_GestionPedidosSeleccion
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
            lblTitulo = new Label();
            lblEmpresa = new Label();
            grpContexto = new GroupBox();
            lblDeposito = new Label();
            cboDeposito = new ComboBox();
            lblRol = new Label();
            grpValidacionOrdenes = new GroupBox();
            grpFiltros = new GroupBox();
            lblFiltroOrden = new Label();
            txtFiltroOrden = new TextBox();
            lblFiltroCliente = new Label();
            cboFiltroCliente = new ComboBox();
            lblFiltroOrigen = new Label();
            cboFiltroOrigen = new ComboBox();
            chkFiltroFechaAsignacion = new CheckBox();
            dtpFiltroFechaAsignacion = new DateTimePicker();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            lblOrdenesAsignadas = new Label();
            lvOrdenesAsignadas = new ListView();
            colOrdenesAsignadasNumero = new ColumnHeader();
            colOrdenesAsignadasAsignacion = new ColumnHeader();
            colOrdenesAsignadasCliente = new ColumnHeader();
            colOrdenesAsignadasOrigen = new ColumnHeader();
            colOrdenesAsignadasModalidad = new ColumnHeader();
            colOrdenesAsignadasProductos = new ColumnHeader();
            colOrdenesAsignadasEstado = new ColumnHeader();
            grpDetalleOrden = new GroupBox();
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblContrato = new Label();
            txtContrato = new TextBox();
            lblModalidad = new Label();
            txtModalidad = new TextBox();
            lblEstado = new Label();
            txtEstado = new TextBox();
            lvDisponibilidad = new ListView();
            colDisponibilidadSku = new ColumnHeader();
            colDisponibilidadProducto = new ColumnHeader();
            colDisponibilidadUnidad = new ColumnHeader();
            colDisponibilidadSolicitado = new ColumnHeader();
            colDisponibilidadDisponible = new ColumnHeader();
            colDisponibilidadValidacion = new ColumnHeader();
            lblAyudaStock = new Label();
            lblResultadoValidacion = new Label();
            lblMotivoRechazo = new Label();
            txtMotivoRechazo = new TextBox();
            grpCortesSeleccion = new GroupBox();
            btnDescartarPropuesta = new Button();
            lvPropuestaSeleccion = new ListView();
            colPropuestaSeleccionCliente = new ColumnHeader();
            colPropuestaSeleccionSku = new ColumnHeader();
            colPropuestaSeleccionProducto = new ColumnHeader();
            colPropuestaSeleccionUbicacion = new ColumnHeader();
            colPropuestaSeleccionCantidad = new ColumnHeader();
            colPropuestaSeleccionUnidad = new ColumnHeader();
            colPropuestaSeleccionPedidos = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            grpContexto.SuspendLayout();
            grpValidacionOrdenes.SuspendLayout();
            grpFiltros.SuspendLayout();
            grpDetalleOrden.SuspendLayout();
            grpCortesSeleccion.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Location = new Point(24, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(890, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Pedidos y Selección";
            // 
            // lblEmpresa
            // 
            lblEmpresa.Location = new Point(26, 48);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(1050, 22);
            lblEmpresa.TabIndex = 1;
            lblEmpresa.Text = "PAMPAZON";
            // 
            // grpContexto
            // 
            grpContexto.Controls.Add(lblDeposito);
            grpContexto.Controls.Add(cboDeposito);
            grpContexto.Controls.Add(lblRol);
            grpContexto.Location = new Point(16, 84);
            grpContexto.Name = "grpContexto";
            grpContexto.Size = new Size(1334, 72);
            grpContexto.TabIndex = 2;
            grpContexto.TabStop = false;
            grpContexto.Text = "Contexto de trabajo";
            // 
            // lblDeposito
            // 
            lblDeposito.Location = new Point(16, 30);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(68, 24);
            lblDeposito.TabIndex = 0;
            lblDeposito.Text = "Depósito";
            // 
            // cboDeposito
            // 
            cboDeposito.Enabled = false;
            cboDeposito.Items.AddRange(new object[] { "GBA" });
            cboDeposito.Location = new Point(90, 26);
            cboDeposito.Name = "cboDeposito";
            cboDeposito.Size = new Size(372, 23);
            cboDeposito.TabIndex = 1;
            // 
            // lblRol
            // 
            lblRol.Location = new Point(480, 29);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(210, 24);
            lblRol.TabIndex = 2;
            lblRol.Text = "Rol: Encargado de Preparación";
            // 
            // grpValidacionOrdenes
            // 
            grpValidacionOrdenes.Controls.Add(grpFiltros);
            grpValidacionOrdenes.Controls.Add(lblOrdenesAsignadas);
            grpValidacionOrdenes.Controls.Add(lvOrdenesAsignadas);
            grpValidacionOrdenes.Controls.Add(grpDetalleOrden);
            grpValidacionOrdenes.Controls.Add(lblMotivoRechazo);
            grpValidacionOrdenes.Controls.Add(txtMotivoRechazo);
            grpValidacionOrdenes.Location = new Point(16, 164);
            grpValidacionOrdenes.Name = "grpValidacionOrdenes";
            grpValidacionOrdenes.Size = new Size(636, 640);
            grpValidacionOrdenes.TabIndex = 3;
            grpValidacionOrdenes.TabStop = false;
            grpValidacionOrdenes.Text = "Órdenes asignadas · Validar, aceptar o rechazar (P01 / P02)";
            // 
            // grpFiltros
            // 
            grpFiltros.Controls.Add(lblFiltroOrden);
            grpFiltros.Controls.Add(txtFiltroOrden);
            grpFiltros.Controls.Add(lblFiltroCliente);
            grpFiltros.Controls.Add(cboFiltroCliente);
            grpFiltros.Controls.Add(lblFiltroOrigen);
            grpFiltros.Controls.Add(cboFiltroOrigen);
            grpFiltros.Controls.Add(chkFiltroFechaAsignacion);
            grpFiltros.Controls.Add(dtpFiltroFechaAsignacion);
            grpFiltros.Controls.Add(btnBuscar);
            grpFiltros.Controls.Add(btnLimpiar);
            grpFiltros.Location = new Point(12, 24);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(612, 112);
            grpFiltros.TabIndex = 0;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Buscar órdenes";
            // 
            // lblFiltroOrden
            // 
            lblFiltroOrden.Location = new Point(12, 22);
            lblFiltroOrden.Name = "lblFiltroOrden";
            lblFiltroOrden.Size = new Size(130, 20);
            lblFiltroOrden.TabIndex = 0;
            lblFiltroOrden.Text = "N.º de orden";
            // 
            // txtFiltroOrden
            // 
            txtFiltroOrden.Location = new Point(12, 44);
            txtFiltroOrden.Name = "txtFiltroOrden";
            txtFiltroOrden.Size = new Size(130, 23);
            txtFiltroOrden.TabIndex = 1;
            // 
            // lblFiltroCliente
            // 
            lblFiltroCliente.Location = new Point(154, 22);
            lblFiltroCliente.Name = "lblFiltroCliente";
            lblFiltroCliente.Size = new Size(180, 20);
            lblFiltroCliente.TabIndex = 2;
            lblFiltroCliente.Text = "Cliente";
            // 
            // cboFiltroCliente
            // 
            cboFiltroCliente.Items.AddRange(new object[] { "Todos los clientes", "Cliente Demo A", "Cliente Demo B" });
            cboFiltroCliente.Location = new Point(154, 44);
            cboFiltroCliente.Name = "cboFiltroCliente";
            cboFiltroCliente.Size = new Size(180, 23);
            cboFiltroCliente.TabIndex = 3;
            // 
            // lblFiltroOrigen
            // 
            lblFiltroOrigen.Location = new Point(346, 22);
            lblFiltroOrigen.Name = "lblFiltroOrigen";
            lblFiltroOrigen.Size = new Size(130, 20);
            lblFiltroOrigen.TabIndex = 4;
            lblFiltroOrigen.Text = "Origen";
            // 
            // cboFiltroOrigen
            // 
            cboFiltroOrigen.Items.AddRange(new object[] { "Todos", "Cliente", "Traslado interno" });
            cboFiltroOrigen.Location = new Point(346, 44);
            cboFiltroOrigen.Name = "cboFiltroOrigen";
            cboFiltroOrigen.Size = new Size(130, 23);
            cboFiltroOrigen.TabIndex = 5;
            // 
            // chkFiltroFechaAsignacion
            // 
            chkFiltroFechaAsignacion.Location = new Point(488, 20);
            chkFiltroFechaAsignacion.Name = "chkFiltroFechaAsignacion";
            chkFiltroFechaAsignacion.Size = new Size(118, 22);
            chkFiltroFechaAsignacion.TabIndex = 6;
            chkFiltroFechaAsignacion.Text = "Asignada desde";
            // 
            // dtpFiltroFechaAsignacion
            // 
            dtpFiltroFechaAsignacion.Enabled = false;
            dtpFiltroFechaAsignacion.Format = DateTimePickerFormat.Short;
            dtpFiltroFechaAsignacion.Location = new Point(488, 44);
            dtpFiltroFechaAsignacion.Name = "dtpFiltroFechaAsignacion";
            dtpFiltroFechaAsignacion.Size = new Size(112, 23);
            dtpFiltroFechaAsignacion.TabIndex = 7;
            dtpFiltroFechaAsignacion.Value = new DateTime(2026, 10, 12, 0, 0, 0, 0);
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 74);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(296, 30);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(314, 74);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(286, 30);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            // 
            // lblOrdenesAsignadas
            // 
            lblOrdenesAsignadas.Location = new Point(12, 144);
            lblOrdenesAsignadas.Name = "lblOrdenesAsignadas";
            lblOrdenesAsignadas.Size = new Size(612, 20);
            lblOrdenesAsignadas.TabIndex = 1;
            lblOrdenesAsignadas.Text = "Órdenes asignadas al depósito";
            // 
            // lvOrdenesAsignadas
            // 
            lvOrdenesAsignadas.Columns.AddRange(new ColumnHeader[] { colOrdenesAsignadasNumero, colOrdenesAsignadasAsignacion, colOrdenesAsignadasCliente, colOrdenesAsignadasOrigen, colOrdenesAsignadasModalidad, colOrdenesAsignadasProductos, colOrdenesAsignadasEstado });
            lvOrdenesAsignadas.FullRowSelect = true;
            lvOrdenesAsignadas.GridLines = true;
            lvOrdenesAsignadas.Location = new Point(12, 166);
            lvOrdenesAsignadas.MultiSelect = false;
            lvOrdenesAsignadas.Name = "lvOrdenesAsignadas";
            lvOrdenesAsignadas.Size = new Size(612, 118);
            lvOrdenesAsignadas.TabIndex = 2;
            lvOrdenesAsignadas.UseCompatibleStateImageBehavior = false;
            lvOrdenesAsignadas.View = View.Details;
            // 
            // colOrdenesAsignadasNumero
            // 
            colOrdenesAsignadasNumero.Text = "N.º de orden";
            colOrdenesAsignadasNumero.Width = 85;
            // 
            // colOrdenesAsignadasAsignacion
            // 
            colOrdenesAsignadasAsignacion.Text = "Asignación";
            colOrdenesAsignadasAsignacion.Width = 80;
            // 
            // colOrdenesAsignadasCliente
            // 
            colOrdenesAsignadasCliente.Text = "Cliente";
            colOrdenesAsignadasCliente.Width = 108;
            // 
            // colOrdenesAsignadasOrigen
            // 
            colOrdenesAsignadasOrigen.Text = "Origen";
            colOrdenesAsignadasOrigen.Width = 105;
            // 
            // colOrdenesAsignadasModalidad
            // 
            colOrdenesAsignadasModalidad.Text = "Modalidad";
            colOrdenesAsignadasModalidad.Width = 90;
            // 
            // colOrdenesAsignadasProductos
            // 
            colOrdenesAsignadasProductos.Text = "Productos";
            colOrdenesAsignadasProductos.Width = 65;
            // 
            // colOrdenesAsignadasEstado
            // 
            colOrdenesAsignadasEstado.Text = "Estado";
            colOrdenesAsignadasEstado.Width = 75;
            // 
            // grpDetalleOrden
            // 
            grpDetalleOrden.Controls.Add(lblCliente);
            grpDetalleOrden.Controls.Add(txtCliente);
            grpDetalleOrden.Controls.Add(lblContrato);
            grpDetalleOrden.Controls.Add(txtContrato);
            grpDetalleOrden.Controls.Add(lblModalidad);
            grpDetalleOrden.Controls.Add(txtModalidad);
            grpDetalleOrden.Controls.Add(lblEstado);
            grpDetalleOrden.Controls.Add(txtEstado);
            grpDetalleOrden.Controls.Add(lvDisponibilidad);
            grpDetalleOrden.Controls.Add(lblAyudaStock);
            grpDetalleOrden.Controls.Add(lblResultadoValidacion);
            grpDetalleOrden.Location = new Point(12, 356);
            grpDetalleOrden.Name = "grpDetalleOrden";
            grpDetalleOrden.Size = new Size(612, 268);
            grpDetalleOrden.TabIndex = 3;
            grpDetalleOrden.TabStop = false;
            grpDetalleOrden.Text = "Detalle de la orden";
            // 
            // lblCliente
            // 
            lblCliente.Location = new Point(10, 27);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(60, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(74, 24);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(220, 23);
            txtCliente.TabIndex = 1;
            // 
            // lblContrato
            // 
            lblContrato.Location = new Point(312, 27);
            lblContrato.Name = "lblContrato";
            lblContrato.Size = new Size(60, 20);
            lblContrato.TabIndex = 2;
            lblContrato.Text = "Contrato";
            // 
            // txtContrato
            // 
            txtContrato.Enabled = false;
            txtContrato.Location = new Point(376, 24);
            txtContrato.Name = "txtContrato";
            txtContrato.Size = new Size(222, 23);
            txtContrato.TabIndex = 3;
            // 
            // lblModalidad
            // 
            lblModalidad.Location = new Point(10, 58);
            lblModalidad.Name = "lblModalidad";
            lblModalidad.Size = new Size(64, 20);
            lblModalidad.TabIndex = 4;
            lblModalidad.Text = "Modalidad";
            // 
            // txtModalidad
            // 
            txtModalidad.Enabled = false;
            txtModalidad.Location = new Point(74, 55);
            txtModalidad.Name = "txtModalidad";
            txtModalidad.Size = new Size(220, 23);
            txtModalidad.TabIndex = 5;
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(312, 58);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(60, 20);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Enabled = false;
            txtEstado.Location = new Point(376, 55);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(222, 23);
            txtEstado.TabIndex = 7;
            // 
            // lvDisponibilidad
            // 
            lvDisponibilidad.Columns.AddRange(new ColumnHeader[] { colDisponibilidadSku, colDisponibilidadProducto, colDisponibilidadUnidad, colDisponibilidadSolicitado, colDisponibilidadDisponible, colDisponibilidadValidacion });
            lvDisponibilidad.FullRowSelect = true;
            lvDisponibilidad.GridLines = true;
            lvDisponibilidad.Location = new Point(10, 88);
            lvDisponibilidad.MultiSelect = false;
            lvDisponibilidad.Name = "lvDisponibilidad";
            lvDisponibilidad.Size = new Size(592, 120);
            lvDisponibilidad.TabIndex = 8;
            lvDisponibilidad.UseCompatibleStateImageBehavior = false;
            lvDisponibilidad.View = View.Details;
            // 
            // colDisponibilidadSku
            // 
            colDisponibilidadSku.Text = "SKU";
            colDisponibilidadSku.Width = 70;
            // 
            // colDisponibilidadProducto
            // 
            colDisponibilidadProducto.Text = "Producto";
            colDisponibilidadProducto.Width = 158;
            // 
            // colDisponibilidadUnidad
            // 
            colDisponibilidadUnidad.Text = "Unidad";
            // 
            // colDisponibilidadSolicitado
            // 
            colDisponibilidadSolicitado.Text = "Solicitado";
            colDisponibilidadSolicitado.Width = 75;
            // 
            // colDisponibilidadDisponible
            // 
            colDisponibilidadDisponible.Text = "Disponible";
            colDisponibilidadDisponible.Width = 75;
            // 
            // colDisponibilidadValidacion
            // 
            colDisponibilidadValidacion.Text = "Validación";
            colDisponibilidadValidacion.Width = 145;
            // 
            // lblAyudaStock
            // 
            lblAyudaStock.Location = new Point(10, 214);
            lblAyudaStock.Name = "lblAyudaStock";
            lblAyudaStock.Size = new Size(592, 20);
            lblAyudaStock.TabIndex = 9;
            lblAyudaStock.Text = "Disponible: mercadería aceptada y no comprometida del cliente en este depósito.";
            // 
            // lblResultadoValidacion
            // 
            lblResultadoValidacion.Location = new Point(10, 238);
            lblResultadoValidacion.Name = "lblResultadoValidacion";
            lblResultadoValidacion.Size = new Size(592, 24);
            lblResultadoValidacion.TabIndex = 10;
            lblResultadoValidacion.Text = "Validación pendiente. Al aceptar se compromete el stock, sin descontar las existencias físicas.";
            // 
            // lblMotivoRechazo
            // 
            lblMotivoRechazo.Location = new Point(12, 299);
            lblMotivoRechazo.Name = "lblMotivoRechazo";
            lblMotivoRechazo.Size = new Size(612, 20);
            lblMotivoRechazo.TabIndex = 7;
            lblMotivoRechazo.Text = "Motivo del rechazo";
            // 
            // txtMotivoRechazo
            // 
            txtMotivoRechazo.Enabled = false;
            txtMotivoRechazo.Location = new Point(12, 325);
            txtMotivoRechazo.Name = "txtMotivoRechazo";
            txtMotivoRechazo.Size = new Size(612, 23);
            txtMotivoRechazo.TabIndex = 8;
            txtMotivoRechazo.Text = "Se completará con los productos y cantidades faltantes.";
            // 
            // grpCortesSeleccion
            // 
            grpCortesSeleccion.Controls.Add(groupBox1);
            grpCortesSeleccion.Controls.Add(lvPropuestaSeleccion);
            grpCortesSeleccion.Controls.Add(btnDescartarPropuesta);
            grpCortesSeleccion.Location = new Point(766, 164);
            grpCortesSeleccion.Name = "grpCortesSeleccion";
            grpCortesSeleccion.Size = new Size(584, 640);
            grpCortesSeleccion.TabIndex = 4;
            grpCortesSeleccion.TabStop = false;
            grpCortesSeleccion.Text = "Vista previa de la selección";
            // 
            // btnDescartarPropuesta
            // 
            btnDescartarPropuesta.Location = new Point(377, 530);
            btnDescartarPropuesta.Name = "btnDescartarPropuesta";
            btnDescartarPropuesta.Size = new Size(200, 34);
            btnDescartarPropuesta.TabIndex = 7;
            btnDescartarPropuesta.Text = "Descartar propuesta";
            // 
            // lvPropuestaSeleccion
            // 
            lvPropuestaSeleccion.Columns.AddRange(new ColumnHeader[] { colPropuestaSeleccionCliente, colPropuestaSeleccionSku, colPropuestaSeleccionProducto, colPropuestaSeleccionUbicacion, colPropuestaSeleccionCantidad, colPropuestaSeleccionUnidad, colPropuestaSeleccionPedidos });
            lvPropuestaSeleccion.FullRowSelect = true;
            lvPropuestaSeleccion.GridLines = true;
            lvPropuestaSeleccion.Location = new Point(6, 22);
            lvPropuestaSeleccion.MultiSelect = false;
            lvPropuestaSeleccion.Name = "lvPropuestaSeleccion";
            lvPropuestaSeleccion.Size = new Size(571, 490);
            lvPropuestaSeleccion.TabIndex = 8;
            lvPropuestaSeleccion.UseCompatibleStateImageBehavior = false;
            lvPropuestaSeleccion.View = View.Details;
            // 
            // colPropuestaSeleccionCliente
            // 
            colPropuestaSeleccionCliente.Text = "Cliente";
            colPropuestaSeleccionCliente.Width = 100;
            // 
            // colPropuestaSeleccionSku
            // 
            colPropuestaSeleccionSku.Text = "SKU";
            colPropuestaSeleccionSku.Width = 65;
            // 
            // colPropuestaSeleccionProducto
            // 
            colPropuestaSeleccionProducto.Text = "Producto";
            colPropuestaSeleccionProducto.Width = 113;
            // 
            // colPropuestaSeleccionUbicacion
            // 
            colPropuestaSeleccionUbicacion.Text = "Ubicación";
            colPropuestaSeleccionUbicacion.Width = 70;
            // 
            // colPropuestaSeleccionCantidad
            // 
            colPropuestaSeleccionCantidad.Text = "Cantidad";
            // 
            // colPropuestaSeleccionUnidad
            // 
            colPropuestaSeleccionUnidad.Text = "Unidad";
            colPropuestaSeleccionUnidad.Width = 55;
            // 
            // colPropuestaSeleccionPedidos
            // 
            colPropuestaSeleccionPedidos.Text = "Pedidos de origen";
            colPropuestaSeleccionPedidos.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(660, 333);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 5;
            button1.Text = "Agregar >>";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(660, 372);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 6;
            button2.Text = "<< Quitar";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(6, 570);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(571, 54);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Corte Operativo";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(105, 24);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(92, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Primer Corte";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(326, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Segundo Corte";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // GestionPedidosSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 809);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblTitulo);
            Controls.Add(lblEmpresa);
            Controls.Add(grpContexto);
            Controls.Add(grpValidacionOrdenes);
            Controls.Add(grpCortesSeleccion);
            Name = "GestionPedidosSeleccionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pampazon - Gestión de Pedidos y Selección";
            grpContexto.ResumeLayout(false);
            grpValidacionOrdenes.ResumeLayout(false);
            grpValidacionOrdenes.PerformLayout();
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            grpDetalleOrden.ResumeLayout(false);
            grpDetalleOrden.PerformLayout();
            grpCortesSeleccion.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Label lblTitulo;
        private Label lblEmpresa;
        private GroupBox grpContexto;
        private Label lblDeposito;
        private ComboBox cboDeposito;
        private Label lblRol;
        private GroupBox grpValidacionOrdenes;
        private GroupBox grpFiltros;
        private Label lblFiltroOrden;
        private TextBox txtFiltroOrden;
        private Label lblFiltroCliente;
        private ComboBox cboFiltroCliente;
        private Label lblFiltroOrigen;
        private ComboBox cboFiltroOrigen;
        private CheckBox chkFiltroFechaAsignacion;
        private DateTimePicker dtpFiltroFechaAsignacion;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Label lblOrdenesAsignadas;
        private ListView lvOrdenesAsignadas;
        private ColumnHeader colOrdenesAsignadasNumero;
        private ColumnHeader colOrdenesAsignadasAsignacion;
        private ColumnHeader colOrdenesAsignadasCliente;
        private ColumnHeader colOrdenesAsignadasOrigen;
        private ColumnHeader colOrdenesAsignadasModalidad;
        private ColumnHeader colOrdenesAsignadasProductos;
        private ColumnHeader colOrdenesAsignadasEstado;
        private GroupBox grpDetalleOrden;
        private Label lblCliente;
        private TextBox txtCliente;
        private Label lblContrato;
        private TextBox txtContrato;
        private Label lblModalidad;
        private TextBox txtModalidad;
        private Label lblEstado;
        private TextBox txtEstado;
        private ListView lvDisponibilidad;
        private ColumnHeader colDisponibilidadSku;
        private ColumnHeader colDisponibilidadProducto;
        private ColumnHeader colDisponibilidadUnidad;
        private ColumnHeader colDisponibilidadSolicitado;
        private ColumnHeader colDisponibilidadDisponible;
        private ColumnHeader colDisponibilidadValidacion;
        private Label lblAyudaStock;
        private Label lblResultadoValidacion;
        private Label lblMotivoRechazo;
        private TextBox txtMotivoRechazo;
        private GroupBox grpCortesSeleccion;
        private Button btnDescartarPropuesta;
        private ListView lvPropuestaSeleccion;
        private ColumnHeader colPropuestaSeleccionCliente;
        private ColumnHeader colPropuestaSeleccionSku;
        private ColumnHeader colPropuestaSeleccionProducto;
        private ColumnHeader colPropuestaSeleccionUbicacion;
        private ColumnHeader colPropuestaSeleccionCantidad;
        private ColumnHeader colPropuestaSeleccionUnidad;
        private ColumnHeader colPropuestaSeleccionPedidos;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
