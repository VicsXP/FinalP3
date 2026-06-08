using FinalP3.Models;
using System.Text.Json;

namespace FinalP3.Services
{
    public class ProductoService
    {
        private readonly string filePath =
            Path.Combine("wwwroot", "data", "productos.json");

        public List<Producto> ObtenerProductos()
        {
            if (!File.Exists(filePath))
            {
                return new List<Producto>();
            }

            string json = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<Producto>();
            }

            return JsonSerializer.Deserialize<List<Producto>>(json)
                   ?? new List<Producto>();
        }

        public void GuardarProducto(Producto producto)
        {
            List<Producto> productos = ObtenerProductos();

            productos.Add(producto);

            string json = JsonSerializer.Serialize(
                productos,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, json);
        }

        public List<Producto> BuscarPorNombre(string nombre)
        {
            return ObtenerProductos()
                .Where(p =>
                    p.Nombre.Contains(
                        nombre,
                        StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public Producto? BuscarPorCodigo(string codigo)
        {
            return ObtenerProductos()
                .FirstOrDefault(p =>
                    p.Codigo.Equals(
                        codigo,
                        StringComparison.OrdinalIgnoreCase));
        }
    }
}
