using CashierTestConsole.Dummies;
using CashierTestConsole.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole
{
    public class Occupant : IOccupant
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public IAppartment Appartement { get; set; } = DummyApartment.Instance;
    }
}
