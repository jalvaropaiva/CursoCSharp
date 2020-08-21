using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Cliente
    {
        public string Nome { get { return nome; } set { nome = value; } }
        public string CPF { get { return cpf; } set { cpf = value; } }
        public decimal LimitePessoal { get { return limite; } set { limite = value; } }
        public string Socio { get { if (socio == null) return ""; else return socio.nome; } }
        public decimal LimiteTotal { get { return GetLimite(); } }

        private string nome, cpf;
        private decimal limite;
        private Cliente socio;
        public Cliente() { }
        public Cliente(string nome, string cpf, decimal limite)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.limite = limite;
        }
        public void SetSocio(Cliente c)
        {
            // this - cliente que chama o método
            // c - cliente passado como parâmetro

            Cliente a = null;
            Cliente b = null;
            
            // Já existia um sócio para this?
            if (this.socio != null) a = this.socio;

            // Já existia um sócio para c?
            if (c.socio != null) b = c.socio;

            if (a != null) a.socio = null;
            if (b != null) b.socio = null;

            this.socio = c;
            c.socio = this;
        }
        public decimal GetLimite()
        {
            if (socio == null) return limite;
            else return limite + socio.limite;
        }
        public override string ToString()
        {
            return nome + " " + cpf;
        }
    }
}
