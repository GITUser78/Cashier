using CashierTestConsole.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole
{
    public class StreetAddress : AddressBase, IAddress
    {
        /// <summary>
        /// Name of the street
        /// </summary>
        public string Street { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public string HouseNumber { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public string District { get; set; } = string.Empty;
    }
}
