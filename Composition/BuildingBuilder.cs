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
        private int appartmentsPerFloor = 2;
        private int lastFloor;
        private int startFloor;
        private readonly IAppartmentFactory apartmentFactory;

        public IServiceProvider Provider { get; }

        public BuildingBuilder(IServiceProvider provider)
        {
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
            var building = this.Provider.GetRequiredService<IBuilding>();
            for (int i = startFloor; i < this.lastFloor; i++)
            {
                for (int j = 0; j < this.appartmentsPerFloor; j++)
                {
                    building.Appartments.Add(this.apartmentFactory.CreateNextAppartment(i));
                }
            }
            
            building.Name = nameOfBuilding;
            building.Address = this.address;
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

        public IBuildingBuilder WithLastFloor(int floors)
        {
            this.lastFloor = floors;            
            return this;
        }

        public IBuildingBuilder WithStartingFloor(int firstFloor)
        {
            this.startFloor = firstFloor;
            return this;
        }
    }
}
