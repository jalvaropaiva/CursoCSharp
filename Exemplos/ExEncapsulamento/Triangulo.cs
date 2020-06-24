using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEncapsulamento
{
    class Triangulo
    {
        private double b, h;
        public void SetBase(double v)
        {
            if (v > 0) b = v;
            else throw new ArgumentOutOfRangeException();
        }
        public void SetAltura(double v)
        {
            if (v > 0) h = v;
            else throw new ArgumentOutOfRangeException();
        }
        public double GetBase()
        {
            return b;
        }
        public double GetAltura()
        {
            return h;
        }
        public double CalcArea()
        {
            return b * h / 2;
        }
    }
}
