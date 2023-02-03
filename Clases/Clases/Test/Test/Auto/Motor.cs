namespace Test.Auto
{
    public class Motor : IMotor
    {
        //Tiene como propiedades a los pistones, una auto de tipo interfaz y un radiador de tipo interfaz
        private Piston piston1;
        private Piston piston2;
        private Piston piston3;
        private Piston piston4;
        private Piston piston5;

        private IAuto auto;
        //private IRadiador radiador;
        //tiene la propiedad en privado ya que motor va a ser el unico encargado de la temperatura
        private double temperature;

        public Motor(IAuto _auto /*IRadiador _radiador*/)
        {
            /*En el constructor de motor, al crear el objeto motor automaticamente se crean los pistones
             * y se los asigna a cada propiedad del motor*/
            piston1 = new PistonA(this);
            piston2 = new PistonA(this);
            piston3 = new PistonA(this);
            piston4 = new PistonB(this);
            piston5 = new PistonB(this);
            //Al crear el auto, la temperatura es 0
            auto = _auto;
            /*radiador = _radiador;*/
            temperature = 0;
        }
        
        public void Arrancar()
        {
            //Al arrancar le dice a los pistones que también arranquen
            piston1.Arrancar();//la clase piston tiene su metodo para arrancar 
            piston2.Arrancar();
            piston3.Arrancar();
            piston4.Arrancar();
            piston5.Arrancar();
        }

        public void ExplotoPiston(double efiTemperatura, double efiCombustible)
        {
            /*Generalizando la accion de lo que desencadena el aumento de temperatura es que se crea el método.
             * Con este método estoy modificando la temperatura*/
            temperature = temperature + efiTemperatura;
            auto.ExplotoPiston(efiCombustible);
        }
        public void bajartemperaturamotor(double _eficienciaderadiador)
        {
            if (temperature == 80)
            {
                temperature = temperature * _eficienciaderadiador;
                auto.bajartemperaturamotor();
            }
                     
        }

            
    }
}