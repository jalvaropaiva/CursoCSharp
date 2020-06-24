using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEncapsulamento
{
    class Circulo
    {
        private double r;
        public void SetRaio(double v)
        {
            if (v > 0) r = v;
        }
        public double GetRaio()
        {
            return r;
        }
        public double CalcArea()
        {
            return Math.PI * r * r;
        }
    }
}
