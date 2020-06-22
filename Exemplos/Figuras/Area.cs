using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Area
    {
        public static double AreaTriangulo(double b, double h)
        {
            double area = b * h / 2;
            return area;
        }
        public static double AreaQuadrado(double b, double h)
        {
            double area = b * h;
            return area;
        }
        public static double AreaCirculo(double r)
        {
            double area = Math.PI * r * r;
            return area;
        }
    }
}
