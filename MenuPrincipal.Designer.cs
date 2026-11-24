namespace administracion_cafeteria
{
    partial class MenuPrincipal
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
            lblNombre = new Label();
            lblProyecto = new Label();
            btnRegistrar = new Button();
            btnConsultar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 22F);
            lblNombre.Location = new Point(89, 53);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(190, 41);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "<CafeCode>";
            lblNombre.Click += label1_Click;
            // 
            // lblProyecto
            // 
            lblProyecto.AutoSize = true;
            lblProyecto.Location = new Point(155, 94);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(63, 15);
            lblProyecto.TabIndex = 1;
            lblProyecto.Text = "Proyecto 3";
            lblProyecto.Click += label2_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(89, 149);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(82, 44);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar Pedido";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(197, 149);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(82, 44);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar Pedidos";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 262);
            Controls.Add(btnConsultar);
            Controls.Add(btnRegistrar);
            Controls.Add(lblProyecto);
            Controls.Add(lblNombre);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblProyecto;
        private Button btnRegistrar;
        private Button btnConsultar;
    }
}