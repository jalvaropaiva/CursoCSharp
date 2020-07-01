using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Musica
    {
        private string titulo, artista, album;
        private DateTime dataInclusao;
        private TimeSpan duracao;
        public Musica(string titulo, string artista, string album, TimeSpan duracao)
        {
            this.titulo = titulo;
            this.artista = artista;
            this.album = album;
            this.duracao = duracao;
        }
        public override string ToString()
        {
            return $"{titulo} {artista} {album} {dataInclusao:dd/MM/yyyy} {duracao}";
        }
        public void SetDataInclusao(DateTime d)
        {
            dataInclusao = d;
        }
        public TimeSpan GetDuracao()
        {
            return duracao;
        }
    }
}
