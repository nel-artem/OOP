using System;
using System.Collections.Generic;
using System.Text;

namespace lb17
{
    class Complex : Norm
    {
        double re, im;
        public Complex(double re, double im) { this.re = re; this.im = im; }
        public override double Modulus()
        {
            return Math.Sqrt(re * re + im * im);
        }

        public override double Norm2()
        {
            return re * re + im * im;
        }
    }
}
