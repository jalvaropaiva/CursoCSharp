using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaCompromissoApp
{
    class Agenda
    {
        private Compromisso[] comps = new Compromisso[10];
        private int k;
        public int Qtd { get { return k; } }

        public void Inserir(Compromisso c)
        {
            if (k < 10) comps[k++] = c;
        }

        public Compromisso[] Listar()
        {
            Compromisso[] novo = new Compromisso[k];
            Array.Copy(comps, novo, k);
            return novo;
        }

        public Compromisso[] Pesquisar(int mes, int ano)
        {
            int c = 0;
            for (int i = 0; i < k; i++)
                if (comps[i].Data.Month == mes && comps[i].Data.Year == ano) c++;

            int d = 0;
            Compromisso[] novo = new Compromisso[c];
            for (int i = 0; i < k; i++)
                if (comps[i].Data.Month == mes && comps[i].Data.Year == ano) 
                    novo[d++] = comps[i];

            return novo;
        }
    }
}
