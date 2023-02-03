namespace Test.Auto
{
    public class TanqueNafta
    {
        private double litros;
        public double eficienciaNafta;
        public TanqueNafta()
        {
            litros = 0;
            eficienciaNafta = 1;
        }

        public void CargarCombustible(double cantidadDeLitrosQueDeseaCargar)
        {
            litros = cantidadDeLitrosQueDeseaCargar;
        }

        public void ConsumirCombustible()
        {
            litros = litros - this.eficienciaNafta;
        }
    }
}
