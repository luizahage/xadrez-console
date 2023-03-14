using Tabuleiro;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Cor cor, TabuleiroXadrez tab) : base(cor, tab) 
        { 
        }

        public override string ToString()
        {
            return "R"; 
        }
    }
}
