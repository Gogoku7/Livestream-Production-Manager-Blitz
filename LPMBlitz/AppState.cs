using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LPMBlitz.FG.Configurations;
using LPMBlitz.FG.Enums;

namespace LPMBlitz;

public class AppState :IDisposable
{
	public FightingGamesConfiguration FightingGamesFormatConfiguration { get; set; }

	public event Action? OnChange;
	public event Action<string>? OnPropertyChange;
	//public event Action<DataSavedEventArgs>? OnDataSubmitted;
	//private Location? location;
	//private Department? department;
	//private ObservableCollection<Api.Message> messages;
	//private string? pageTitle;

	private SeriesEnum? selectedSeries;
	public SeriesEnum? SelectedSeries
	{
		get => selectedSeries;
		set
		{
			selectedSeries = value;
			//NotifyStateChanged();
		}
	}

	private GamesEnum? selectedGame;
	public GamesEnum? SelectedGame
	{
		get => selectedGame;
		set
		{
			selectedGame = value;
			//NotifyStateChanged();
		}
	}

	private FormatsEnum? selectedFormat;
	public FormatsEnum? SelectedFormat
	{
		get => SelectedFormat;
		set
		{
			SelectedFormat = value;
			//NotifyStateChanged();
		}
	}

	public AppState()
	{
		//messages = new ObservableCollection<Api.Message>();
		//messages.CollectionChanged += OnCollectionChanged;
	}

	//public void NotifyDataSubmitted(string entityName, bool success) => OnDataSubmitted?.Invoke(new DataSavedEventArgs(entityName, success));
	private void NotifyStateChanged() => OnChange?.Invoke();
	private void NotifyPropertyChanged(string propertyName) => OnPropertyChange?.Invoke(propertyName);
	private void OnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
	{
		NotifyStateChanged();
	}

	public void Dispose()
	{
	}
}
