using primeiraApp.Interface;

namespace primeiraApp.lib
{
    public class jogador2 : ijogador
    {
        public string Chuta()
        { 
            return "Maradona estas pateando \n";
        }

        public string Corre()
        {
            return "Maradona estas corriendo \n";
        }

        public string Passe()
        {
            return "Maradona estas passando \n";
        }
    }
}