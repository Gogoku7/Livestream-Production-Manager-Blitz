using LPMBlitz.FG.Enums;

namespace LPMBlitz.FG.Models;

public class FormatSelection
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

        }
    }

    private FormatsEnum? _selectedFormat;
    public FormatsEnum? SelectedFormat
    {
        get => _selectedFormat;
        set => _selectedFormat = value;
    }

    public List<SeriesModel> Series;
    public List<GameModel> Games;
    public List<FormatModel> Formats;
}