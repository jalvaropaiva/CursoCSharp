using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Fracao x = new Fracao(1, 2);
            Fracao y = new Fracao(3, 4);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Fracao z = Fracao.Multiplicar(x, y);
            Fracao w = x.Multiplicar(y);
            Fracao q = x * y;
            Console.WriteLine(z);
            Console.WriteLine(w);
            Console.WriteLine(q);
            Console.ReadKey();
        }
    }
}
