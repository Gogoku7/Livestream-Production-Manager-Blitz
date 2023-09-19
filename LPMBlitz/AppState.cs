using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPMBlitz.FG.Configurations;
using LPMBlitz.FG.Enums;
using LPMBlitz.FG.Models;
using LPMBlitz.FG.Models.Formats.CrewsClassic;
using LPMBlitz.FG.Models.Formats.CrewsSmash;
using LPMBlitz.FG.Models.Formats.Doubles;
using LPMBlitz.FG.Models.Formats.Singles;

namespace LPMBlitz;

public class AppState : IDisposable
{
    public FightingGamesConfiguration FightingGamesFormatConfiguration { get; set; }

    public event Action? OnChange;
    public event Action? OnChangeFormatSelection;
    public event Action<string>? OnPropertyChange;

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
        FormatSelection = new(NotifyFormatSelectionHasChanged);
    }



    //public void NotifyDataSubmitted(string entityName, bool success) => OnDataSubmitted?.Invoke(new DataSavedEventArgs(entityName, success));
    private void NotifyFormatSelectionHasChanged() => OnChangeFormatSelection?.Invoke();

    private void NotifyPropertyChanged(string propertyName) => OnPropertyChange?.Invoke(propertyName);
    //private void OnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    //{
    //	NotifyStateChanged();
    //}

    public void Dispose()
    {
    }
}
