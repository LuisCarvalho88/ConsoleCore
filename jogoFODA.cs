using primeiraApp.Interface;

namespace primeiraApp
{
    public class jogoFODA
    {
        private readonly ijogador _jogadorA;
        private readonly ijogador _jogadorB;

        public jogoFODA(ijogador jogadorA,ijogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
           System.Console.Write(_jogadorA.Chuta());
           System.Console.Write(_jogadorA.Corre());
           System.Console.Write(_jogadorA.Passe()); 

           System.Console.Write("\n PRÓXIMO JOGADOR \n");
            
           System.Console.Write(_jogadorB.Chuta());
           System.Console.Write(_jogadorB.Corre());
           System.Console.Write(_jogadorB.Passe());
        }
    }
}