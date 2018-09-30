using System;

namespace GameXadres
{
    using tabuleiro;
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;
            p = new Posicao(3, 4);

            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);

            Console.WriteLine("Posição: " + p);
            Console.ReadLine();




        }
    }
}
 