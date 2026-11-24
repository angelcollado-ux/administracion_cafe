using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace administracion_cafeteria
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //form01 -> registro
            RegistroInformacion formulario01 = new RegistroInformacion();
            formulario01.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //form02 -> consulta
            ConsultaInformacion formulario02 = new ConsultaInformacion();
            formulario02.ShowDialog();
        }
    }
}
