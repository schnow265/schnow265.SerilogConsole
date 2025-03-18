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

## Installation

For example to install the Serilog Console template:

```bash
# Install a specific template
dotnet new install schnow265.Templates.SerilogConsole
```

Or directly from GitHub packages:

```bash
dotnet new install schnow265.Templates::1.0.0 --nuget-source https://nuget.pkg.github.com/schnow265/index.json
# OR
dotnet new install schnow265.Templates.SerilogConsole::1.0.0 --nuget-source https://nuget.pkg.github.com/schnow265/index.json
```

## Usage

### Serilog Console Template

Create a new application with the Serilog Console template:

```bash
dotnet new ConsoleLogger -o MyLoggerApp
```

Optional parameters:
- `--Framework`: Specify target framework (net8.0 or net9.0, default: net9.0)

## License

Distributed under the MIT License. See `LICENSE` for more information.
