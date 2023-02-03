using System;
using System.Collections.Generic;
using System.Text;

namespace Mercado_Singleton_Builder
{
    class Director
    {
        private IBuilder builder;


        public void setBuilder(IBuilder _builder)
        {
            this.builder = _builder;
        }
        public void ConstructorCarrito(IBuilder _builder)
        {
            this.builder.FormaDePago()
        }

    }
}
