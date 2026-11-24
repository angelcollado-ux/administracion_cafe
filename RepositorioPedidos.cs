using System.Globalization;
using System.Text;

namespace administracion_cafeteria
{
    /// <summary>
    /// Datos de un pedido guardado en el CSV.
    /// </summary>
    internal record Pedido(
        string Codigo,
        string Productos,
        int Total,
        string Fecha,
        string Atencion,
        string Pago);

    /// <summary>
    /// Lectura/escritura del CSV de pedidos y generación del código de pedido.
    /// Registro y Consulta usan esta misma clase, así siempre trabajan sobre el mismo archivo.
    /// Formato de cada línea: codigo,productos,total,fecha,atencion,pago
    /// </summary>
    internal static class RepositorioPedidos
    {
        private const string Prefijo = "PED-";

        public static string Archivo =>
            Path.Combine(Application.StartupPath, "pedidos_cafeteria.csv");

        /// <summary>
        /// Devuelve el siguiente código libre: PED-0001, PED-0002, ...
        /// </summary>
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
            // Se quitan las comas de los textos para no romper el formato CSV.
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

        /// <summary>
        /// Lee todos los pedidos válidos y los devuelve en un arreglo.
        /// Si el archivo no existe devuelve un arreglo vacío.
        /// Se ignoran las líneas que no tengan el formato nuevo (por ejemplo, registros antiguos).
        /// </summary>
        public static Pedido[] Cargar()
        {
            if (!File.Exists(Archivo))
                return new Pedido[0];

            string[] lineas = File.ReadAllLines(Archivo, Encoding.UTF8);

            // Como máximo habrá un pedido por línea
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
