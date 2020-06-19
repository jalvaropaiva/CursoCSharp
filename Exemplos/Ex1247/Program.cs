using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1247
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            while(string.IsNullOrEmpty(s) == false)
            {
                Console.WriteLine("Leu alguma coisa");
                s = Console.ReadLine();
            }
        }
    }
}
