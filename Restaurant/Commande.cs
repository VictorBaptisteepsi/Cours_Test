using System;

namespace Restaurant
{
    public class Commande
    {
        private static readonly TimeSpan 
            TempsAvantDeContacterLaGendarmerie = TimeSpan.FromDays(15);

        private readonly IHorloge _horloge;
        private readonly DateTime _dateAffectation;
        private readonly Serveur _affectataire;

        public Commande(IHorloge horloge, Serveur serveurEnCharge)
        {
            _horloge = horloge;
            _affectataire = serveurEnCharge;
            _dateAffectation = _horloge.Now;
        }

        public bool EstÉpinglée { get; private set; }

        public bool ATransmettreGendarmerie
            => _horloge.Now >= _dateAffectation + TempsAvantDeContacterLaGendarmerie;

        internal void Épingler(Serveur acteur)
        {
            if (acteur != _affectataire) 
                throw new InvalidOperationException();

            EstÉpinglée = true;
        }
    }
}
