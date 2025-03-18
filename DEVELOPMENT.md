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
