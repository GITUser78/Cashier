using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole.interfaces
{
    public interface IAppartment
    {
        int Number { get; set; }

        IFloor Floor { get; set; }

        int NumberOfOccupants { get; set; }

        IList<IOccupant> Occupants { get; }
    }
}
