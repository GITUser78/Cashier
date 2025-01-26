using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole.interfaces
{
    public interface IOccupant
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string PhoneNumber { get; set; }

        IAppartment Appartement { get; set; }
    }
}
