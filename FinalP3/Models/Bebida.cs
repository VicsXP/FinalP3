namespace FinalP3.Models
{
    public class Bebida : Producto
    {
        public int Volumen { get; set; }

        public string Tipo { get; set; }

        public Bebida()
        {
            Tipo = "";
        }
    }
}
