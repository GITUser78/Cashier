using CashierTestConsole.interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole.Composition
{
    internal class FloorFactory : IFloorFactory
    {
        int currentFloor;

        public FloorFactory(IServiceProvider provider)
        {
            this.currentFloor = 1;
            Provider = provider;
        }


        public int AppartmentsPerFloor { get; set; } = 2;
        public IServiceProvider Provider { get; }

        public IFloor CreateNextFloor()
        {
            var floor = Provider.GetRequiredService<IFloor>();
            floor.FloorNumber = currentFloor++;
            return floor;
        }
    }
}
