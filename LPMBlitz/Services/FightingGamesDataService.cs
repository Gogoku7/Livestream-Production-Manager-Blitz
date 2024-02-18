using LPMBlitz.FG.Models;
using LPMBlitz.FG.Models.Formats.CrewsClassic;
using LPMBlitz.FG.Models.Formats.CrewsSmash;
using LPMBlitz.FG.Models.Formats.Doubles;
using LPMBlitz.FG.Models.Formats.Singles;
using System.Text.Json;

namespace LPMBlitz.Services;

public class FightingGamesDataService
{
    private const string _fightingGamesFolder = "FightingGames";
    private const string _jsonFolder = "JSON";
    private const string _jsonFileName = "Content.json";
    private const string _cssFolder = "CSS";
    private const string _cssFileName = "Content.css";
    private readonly JsonSerializerOptions jsonSerializerOptions = new() { WriteIndented = true };

    public async Task SaveSingles(TournamentInfo tournamentInfo, SinglesModel singles, FormatSelection formatSelection)
    {
        try
        {
            var singlesData = new SinglesDataModel(tournamentInfo, singles);
            var jsonFolderPath = GetFormatFolderPathAndCreate(formatSelection, _jsonFolder);
            //var cssFolderPath = GetFormatFolderPathAndCreate(formatSelection, _cssFolder);
            await File.WriteAllTextAsync(Path.Combine(jsonFolderPath, _jsonFileName), JsonSerializer.Serialize(singlesData, jsonSerializerOptions));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task SaveDoubles(TournamentInfo tournamentInfo, DoublesModel doubles, FormatSelection formatSelection)
    {
        try
        {
            var jsonFolderPath = GetFormatFolderPathAndCreate(formatSelection, _jsonFolder);
            //var cssFolderPath = GetFormatFolderPathAndCreate(formatSelection, _cssFolder);
            await File.WriteAllTextAsync(Path.Combine(jsonFolderPath, _jsonFileName), JsonSerializer.Serialize(doubles));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task SaveCrewsClassic(TournamentInfo tournamentInfo, CrewsClassicModel crewsClassic, FormatSelection formatSelection)
    {
        try
        {
            var jsonFolderPath = GetFormatFolderPathAndCreate(formatSelection, _jsonFolder);
            //var cssFolderPath = GetFormatFolderPathAndCreate(formatSelection, _cssFolder);
            await File.WriteAllTextAsync(Path.Combine(jsonFolderPath, _jsonFileName), JsonSerializer.Serialize(crewsClassic));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task SaveCrewsSmash(TournamentInfo tournamentInfo, CrewsSmashModel crewsSmash, FormatSelection formatSelection)
    {
        try
        {
            var jsonFolderPath = GetFormatFolderPathAndCreate(formatSelection, _jsonFolder);
            //var cssFolderPath = GetFormatFolderPathAndCreate(formatSelection, _cssFolder);
            await File.WriteAllTextAsync(Path.Combine(jsonFolderPath, _jsonFileName), JsonSerializer.Serialize(crewsSmash));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task<string> GetLatest(FormatSelection formatSelection)
    {
        try
        {
            return await File.ReadAllTextAsync(Path.Combine(GetFormatFolderPathAndCreate(formatSelection, _jsonFolder), _jsonFileName));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    private string GetFormatFolderPathAndCreate(FormatSelection formatSelection, string folderPath)
    {
        var jsonFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _fightingGamesFolder, formatSelection.SelectedGame.ToString(), formatSelection.SelectedFormat.ToString(), folderPath);
        Directory.CreateDirectory(jsonFolderPath);
        return jsonFolderPath;
    }
}