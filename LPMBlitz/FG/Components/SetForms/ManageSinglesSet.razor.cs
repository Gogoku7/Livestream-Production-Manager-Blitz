using LPMBlitz.FG.Models.Formats.Singles;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPMBlitz.FG.Components.SetForms
{
    public partial class ManageSinglesSet : ComponentBase
    {
        [Parameter]
        public SinglesModel Singles { get; set; }
    }
}