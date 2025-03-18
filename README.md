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

## Template Development

### Adding a New Template

1. Create a new project directory
2. Add a `.template.config/template.json` file with appropriate metadata
3. Create a `.nuspec` file for packaging
4. Update the GitHub workflow in `.github/workflows/publish.yml` to include the new template
5. Add the new template as a dependency in the `MetaTemplate/.nuspec` file

## Publishing

Templates are automatically published to GitHub Packages when a new tag is pushed:

```bash
git tag v1.0.1
git push origin v1.0.1
```

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

Distributed under the MIT License. See `LICENSE` for more information.
