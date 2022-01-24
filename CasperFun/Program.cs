using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using CasperFun.Services;
using Blazored.SessionStorage;
using CasperFun.Auth;
using Microsoft.AspNetCore.Components.Authorization;

namespace CasperFun
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddMudServices();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, MyAuthenticationStateProvider>();
            builder.Services.AddBlazoredSessionStorage();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<ICasperService, CasperService>();

            await builder.Build().RunAsync();
        }
    }
}
