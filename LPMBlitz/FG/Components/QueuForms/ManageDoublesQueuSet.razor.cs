using LPMBlitz.FG.Models.Formats.Doubles;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPMBlitz.FG.Components.QueuForms
{
    public partial class ManageDoublesQueuSet : ComponentBase
    {
        [Parameter]
        public DoublesQueuModel DoublesQueuSet { get; set; }
        [Parameter]
        public int Index { get; set; }

        public void Import()
        {

        }
    }
}