using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBuilder
{
    public class Compra
    {
        public CompraBuilder Builder;
        public Compra(CompraBuilder builder) 
        {
            Builder = builder;
        }
    }
}
