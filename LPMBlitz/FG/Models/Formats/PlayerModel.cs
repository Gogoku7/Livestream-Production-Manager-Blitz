using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPMBlitz.FG.Models.Formats;

public class PlayerModel
{
    public string Name { get; set; }
    public string Sponsor { get; set; }

    public string RealName { get; set; }
    public string Twitter { get; set; }
    public string Twitch { get; set; }
    public int Score { get; set; }

    public BaseCharacterModel Character { get; set; }
}