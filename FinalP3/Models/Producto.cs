namespace FinalP3.Models
{
    public class Producto
    {
         public string Codigo { get; set; }

        public string Nombre { get; set; }

        public decimal PrecioBase { get; set; }

        public string TipoProducto { get; set; }

        public Producto()
        {
            Codigo = "";
            Nombre = "";
            TipoProducto = "";
        }
    }
}
