using System;

namespace Restaurant
{
    public class HorlogeSystème : IHorloge
    {
        /// <inheritdoc />
        public DateTime Now => DateTime.Now;
    }
}
