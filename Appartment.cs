using CashierTestConsole.interfaces;

namespace CashierTestConsole
{
    public class Appartment : IAppartment
    {
        public int Number { get; set; }
        public int Floor { get; set; }
        public int NumberOfOccupants { get; set; }
        public IList<IOccupant> Occupants { get; } = new List<IOccupant>();
    }
}
