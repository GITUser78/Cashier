using CashierTestConsole.interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CashierTestConsole.Composition
{
    internal class AppartmentFactory : IAppartmentFactory
    {
        int currentAppartment = 1;
        private IServiceProvider provider;

        public AppartmentFactory(IServiceProvider serviceProvider)
        {
            this.provider = serviceProvider;
        }

        public IAppartment CreateNextAppartment(int floor)
        {
            var appartment = this.provider.GetRequiredService<IAppartment>();
            appartment.Floor = floor;
            appartment.Number = currentAppartment++;
            return appartment;
        }
    }
}
