using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace administracion_cafeteria
{
    public partial class ConsultaInformacion : Form
    {
        // Pedidos cargados desde el CSV (el ComboBox muestra solo el código)
        private Pedido[] pedidos = new Pedido[0];

        public ConsultaInformacion()
        {
            InitializeComponent();
        }

        private void ConsultaInformacion_Load(object sender, EventArgs e)
        {
            CargarCodigos();
        }

        // Llena el ComboBox con los códigos de todos los pedidos registrados
        private void CargarCodigos()
        {
            pedidos = RepositorioPedidos.Cargar();

            cbCodigoPedido.Items.Clear();
            foreach (var pedido in pedidos)
                cbCodigoPedido.Items.Add(pedido.Codigo);

            if (pedidos.Length == 0)
                lsbxConsultaInformacion.Items.Add("Aún no hay pedidos registrados.");
        }

        private void btnVolver02_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Botón Consultar: vuelve a leer el archivo (por si hubo pedidos nuevos) y muestra el seleccionado
        private void button1_Click(object sender, EventArgs e)
        {
            string? seleccionado = cbCodigoPedido.SelectedItem?.ToString();

            lsbxConsultaInformacion.Items.Clear();
            CargarCodigos();

            if (seleccionado == null)
            {
                MessageBox.Show("Selecciona un código de pedido.");
                return;
            }

            cbCodigoPedido.SelectedItem = seleccionado;   // dispara la muestra del detalle
        }

        // Al elegir un código en el ComboBox se muestra el detalle del pedido
        private void cbCodigoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbxConsultaInformacion.Items.Clear();

            string? codigo = cbCodigoPedido.SelectedItem?.ToString();
            Pedido? pedido = Array.Find(pedidos, p => p.Codigo == codigo);

            if (pedido == null)
                return;

            lsbxConsultaInformacion.Items.Add($"Código: {pedido.Codigo}");
            lsbxConsultaInformacion.Items.Add($"Fecha: {pedido.Fecha}");
            lsbxConsultaInformacion.Items.Add($"Atención: {pedido.Atencion}");
            lsbxConsultaInformacion.Items.Add($"Medio de pago: {pedido.Pago}");
            lsbxConsultaInformacion.Items.Add("");
            lsbxConsultaInformacion.Items.Add("Productos:");
            foreach (string producto in pedido.Productos.Split('|', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries))
                lsbxConsultaInformacion.Items.Add("   " + producto);
            lsbxConsultaInformacion.Items.Add("");
            lsbxConsultaInformacion.Items.Add($"Total (IVA incl.): ${pedido.Total:N0}");
        }

        private void lsbxConsultaInformacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
