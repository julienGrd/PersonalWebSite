using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PersonalWebSite.Blazor.Client.Model;
using PersonalWebSite.Blazor.Client.Services;
using System.Globalization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//builder.Services.AddBlazoredLocalStorage();
//builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
//builder.Services.AddScoped<LanguageService>();
builder.Services.AddCommon();




var host = builder.Build();

await host.Services.SetDefaultUICulture();

await host.RunAsync();
