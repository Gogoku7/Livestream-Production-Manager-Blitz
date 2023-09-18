using LPMBlitz.FG.Models;
using LPMBlitz.Services;
using Microsoft.AspNetCore.Components;

namespace LPMBlitz.Pages
{
    public partial class Commentators : ComponentBase
    {
        [Inject]
        public CommentatorsDataService CommentatorsDataService { get; set; }
        private readonly List<CommentatorModel> _commentators = new() { new CommentatorModel() };

        public void OnSubmitCommentatorsClick()
        {
            CommentatorsDataService.SaveCommentators(_commentators);
        }

        public void OnAddButtonClick()
        {
            _commentators.Add(new CommentatorModel());
            StateHasChanged();
        }

        public void OnRemoveButtonClick(int index)
        {
            _commentators.RemoveAt(index);
            StateHasChanged();
        }

        public void OnMoveUpButtonClick(int index)
        {
            _commentators.Reverse(index - 1, 2);
            StateHasChanged();
        }

        public void OnMoveDownButtonClick(int index)
        {
            _commentators.Reverse(index, 2);
            StateHasChanged();
        }
    }
}