using System.ComponentModel;
using LPMBlitz.FG.Models;
using LPMBlitz.FG.Models.Formats.CrewsClassic;
using LPMBlitz.FG.Models.Formats.CrewsSmash;
using LPMBlitz.FG.Models.Formats.Doubles;
using LPMBlitz.FG.Models.Formats.Singles;

namespace LPMBlitz;

public class AppState : IDisposable
{
    public event EventHandler<EventArgs> OnChangeformatSelectionEvent;
    public event EventHandler<EventArgs> OnExportQueuSetEvent;

    public TournamentInfo TournamentInfo { get; set; } = new();
    public FormatSelection FormatSelection { get; set; }

    //Set
    public SinglesModel Singles { get; set; } = new();
    public DoublesModel Doubles { get; set; } = new();
    public CrewsClassicModel CrewsClassic { get; set; } = new();
    public CrewsSmashModel CrewsSmash { get; set; } = new();

    //Queu
    public List<SinglesQueuModel> SinglesQueu { get; set; } = new();
    public List<DoublesQueuModel> DoublesQueu { get; set; } = new();
    public List<CrewsClassicQueuModel> CrewsClassicQueu { get; set; } = new();
    public List<CrewsSmashQueuModel> CrewsSmashQueu { get; set; } = new();

    public AppState()
    {
        FormatSelection = new();
        FormatSelection.PropertyChanged += OnFormatSelectionChange;
    }

    public async Task NotifyExportQueuSet() => 
        OnExportQueuSetEvent?.Invoke(this, EventArgs.Empty);

    private async void OnFormatSelectionChange(object? sender, PropertyChangedEventArgs e) => 
        OnChangeformatSelectionEvent?.Invoke(this, EventArgs.Empty);
    
    public void Dispose()
    {
    }
}