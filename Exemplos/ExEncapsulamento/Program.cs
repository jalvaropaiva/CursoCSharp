using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();
            Circulo z = new Circulo();

            Console.WriteLine("Informe a base do triângulo");
            x.SetBase(double.Parse(Console.ReadLine()));
            Console.WriteLine("Informe a altura do triângulo");
            x.SetAltura(double.Parse(Console.ReadLine()));

            y.SetBase(10);
            y.SetAltura(20);
            z.SetRaio(10);

            Console.WriteLine($"Triângulo: base = {x.GetBase()} altura = {x.GetAltura()}");
            Console.WriteLine($"Triângulo: área = {x.CalcArea()}");

            Console.WriteLine($"Triângulo: base = {y.GetBase()} altura = {y.GetAltura()}");
            Console.WriteLine($"Triângulo: área = {y.CalcArea()}");

            Console.WriteLine($"Círculo: raio = {z.GetRaio()}");
            Console.WriteLine($"Círculo: área = {z.CalcArea()}");
            Console.ReadKey();
        }
    }
}
