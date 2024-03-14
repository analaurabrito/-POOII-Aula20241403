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
        }

        public void valorItem(Produto produto, int quantidade)
        {
            this.valor = quantidade * produto.preço;
        }

        public void totalDesconto(Produto produto, double valor, double desconto)
        {
            this.valor = (valor) * desconto;
        }
    }
}
