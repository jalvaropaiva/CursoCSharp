using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Data x = new Data(8, 7, 2020);
            Console.WriteLine(x.NomeMes());

            Data y = Data.Hoje();
            Console.WriteLine(y.NomeMes());

            Numero z = new Numero(16);
            Console.WriteLine(z.RaizQuadrada());

            double r = 16;
            Console.WriteLine(Math.Sqrt(r));

            object a = x;
            object b = y;
            object c = z;
            object d = r;
            object e = "Teste de Object";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            Console.WriteLine("Informe sua data de nascimento dd/mm/yyyy");


            DateTime data;
            while (!DateTime.TryParse(Console.ReadLine(), out data))
            {
            }
            Console.WriteLine(data);

            Console.ReadKey();
        }
    }

    class Boleto
    {
        private string codBarras;
        private DateTime dataVecto;
        public Boleto(string codBarras, DateTime dataVecto)
        {
            this.codBarras = codBarras;
            this.dataVecto = dataVecto;
        }

    }


    class Numero
    {
        private double valor;
        public Numero(double valor)
        {
            this.valor = valor;
        }
        public double RaizQuadrada()
        {
            return Math.Sqrt(valor);
        }
        public override string ToString()
        {
            return $"{valor}";
        }
    }

    class Data
    {
        private int dia, mes, ano;
        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
        public static Data Hoje()
        {
            Data novo = new Data(6, 7, 2020);
            return novo;
        }
        public string NomeMes()
        {
            switch(mes)
            {
                case 1: return "Janeiro";
                case 2: return "Fevereiro";
                case 3: return "Março";
                case 4: return "Abril";
                case 5: return "Maio";
                case 6: return "Junho";
                case 7: return "Julho";
                case 8: return "Agosto";
                case 9: return "Setembro";
                case 10: return "Outubro";
                case 11: return "Novembro";
                case 12: return "Dezembro";
            }
            return "";
        }
        public override string ToString()
        {
            return $"{dia:00}/{mes:00}/{ano:0000}";
        }
    }

}
