using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            TabuleiroXadrez tab = new TabuleiroXadrez(8, 8);

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
