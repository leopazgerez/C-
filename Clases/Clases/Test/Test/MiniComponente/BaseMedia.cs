using System;
using System.Collections.Generic;
using System.Text;

namespace Test.MiniComponente
{
    public abstract class BaseMedia
    {
        public virtual void Play()
        {
            Console.WriteLine("Default para todos");
        }
    }
}
