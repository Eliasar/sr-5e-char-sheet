using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using JsonModels.Sheet;

namespace src.Pages
{
    public partial class Slider : ComponentBase
    {
        [Parameter]
        public DamageTrack DamageTrack { get; set; }

        [Parameter]
        public EventCallback<DamageTrack> OnDamageTrackChanged { get; set; }

        [Parameter]
        public string Id { get; set; }

        private DotNetObjectReference<Slider> objRef;
        private bool NeedsRefresh = true;

        [Inject]
        private IJSRuntime JS { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender || !NeedsRefresh) return;

            // If the slider exists, don't build
            if (DamageTrack.Total > 0)
            {
                objRef = DotNetObjectReference.Create(this);

                await JS.InvokeVoidAsync("sliderFunctions.createSlider", $"#{Id}", objRef);

                NeedsRefresh = false;
            }
        }

        [JSInvokable]
        public void UpdateDamageTrackValue(int value)
        {
            DamageTrack.Current = value;
            OnDamageTrackChanged.InvokeAsync(DamageTrack);
        }
    }
}