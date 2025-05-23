using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddMudServices();

builder.Services.AddHttpClient();
builder.Services.AddHttpClient("ClientConfig",x =>
{
    x.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddHttpClient("InvestmentBackendConfig",x =>
{
    x.BaseAddress = new Uri("http://localhost:5555");
});

await builder.Build().RunAsync();