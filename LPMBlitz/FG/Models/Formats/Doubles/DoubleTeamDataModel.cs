namespace LPMBlitz.FG.Models.Formats.Doubles;

public class DoubleTeamDataModel
{
    public PlayerDataModel Player1 { get; set; }
    public PlayerDataModel Player2 { get; set; }
    public int Score { get; set; }

    public DoubleTeamDataModel(DoubleTeamModel doubleTeamModel)
    {
        Player1 = new(doubleTeamModel.Player1);
        Player2 = new(doubleTeamModel.Player2);
        Score = doubleTeamModel.Score;
    }
}