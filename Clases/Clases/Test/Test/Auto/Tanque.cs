namespace Test.Auto
{
    public class Tanque
    {
        //Modificador de acceso privado ya que al unico que le interesa y que puede acceder a esto va a ser la clase tanque
        //Es una propiedad de tanque los litros que va a tener
        private double litros;

        public Tanque()
        {
           //Dentro del constructor de la clase se va a establecer la cantidad de litros que va a tener al momento de instanciar
            litros = 0;
        }

        public void CargarCombustible(int cantidadDeLitrosQueDeseaCargar)
        {
            /*Este metodo se va a encargar de cargar la cantidad de litros que se le pase por parametros y 
             * se lo va a settear a la propiedad de la clase*/
            litros = cantidadDeLitrosQueDeseaCargar;
        }

        public void ConsumirCombustible(double efiCombustible)
        {
            /*Además no solo va a cargar combustible sino que también debe consumirlo
             * Para eso está este método que va a pasar por parametro la eficiencia del consumo de determinado piston
             * para asi saber cuanto combustible se va a ocnsumir*/
            litros = litros - efiCombustible;
        }
    }
}
