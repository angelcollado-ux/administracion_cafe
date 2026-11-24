namespace administracion_cafeteria
{
    partial class ConsultaInformacion
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
            lblConsultar = new Label();
            btnVolver02 = new Button();
            btnConsultaPorNombre = new Button();
            cbCodigoPedido = new ComboBox();
            label1 = new Label();
            lsbxConsultaInformacion = new ListBox();
            SuspendLayout();
            // 
            // lblConsultar
            // 
            lblConsultar.AutoSize = true;
            lblConsultar.Font = new Font("Segoe UI", 12F);
            lblConsultar.Location = new Point(22, 9);
            lblConsultar.Name = "lblConsultar";
            lblConsultar.Size = new Size(258, 21);
            lblConsultar.TabIndex = 0;
            lblConsultar.Text = "CONSULTAR INFORMACIÓN FORM";
            // 
            // btnVolver02
            // 
            btnVolver02.Location = new Point(131, 107);
            btnVolver02.Name = "btnVolver02";
            btnVolver02.Size = new Size(75, 23);
            btnVolver02.TabIndex = 1;
            btnVolver02.Text = "Volver";
            btnVolver02.UseVisualStyleBackColor = true;
            btnVolver02.Click += btnVolver02_Click;
            // 
            // btnConsultaPorNombre
            // 
            btnConsultaPorNombre.Location = new Point(22, 107);
            btnConsultaPorNombre.Name = "btnConsultaPorNombre";
            btnConsultaPorNombre.Size = new Size(75, 23);
            btnConsultaPorNombre.TabIndex = 2;
            btnConsultaPorNombre.Text = "Consultar";
            btnConsultaPorNombre.UseVisualStyleBackColor = true;
            btnConsultaPorNombre.Click += button1_Click;
            // 
            // cbCodigoPedido
            // 
            cbCodigoPedido.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCodigoPedido.FormattingEnabled = true;
            cbCodigoPedido.Location = new Point(22, 69);
            cbCodigoPedido.Name = "cbCodigoPedido";
            cbCodigoPedido.Size = new Size(184, 23);
            cbCodigoPedido.TabIndex = 3;
            cbCodigoPedido.SelectedIndexChanged += cbCodigoPedido_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 40);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 4;
            label1.Text = "Selecciona el código del pedido:";
            // 
            // lsbxConsultaInformacion
            // 
            lsbxConsultaInformacion.FormattingEnabled = true;
            lsbxConsultaInformacion.Location = new Point(253, 69);
            lsbxConsultaInformacion.Name = "lsbxConsultaInformacion";
            lsbxConsultaInformacion.Size = new Size(221, 229);
            lsbxConsultaInformacion.TabIndex = 5;
            lsbxConsultaInformacion.SelectedIndexChanged += lsbxConsultaInformacion_SelectedIndexChanged;
            // 
            // ConsultaInformacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 326);
            Controls.Add(lsbxConsultaInformacion);
            Controls.Add(label1);
            Controls.Add(cbCodigoPedido);
            Controls.Add(btnConsultaPorNombre);
            Controls.Add(btnVolver02);
            Controls.Add(lblConsultar);
            Name = "ConsultaInformacion";
            Text = "ConsultaInformacion";
            Load += ConsultaInformacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConsultar;
        private Button btnVolver02;
        private Button btnConsultaPorNombre;
        private ComboBox cbCodigoPedido;
        private Label label1;
        private ListBox lsbxConsultaInformacion;
    }
}