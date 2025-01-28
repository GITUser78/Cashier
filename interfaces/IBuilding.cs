using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole.interfaces
{
    public interface IBuilding
    {
        string Name { get; set; }

        IAddress Address { get; set; }

        List<IAppartment> Appartments { get; set; }

        /// <summary>
        /// caretaker, janitor, apartment manager
        /// </summary>
        IOccupant Groundskeeper { get; set; }
    }
}
