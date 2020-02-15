﻿using static Microsoft.AspNetCore.Blazor.Hosting.WebAssemblyHostBuilder;
using System.Threading.Tasks;

namespace BlazorWasm
{
    class Program
    {
        //static async Task Main() => await WebAssemblyHostBuilder.CreateDefault().RootComponents.Add<Body>("body").Build().RunAsync();

        public static async Task Main()
        {
            var builder = CreateDefault();
            builder.RootComponents.Add<Body>("body");
            await builder.Build().RunAsync();
        }
    }
}