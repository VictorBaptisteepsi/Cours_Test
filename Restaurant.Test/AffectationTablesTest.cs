using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;


namespace Restaurant.Test
{
    public class AffectationTablesTest
    {
        [Fact(DisplayName = "Etant donn� une salle ayant une table, elle est affect�e par d�faut au ma�tre d'hotel.")]
        public void Affectation_Initiale()
        {
            // �tant donn� une salle ayant une table
            var maîtreHotel = new MaîtreHotel();
            var table = new Table();
            new Salle(maîtreHotel, table);

            // Alors cette table est affect�e par d�faut au ma�tre d'h�tel
            Assert.Equal(maîtreHotel, table.Affectataire);
        }

        [Fact(DisplayName = "Etant donn� une salle ayant deux tables, l'affectation de l'une d'entre " +
                            "elles � un serveur ne change que son affectation.")]
        public void Deux_Tables_Une_Est_Affectée_A_Autrui()
        {
            // �tant donn� une salle ayant une table
            var maîtreHotel = new MaîtreHotel();

            var tableDuMaîtreHotel = new Table();
            var tableDuServeur = new Table();

            new Salle(maîtreHotel, tableDuServeur, tableDuMaîtreHotel);

            //Quand j'affecte une des tables a un serveur
            var serveur = new Serveur();
            tableDuServeur.AffecterA(serveur);

            //Alors la table est affect�e au serveur et l'autre reste au ma�tre d'hotel
            Assert.Equal(serveur, tableDuServeur.Affectataire);
            Assert.Equal(maîtreHotel, tableDuMaîtreHotel.Affectataire);
        }
    }
}