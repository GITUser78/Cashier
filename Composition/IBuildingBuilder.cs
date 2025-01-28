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
        IBuildingBuilder WithLastFloor(int floors);
        IBuildingBuilder WithAppartmentsPerFloor(int appartmentsPerFloor);
        
        IBuildingBuilder WithStartingFloor(int firstFloor);

        IBuilding Build();
    }
}
