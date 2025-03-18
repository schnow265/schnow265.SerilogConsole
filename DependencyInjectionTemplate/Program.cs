using DependencyInjectionTemplate.Services;
using DependencyInjectionTemplate.Services.Interfaces;

using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionTemplate{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSingleton<IApplication, Application>();


            // Add any services before this line.
            var serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetRequiredService<IApplication>()?.Run(args);
        }
    }
}
