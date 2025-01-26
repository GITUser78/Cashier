using CashierTestConsole.interfaces;

namespace CashierTestConsole
{
    public class Appartment : IAppartment
    {
        public int Number { get; set; }
        public IFloor Floor { get; set; } = new Floor();
        public int NumberOfOccupants { get; set; }
        public IList<IOccupant> Occupants { get; } = new List<IOccupant>();
    }
}
