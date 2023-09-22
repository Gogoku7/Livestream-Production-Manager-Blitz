using LPMBlitz.FG.Models.Formats.CrewsSmash;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPMBlitz.FG.Components.QueuForms
{
    public partial class ManageCrewsSmashQueuSet : ComponentBase
    {
        [Parameter]
        public CrewsSmashQueuModel CrewsSmashQueuSet { get; set; }
        [Parameter]
        public int Index { get; set; }
        [Parameter]
        public bool ShowMoveDownButton { get; set; }

        [Parameter]
        public Action<int>? ExportSet { get; set; }
        [Parameter]
        public Action<int>? SubmitSet { get; set; }
        [Parameter]
        public Action<int>? RemoveSet { get; set; }
        [Parameter]
        public Action<int>? MoveSetUp { get; set; }
        [Parameter]
        public Action<int>? MoveSetDown { get; set; }

        public void OnExportSetClick()
        {
            ExportSet?.Invoke(Index);
        }

        public void OnSubmitSetClick()
        {
            SubmitSet?.Invoke(Index);
        }

        public void OnRemoveSetButtonClick()
        {
            RemoveSet?.Invoke(Index);
        }

        public void OnMoveSetUpButtonClick()
        {
            MoveSetUp?.Invoke(Index);
        }

        public void OnMoveSetDownButtonClick()
        {
            MoveSetDown?.Invoke(Index);
        }
    }
}