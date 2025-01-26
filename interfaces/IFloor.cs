using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole.interfaces
{
    public interface IFloor
    {
        int FloorNumber { get; set; }

        IList<IAppartment> Appartments { get; }
    }
}
