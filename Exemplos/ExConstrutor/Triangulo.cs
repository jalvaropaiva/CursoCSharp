using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExConstrutor
{
    class Triangulo 
    {
        private double b, h;
        public Triangulo()
        {
            b = 10;
            h = 20;
        }
        public Triangulo(double b, double h)
        {
            if (b > 0) this.b = b;
            if (h > 0) this.h = h;
        }
        public void SetBase(double b)
        {
            if (b > 0) this.b = b;
        }
        public override string ToString()
        {
            return $"{b} {h}";
        }
    }
}
