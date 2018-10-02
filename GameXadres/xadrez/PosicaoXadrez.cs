using System;
using System.Collections.Generic;
using System.Text;
using GameXadres.tabuleiro;

namespace GameXadres.xadrez
{
    class PosicaoXadrez
    {

        public char coluna { get; set; }
        public int linha { get; set; }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }
        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
