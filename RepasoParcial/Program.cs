using System;

namespace RepasoParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Minicomponente radio = new Minicomponente();
            radio.Play();
            radio.SetCD();
            radio.Play();
        }
    }
    class Minicomponente
    {
        public USB usb;
        public CD cd;
        public IReproducir sonido;
       public Minicomponente()
        {
            usb = new USB();
            cd = new CD();
            sonido = usb;
        }
        public void Play()
        {
            sonido.Reproducir();
        }
        public void SetUsb()
        {
            sonido = usb;
        }
        public void SetCD()
        {
            sonido = cd;
        }

    }
    class USB: IReproducir
    {
        public void Reproducir()
        {
            Console.WriteLine("Repdroduciendo MP3");
        }
        public USB()
        {

        }
    }
    class CD: IReproducir
    {
        public void Reproducir()
        {
            Console.WriteLine("Repdroduciendo CD");
        }
        public CD()
        {

        }
    }
    interface IReproducir
    {
        public void Reproducir();
    }
}
