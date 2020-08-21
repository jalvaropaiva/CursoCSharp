using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaCompromissoApp
{
    public class Compromisso
    {
        private string assunto;
        public string Assunto { get { return assunto; } set { assunto = value; } }
        public string Local { get; set; }
        public DateTime Data { get; set; }
        
        public override string ToString()
        {
            return $"{Assunto} - {Local} - {Data:dd/MM/yyyy}";
        }
        
    }
}
