using System.ComponentModel;
using LPMBlitz.FG.Models;
using LPMBlitz.FG.Models.Formats.CrewsClassic;
using LPMBlitz.FG.Models.Formats.CrewsSmash;
using LPMBlitz.FG.Models.Formats.Doubles;
using LPMBlitz.FG.Models.Formats.Singles;
using Microsoft.AspNetCore.Components;

namespace LPMBlitz;

public class AppState : IDisposable
{
    public EventCallback OnChangeFormatSelection;
    public EventCallback OnExportQueuSet;

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

    private async Task NotifyFormatSelectionHasChanged() => await OnChangeFormatSelection.InvokeAsync();
    public async Task NotifyExportQueuSet() => await OnExportQueuSet.InvokeAsync();

    private async void OnFormatSelectionChange(object? sender, PropertyChangedEventArgs e)
    {
        await NotifyFormatSelectionHasChanged();
    }

    public void Dispose()
    {
    }
}
