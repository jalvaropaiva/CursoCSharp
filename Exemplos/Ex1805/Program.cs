using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1805
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] v = s.Split('+', '-');

            Console.WriteLine(s[0]);
            Console.WriteLine(s[1]);
            Console.WriteLine(s[2]);
            Console.WriteLine(s[3]);
            Console.WriteLine(s.Length);
            Console.WriteLine(v.Length);

            //s[0] = '2';

            int a = int.Parse(v[0]);
            int b = int.Parse(v[1]);

            if (s.Contains('+')) Console.WriteLine(a + b);
            if (s.Contains('-')) Console.WriteLine(a - b);

            int n = b - a + 1;
            long soma = ((long) a + b) * n / 2;
            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}
