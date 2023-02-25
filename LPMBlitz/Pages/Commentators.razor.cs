using LPMBlitz.FG.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPMBlitz.Pages
{
    public partial class Commentators : ComponentBase
    {
        private List<CommentatorModel> _commentators = new() { new CommentatorModel() };
    }
}