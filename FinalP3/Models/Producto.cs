namespace FinalP3.Models
{
    public class Producto
    {
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public decimal PrecioBase { get; set; }

        public Producto()
        {
            Codigo = "";
            Nombre = "";
        }

        public Producto(
            string codigo,
            string nombre,
            decimal precioBase)
        {
            Codigo = codigo;
            Nombre = nombre;
            PrecioBase = precioBase;
        }
    }
}
