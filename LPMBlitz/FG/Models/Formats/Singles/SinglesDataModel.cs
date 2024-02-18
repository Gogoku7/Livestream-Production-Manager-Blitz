namespace LPMBlitz.FG.Models.Formats.Singles;

public class SinglesDataModel : TournamentInfoDataModel
{
    public int Game => Player1.Score + Player2.Score + 1;

    public PlayerDataModel Player1 { get; set; }
    public PlayerDataModel Player2 { get; set; }

    public SinglesDataModel(TournamentInfo tournamentInfo, SinglesModel singles)
    {
        Tournament = tournamentInfo.Tournament;
        Phase = tournamentInfo.Phase;
        Round = tournamentInfo.Round;
        BestOfOrFirstTo = tournamentInfo.BestOf;

        Player1 = new(singles.Player1);
        Player2 = new(singles.Player2);
    }
}