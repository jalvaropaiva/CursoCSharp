using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFracao
{
    class Fracao
    {
        private int num, den;

        public Fracao()
        {
            den = 1;
        }
        public Fracao(int num, int den)
        {
            this.num = num;
            if (den != 0) this.den = den;
        }
        public override string ToString()
        {
            return $"{num}/{den}";
        }
        public static Fracao Multiplicar(Fracao a, Fracao b)
        {
            Fracao novo = new Fracao(a.num * b.num, a.den * b.den);
            return novo;
        }
        public Fracao Multiplicar(Fracao a)
        {
            Fracao novo = new Fracao(this.num * a.num, this.den * a.den);
            return novo;
        }
        public static Fracao operator *(Fracao a, Fracao b)
        {
            Fracao novo = new Fracao(a.num * b.num, a.den * b.den);
            return novo;
        }
    }
}
