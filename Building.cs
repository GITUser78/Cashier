using CashierTestConsole.Dummies;
using CashierTestConsole.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole
{
    internal class Building : IBuilding
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; } = string.Empty;

        public IAddress Address { get; set; } = EmptyAddress.Instance;

        public IOccupant Groundskeeper { get; set; } = AnonymousPersion.Instance;

        public List<IAppartment> Appartments {  get; set; } = new List<IAppartment>();
    }
}
