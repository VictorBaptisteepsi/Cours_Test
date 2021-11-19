using System.Collections.Generic;

namespace Restaurant
{
    public class Service
    {
        private bool _serviceEnCours;
        private List<Table> _tables;
        private MaîtreHotel _maîtreHotel;

        public Service(MaîtreHotel maîtreHotel)
        {
            _maîtreHotel = maîtreHotel;
        }

        public bool ServiceEnCours
        {
            get
            {
                return _serviceEnCours;
            }
            set
            {
                foreach (var table in _tables)
                {
                    table.AffecterA(_maîtreHotel);
                }
            }
        }

        public List<Table> Tables
        {
            get => _tables;
            set => _tables = value;
        }
    }
}