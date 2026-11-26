using System.Globalization;
using System.Text;

namespace administracion_cafeteria
{
    internal record Pedido(
        string Codigo,
        string Productos,
        int Total,
        string Fecha,
        string Atencion,
        string Pago);

    internal static class RepositorioPedidos
    {
        private const string Prefijo = "PED-";

        public static string Archivo =>
            Path.Combine(Application.StartupPath, "pedidos_cafeteria.csv");

        public static string SiguienteCodigo()
        {
            int maximo = 0;
            Pedido[] pedidos = Cargar();
            foreach (var pedido in pedidos)
            {
                if (int.TryParse(pedido.Codigo.AsSpan(Prefijo.Length), out int numero) && numero > maximo)
                    maximo = numero;
            }
            return Prefijo + (maximo + 1).ToString("0000");
        }

        public static void Guardar(Pedido pedido)
        {

            string productos = pedido.Productos.Replace(",", " ");

            string linea = string.Join(",",
                pedido.Codigo,
                productos,
                pedido.Total.ToString(CultureInfo.InvariantCulture),
                pedido.Fecha,
                pedido.Atencion,
                pedido.Pago);

            File.AppendAllText(Archivo, linea + Environment.NewLine, Encoding.UTF8);
        }

        public static Pedido[] Cargar()
        {
            if (!File.Exists(Archivo))
                return new Pedido[0];

            string[] lineas = File.ReadAllLines(Archivo, Encoding.UTF8);

            Pedido[] pedidos = new Pedido[lineas.Length];
            int cantidad = 0;

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] c = lineas[i].Split(',');

                if (c.Length != 6 || !c[0].StartsWith(Prefijo))
                    continue;

                if (!int.TryParse(c[2], NumberStyles.Integer, CultureInfo.InvariantCulture, out int total))
                    continue;

                pedidos[cantidad] = new Pedido(c[0], c[1], total, c[3], c[4], c[5]);
                cantidad++;
            }

            // Se recorta el arreglo al tamaño real
            Array.Resize(ref pedidos, cantidad);
            return pedidos;
        }
    }
}
