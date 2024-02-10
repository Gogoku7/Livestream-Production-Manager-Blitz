using LPMBlitz.FG.Components;
using LPMBlitz.FG.Configurations;
using LPMBlitz.FG.Enums;
using Microsoft.AspNetCore.Components;

namespace LPMBlitz.Pages;

public partial class Index : ComponentBase
{
    [Inject]
    FightingGamesConfiguration FightingGamesConfiguration { get; set; }

    [Inject]
    public AppState AppState { get; set; }

    private ManageSet ManageSet { get; set; }

    //protected async override Task OnInitializedAsync()
    protected override void OnInitialized()
    {
        //await base.OnInitializedAsync();
        base.OnInitialized();
        AppState.FormatSelection.Series = FightingGamesConfiguration.GetConfiguration();
        StateHasChanged();
    }

    // public async Task OnSeriesSelect
    public void OnSeriesSelect(ChangeEventArgs e) => AppState.FormatSelection.SelectedSeries = (SeriesEnum)Enum.Parse(typeof(SeriesEnum), e.Value.ToString());

    //public async Task OnGameSelectedChangeEventArgs
    public void OnGameSelectedChangeEventArgs(ChangeEventArgs e) => AppState.FormatSelection.SelectedGame = (GamesEnum)Enum.Parse(typeof(GamesEnum), e.Value.ToString());

    //public async Task OnFormatSelected()
    public void OnFormatSelected(ChangeEventArgs e) => AppState.FormatSelection.SelectedFormat = (FormatsEnum)Enum.Parse(typeof(FormatsEnum), e.Value.ToString());
    
    private async Task OnSubmitSetClick()
    {
        if (AppState.FormatSelection.SelectedSeries == null || 
            AppState.FormatSelection.SelectedGame == null || 
            AppState.FormatSelection.SelectedFormat == null) return;
        
        await ManageSet.SubmitSet();
    }
}