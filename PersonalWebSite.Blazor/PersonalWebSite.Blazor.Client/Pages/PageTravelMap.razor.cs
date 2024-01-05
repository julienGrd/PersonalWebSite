using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace PersonalWebSite.Blazor.Client.Pages
{
    public partial class PageTravelMap
    {
        [Inject]
        public IJSRuntime JsRuntime { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await this.JsRuntime.InvokeVoidAsync("initSvg", "#travel-map-svg");
            }
            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
