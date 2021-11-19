namespace Restaurant
{
    public class Serveur : IPeutServir
    {
        private readonly IHorloge _horloge;

        public Serveur(IHorloge horloge)
        {
            _horloge = horloge;
        }

        public int chiffreAffaire { get; set; }

        public Commande PrendreCommande()
        {
            return new Commande(_horloge, this);
        }

        public void DéclarerNonPayée(Commande commande)
        {
            commande.Épingler(this);
        }
    }
}
