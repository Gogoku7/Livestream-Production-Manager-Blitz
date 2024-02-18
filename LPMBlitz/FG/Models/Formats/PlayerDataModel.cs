namespace LPMBlitz.FG.Models.Formats;

public class PlayerDataModel : PlayerModel
{
    public string FullName => $"{(string.IsNullOrWhiteSpace(Sponsor) ? string.Empty : $"{Sponsor} ")}{Name}";
    public string FullNameWithSeparator => $"{(string.IsNullOrWhiteSpace(Sponsor) ? string.Empty : $"{Sponsor} | ")}{Name}";

    public PlayerDataModel(PlayerModel player)
    {
        Name = player.Name;
        Sponsor = player.Sponsor;
        RealName = player.RealName;
        Twitter = player.Twitter;
        Twitch = player.Twitch;
        Score = player.Score;
        Character = player.Character;
    }
}
