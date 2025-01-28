using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole.Composition
{
    internal class BuildingConfigurator
    {
        public string BuildingName { get; set; } = "Default Building";

        public int LastFloor { get; set; }

        public int AppartmentsPerFloor { get; set; }

        public int StartingFloor { get; set; }
    }
}
