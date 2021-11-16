namespace LeGrandRestaurant
{
    public class Table
    {
        public MaîtreHotel Affectataire { get; private set; }

        public void AffecterA(MaîtreHotel maîtreHotel)
        {
            Affectataire = maîtreHotel;
        }
    }
}
