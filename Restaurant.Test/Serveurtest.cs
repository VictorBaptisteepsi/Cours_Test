using System;
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
            var horloge = new HorlogeSystème();
            var serveur = new Serveur(horloge);
            
            //"QUAND on récupére son chiffre d'affaires"
            
            //"ALORS celui-ci est à 0"
            Assert.Equal(0,serveur.chiffreAffaire);


        }

        [Fact(DisplayName = "ÉTANT DONNÉ un nouveau serveur" + "QUAND il prend une commande" +
                            "ALORS son chiffre d'affaires est le montant de celle-ci")]
        public void CAequalsOrder()
        {
            // ÉTANT DONNÉ un nouveau serveur
            var horloge = new HorlogeSystème();
            var serveur = new Serveur(horloge);
            //"QUAND il prend une commande"
            var commande = serveur.PrendreCommande();
            //var aleatoire = new Random();
            //int x = aleatoire.Next(1, 100);
            commande.Montant = 50;
            //ALORS son chiffre d'affaires est le montant de celle-ci
            Assert.Equal(50,serveur.chiffreAffaire);
        }
        
        [Fact(DisplayName = "ÉTANT DONNÉ un serveur ayant déjà pris une commande" 
        +"QUAND il prend une nouvelle commande"+
        "ALORS son chiffre d'affaires est la somme des deux commandes")]
        
        public void ServeurTwoOrder()
        {
            //ÉTANT DONNÉ un serveur ayant déjà pris une commande
            var horloge = new HorlogeSystème();
            var serveur = new Serveur(horloge);
            var commande = serveur.PrendreCommande();
            //QUAND il prend une nouvelle commande
            var commande2 = serveur.PrendreCommande();
            //ALORS son chiffre d'affaires est la somme des deux commandes
            commande.Montant = 30;
            commande2.Montant = 80;
            
            Assert.Equal(110,serveur.chiffreAffaire);

        }
    }
}