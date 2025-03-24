using DependencyInjectionTemplate.Extensions.Serilog;
using DependencyInjectionTemplate.Services;
using DependencyInjectionTemplate.Services.Interfaces;

using Microsoft.Extensions.DependencyInjection;

using Serilog;

namespace DependencyInjectionTemplate{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console(
                    outputTemplate: "[{UtcTimestamp}] [{Level}] [{SourceType:l}] {Message:l}{NewLine}{Exception}")
                .Enrich.FromLogContext() // Enrich log messages with additional context like service names
                .Enrich.With<SourceTypeEnricher>() // add the logging source
                .Enrich.With<UtcTimestampEnricher>() // all timestamps are now in UTC
                .CreateLogger();
            
            var services = new ServiceCollection();
            services.AddLogging(builder =>
            {
                builder.AddSerilog();
            });
            
            services.AddSingleton<IApplication, Application>();


            // Add any services before this line.
            var serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetRequiredService<IApplication>()?.Run(args);
        }
    }
}
