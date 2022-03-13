using Microsoft.AspNetCore.Components;
using PersonalWebSite.Front.Services;

namespace PersonalWebSite.Front.Components
{
    public class CustomBaseComponent : ComponentBase
    {
        [Inject]
        public LanguageService LanguageService { get; set; }
    }
}
