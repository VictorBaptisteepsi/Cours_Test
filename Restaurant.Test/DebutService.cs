using System.Collections.Generic;
using Xunit;
using Shouldly;

namespace Restaurant.Test
{
    public class DebutService
    {
        [Fact(DisplayName = "ÉTANT DONNE un restaurant ayant 3 tables" +
                            "QUAND le service commence" +
                            "ALORS elles sont toutes affectées au Maître d'Hôtel")]

        public void ThreeTableMaster()
        {
            //ÉTANT DONNE un restaurant ayant 3 tables
            var maitrehotel = new MaîtreHotel();
            var service = new Service(maitrehotel);
            var tables = new List<Table>{new Table(), new Table(), new Table()};
            service.Tables = tables;
            //"QUAND le service commence"
            service.ServiceEnCours = true;
            //ALORS elles sont toutes affectées au Maître d'Hôtel
            Assert.All(service.Tables, table => Assert.Equal(maitrehotel, table.Affectataire));
            
        }
    }
}