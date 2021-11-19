using System;
using Restaurant.Test.Utilities;
using Xunit;

namespace Restaurant.Test
{
    public class ÉpinglageTest
    {
        [Fact(DisplayName = "ÉTANT DONNE deux serveurs dont un ayant pris une commande" +
                            "QUAND le second épingle la commande du premier " +
                            "ALORS une exception est lancée et la commande n'est pas épinglée")]
        public void EpinglageParLePreneurDeCommandes()
        {
            // ÉTANT DONNE deux serveurs dont un ayant pris une commande
            //TODO refaire séance n°3

            var horloge = new HorlogeSystème();
            var serveurPrenantUneCommande = new Serveur(horloge);
            var commande = serveurPrenantUneCommande.PrendreCommande(); 

            var autreServeur = new Serveur(horloge);

            // QUAND le second épingle la commande du premier
            void ÉpinglerCommande() => autreServeur.DéclarerNonPayée(commande);

            // ALORS une exception est lancée et la commande n'est pas épinglée
            Assert.Throws<InvalidOperationException>(ÉpinglerCommande);
            Assert.False(commande.EstÉpinglée);
        }

        [Fact(DisplayName = "ÉTANT DONNE un serveur " +
                            "QUAND il prend une commande " +
                            "ALORS cette commande n'est pas marquée comme épinglée")]
        public void NonEpingléALOrigine()
        {
            // ÉTANT DONNE un serveur
            // TODO refaire séance n°3
            var serveur = new Serveur(new HorlogeSystème());

            // QUAND il prend une commande
            var commande = serveur.PrendreCommande(); 

            // ALORS cette commande n'est pas marquée comme épinglée
            Assert.False(commande.EstÉpinglée);
        }

        [Fact(DisplayName = "ÉTANT DONNE un serveur ayant pris une commande " +
              "QUAND il la déclare comme non-payée " +
              "ALORS cette commande est marquée comme épinglée")]
        public void EpingléSiNonPayée()
        {
            // ÉTANT DONNE un serveur ayant pris une commande
            // TODO refaire séance n°3
            var serveur = new Serveur(new HorlogeSystème());
            var commande = serveur.PrendreCommande();

            // QUAND il la déclare comme non-payée
            serveur.DéclarerNonPayée(commande);

            // ALORS cette commande est marquée comme épinglée
            Assert.True(commande.EstÉpinglée);
        }

        [Fact(DisplayName = "ÉTANT DONNE un serveur ayant épinglé une commande " +
                            "QUAND elle date d'il y a moins de 15 jours " +
                            "ALORS cette commande n'est pas marquée comme à transmettre gendarmerie")]
        public void PasATransmettreGendarmerie()
        {
            // ÉTANT DONNE un serveur ayant épinglé une commande
            var horloge = new HorlogeRéglable();

            // TODO refaire séance n°3
            var serveur = new Serveur(new HorlogeSystème());
            var commande = serveur.PrendreCommande();
            serveur.DéclarerNonPayée(commande);

            // QUAND elle date d'il y a 15 jours moins 1ms
            horloge.AdvanceInTime(TimeSpan.FromDays(15) - TimeSpan.FromMilliseconds(1));

            // ALORS cette commande est marquée comme à transmettre gendarmerie
            Assert.False(commande.ATransmettreGendarmerie);
        }

        [Fact(DisplayName = "ÉTANT DONNE un serveur ayant épinglé une commande " +
                            "QUAND elle date d'il y a au moins 15 jours " +
                            "ALORS cette commande est marquée comme à transmettre gendarmerie")]
        public void ATransmettreGendarmerie()
        {
            // ÉTANT DONNE un serveur ayant épinglé une commande
            var horloge = new HorlogeRéglable();

            // TODO refaire séance n°3
            var serveur = new Serveur(horloge);
            var commande = serveur.PrendreCommande();
            serveur.DéclarerNonPayée(commande);

            // QUAND elle date d'il y a au moins 15 jours
            horloge.AdvanceInTime(TimeSpan.FromDays(15));

            // ALORS cette commande est marquée comme à transmettre gendarmerie
            Assert.True(commande.ATransmettreGendarmerie);
        }


        // ÉTANT DONNE une commande à transmettre gendarmerie
        // QUAND on consulte la liste des commandes à transmettre du restaurant
        // ALORS elle y figure

        // ÉTANT DONNE une commande à transmettre gendarmerie
        // QUAND elle est marquée comme transmise à la gendarmerie
        // ALORS elle ne figure plus dans la liste des commandes à transmettre du restaurant
    }
}
