using CashierTestConsole.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole.Dummies
{
    internal class EmptyAddress : IAddress
    {
        private static readonly Lazy<EmptyAddress> instance = new Lazy<EmptyAddress>(() => new EmptyAddress());

        private EmptyAddress() { }

        public static EmptyAddress Instance => instance.Value;

        public string AddressString => "No address";
    }
}
