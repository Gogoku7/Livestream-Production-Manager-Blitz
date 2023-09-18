namespace LPMBlitz.FG.Models
{
    public class QueuModel
    {
        public TournamentInfo TournamentInfo { get; set; } = new();
        public DateTimeOffset SetStartTime { get; set; } = DateTimeOffset.Now.Date;
        public string SetStartMoment { get; set; }
    }
}