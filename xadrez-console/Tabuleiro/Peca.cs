namespace Tabuleiro
{
    class Peca
    {
        public Peca posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdeMovimentos { get; protected set; }
        public TabuleiroXadrez tab { get; protected set; }

        public Peca(Peca posicao, Cor cor, TabuleiroXadrez tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            this.qtdeMovimentos = 0;
        }
    }
}
