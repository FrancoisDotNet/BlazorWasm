# Blazor WebAssembly Template

## Prerequisites
1. **SDK** : [.NET Core](https://dotnet.microsoft.com/download)
2. **IDE** : [VS Code](https://code.visualstudio.com/download)
3. **SCM** : [Git](https://git-scm.com/downloads)

## Template structure
- Root directory : **repository** files
  - [*`License.txt`*](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/licensing-a-repository)
  - [*`Readme.md`*](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/about-readmes)
- `Docs` directory : [**publishing** files](https://help.github.com/en/github/working-with-github-pages/configuring-a-publishing-source-for-your-github-pages-site#choosing-a-publishing-source)
- `BlazorWasm` directory : **project** files
  - `*BlazorWasm.csproj*` [project file](https://docs.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/project-structure#project-file) and `*Program.cs*` [entry point](https://docs.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/project-structure#entry-point) : project and app configuration.
  - `*Body.razor*` [razor component](https://docs.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/project-structure#razor-components) and `index.html` (in `wwwroot` [static files](https://docs.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/project-structure#static-files) subdirectory) : web page and app files.
