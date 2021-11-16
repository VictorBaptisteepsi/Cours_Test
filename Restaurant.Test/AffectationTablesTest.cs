using Xunit;

namespace LeGrandRestaurant.Test
{
    public class AffectationTablesTest
    {
        [Fact(DisplayName = "Etant donné une salle ayant une table, elle est affectée par défaut au maître d'hotel.")]
        public void Affectation_Initiale()
        {
            // Étant donné une salle ayant une table
            var maîtreHotel = new MaîtreHotel();
            var table = new Table();
            var salle = new Salle(table, maîtreHotel);

            // Alors cette table est affectée par défaut au maître d'hôtel
            Assert.Equal(maîtreHotel, table.Affectataire);
        }
    }
}