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

        private FormatSelection FormatSelection = new();

        [Parameter]
        public TournamentInfo TournamentInfo { get; set; }

        private List<SinglesQueuModel> SinglesQueu = new();
        private List<DoublesQueuModel> DoublesQueu = new();
        private List<CrewsClassicQueuModel> CrewsClassicQueu = new();
        private List<CrewsSmashQueuModel> CrewsSmashQueu = new();

        protected override void OnInitialized()
        {
            base.OnInitialized();

            FormatSelection.Series = FightingGamesConfiguration.GetConfiguration();

            FormatSelection.SelectedSeries = SeriesEnum.SuperSmashBros;
            FormatSelection.SelectedGame = GamesEnum.SuperSmashBrosUltimate;
            FormatSelection.SelectedFormat = FormatsEnum.Singles;
            
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
            if (FormatSelection.SelectedFormat == FormatsEnum.Singles)
                SinglesQueu.Add(new());
            else if (FormatSelection.SelectedFormat == FormatsEnum.Doubles)
                DoublesQueu.Add(new());
            else if (FormatSelection.SelectedFormat == FormatsEnum.ClassicCrew)
                CrewsClassicQueu.Add(new());
            else if (FormatSelection.SelectedFormat == FormatsEnum.SmashCrew)
                CrewsSmashQueu.Add(new());

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