using System;

namespace Restaurant.Test.Utilities
{
    internal class HorlogeRéglable : IHorloge
    {
        public DateTime Now { get; private set; }

        public void AdvanceInTime(TimeSpan howMany)
        {
            Now += howMany;
        }
    }
}
