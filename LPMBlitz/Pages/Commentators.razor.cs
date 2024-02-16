using LPMBlitz.FG.Models;
using LPMBlitz.Services;
using Microsoft.AspNetCore.Components;

namespace LPMBlitz.Pages
{
    public partial class Commentators : ComponentBase
    {
        [Inject]
        private CommentatorsDataService CommentatorsDataService { get; set; }
        private readonly List<CommentatorModel> _commentators = new() { new CommentatorModel() };

        private string CalculateDeleteButtonColOffset => _commentators.Count == 1 
            ? "col-4 offset-8 col-lg-3 offset-lg-6 col-xxl-2 offset-xxl-4"
            : "col-4 offset-4 col-lg-3 offset-lg-3 col-xxl-2 offset-xxl-2";

        private async Task OnSubmitCommentatorsClick()
        {
            await CommentatorsDataService.SaveCommentators(_commentators);
        }

        private async Task OnAddButtonClick()
        {
            _commentators.Add(new CommentatorModel());
            StateHasChanged();
        }

        private async Task OnRemoveButtonClick(int index)
        {
            _commentators.RemoveAt(index);
            StateHasChanged();
        }

        private async Task OnMoveUpButtonClick(int index)
        {
            _commentators.Reverse(index - 1, 2);
            StateHasChanged();
        }

        private async Task OnMoveDownButtonClick(int index)
        {
            _commentators.Reverse(index, 2);
            StateHasChanged();
        }
    }
}