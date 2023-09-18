using LPMBlitz.FG.Models.Formats.CrewsClassic;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPMBlitz.FG.Components.QueuForms
{
    public partial class ManageCrewsClassicQueuSet : ComponentBase
    {
        [Parameter]
        public CrewsClassicQueuModel CrewsClassicQueuSet { get; set; }

        public void Import()
        {

        }
    }
}