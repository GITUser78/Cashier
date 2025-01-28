using CashierTestConsole.interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CashierTestConsole.Composition
{
    internal static class CompositionRoot
    {

        public static IBuilding CreateServices(IServiceProvider serviceProvider)
        {
            var appartmentFactory = serviceProvider.GetService<IAppartmentFactory>();
            var buildingBuilder = serviceProvider.GetRequiredService<IBuildingBuilder>();
            var address = serviceProvider.GetRequiredService<IAddress>();
            var configurator = serviceProvider.GetRequiredService<BuildingConfigurator>();

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            configuration.GetSection("Address").Bind(address);
            configuration.GetSection("BuildingConfigurator").Bind(configurator);


            return buildingBuilder.CreateBuilding()
                                      .WithLastFloor(configurator.LastFloor)
                                      .WithAppartmentsPerFloor(configurator.AppartmentsPerFloor)
                                      .WithStartingFloor(configurator.StartingFloor)
                                      .WithName(configurator.BuildingName)
                                      .AtAddress(address)
                                      .Build();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IOccupant, Occupant>();
            services.AddTransient<IAppartment, Appartment>();
            services.AddSingleton<IAppartmentFactory, AppartmentFactory>();
            services.AddSingleton<BuildingConfigurator>();
            services.AddSingleton<IBuildingBuilder, BuildingBuilder>();
            services.AddSingleton<IBuilding, Building>();
            services.AddSingleton<IAddress, StreetAddress>();
        }
    }

}
