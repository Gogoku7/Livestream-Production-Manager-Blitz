using LPMBlitz.FG.Models.Formats.Singles;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPMBlitz.FG.Components.QueuForms
{
    public partial class ManageSinglesQueuSet : ComponentBase
    {
        [Parameter]
        public SinglesQueuModel SinglesQueuSet { get; set; }
        [Parameter]
        public int Index { get; set; }
        [Parameter]
        public bool ShowMoveDownButton { get; set; }

        public void Import()
        {

        }
    }
}