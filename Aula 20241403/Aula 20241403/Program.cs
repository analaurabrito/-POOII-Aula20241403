using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20241403
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p1 = new Produto("Tênis", 500.00);
            Produto p2 = new Produto("Boné", 89.90);
            Produto p3 = new Produto("Pochete", 129.90);

            Pedido pe1 = new Pedido();
            pe1.addItem(p1, 1, 0.50);
            pe1.addItem(p2, 2);
            pe1.addItem(p3, 4);

            pe1.imprimirItens();

        }
    }
}
