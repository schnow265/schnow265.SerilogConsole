# schnow265.Templates

A collection of .NET project templates designed to accelerate development workflows by providing pre-configured setups for common scenarios.

## Available Templates

### Serilog Console Template

A console application template with Serilog integration for structured logging.

**Features:**

- Pre-configured Serilog setup
- Console sink ready to use
- Structured for easy extensibility
- Supports .NET 8.0 and .NET 9.0

### Dependency Injection Template

A console application template with Microsoft Dependency Injection already set up.

**Features:**

- Pre-configured Microsoft.Extensions.DependencyInjection setup
- Basic service interfaces and implementations
- Ready-to-use dependency registration
- Supports .NET 8.0 and .NET 9.0

## Installation

For example to install a template (you will need a github access token.):

```bash
dotnet new install schnow265.Templates.SerilogConsole::1.0.0 --nuget-source https://nuget.pkg.github.com/schnow265/index.json
dotnet new install schnow265.Templates.DependencyInjectionTemplate::1.0.0 --nuget-source https://nuget.pkg.github.com/schnow265/index.json
```

## Usage

### Serilog Console Template

Create a new application with the Serilog Console template:

```bash
dotnet new ConsoleLogger -o MyLoggerApp
```

### Dependency Injection Template

Create a new application with Dependency Injection ready to use:

```bash
dotnet new DependencyInjection -o MyDIApp
```

Optional parameters for both templates:

- `--Framework`: Specify target framework (net8.0 or net9.0, default: net9.0)

## License

Distributed under the MIT License. See `LICENSE` for more information.
