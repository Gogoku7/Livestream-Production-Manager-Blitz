namespace LPMBlitz.FG.Models.Formats.Doubles;

public class DoublesDataModel : TournamentInfoDataModel
{
    public int Game => Team1.Score + Team2.Score + 1;

    public DoubleTeamDataModel Team1 { get; set; }
    public DoubleTeamDataModel Team2 { get; set; }

    public DoublesDataModel(TournamentInfo tournamentInfo, DoublesModel doubles)
    {
        Tournament = tournamentInfo.Tournament;
        Phase = tournamentInfo.Phase;
        Round = tournamentInfo.Round;
        BestOfOrFirstTo = tournamentInfo.BestOf;

        Team1 = new(doubles.Team1);
        Team2 = new(doubles.Team2);
    }
}
