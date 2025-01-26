using CashierTestConsole.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole.interfaces
{
    public class Floor : IFloor
    {
        /// <summary>
        /// 
        /// </summary>
        public int FloorNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<IAppartment> Appartments {  get; } = new List<IAppartment>();
    }
}
