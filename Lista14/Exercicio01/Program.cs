using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente p = new Paciente("Eduardo", "1234", "8888-8888",
                DateTime.Parse("20/07/1971"));
            Console.WriteLine(p);
            Console.WriteLine(p.Idade());
            Console.WriteLine(p.IdadeDias().Days);
            Console.WriteLine(p.IdadeDias().TotalDays);
            Console.ReadKey();
        }
    }
}
