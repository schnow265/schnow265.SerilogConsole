using Serilog.Core;
using Serilog.Events;

namespace DependencyInjectionTemplate.Extensions.Serilog;

internal class SourceTypeEnricher : ILogEventEnricher
{
    public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
    {
        if (!logEvent.Properties.TryGetValue("SourceContext", out LogEventPropertyValue? context))
        {
            return;
        }

        string value = context.ToString();
        value = value.Replace("\"", string.Empty);
        string typeName = value;
        int pos = value.LastIndexOf('.');
        if (pos != -1)
        {
            typeName = value.Substring(pos + 1, value.Length - pos - 1);
        }

        logEvent.AddOrUpdateProperty(propertyFactory.CreateProperty("SourceType", typeName));
    }
}