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

        [Parameter]
        public FormatSelection FormatSelection { get; set; }
        [Parameter]
        public TournamentInfo TournamentInfo { get; set; }

        private SinglesModel Singles = new SinglesModel();
        private DoublesModel Doubles = new DoublesModel();
        private CrewsClassicModel CrewsClassic = new CrewsClassicModel();
        private CrewsSmashModel CrewsSmash = new CrewsSmashModel();

        public void SubmitSet()
        {
            var formatFolderPath = FightingGamesDataService.GetFormatFolderPath(FormatSelection);
            if (FormatSelection.SelectedFormat == FormatsEnum.Singles)
            {
                FightingGamesDataService.SaveSingles(TournamentInfo, Singles, formatFolderPath);
            }
            else if (FormatSelection.SelectedFormat == FormatsEnum.Doubles)
            {
                FightingGamesDataService.SaveDoubles(TournamentInfo, Doubles, formatFolderPath);

            }
            else if (FormatSelection.SelectedFormat == FormatsEnum.ClassicCrew)
            {
                FightingGamesDataService.SaveCrewsClassic(TournamentInfo, CrewsClassic, formatFolderPath);
            }
            else if (FormatSelection.SelectedFormat == FormatsEnum.SmashCrew)
            {
                FightingGamesDataService.SaveCrewsSmash(TournamentInfo, CrewsSmash, formatFolderPath);
            }
        }
    }
}