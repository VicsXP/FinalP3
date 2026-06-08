namespace FinalP3.Models
{
    public class PlatoFuerte : Producto
    {
        public string TipoCarne { get; set; }

        public string Acompanamiento { get; set; }

        public PlatoFuerte()
        {
            TipoCarne = "";
            Acompanamiento = "";
        }
    }
}
