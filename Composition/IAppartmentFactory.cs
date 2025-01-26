using CashierTestConsole.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole.Composition
{
    internal interface IAppartmentFactory
    {
        IAppartment CreateNextAppartment(IFloor floor);
    }
}
