using Xunit;

namespace Restaurant.Test
{
    public class Serveurtest
    {
        [Fact(DisplayName = "ÉTANT DONNÉ un nouveau serveur" + "QUAND on récupére son chiffre d'affaires" +
                            "ALORS celui-ci est à 0")]

        public  void CAinit0()
        {
            //"ÉTANT DONNÉ un nouveau serveur"
            var serveur = new Serveur();
        }
    }
}