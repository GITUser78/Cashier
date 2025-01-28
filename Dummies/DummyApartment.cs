using CashierTestConsole.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole.Dummies
{
    public class DummyApartment : IAppartment
    {
        private static readonly Lazy<DummyApartment> instance = new Lazy<DummyApartment>(() => new DummyApartment());

        private DummyApartment() { }

        public static DummyApartment Instance => instance.Value;

        public int Number { get; set; }
        public int Floor { get; set; } = -1;
        public int NumberOfOccupants { get; set; }

        public IList<IOccupant> Occupants => new List<IOccupant>();
    }
}
