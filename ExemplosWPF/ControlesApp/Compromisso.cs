using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesApp
{
    class Compromisso
    {
        public string Assunto { get; set; }
        public string Local { get; set; }
        public DateTime Data { get; set; }

        public override string ToString()
        {
            return $"{Assunto} - {Local} - {Data:dd/MM/yyyy}";
        }
    }

}
