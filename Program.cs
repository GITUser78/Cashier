
using CashierTestConsole.Composition;
using CashierTestConsole.interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();

        // Hier können Sie den Service-Provider verwenden, um Ihre Anwendung zu starten
        var serviceProvider = host.Services;

        // Beispiel: var myService = serviceProvider.GetRequiredService<MyService>();
        var building = CompositionRoot.CreateServices(serviceProvider);

        host.Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                CompositionRoot.ConfigureServices(services);
                // Weitere Service-Registrierungen hier
            });
}