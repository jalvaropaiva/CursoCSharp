using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta x = new Conta();
            Console.WriteLine("Informe o titular");
            x.SetTitular(Console.ReadLine());
            Console.WriteLine("Informe o número da conta");
            x.SetNumero(Console.ReadLine());
            int op = 1;
            while (op != 0)
            {
                Console.WriteLine("1 - Depositar, 2 - Sacar, 3 - Saldo, 4 - Dados, 0 - Fim");
                op = int.Parse(Console.ReadLine());
                switch(op)
                {
                    case 1:
                        Console.WriteLine("Informe o depósito");
                        x.Depositar(decimal.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Informe o saque");
                        x.Sacar(decimal.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine($"Saldo = {x.GetSaldo()}");
                        break;
                    case 4:
                        Console.WriteLine($"Cliente = {x.GetTitular()}");
                        Console.WriteLine($"Conta = {x.GetNumero()}");
                        break;
                }
            }
        }
    }
}
