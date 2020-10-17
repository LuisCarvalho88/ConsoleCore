using System;
using primeiraApp.lib;

namespace primeiraApp
{
    public class program
    {
        static void Main(string[] args)
        {
            var jogo = new jogoFODA(
                new Jogador1 (),
                new jogador2 ()
                );

            jogo.IniciarJogo();
        }
    }
}