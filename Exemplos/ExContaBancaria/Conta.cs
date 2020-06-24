using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExContaBancaria
{
    class Conta
    {
        private string titular;
        private string numero;
        private decimal saldo;
        public void SetTitular(string t) {
            titular = t;
        }
        public string GetTitular() {
            return titular;
        }
        public void SetNumero(string n) {
            numero = n;
        }
        public string GetNumero() {
            return numero;
        }
        public void Depositar(decimal v)
        {
            if (v > 0) saldo += v;
        }
        public void Sacar(decimal v)
        {
            if (v > 0 && saldo >= v) saldo -= v;
        }
        public decimal GetSaldo()
        {
            return saldo;
        }
    }
}
