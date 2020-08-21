using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTrianguloApp
{
    class Triangulo
    {
        private double b, h;
        public double Base {
            get => b; set => b = value > 0 ? value : 0;
        }
        public double Altura {
            get => h; set => h = value > 0 ? value : 0;
        }
        public double Area {
            get => b * h / 2; 
        }
    }
}
