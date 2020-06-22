using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEstrutura
{
    class Program
    {
        static void Main(string[] args)
        {
            Disciplina d = new Disciplina();
            d.Nome = "Programação";
            d.Nota1 = 100;
            d.Nota2 = 100;
            d.NotaF = 100;
            d.Media = 100;
            Console.WriteLine(d.ToString());
            Console.WriteLine(d.Nome);
            Console.WriteLine(d.Nota1);
            Console.ReadKey();
        }
    }
}
