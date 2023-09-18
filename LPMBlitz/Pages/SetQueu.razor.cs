using LPMBlitz.FG.Components;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPMBlitz.Pages
{
    public partial class SetQueu : ComponentBase
    {
        private ManageSetQueu ManageSetQueu { get; set; }

        public void OnSubmitEntireQueuClick()
        {

        }

        public void OnSubmitSetClick()
        {
            //CommentatorsDataService.SaveCommentators(_commentators);
        }

        public void OnGenerateTop8ButtonClick()
        {
            //Future feature.
        }

        public void OnAddButtonClick()
        {
            ManageSetQueu.AddSetToQueu();
            StateHasChanged();
        }

        public void OnRemoveButtonClick(int index)
        {
            //_commentators.RemoveAt(index);
            StateHasChanged();
        }

        public void OnMoveUpButtonClick(int index)
        {
            //_commentators.Reverse(index - 1, 2);
            StateHasChanged();
        }

        public void OnMoveDownButtonClick(int index)
        {
            //_commentators.Reverse(index, 2);
            StateHasChanged();
        }
    }
}
