using CashierTestConsole.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole.Composition
{
    internal interface IBuildingBuilder
    {
        IBuildingBuilder CreateBuilding();
        IBuildingBuilder WithName(string name);
        IBuildingBuilder AtAddress(IAddress address);
        IBuildingBuilder WithNumberOfFloors(int floors);
        IBuildingBuilder WithAppartmentsPerFloor(int appartmentsPerFloor);
        IBuilding Build();
    }
}
