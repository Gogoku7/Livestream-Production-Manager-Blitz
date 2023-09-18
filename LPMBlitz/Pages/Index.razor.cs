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

    private ManageSet ManageSet { get; set; }

    private readonly FormatSelection FormatSelection = new();
    private readonly TournamentInfo TournamentInfo = new();

    protected override void OnInitialized()
    {
        base.OnInitialized();
        FormatSelection.Series = FightingGamesConfiguration.GetConfiguration();
        StateHasChanged();
    }

    public void OnSeriesSelect(ChangeEventArgs e)
    {
        FormatSelection.SelectedSeries = (SeriesEnum) Enum.Parse(typeof(SeriesEnum), e.Value.ToString());
        StateHasChanged();
    }

    public void OnGameSelectedChangeEventArgs(ChangeEventArgs e)
    {
        FormatSelection.SelectedGame = (GamesEnum) Enum.Parse(typeof(GamesEnum), e.Value.ToString());
        StateHasChanged();
    }

    public void OnFormatSelected(ChangeEventArgs e)
    {
        FormatSelection.SelectedFormat = (FormatsEnum) Enum.Parse(typeof(FormatsEnum), e.Value.ToString());



        StateHasChanged();
    }

    public void OnSubmitSetClick()
    {
        if (FormatSelection.SelectedSeries == null) return;
        if (FormatSelection.SelectedGame == null) return;
        if (FormatSelection.SelectedFormat == null) return;

        ManageSet.SubmitSet();
    }
}