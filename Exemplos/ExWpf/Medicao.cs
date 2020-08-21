using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExWpf
{
    class Medicao
    {
        private double temp;
        private DateTime data;
        public Medicao(double temp, DateTime data)
        {
            this.temp = temp;
            this.data = data;
        }
        public override string ToString()
        {
            return $"{temp} {data:dd/MM/yyyy}";
        }
    }
}
