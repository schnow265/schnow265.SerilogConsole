using DependencyInjectionTemplate.Services.Interfaces;

namespace DependencyInjectionTemplate.Services
{
    public class Application : IApplication
    {
        public void Run(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}