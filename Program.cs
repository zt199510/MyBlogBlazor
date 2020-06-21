using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyblogBlazor.Commons;

namespace MyblogBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            var baseAddress = "https://localhost:44352";

            //if (builder.HostEnvironment.IsProduction())
            //     baseAddress = "https://api.meowv.com";

                builder.Services.AddTransient(sp => new HttpClient
                {
                    BaseAddress = new Uri(baseAddress)
                });
          
            builder.Services.AddSingleton(typeof(Common));

            await builder.Build().RunAsync();
        }
    }
}
