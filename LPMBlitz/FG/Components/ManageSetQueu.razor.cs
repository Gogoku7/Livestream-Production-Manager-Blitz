using LPMBlitz.FG.Configurations;
using LPMBlitz.FG.Enums;
using LPMBlitz.FG.Models;
using LPMBlitz.FG.Models.Formats.CrewsClassic;
using LPMBlitz.FG.Models.Formats.CrewsSmash;
using LPMBlitz.FG.Models.Formats.Doubles;
using LPMBlitz.FG.Models.Formats.Singles;
using LPMBlitz.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPMBlitz.FG.Components
{
    public partial class ManageSetQueu : ComponentBase
    {
        [Inject]
        FightingGamesConfiguration FightingGamesConfiguration { get; set; }
        [Inject]
        public FightingGamesDataService FightingGamesDataService { get; set; }
        [Inject]
        public FightingGamesSetQueuDataService FightingGamesSetQueuDataService { get; set; }

        [Inject]
        public AppState AppState { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            AppState.OnChangeFormatSelection += StateHasChanged;
            
            StateHasChanged();
        }

        public void OnSubmitQueuClick()
        {

        }

        public void OnSubmitSetClick()
        {

        }

        public void AddSetToQueu()
        {
            if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Singles)
                AppState.SinglesQueu.Add(new());
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Doubles)
                AppState.DoublesQueu.Add(new());
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.ClassicCrew)
                AppState.CrewsClassicQueu.Add(new());
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.SmashCrew)
                AppState.CrewsSmashQueu.Add(new());

            StateHasChanged();
        }

        public void OnRemoveButtonClick(int index)
        {
            //_commentators.RemoveAt(index);
        }

        public void OnMoveUpButtonClick(int index)
        {
            //_commentators.Reverse(index - 1, 2);
        }

        public void OnMoveDownButtonClick(int index)
        {
            //_commentators.Reverse(index, 2);
        }
    }
}