using Xunit;

namespace LeGrandRestaurant.Test
{
    public class AffectationTablesTest
    {
        [Fact(DisplayName = "Etant donn� une salle ayant une table, elle est affect�e par d�faut au ma�tre d'hotel.")]
        public void Affectation_Initiale()
        {
            // �tant donn� une salle ayant une table
            var ma�treHotel = new Ma�treHotel();
            var table = new Table();
            var salle = new Salle(table, ma�treHotel);

            // Alors cette table est affect�e par d�faut au ma�tre d'h�tel
            Assert.Equal(ma�treHotel, table.Affectataire);
        }
    }
}