global using DiabetesBlazorApp.Client.Services.GlucoseValuesSerice;
global using DiabetesBlazorApp.Shared;
using DiabetesBlazorApp.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IGlucoseValuesService, GlucoseValuesService>();

await builder.Build().RunAsync();
