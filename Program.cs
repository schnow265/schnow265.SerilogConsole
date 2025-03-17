using Serilog;
using SerilogConsole.TemplateSettings;

namespace SerilogConsole;

class Program
{
    static void Main(string[] args)
    {
        BuildLogger.Build();
        
        Log.Information("Hello, World!");
    }
}