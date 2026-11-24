namespace administracion_cafeteria
{
    partial class RegistroInformacion
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
            lblRegistro = new Label();
            btnVolver01 = new Button();
            DTIFecha = new DateTimePicker();
            lblFecha = new Label();
            lblProducto = new Label();
            lblNumPedido = new Label();
            lblCantidad = new Label();
            lblPrecio = new Label();
            lblMedioDePago = new Label();
            lblAtencion = new Label();
            numericUpDown1 = new NumericUpDown();
            cbProducto = new ComboBox();
            rbnServir = new RadioButton();
            rbnLlevar = new RadioButton();
            rbnTarjeta = new RadioButton();
            rbnEfectivo = new RadioButton();
            gbAtencion = new GroupBox();
            gbMedioDePago = new GroupBox();
            btnAgregarProductos = new Button();
            lsbxProductos = new ListView();
            btnRegistrarPedido = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            gbAtencion.SuspendLayout();
            gbMedioDePago.SuspendLayout();
            SuspendLayout();
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Segoe UI", 12F);
            lblRegistro.Location = new Point(25, 9);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(250, 21);
            lblRegistro.TabIndex = 0;
            lblRegistro.Text = "REGISTRAR INFORMACIÓN FORM";
            lblRegistro.Click += label1_Click;
            // 
            // btnVolver01
            // 
            btnVolver01.Location = new Point(297, 294);
            btnVolver01.Name = "btnVolver01";
            btnVolver01.Size = new Size(75, 23);
            btnVolver01.TabIndex = 1;
            btnVolver01.Text = "Volver";
            btnVolver01.UseVisualStyleBackColor = true;
            btnVolver01.Click += button1_Click;
            // 
            // DTIFecha
            // 
            DTIFecha.Location = new Point(44, 53);
            DTIFecha.Name = "DTIFecha";
            DTIFecha.Size = new Size(168, 23);
            DTIFecha.TabIndex = 2;
            DTIFecha.ValueChanged += DTIFecha_ValueChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(44, 35);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha:";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.CausesValidation = false;
            lblProducto.Location = new Point(45, 121);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 4;
            lblProducto.Text = "Producto";
            lblProducto.Click += label1_Click_1;
            // 
            // lblNumPedido
            // 
            lblNumPedido.AutoSize = true;
            lblNumPedido.Location = new Point(46, 94);
            lblNumPedido.Name = "lblNumPedido";
            lblNumPedido.Size = new Size(113, 15);
            lblNumPedido.TabIndex = 5;
            lblNumPedido.Text = "Numero del Pedido:";
            lblNumPedido.Click += label2_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(187, 121);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            lblCantidad.Click += lblCantidad_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(45, 282);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio";
            lblPrecio.Click += lblPrecio_Click;
            // 
            // lblMedioDePago
            // 
            lblMedioDePago.AutoSize = true;
            lblMedioDePago.Location = new Point(15, 19);
            lblMedioDePago.Name = "lblMedioDePago";
            lblMedioDePago.Size = new Size(87, 15);
            lblMedioDePago.TabIndex = 8;
            lblMedioDePago.Text = "Medio de pago";
            lblMedioDePago.Click += lblMedioDePago_Click;
            // 
            // lblAtencion
            // 
            lblAtencion.AutoSize = true;
            lblAtencion.Location = new Point(10, 19);
            lblAtencion.Name = "lblAtencion";
            lblAtencion.Size = new Size(96, 15);
            lblAtencion.TabIndex = 9;
            lblAtencion.Text = "Tipo de atención";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(187, 139);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(55, 23);
            numericUpDown1.TabIndex = 15;
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(45, 139);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(121, 23);
            cbProducto.TabIndex = 17;
            cbProducto.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // rbnServir
            // 
            rbnServir.AutoSize = true;
            rbnServir.Checked = true;
            rbnServir.Location = new Point(27, 37);
            rbnServir.Name = "rbnServir";
            rbnServir.Size = new Size(80, 19);
            rbnServir.TabIndex = 19;
            rbnServir.TabStop = true;
            rbnServir.Text = "Para Servir";
            rbnServir.UseVisualStyleBackColor = true;
            rbnServir.CheckedChanged += rbnServir_CheckedChanged;
            // 
            // rbnLlevar
            // 
            rbnLlevar.AutoSize = true;
            rbnLlevar.Location = new Point(28, 62);
            rbnLlevar.Name = "rbnLlevar";
            rbnLlevar.Size = new Size(82, 19);
            rbnLlevar.TabIndex = 20;
            rbnLlevar.TabStop = true;
            rbnLlevar.Text = "Para Llevar";
            rbnLlevar.UseVisualStyleBackColor = true;
            // 
            // rbnTarjeta
            // 
            rbnTarjeta.AutoSize = true;
            rbnTarjeta.Location = new Point(32, 62);
            rbnTarjeta.Name = "rbnTarjeta";
            rbnTarjeta.Size = new Size(60, 19);
            rbnTarjeta.TabIndex = 22;
            rbnTarjeta.TabStop = true;
            rbnTarjeta.Text = "Tarjeta";
            rbnTarjeta.UseVisualStyleBackColor = true;
            rbnTarjeta.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rbnEfectivo
            // 
            rbnEfectivo.AutoSize = true;
            rbnEfectivo.Checked = true;
            rbnEfectivo.Location = new Point(31, 37);
            rbnEfectivo.Name = "rbnEfectivo";
            rbnEfectivo.Size = new Size(67, 19);
            rbnEfectivo.TabIndex = 21;
            rbnEfectivo.TabStop = true;
            rbnEfectivo.Text = "Efectivo";
            rbnEfectivo.UseVisualStyleBackColor = true;
            // 
            // gbAtencion
            // 
            gbAtencion.Controls.Add(lblAtencion);
            gbAtencion.Controls.Add(rbnServir);
            gbAtencion.Controls.Add(rbnLlevar);
            gbAtencion.Location = new Point(297, 55);
            gbAtencion.Name = "gbAtencion";
            gbAtencion.Size = new Size(200, 107);
            gbAtencion.TabIndex = 23;
            gbAtencion.TabStop = false;
            gbAtencion.Text = "Seleccionar Atencion";
            gbAtencion.Enter += groupBox1_Enter;
            // 
            // gbMedioDePago
            // 
            gbMedioDePago.Controls.Add(lblMedioDePago);
            gbMedioDePago.Controls.Add(rbnEfectivo);
            gbMedioDePago.Controls.Add(rbnTarjeta);
            gbMedioDePago.Location = new Point(297, 179);
            gbMedioDePago.Name = "gbMedioDePago";
            gbMedioDePago.Size = new Size(200, 100);
            gbMedioDePago.TabIndex = 24;
            gbMedioDePago.TabStop = false;
            gbMedioDePago.Text = "Seleccionar Medio de pago";
            // 
            // btnAgregarProductos
            // 
            btnAgregarProductos.Location = new Point(46, 168);
            btnAgregarProductos.Name = "btnAgregarProductos";
            btnAgregarProductos.Size = new Size(75, 23);
            btnAgregarProductos.TabIndex = 25;
            btnAgregarProductos.Text = "Agregar";
            btnAgregarProductos.UseVisualStyleBackColor = true;
            btnAgregarProductos.Click += btnAgregarProductos_Click;
            // 
            // lsbxProductos
            // 
            lsbxProductos.Location = new Point(46, 197);
            lsbxProductos.Name = "lsbxProductos";
            lsbxProductos.Size = new Size(196, 70);
            lsbxProductos.TabIndex = 26;
            lsbxProductos.UseCompatibleStateImageBehavior = false;
            lsbxProductos.SelectedIndexChanged += lsbxProductos_SelectedIndexChanged;
            // 
            // btnRegistrarPedido
            // 
            btnRegistrarPedido.Location = new Point(422, 294);
            btnRegistrarPedido.Name = "btnRegistrarPedido";
            btnRegistrarPedido.Size = new Size(75, 23);
            btnRegistrarPedido.TabIndex = 27;
            btnRegistrarPedido.Text = "Registrar Pedido";
            btnRegistrarPedido.UseVisualStyleBackColor = true;
            btnRegistrarPedido.Click += button1_Click_1;
            // 
            // RegistroInformacion
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.Control;
            ClientSize = new Size(541, 357);
            Controls.Add(btnRegistrarPedido);
            Controls.Add(lsbxProductos);
            Controls.Add(btnAgregarProductos);
            Controls.Add(gbMedioDePago);
            Controls.Add(gbAtencion);
            Controls.Add(cbProducto);
            Controls.Add(numericUpDown1);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(lblNumPedido);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Controls.Add(DTIFecha);
            Controls.Add(btnVolver01);
            Controls.Add(lblRegistro);
            Name = "RegistroInformacion";
            Text = "RegistroInformacion";
            Load += RegistroInformacion_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            gbAtencion.ResumeLayout(false);
            gbAtencion.PerformLayout();
            gbMedioDePago.ResumeLayout(false);
            gbMedioDePago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistro;
        private Button btnVolver01;
        private DateTimePicker DTIFecha;
        private Label lblFecha;
        private Label lblProducto;
        private Label lblNumPedido;
        private Label lblCantidad;
        private Label lblPrecio;
        private Label lblMedioDePago;
        private Label lblAtencion;
        private NumericUpDown numericUpDown1;
        private ComboBox cbProducto;
        private RadioButton rbnServir;
        private RadioButton rbnLlevar;
        private RadioButton rbnTarjeta;
        private RadioButton rbnEfectivo;
        private GroupBox gbAtencion;
        private GroupBox gbMedioDePago;
        private Button btnAgregarProductos;
        private ListView lsbxProductos;
        private Button btnRegistrarPedido;
    }
}