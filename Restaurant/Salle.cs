namespace Restaurant
{
    public class Salle
    {
        public Salle(Table table, MaîtreHotel maîtreHotel)
        {
            table.AffecterA(maîtreHotel);
        }
    }
}
