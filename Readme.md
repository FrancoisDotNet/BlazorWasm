# Blazor WebAssembly

## Prerequisites
1. [.NET Core **SDK**](https://dotnet.microsoft.com/download)
2. [VS Code **IDE**](https://code.visualstudio.com/download)
3. [Git **SCM**](https://git-scm.com/downloads)

## Structure
- `BlazorWasm` **repository** root : [*`License.txt`*](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/licensing-a-repository) and [*`Readme.md`*](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/about-readmes)
- `Docs` **publishing** directory : [GitHub Pages site source](https://help.github.com/en/github/working-with-github-pages/configuring-a-publishing-source-for-your-github-pages-site#choosing-a-publishing-source)
- `BlazorWasm` **project** directory :
  - *`BlazorWasm.csproj`* [Project file](https://docs.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/project-structure#project-file)
  - *`Program.cs`* [App entry point](https://docs.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/project-structure#entry-point)
  - `wwwroot` [static files](https://docs.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/project-structure#static-files) subdirectory (contains the *`index.html`* HTML document )
  - *`Body.razor`* [Razor component](https://docs.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/project-structure#razor-components)
