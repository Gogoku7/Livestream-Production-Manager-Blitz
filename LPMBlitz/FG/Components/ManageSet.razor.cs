using LPMBlitz.FG.Enums;
using LPMBlitz.Services;
using Microsoft.AspNetCore.Components;

namespace LPMBlitz.FG.Components
{
    public partial class ManageSet : ComponentBase
    {
        [Inject]
        private FightingGamesDataService FightingGamesDataService { get; set; }

        [Inject]
        private AppState AppState { get; set; }

        //protected async override Task OnInitializedAsync()
        protected override void OnInitialized()
        {
            AppState.OnChangeFormatSelection += StateHasChanged;
            AppState.OnExportQueuSet += StateHasChanged;
            //await base.OnInitializedAsync();
            base.OnInitialized();
        }

        public async Task SubmitSet()
        {
            if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Singles)
                await FightingGamesDataService.SaveSingles(AppState.TournamentInfo, AppState.Singles, AppState.FormatSelection);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Doubles)
                await FightingGamesDataService.SaveDoubles(AppState.TournamentInfo, AppState.Doubles, AppState.FormatSelection);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.ClassicCrew)
                await FightingGamesDataService.SaveCrewsClassic(AppState.TournamentInfo, AppState.CrewsClassic, AppState.FormatSelection);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.SmashCrew)
                await FightingGamesDataService.SaveCrewsSmash(AppState.TournamentInfo, AppState.CrewsSmash, AppState.FormatSelection);
        }
    }
}