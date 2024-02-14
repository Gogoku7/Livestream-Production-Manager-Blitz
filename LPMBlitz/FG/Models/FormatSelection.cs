using LPMBlitz.FG.Enums;
using System.ComponentModel;

namespace LPMBlitz.FG.Models;

public class FormatSelection : INotifyPropertyChanged
{
    private SeriesEnum? _selectedSeries;
    public SeriesEnum? SelectedSeries
    {
        get => _selectedSeries;
        set
        {
            _selectedSeries = value;
            SelectedGame = null;
            SelectedFormat = null;
            Games = Series.First(s => s.Series == SelectedSeries).Games;
            Formats = null;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedSeries)));
        }
    }



    private GamesEnum? _selectedGame;
    public GamesEnum? SelectedGame
    {
        get => _selectedGame;
        set
        {
            _selectedGame = value;
            if (_selectedGame != null)
            {
                SelectedFormat = null;
                Formats = Games.First(g => g.Game == SelectedGame).Formats;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedGame)));
        }
    }

    private FormatsEnum? _selectedFormat;
    public FormatsEnum? SelectedFormat
    {
        get => _selectedFormat;
        set
        {
            _selectedFormat = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedFormat)));
        }
    }

    public List<SeriesModel> Series;
    public List<GameModel> Games;
    public List<FormatModel> Formats;

    public event PropertyChangedEventHandler PropertyChanged;
}