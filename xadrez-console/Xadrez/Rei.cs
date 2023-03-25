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

        private bool PodeMover(Posicao pos)
        {
            Peca p = tab.Peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //Norte
            pos.DefinirValores(posicao.linha - 1, posicao.coluna);
            if (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Nordeste
            pos.DefinirValores(posicao.linha - 1, posicao.coluna + 1);
            if (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Leste
            pos.DefinirValores(posicao.linha, posicao.coluna + 1);
            if (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Sudeste
            pos.DefinirValores(posicao.linha + 1, posicao.coluna + 1);
            if (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Sul
            pos.DefinirValores(posicao.linha + 1, posicao.coluna);
            if (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Sudoeste
            pos.DefinirValores(posicao.linha + 1, posicao.coluna - 1);
            if (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Oeste
            pos.DefinirValores(posicao.linha, posicao.coluna - 1);
            if (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //Noroeste
            pos.DefinirValores(posicao.linha - 1, posicao.coluna - 1);
            if (tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }
    }
}
