using CashierTestConsole.Dummies;
using CashierTestConsole.interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierTestConsole.Composition
{
    internal class BuildingBuilder : IBuildingBuilder
    {
        private string nameOfBuilding = "";
        private IAddress address;
        private IList<IFloor> floors = new List<IFloor>();
        private int appartmentsPerFloor = 2;
        private int numFloors;
        private IFloorFactory floorFactory;
        private readonly IAppartmentFactory apartmentFactory;

        public IServiceProvider Provider { get; }

        public BuildingBuilder(IServiceProvider provider)
        {
            this.floorFactory = provider.GetRequiredService<IFloorFactory>();
            this.apartmentFactory = provider.GetRequiredService<IAppartmentFactory>();
            address = EmptyAddress.Instance;
            Provider = provider;
        }
        public IBuildingBuilder AtAddress(IAddress address)
        {
            this.address = address;
            return this;
        }

        public IBuilding Build()
        {
            for (int i = 0; i < this.numFloors; i++)
            {
                var floor = this.floorFactory.CreateNextFloor();
                for (int j = 0; j < this.appartmentsPerFloor; j++)
                {
                    floor.Appartments.Add(this.apartmentFactory.CreateNextAppartment(floor));
                }
                this.floors.Add(floor);
            }

            var building = this.Provider.GetRequiredService<IBuilding>();
            building.Name = nameOfBuilding;
            building.Address = this.address;
            building.Floors = this.floors;
            return building;
        }

        public IBuildingBuilder CreateBuilding() => this;

        public IBuildingBuilder WithAppartmentsPerFloor(int appartmentsPerFloor)
        {
            this.appartmentsPerFloor = appartmentsPerFloor;
            return this;
        }

        public IBuildingBuilder WithName(string name)
        {
            this.nameOfBuilding = name;
            return this;
        }

        public IBuildingBuilder WithNumberOfFloors(int floors)
        {
            this.numFloors = floors;            
            return this;
        }
    }
}
