using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.Ollama;
using Serilog;
using Serilog.Events;
using SematicKernelOllama.Services;

namespace SematicKernelOllama;

class Program
{
    static async Task Main(string[] args)
    {
        // Configure Serilog
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Error)
            .WriteTo.File("debug.log", restrictedToMinimumLevel: LogEventLevel.Debug)
            .Enrich.FromLogContext()
            .CreateLogger();

        try
        {
            Log.Information("Starting application");
            
            // Setup host with dependency injection and Serilog
            var host = Host.CreateDefaultBuilder(args)
                .UseSerilog() // Use Serilog as the logging provider
                .ConfigureServices((context, services) =>
                {
                    // Configure Ollama endpoint
                    Uri endpoint = new Uri("http://localhost:11434");
                    
                    // Register Kernel and configure it
                    services.AddSingleton(sp =>
                    {
                        var builder = Kernel.CreateBuilder();
                        
                        // Add Ollama integration
                        #pragma warning disable SKEXP0070
                        builder.AddOllamaChatCompletion(
                            "qwen2.5:1.5b",   // Model ID for Qwen 2.5 1.5B
                            endpoint: endpoint // Default Ollama endpoint
                        );

                        // Use the Serilog logger via ILoggerFactory
                        builder.Services.AddLogging(loggingBuilder => 
                        {
                            loggingBuilder.AddSerilog(dispose: false);
                        });
                        
                        return builder.Build();
                    });
                    
                    // Register our custom chat service
                    services.AddScoped<IChatService, OllamaChatService>();
                    
                    // Register the console application
                    services.AddSingleton<ConsoleApplication>();
                })
                .Build();

            // Run the application
            var app = host.Services.GetRequiredService<ConsoleApplication>();
            await app.RunAsync();
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Application terminated unexpectedly");
        }
        finally
        {
            // Ensure to flush and close the log
            Log.CloseAndFlush();
        }
    }
}