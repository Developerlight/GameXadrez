using GameXadres.tabuleiro;

namespace GameXadres.xadrez
{
    class Rei : Peca
    {
        public Rei( Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "R ";
        }
    }
}
