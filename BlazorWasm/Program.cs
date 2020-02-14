using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.AspNetCore.Components.Web;
using System.Threading.Tasks;

namespace BlazorWasm
{
    class Program
    {
        //static async Task Main() => await WebAssemblyHostBuilder.CreateDefault().RootComponents.Add<Body>("body").Build().RunAsync();

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<Body>("body");

            await builder.Build().RunAsync();
        }
    }
}