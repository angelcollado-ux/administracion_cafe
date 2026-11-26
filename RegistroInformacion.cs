using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace administracion_cafeteria
{
    public partial class RegistroInformacion : Form
    {
        Dictionary<string, int> precios = new Dictionary<string, int>()
        {
            { "Cafe Espresso", 2000 },
            { "Cafe americano", 2300 },
            { "Cafe capuchino", 3000 },
            { "Cafe latte", 3200 },
            { "Te", 1800 },
            { "Agua", 1500 },
            { "Sandwich", 4500 },
            { "Medialuna", 1500 }
        };

        const int MAX_PRODUCTOS = 50;
        int[] subtotales = new int[MAX_PRODUCTOS];
        int cantidadProductos = 0;
        int total = 0;
        float IVA = 0.19f;
        string[] detalleProductos = new string[MAX_PRODUCTOS];
        string codigoPedido = "";

        public RegistroInformacion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegistroInformacion_Load(object sender, EventArgs e)
        {
            foreach (var producto in precios.Keys)
                cbProducto.Items.Add(producto);


            cbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProducto.SelectedIndex = -1;


            numericUpDown1.Minimum = 1;
            numericUpDown1.Value = 1;

            MostrarNuevoCodigo();
        }

        private void MostrarNuevoCodigo()
        {
            codigoPedido = RepositorioPedidos.SiguienteCodigo();
            lblNumPedido.Text = "Número del Pedido: " + codigoPedido;
        }


        private void LimpiarFormulario()
        {
            lsbxProductos.Items.Clear();
            Array.Clear(detalleProductos);
            Array.Clear(subtotales);
            cantidadProductos = 0;
            total = 0;
            lblPrecio.Text = "Total: $0";
            cbProducto.SelectedIndex = -1;
            numericUpDown1.Value = 1;
            DTIFecha.Value = DateTime.Now;
            rbnServir.Checked = false;
            rbnLlevar.Checked = false;
            rbnEfectivo.Checked = false;
            rbnTarjeta.Checked = false;
            MostrarNuevoCodigo();
        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMedioDePago_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lsbxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {

            if (cbProducto.SelectedItem == null)
            {

                MessageBox.Show("Selecciona un producto.");
                return;
            }


            string producto = cbProducto.SelectedItem.ToString();
            int cantidad = (int)numericUpDown1.Value;
            int subtotal = precios[producto] * cantidad;


            lsbxProductos.Items.Add($"{cantidad} x {producto} - ${subtotal:N0}");


            if (cantidadProductos >= MAX_PRODUCTOS)
            {
                MessageBox.Show($"Un pedido no puede tener más de {MAX_PRODUCTOS} productos.");
                return;
            }

            detalleProductos[cantidadProductos] = $"{cantidad} x {producto}";
            subtotales[cantidadProductos] = subtotal;
            cantidadProductos++;
            total += subtotal;
            lblPrecio.Text = $"Total: ${(total * (1 + IVA)):N0}";


            numericUpDown1.Value = 1;
            cbProducto.SelectedIndex = -1;
        }

        private void txtBxNombrePedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cantidadProductos == 0 || total == 0)
            {
                MessageBox.Show("Agrega al menos un producto antes de registrar el pedido.");
                return;
            }
            if (!rbnServir.Checked && !rbnLlevar.Checked)
            {
                MessageBox.Show("Selecciona el tipo de atención (Servir / Llevar).");
                return;
            }
            if (!rbnEfectivo.Checked && !rbnTarjeta.Checked)
            {
                MessageBox.Show("Selecciona el medio de pago (Efectivo / Tarjeta).");
                return;
            }

            string codigo = RepositorioPedidos.SiguienteCodigo();

            var pedido = new Pedido(
                codigo,
                string.Join(" | ", detalleProductos, 0, cantidadProductos),
                (int)Math.Round(total * (1 + IVA)),
                DTIFecha.Value.ToString("yyyy-MM-dd"),
                rbnServir.Checked ? "Servir" : "Llevar",
                rbnEfectivo.Checked ? "Efectivo" : "Tarjeta");

            RepositorioPedidos.Guardar(pedido);

            MessageBox.Show($"Pedido registrado correctamente.\n\nCódigo del pedido: {codigo}",
                            "Pedido registrado");

            LimpiarFormulario();
        }

        private void DTIFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbnServir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void lblAtencion_Click(object sender, EventArgs e)
        {

        }
    }
}
