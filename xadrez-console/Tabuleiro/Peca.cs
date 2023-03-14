namespace Tabuleiro
{
    class Peca
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
    }
}
