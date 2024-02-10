using LPMBlitz.FG.Models.Formats.Doubles;
using Microsoft.AspNetCore.Components;

namespace LPMBlitz.FG.Components.QueuForms
{
    public partial class ManageDoublesQueuSet : ComponentBase
    {
        [Parameter]
        public DoublesQueuModel DoublesQueuSet { get; set; }
        [Parameter]
        public int Index { get; set; }
        [Parameter]
        public bool ShowMoveDownButton { get; set; }

        [Parameter]
        public EventCallback ExportSet { get; set; }
        [Parameter]
        public EventCallback SubmitSet { get; set; }
        [Parameter]
        public EventCallback RemoveSet { get; set; }
        [Parameter]
        public EventCallback MoveSetUp { get; set; }
        [Parameter]
        public EventCallback MoveSetDown { get; set; }

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