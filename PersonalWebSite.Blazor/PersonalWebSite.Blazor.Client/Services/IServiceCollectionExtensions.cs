using Blazored.LocalStorage;

namespace PersonalWebSite.Blazor.Client.Services
{
    public static class IServiceCollectionExtensions
    {
        public static void AddCommon(this IServiceCollection services)
        {
            services.AddBlazoredLocalStorage();
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddScoped<LanguageService>();

        }
    }
}
