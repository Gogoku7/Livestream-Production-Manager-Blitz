using LPMBlitz.FG.Components;
using Microsoft.AspNetCore.Components;

namespace LPMBlitz.Pages
{
    public partial class SetQueu : ComponentBase
    {
        private ManageSetQueu ManageSetQueu { get; set; }

        private async Task OnSubmitEntireQueuClick()
        {
            await ManageSetQueu.SubmitEntireQueu();
        }

        private async Task OnSubmitSetClick()
        {
            //CommentatorsDataService.SaveCommentators(_commentators);
        }

        private async Task OnGenerateTop8ButtonClick()
        {
            throw new NotImplementedException();
            //Future feature.
        }

        private async Task OnAddButtonClick()
        {
            await ManageSetQueu.AddSetToQueu();
            StateHasChanged();
        }

        private async Task OnRemoveButtonClick(int index)
        {
            //_commentators.RemoveAt(index);
            StateHasChanged();
        }

        private async Task OnMoveUpButtonClick(int index)
        {
            //_commentators.Reverse(index - 1, 2);
            StateHasChanged();
        }

        private async Task OnMoveDownButtonClick(int index)
        {
            //_commentators.Reverse(index, 2);
            StateHasChanged();
        }
    }
}
