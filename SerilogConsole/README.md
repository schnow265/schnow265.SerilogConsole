# Serilog Console Template

A .NET template that creates a console application with Serilog integration.

## Installation

You can install this template using the .NET CLI:

```bash
dotnet new install schnow265.Templates.SerilogConsole
```

Or directly from GitHub packages:

```bash
dotnet new install schnow265.Templates.SerilogConsole::1.0.0 --nuget-source https://nuget.pkg.github.com/schnow265/index.json
```

## Usage

Create a new application using the template:

```bash
dotnet new ConsoleLogger -o MyLoggerApp
```

## Features

- Pre-configured Serilog setup
- Console sink ready to use
- Structured for easy extensibility
- Supports .NET 8.0 and .NET 9.0

## License

MIT
