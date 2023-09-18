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

        public void Import()
        {

        }
    }
}