# Dependency Injection Template

A .NET template that creates a console application with Microsoft DI integration already set up.

## Installation

You can install this template using the .NET CLI:

```bash
dotnet new install schnow265.Templates.DependencyInjectionTemplate
```

Or directly from GitHub packages:

```bash
dotnet new install schnow265.Templates.DependencyInjectionTemplate::1.0.0 --nuget-source https://nuget.pkg.github.com/schnow265/index.json
```

## Usage

Create a new application using the template:

```bash
dotnet new DependencyInjection -o MyDIApp
```

## Features

- Pre-configured Microsoft.Extensions.DependencyInjection setup
- Basic service interfaces and implementations
- Ready-to-use dependency registration
- Supports .NET 8.0 and .NET 9.0

## Project Structure

- `Services/Interfaces` - Contains service interfaces
- `Services` - Contains service implementations
- `Program.cs` - Main entry point with DI container setup

## License

MIT
