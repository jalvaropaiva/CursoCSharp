using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = x;
            Console.WriteLine(x);
            x.SetBase(100);
            object z = x;
            Console.WriteLine(y);
            y.SetBase(200);
            Console.WriteLine(z);
            z = 200;
            Console.WriteLine(z);
            int i = (int)z;
            i++;

            Console.ReadKey();
        }
    }
}
