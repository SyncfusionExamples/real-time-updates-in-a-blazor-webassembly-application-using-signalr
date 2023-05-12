using BlazorSignalRScheduler.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTk5MDA2MkAzMjMxMmUzMjJlMzNLS3V4ak5FeG1GRXhhcUxLT0JyKzFVV1RrK1NRaDc0U1QyU2FoVXhnQkw4PQ==");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSyncfusionBlazor();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
