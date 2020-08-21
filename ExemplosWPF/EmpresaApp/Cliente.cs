using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaApp
{
    class Cliente
    {
        public string Nome         { get; set; }
        public string CPF          { get; set; }
        public decimal Limite      { get { return limite; } set { limite = value; } }
        public string Socio        { get { if (socio == null) return ""; else return socio.Nome; }  }
        public decimal LimiteTotal { get { return GetLimite(); } }

        private decimal limite;
        private Cliente socio;
        public void SetSocio(Cliente c)
        {
            socio = c;
            c.socio = this;
        }
        public decimal GetLimite()
        {
            if (socio == null) return limite; else return limite + socio.limite;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
