using System;
using System.Collections.Generic;
using System.Text;

namespace Tirando_fruta
{
    public class trapezoid
    {
        private double a, b, h;
        public trapezoid (double aval, double bval, double hval)
        {
            a = aval;
            b = bval;
            h = hval;
        }
        public double Area()
        {
            return (a + b) / 2 * h;
        }
    }
}
