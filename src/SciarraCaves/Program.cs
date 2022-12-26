using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SciarraCaves.Core.Managers;
using SciarraCaves.Core.Services;
using System.Security.Cryptography;

namespace SciarraCaves
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            ExecuteScope(host.Services);

            await host.RunAsync();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).ConfigureServices((_, services) =>
                services
                    .AddTransient<IBattleService, BattleService>()
                    .AddTransient<IDamageService, DamageService>()
            );

        private static void ExecuteScope(IServiceProvider services)
        {
            using IServiceScope serviceScope = services.CreateScope();
            IServiceProvider provider = serviceScope.ServiceProvider;

            var startup = provider.GetRequiredService<IBattleService>();
            startup.Start();
        }
    }
}
