using CashierTestConsole.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole.Dummies
{
    internal class Cellar : IFloor
    {
        private static readonly Lazy<Cellar> instance = new Lazy<Cellar>(() => new Cellar());

        private Cellar() { }

        public static Cellar Instance => instance.Value;

        public int FloorNumber => -1;

        public IList<IAppartment> Appartments => new List<IAppartment>();

        int IFloor.FloorNumber { get; set; } = -1;
    }
}
