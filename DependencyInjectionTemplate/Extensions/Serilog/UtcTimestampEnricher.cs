using Serilog.Core;
using Serilog.Events;

namespace DependencyInjectionTemplate.Extensions.Serilog;

public class UtcTimestampEnricher : ILogEventEnricher
{
    public void Enrich(LogEvent logEvent, ILogEventPropertyFactory pf)
    {
        logEvent.AddPropertyIfAbsent(pf.CreateProperty("UtcTimestamp", logEvent.Timestamp.UtcDateTime.ToString("yyyy-MM-d HH:mm:ss")));
    }
}