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
        public void SubmitEntireQueu()
        {
            if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Singles)
                FightingGamesSetQueuDataService.SaveSinglesSetQueu(AppState.TournamentInfo, AppState.SinglesQueu, AppState.FormatSelection);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Doubles)
                FightingGamesSetQueuDataService.SaveDoublesSetQueu(AppState.TournamentInfo, AppState.DoublesQueu, AppState.FormatSelection);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.ClassicCrew)
                FightingGamesSetQueuDataService.SaveCrewsClassicSetQueu(AppState.TournamentInfo, AppState.CrewsClassicQueu, AppState.FormatSelection);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.SmashCrew)
                FightingGamesSetQueuDataService.SaveCrewsSmashSetQueu(AppState.TournamentInfo, AppState.CrewsSmashQueu, AppState.FormatSelection);
        }

        public void ExportSet(int index)
        {
            if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Singles)
                AppState.Singles = AppState.SinglesQueu[index].Singles;
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Doubles)
                AppState.Doubles = AppState.DoublesQueu[index].Doubles;
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.ClassicCrew)
                AppState.CrewsClassic = AppState.CrewsClassicQueu[index].CrewsClassic;
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.SmashCrew)
                AppState.CrewsSmash = AppState.CrewsSmashQueu[index].CrewsSmash;

            AppState.NotifyExportQueuSet();
            StateHasChanged();
        }

        public void SubmitSet(int index)
        {
            if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Singles)
                FightingGamesSetQueuDataService.SaveSinglesNextSet(AppState.TournamentInfo, AppState.SinglesQueu[index], AppState.FormatSelection);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.Doubles)
                FightingGamesSetQueuDataService.SaveDoublesNextSet(AppState.TournamentInfo, AppState.DoublesQueu[index], AppState.FormatSelection);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.ClassicCrew)
                FightingGamesSetQueuDataService.SaveCrewsClassicNextSet(AppState.TournamentInfo, AppState.CrewsClassicQueu[index], AppState.FormatSelection);
            else if (AppState.FormatSelection.SelectedFormat == FormatsEnum.SmashCrew)
                FightingGamesSetQueuDataService.SaveCrewsSmashNextSet(AppState.TournamentInfo, AppState.CrewsSmashQueu[index], AppState.FormatSelection);
        }

        public void RemoveSet(int index)
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

        public void MoveSetUp(int index)
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

        public void MoveSetDown(int index)
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