using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Musica m1 = new Musica("Hotel California", "Eagles", "Eagles",
                TimeSpan.Parse("00:05:00"));
            Musica m2 = new Musica("Transilvania", "Iron Maiden", "Iron Maiden",
                TimeSpan.Parse("00:04:00"));

            PlayList p = new PlayList("Rock", "Minha lista de músicas de Rock");
            p.Inserir(m1);
            p.Inserir(m2);
            foreach(Musica m in p.Listar())
              Console.WriteLine(m);
            Console.WriteLine(p.TempoTotal());
            Console.ReadKey();
        }
    }
}
