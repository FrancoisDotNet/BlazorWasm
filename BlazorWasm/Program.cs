﻿using Microsoft.AspNetCore.Blazor.Hosting;
using System.Threading.Tasks;

namespace BlazorWasm
{
    class Program
    {
        public static async Task Main()
        {   
            var builder = WebAssemblyHostBuilder.CreateDefault();
            builder.RootComponents.Add<Body>("body");
            await builder.Build().RunAsync();
        }
    }
}