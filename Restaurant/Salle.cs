namespace Restaurant
{
    public class Salle
    {
        public Salle(MaîtreHotel maîtreHotel, params Table[] tables)
        {
            foreach (var table in tables)
            {
                table.AffecterA(maîtreHotel);
            }
        }
    }
}
