using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Paciente
    {
        private string nome, cpf, telefone;
        private DateTime nascimento;
        public Paciente(string n, string c, string t, DateTime d)
        {
            nome = n;
            cpf = c;
            telefone = t;
            nascimento = d;
        }
        public override string ToString()
        {
            return $"{nome} - {cpf} - {telefone} - {nascimento:dd/MMM/yyyy}";
        }
        public string Idade()
        {
            DateTime hoje = DateTime.Now;
            int a = hoje.Year - nascimento.Year;
            int m = hoje.Month - nascimento.Month;
            if (m < 0)
            {
                a--;
                m += 12;
            }
            return $"{a} ano(s) e {m} mes(es)";
        }
        public TimeSpan IdadeDias()
        {
            DateTime hoje = DateTime.Now;
            return hoje - nascimento;
        }
    }
}
