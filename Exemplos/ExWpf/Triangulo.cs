using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExWpf
{
    class Triangulo
    {
        private double b, h;
        public Triangulo(double b, double h)
        {
            this.b = b;
            this.h = h;
        }
        public double CalcArea()
        {
            return b * h / 2;
        }
    }
}
