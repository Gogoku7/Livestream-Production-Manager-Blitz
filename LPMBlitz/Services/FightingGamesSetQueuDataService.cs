using LPMBlitz.FG.Models;
using LPMBlitz.FG.Models.Formats.CrewsClassic;
using LPMBlitz.FG.Models.Formats.CrewsSmash;
using LPMBlitz.FG.Models.Formats.Doubles;
using LPMBlitz.FG.Models.Formats.Singles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LPMBlitz.Services;

public class FightingGamesSetQueuDataService
{
    private const string _fightingGamesFolder = "FightingGames";
    private const string _jsonFolder = "JSON";
    private const string _jsonNextSetFileName = "NextSetContent.json";
    private const string _jsonSetQueuFileName = "SetQueuContent.json";
    private const string _cssFolder = "CSS";
    private const string _cssNextSetFileName = "NextSetContent.css";
    private const string _cssSetQueuFileName = "SetQueuContent.css";
    private readonly JsonSerializerOptions jsonSerializerOptions = new() { WriteIndented = true };

    public async Task SaveSinglesNextSet(TournamentInfo tournamentInfo, SinglesQueuModel singles, FormatSelection formatSelection)
    {
        try
        {
            var jsonFolderPath = Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder);
            Directory.CreateDirectory(jsonFolderPath);
            await File.WriteAllTextAsync(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(singles, jsonSerializerOptions));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task SaveSinglesSetQueu(TournamentInfo tournamentInfo, List<SinglesQueuModel> singlesSets, FormatSelection formatSelection)
    {
        try
        {
            var jsonFolderPath = Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder);
            Directory.CreateDirectory(jsonFolderPath);
            await File.WriteAllTextAsync(Path.Combine(jsonFolderPath, _jsonSetQueuFileName), JsonSerializer.Serialize(singlesSets, jsonSerializerOptions));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task SaveDoublesNextSet(TournamentInfo tournamentInfo, DoublesQueuModel doubles, FormatSelection formatSelection)
    {
        try
        {
            var jsonFolderPath = Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder);
            Directory.CreateDirectory(jsonFolderPath);
            await File.WriteAllTextAsync(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(doubles));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task SaveDoublesSetQueu(TournamentInfo tournamentInfo, List<DoublesQueuModel> doublesSets, FormatSelection formatSelection)
    {
        try
        {
            var jsonFolderPath = Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder);
            Directory.CreateDirectory(jsonFolderPath);
            await File.WriteAllTextAsync(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(doublesSets));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task SaveCrewsClassicNextSet(TournamentInfo tournamentInfo, CrewsClassicQueuModel crewsClassic, FormatSelection formatSelection)
    {
        try
        {
            var jsonFolderPath = Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder);
            await File.WriteAllTextAsync(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(crewsClassic));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task SaveCrewsClassicSetQueu(TournamentInfo tournamentInfo, List<CrewsClassicQueuModel> crewsClassicSets, FormatSelection formatSelection)
    {
        try
        {
            var jsonFolderPath = Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder);
            Directory.CreateDirectory(jsonFolderPath);
            await File.WriteAllTextAsync(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(crewsClassicSets));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task SaveCrewsSmashNextSet(TournamentInfo tournamentInfo, CrewsSmashQueuModel crewsSmash, FormatSelection formatSelection)
    {
        try
        {
            var jsonFolderPath = Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder);
            Directory.CreateDirectory(jsonFolderPath);
            await File.WriteAllTextAsync(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(crewsSmash));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task SaveCrewsSmashSetQueu(TournamentInfo tournamentInfo, List<CrewsSmashQueuModel> crewsSmashSets, FormatSelection formatSelection)
    {
        try
        {
            var jsonFolderPath = Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder);
            Directory.CreateDirectory(jsonFolderPath);
            await File.WriteAllTextAsync(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(crewsSmashSets));
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    private string GetFormatFolderPath(FormatSelection formatSelection)
    {
        return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _fightingGamesFolder, formatSelection.SelectedGame.ToString(), formatSelection.SelectedFormat.ToString());
        //TODO: Test this
        //return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _fightingGamesFolder, formatSelection.SelectedGame.ToString(), formatSelection.SelectedFormat.ToString(), _jsonFolder);
    }
}