using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras;

namespace ExMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de Métodos");
            Console.WriteLine(AreaTriangulo(10, 20));
            Console.WriteLine(AreaLocal.AreaTriangulo(10, 20));
            int x = 10, y = 20;
            InverterValores(x, y);
            Console.WriteLine($"{x} {y}");
            InverterValores(ref x, ref y);
            Console.WriteLine($"{x} {y}");

            string s = x.ToString() + x.ToString();
            Console.WriteLine(s);

            // Acesso à biblioteca Figuras
            Console.WriteLine(Figuras.Area.AreaQuadrado(10, 20));
            Console.WriteLine(Area.AreaCirculo(10));

            Console.ReadKey();
        }
        public static double AreaTriangulo(double b, double h)
        {
            double area = b * h / 2;
            return area;
        }
        public static void InverterValores(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static void InverterValores(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
