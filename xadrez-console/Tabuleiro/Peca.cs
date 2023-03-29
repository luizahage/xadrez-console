namespace Tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdeMovimentos { get; protected set; }
        public TabuleiroXadrez tab { get; protected set; }

        public Peca(Cor cor, TabuleiroXadrez tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qtdeMovimentos = 0;
        }

        public void IncrementarQtdeMovimentos()
        {
            qtdeMovimentos++;
        }

        public void DecrementarQtdeMovimentos()
        {
            qtdeMovimentos--;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
