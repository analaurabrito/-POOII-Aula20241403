using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20241403
{
    internal class Pedido
    {
        public List<Item> listaItems;
        public double valorTotal;

        public Pedido(Produto produto, int quantidade)
        {
            Item i = new Item(produto, quantidade);
            listaItems.Add(i);
        }

        public void addItem(Produto produto, int quantidade)
        {
            Item i = new Item(produto, quantidade);
            listaItems.Add(i);
        }

        public void calculoTotal(List<Item> listaItems, double valorTotal)
        {
            foreach (Item i in listaItems)
            {
                valorTotal += i.valor;
            }

            this.valorTotal = valorTotal;
        }

    }
}
