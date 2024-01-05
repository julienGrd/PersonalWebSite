using Microsoft.AspNetCore.Components;
using PersonalWebSite.Blazor.Client.Services;

namespace PersonalWebSite.Blazor.Client.Components
{
    public class CustomBaseComponent : ComponentBase
    {
        [Inject]
        public LanguageService LanguageService { get; set; }
    }
}
