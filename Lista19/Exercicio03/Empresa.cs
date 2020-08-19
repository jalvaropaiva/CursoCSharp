using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Empresa
    {
        private Cliente[] clientes = new Cliente[10];
        private int k;
        public void Inserir(Cliente c)
        {
            if (k < 10) clientes[k++] = c;
        }
        public Cliente[] Listar()
        {
            Cliente[] novo = new Cliente[k];
            Array.Copy(clientes, novo, k);
            return novo;
        }
    }
}
