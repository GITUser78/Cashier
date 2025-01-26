using CashierTestConsole.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole.Dummies
{
    internal class AnonymousPersion : IOccupant
    {
        private static readonly Lazy<AnonymousPersion> instance = new Lazy<AnonymousPersion>(() => new AnonymousPersion());

        public static AnonymousPersion Instance => instance.Value;

        private AnonymousPersion()
        {
            FirstName = "Anton";
            LastName = "Anonymous";
            PhoneNumber = "+359 12345678";
            Appartement = DummyApartment.Instance;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public IAppartment Appartement { get; set; }
    }
}
