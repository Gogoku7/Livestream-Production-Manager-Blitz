using LPMBlitz.FG.Configurations;
using LPMBlitz.FG.Enums;
using LPMBlitz.FG.Models;
using Microsoft.AspNetCore.Components;

namespace LPMBlitz.FG.Components
{
    public partial class ManageSet : ComponentBase
    {
        [Parameter]
        public FormatSelection FormatSelection { get; set; }
        [Parameter]
        public TournamentInfo TournamentInfo { get; set; }
    }
}