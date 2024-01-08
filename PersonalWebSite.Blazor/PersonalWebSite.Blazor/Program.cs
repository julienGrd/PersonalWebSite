using Microsoft.Extensions.Hosting;
using PersonalWebSite.Blazor.Client.Pages;
using PersonalWebSite.Blazor.Client.Services;
using PersonalWebSite.Blazor.Components;
//using PersonalWebSite.Blazor.Client.Model;
//using System.Globalization;
//using Microsoft.AspNetCore.Components.Web;
//using PersonalWebSite.Blazor.Services;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddScoped<HtmlRenderer>();
//builder.Services.AddScoped<BlazorRenderer>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

//builder.Services.AddRazorPages();
//builder.Services.AddControllers();

builder.Services.AddCommon();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();


//app.UseRouting();

app.UseAntiforgery();

//app.MapControllers();


//var supportedCultures = new[] { "fr", "en" };
//var localizationOptions = new RequestLocalizationOptions()
//    .SetDefaultCulture(supportedCultures[0])
//    .AddSupportedCultures(supportedCultures)
//    .AddSupportedUICultures(supportedCultures);

//app.UseRequestLocalization(localizationOptions);

//app.MapControllers();
//CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;
//CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Counter).Assembly);
app.Run();


