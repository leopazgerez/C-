using System;

namespace Test.MiniComponente
{
    public class Mp3 : BaseMedia
    {
        public override void Play()
        {
            base.Play();
            Console.WriteLine("Reproduciendo Mp3");
        }
    }
}
