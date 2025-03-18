using Serilog;

namespace SerilogConsole.TemplateSettings;

public class BuildLogger
{
    public static void Build()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();
    }
}