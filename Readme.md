# Blazor WebAssembly Template

## Template structure
- [`Readme.md`](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/about-readmes) and [`License.txt`](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/licensing-a-repository) of the repository.
- `Docs` [publishing source](https://help.github.com/en/github/working-with-github-pages/configuring-a-publishing-source-for-your-github-pages-site#choosing-a-publishing-source) : web app files published by VS Code from the project files.
- `BlazorWasm` directory : project files
  - `BlazorWasm.csproj` [project file](https://docs.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/project-structure#project-file) and `Program.cs` [entry point](https://docs.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/project-structure#entry-point) : project and app configuration.
  - `Body.razor` [razor component](https://docs.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/project-structure#razor-components) and `wwwroot` [static files](https://docs.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/project-structure#static-files) : web page and app files.
## Install the tools
1. [.NET Core SDK](https://dotnet.microsoft.com/download)
2. [VS Code IDE](https://code.visualstudio.com/download)
3. [Git SCM](https://git-scm.com/downloads)
## Get the code
1. [Create a repository from this template](https://github.com/FrancoisDotNet/BlazorWasm/generate).
2. [Choose the `Docs` folder as publishing source for GitHub Pages](https://help.github.com/en/github/working-with-github-pages/configuring-a-publishing-source-for-your-github-pages-site#choosing-a-publishing-source).
3. [Clone the created repository](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository).

## IV. 
1. Run `dotnet publish -c:release` command in VS Code terminal to publish the Web App.
2. Follow the VS Code prompted link to visit the Web App hosted on GitHub Pages.
