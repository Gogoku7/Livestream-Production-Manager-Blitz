using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPMBlitz.FG.Models.Formats.Singles;

public class SinglesDataModel
{
    public string BestOfFull { get; set; } //Best of 3
    public string BestOfShort { get; set; } //Bo3
    public string FirstToFull { get; set; } //First to 2
    public string FirstToShort { get; set; } //Ft2

    public string WinnerAdvancesTo { get; set; } // if top 8
    public string LoserAdvancesTo { get; set; } // if top 8

    public int Game { get; set; }
}
