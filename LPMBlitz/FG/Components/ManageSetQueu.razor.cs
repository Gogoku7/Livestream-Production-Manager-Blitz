using LPMBlitz.FG.Enums;
using LPMBlitz.Services;
using Microsoft.AspNetCore.Components;

namespace LPMBlitz.FG.Components
{
    public partial class ManageSetQueu : ComponentBase
    {
        [Inject]
        private FightingGamesDataService FightingGamesDataService { get; set; }
        [Inject]
        private FightingGamesSetQueuDataService FightingGamesSetQueuDataService { get; set; }

        [Inject]
        private AppState AppState { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            AppState.OnChangeformatSelectionEvent += FormatSelectionChanged;

            StateHasChanged();
        }

        private async void FormatSelectionChanged(object sender, EventArgs e) => 
            StateHasChanged();

        public async Task AddSetToQueu()
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

        public async Task SubmitEntireQueu()
        {
            if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Singles)
                await FightingGamesSetQueuDataService.SaveSinglesSetQueu(AppState.TournamentInfo, AppState.SinglesQueu, AppState.FormatSelection);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Doubles)
                await FightingGamesSetQueuDataService.SaveDoublesSetQueu(AppState.TournamentInfo, AppState.DoublesQueu, AppState.FormatSelection);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.ClassicCrew)
                await FightingGamesSetQueuDataService.SaveCrewsClassicSetQueu(AppState.TournamentInfo, AppState.CrewsClassicQueu, AppState.FormatSelection);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.SmashCrew)
                await FightingGamesSetQueuDataService.SaveCrewsSmashSetQueu(AppState.TournamentInfo, AppState.CrewsSmashQueu, AppState.FormatSelection);
        }

        private async Task ExportSet(int index)
        {
            if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Singles)
                AppState.Singles = AppState.SinglesQueu[index].Singles;
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Doubles)
                AppState.Doubles = AppState.DoublesQueu[index].Doubles;
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.ClassicCrew)
                AppState.CrewsClassic = AppState.CrewsClassicQueu[index].CrewsClassic;
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.SmashCrew)
                AppState.CrewsSmash = AppState.CrewsSmashQueu[index].CrewsSmash;

            await AppState.NotifyExportQueuSet();
            StateHasChanged();
        }

        private async Task SubmitSet(int index)
        {
            if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Singles)
                await FightingGamesSetQueuDataService.SaveSinglesNextSet(AppState.TournamentInfo, AppState.SinglesQueu[index], AppState.FormatSelection);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Doubles)
                await FightingGamesSetQueuDataService.SaveDoublesNextSet(AppState.TournamentInfo, AppState.DoublesQueu[index], AppState.FormatSelection);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.ClassicCrew)
                await FightingGamesSetQueuDataService.SaveCrewsClassicNextSet(AppState.TournamentInfo, AppState.CrewsClassicQueu[index], AppState.FormatSelection);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.SmashCrew)
                await FightingGamesSetQueuDataService.SaveCrewsSmashNextSet(AppState.TournamentInfo, AppState.CrewsSmashQueu[index], AppState.FormatSelection);

            StateHasChanged();
        }

        private async Task RemoveSet(int index)
        {
            if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Singles)
                AppState.SinglesQueu.RemoveAt(index);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Doubles)
                AppState.DoublesQueu.RemoveAt(index);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.ClassicCrew)
                AppState.CrewsClassicQueu.RemoveAt(index);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.SmashCrew)
                AppState.CrewsSmashQueu.RemoveAt(index);

            StateHasChanged();
        }

        private async Task MoveSetUp(int index)
        {
            if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Singles)
                AppState.SinglesQueu.Reverse(index - 1, 2);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Doubles)
                AppState.DoublesQueu.Reverse(index - 1, 2);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.ClassicCrew)
                AppState.CrewsClassicQueu.Reverse(index - 1, 2);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.SmashCrew)
                AppState.CrewsSmashQueu.Reverse(index - 1, 2);

            StateHasChanged();
        }

        private async Task MoveSetDown(int index)
        {
            if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Singles)
                AppState.SinglesQueu.Reverse(index, 2);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Doubles)
                AppState.DoublesQueu.Reverse(index, 2);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.ClassicCrew)
                AppState.CrewsClassicQueu.Reverse(index, 2);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.SmashCrew)
                AppState.CrewsSmashQueu.Reverse(index, 2);

            StateHasChanged();
        }
    }
}