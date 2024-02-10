using LPMBlitz.FG.Models.Formats.Singles;
using Microsoft.AspNetCore.Components;

namespace LPMBlitz.FG.Components.QueuForms
{
    public partial class ManageSinglesQueuSet : ComponentBase
    {
        [Parameter]
        public SinglesQueuModel SinglesQueuSet { get; set; }
        [Parameter]
        public int Index { get; set; }
        [Parameter]
        public bool ShowMoveDownButton { get; set; }

        [Parameter]
        public EventCallback<int> ExportSet { get; set; }
        [Parameter]
        public EventCallback<int> SubmitSet { get; set; }
        [Parameter]
        public EventCallback<int> RemoveSet { get; set; }
        [Parameter]
        public EventCallback<int> MoveSetUp { get; set; }
        [Parameter]
        public EventCallback<int> MoveSetDown { get; set; }

        public async Task OnExportSetClick()
        {
            await ExportSet.InvokeAsync(Index);
        }

        public async Task OnSubmitSetClick()
        {
            await SubmitSet.InvokeAsync(Index);
        }

        public async Task OnRemoveSetButtonClick()
        {
            await RemoveSet.InvokeAsync(Index);
        }

        public async Task OnMoveSetUpButtonClick()
        {
            await MoveSetUp.InvokeAsync(Index);
        }

        public async Task OnMoveSetDownButtonClick()
        {
            await MoveSetDown.InvokeAsync(Index);
        }
    }
}