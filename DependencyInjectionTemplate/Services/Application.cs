using DependencyInjectionTemplate.Services.Interfaces;

using Microsoft.Extensions.Logging;

namespace DependencyInjectionTemplate.Services
{
    public class Application(ILogger<Application> logger) : IApplication
    {
        public void Run(string[] args)
        {
            logger.LogDebug("Hello, World!");
        }
    }
}