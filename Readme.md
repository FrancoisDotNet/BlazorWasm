# Blazor WebAssembly Web App Template
> The minimal amount of code to build a Blazor WebAssembly Web App.
## I. Install the tools
1. [.NET Core SDK](https://dotnet.microsoft.com/download)
2. [VS Code IDE](https://code.visualstudio.com/download)
3. [Git SCM](https://git-scm.com/downloads)
## II. Get the code
1. [Create a repository from this template](https://github.com/FrancoisDotNet/BlazorWasm/generate).
2. [Choosing the `Docs` created repository directory as publishing source for GitHub Pages](https://help.github.com/en/github/working-with-github-pages/configuring-a-publishing-source-for-your-github-pages-site#choosing-a-publishing-source).
3. Set your Git [username](https://help.github.com/en/github/using-git/setting-your-username-in-git#setting-your-git-username-for-every-repository-on-your-computer) and [email](https://help.github.com/en/github/setting-up-and-managing-your-github-user-account/setting-your-commit-email-address#setting-your-email-address-for-every-repository-on-your-computer) for every repository on your computer.
4. [Clone the created repository](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository).
## III. Undestand the files structure
- [`Readme.md`](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/about-readmes) and [`License.txt`](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/licensing-a-repository) of the repository.
- `Docs` directory : the published files from VS Code
  - `.nojekyll` : [for GitHub Pages hosting](https://help.github.com/en/github/working-with-github-pages/about-github-pages#static-site-generators)
  - `index.html` : see below
  - `_framwork` directory : the app assets
- `BlazorWasm` directory : the working files
  - `BlazorWasm.csproj` : the project file customized building configuration
  - `Body.razor` : the razor
  - `Program.cs` : the entry point
  - `wwwroot` directory : `index.html`
## IV. 
1. Run `dotnet publish -c:release` command in VS Code terminal to publish the Web App.
2. Follow the VS Code prompted link to visit the Web App hosted on GitHub Pages.
