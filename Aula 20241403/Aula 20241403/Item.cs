using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20241403
{
    internal class Item
    {
        public Produto produto;
        public int quantidade;
        public double desconto;
        public double valor;

        public Item(Produto produto, int quantidade)
        {
            this.produto = produto;
            this.quantidade = quantidade;
            this.desconto = 0;
        }
        
        public Item(Produto produto, int quantidade, double desconto)
        {
            this.produto = produto;
            this.quantidade = quantidade;
            this.desconto = desconto;
        }

        public double totalValor()
        {
            valor = (quantidade * valor) - (valor * desconto);
            return this.valor;
        }
    }
}
