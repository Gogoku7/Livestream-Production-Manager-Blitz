using LPMBlitz.FG.Components.SetForms;
using LPMBlitz.FG.Configurations;
using LPMBlitz.FG.Enums;
using LPMBlitz.FG.Models;
using LPMBlitz.FG.Models.Formats.CrewsClassic;
using LPMBlitz.FG.Models.Formats.CrewsSmash;
using LPMBlitz.FG.Models.Formats.Doubles;
using LPMBlitz.FG.Models.Formats.Singles;
using LPMBlitz.Services;
using Microsoft.AspNetCore.Components;

namespace LPMBlitz.FG.Components
{
    public partial class ManageSet : ComponentBase
    {
        [Inject]
        public FightingGamesDataService FightingGamesDataService { get; set; }

        [Inject]
        public AppState AppState { get; set; }

        protected override void OnInitialized()
        {
            AppState.OnChangeFormatSelection += StateHasChanged;
            base.OnInitialized();
        }

        public void SubmitSet()
        {
            var formatFolderPath = FightingGamesDataService.GetFormatFolderPath(AppState.FormatSelection);
            if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Singles)
            {
                FightingGamesDataService.SaveSingles(AppState.TournamentInfo, AppState.Singles, formatFolderPath);
            }
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Doubles)
            {
                FightingGamesDataService.SaveDoubles(AppState.TournamentInfo, AppState.Doubles, formatFolderPath);

            }
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.ClassicCrew)
            {
                FightingGamesDataService.SaveCrewsClassic(AppState.TournamentInfo, AppState.CrewsClassic, formatFolderPath);
            }
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.SmashCrew)
            {
                FightingGamesDataService.SaveCrewsSmash(AppState.TournamentInfo, AppState.CrewsSmash, formatFolderPath);
            }
        }
    }
}