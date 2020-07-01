using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class PlayList
    {
        private string nome, descricao;
        private Musica[] musicas = new Musica[10];
        private int k;
        public PlayList(string nome, string descricao)
        {
            this.nome = nome;
            this.descricao = descricao;
        }
        public void Inserir(Musica m)
        {
            if(k == musicas.Length) Array.Resize(ref musicas, 2 * musicas.Length);
            musicas[k] = m;
            m.SetDataInclusao(DateTime.Now);
            k++;
        }
        public Musica[] Listar()
        {
            Musica[] v = new Musica[k];
            Array.Copy(musicas, v, k);
            return v;
        }
        public TimeSpan TempoTotal()
        {
            TimeSpan tempo = new TimeSpan();
            foreach (Musica m in Listar())
                tempo += m.GetDuracao();
            return tempo;
        }
    }
}
