namespace FinalP3.Models
{
    public class Postre : Producto
    {
        public bool ContieneAzucar { get; set; }

        public string Porcion { get; set; }

        public Postre()
        {
            Porcion = "";
        }
    }
}
