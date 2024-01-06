using Microsoft.AspNetCore.Components;
using PersonalWebSite.Blazor.Client.Services;

namespace PersonalWebSite.Blazor.Client.Components
{
    public class CustomBaseComponent : ComponentBase, IDisposable
    {
        [Inject]
        public LanguageService LanguageService { get; set; }

        protected override void OnInitialized()
        {
            LanguageService.OnLanguageChanged += LanguageService_OnLanguageChanged;
            base.OnInitialized();
        }

        private void LanguageService_OnLanguageChanged(object sender, EventArgs e)
        {
            this.StateHasChanged();
        }

        public void Dispose()
        {
            LanguageService.OnLanguageChanged -= LanguageService_OnLanguageChanged;
        }
    }
}
