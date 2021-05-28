using azure_functions_example.Configurations;
using azure_functions_example.HealthCheck;
using azure_functions_example.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

[assembly: FunctionsStartup(typeof(azure_functions_example.StartUp))]
namespace azure_functions_example
{
    /// <summary>
    /// This represents the entity to be invoked during the runtime startup.
    /// </summary>
    public class StartUp : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            ConfigureServices(builder.Services);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddSingleton<AppSettings>();
            services.AddTransient<IDummyHttpService, DummyHttpService>();

            services.AddFunctionHealthChecks()
                .AddMongoDb("mongodb://root:MongoDB2021!@localhost:27017");
        }
    }
}
