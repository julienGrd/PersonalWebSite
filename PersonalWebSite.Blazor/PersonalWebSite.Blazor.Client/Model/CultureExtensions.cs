using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PersonalWebSite.Blazor.Client.Services;
using System.Globalization;

namespace PersonalWebSite.Blazor.Client.Model
{
    public static class CultureExtensions
    {
        public async static Task SetDefaultUICulture(this IServiceProvider services)
        {
            // 1. Read the ILocalStorageService to read the LocalStorage


            //var localStorage = services.GetRequiredService<ILocalStorageService>();
           

            //// 2. Read the current value for the Culture from the
            //// LocalStorage  

            //var result = await localStorage.GetItemAsync<string>("currentcuture");

            //CultureInfo culture;
            //if (result != null)
            //    // 3.a. Set the selected Culture
            //    culture = new CultureInfo(result);
            //else
            //    // 3.b. else the default culture will be en-US
            //    culture = CultureInfo.CurrentUICulture;
            
            // Set the cukture to application
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.CurrentUICulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.CurrentUICulture;
            //CultureInfo.CurrentUICulture = culture;
        }
    }
}
