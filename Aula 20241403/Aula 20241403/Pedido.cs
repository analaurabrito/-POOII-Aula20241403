using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20241403
{
    internal class Pedido
    {
        public List<Item> listaItems = new List<Item>();
        public double valorTotal;

        public Pedido()
        {

        }

        public void addItem(Produto produto, int quantidade)
        {
            Item i = new Item(produto, quantidade);
            listaItems.Add(i);
        }

        public void addItem(Produto produto, int quantidade, double desconto)
        {
            Item i = new Item(produto, quantidade, desconto);
            listaItems.Add(i);
        }

        public double calculoTotal()
        {
            foreach (Item i in listaItems)
            {
                valorTotal += i.valor;
            }
            return valorTotal;
        }

        public void imprimirItens()
        {
            foreach (Item i in listaItems)
            {
                Console.WriteLine(i.produto.nome + ": " + i.produto.preco);
            }

            Console.WriteLine("Total: " +calculoTotal());
        }

    }
}
