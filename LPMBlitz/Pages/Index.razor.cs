using LPMBlitz.FG.Components;
using LPMBlitz.FG.Configurations;
using LPMBlitz.FG.Enums;
using LPMBlitz.FG.Models;
using Microsoft.AspNetCore.Components;

namespace LPMBlitz.Pages;

public partial class Index : ComponentBase
{
    [Inject]
    FightingGamesConfiguration FightingGamesConfiguration { get; set; }

    [Inject]
    public AppState AppState { get; set; }

    private ManageSet ManageSet { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        AppState.FormatSelection.Series = FightingGamesConfiguration.GetConfiguration();
        StateHasChanged();
    }

    public void OnSeriesSelect(ChangeEventArgs e) => AppState.FormatSelection.SelectedSeries = (SeriesEnum)Enum.Parse(typeof(SeriesEnum), e.Value.ToString());
    
    public void OnGameSelectedChangeEventArgs(ChangeEventArgs e) => AppState.FormatSelection.SelectedGame = (GamesEnum)Enum.Parse(typeof(GamesEnum), e.Value.ToString());
    
    public void OnFormatSelected(ChangeEventArgs e) => AppState.FormatSelection.SelectedFormat = (FormatsEnum)Enum.Parse(typeof(FormatsEnum), e.Value.ToString());
    
    public void OnSubmitSetClick()
    {
        if (AppState.FormatSelection.SelectedSeries == null) return;
        if (AppState.FormatSelection.SelectedGame == null) return;
        if (AppState.FormatSelection.SelectedFormat == null) return;

        ManageSet.SubmitSet();
    }
}