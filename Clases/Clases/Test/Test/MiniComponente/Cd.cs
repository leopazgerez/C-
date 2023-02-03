using System;

namespace Test.MiniComponente
{
    public class Cd : BaseMedia
    {
        public override void Play()
        {
            Console.WriteLine("Reproduciendo CD");
        }
    }
}
