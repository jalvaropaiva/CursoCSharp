using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloApp
{
    class Triangulo
    {
        private double b, h;
        public double Base
        {
            get { return b; }
            set { if (value > 0) b = value; }
        }
        public double Altura
        {
            get { return h; }
            set { if (value > 0) h = value; }
        }
        public void SetBase(double b) {
            if (b > 0) this.b = b;
        }
        public void SetAltura(double h) {
            if (h > 0) this.h = h;
        }
        public double GetBase() {
            return b;
        }
        public double GetAltura() {
            return h;
        }
        public double Area
        {
            get { return b * h / 2; }
        }
        public double CalcArea() {
            return b * h / 2;
        }
    }
}
