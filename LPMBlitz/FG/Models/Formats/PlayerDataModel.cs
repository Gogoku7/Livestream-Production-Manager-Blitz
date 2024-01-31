using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LPMBlitz.FG.Models.Formats
{
    public class PlayerDataModel
    {

        public string FullName { get; set; } // $"{(string.IsNullOrWhiteSpace(Sponsor) ? "" : $"{Sponsor} ")}{Name}"
        public string FullNameWithSeparator { get; set; } //$"{(string.IsNullOrWhiteSpace(Sponsor) ? "" : $"{Sponsor} | ")}{Name}"
    }
}
