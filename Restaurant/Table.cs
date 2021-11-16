namespace Restaurant
{
    public class Table
    {
        public IPeutServir Affectataire { get; private set; }

        public void AffecterA(IPeutServir serveur)
        {
            Affectataire = serveur;
        }
    }
}
