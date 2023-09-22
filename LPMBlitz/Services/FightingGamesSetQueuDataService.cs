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

namespace LPMBlitz.Services
{
    public class FightingGamesSetQueuDataService
    {
        private const string _fightingGamesFolder = "FightingGames";
        private const string _jsonFolder = "JSON";
        private const string _jsonNextSetFileName = "NextSetContent.json";
        private const string _jsonSetQueuFileName = "SetQueuContent.json";
        private const string _cssFolderE = "CSS";
        private const string _cssNextSetFileName = "NextSetContent.css";
        private const string _cssSetQueuFileName = "SetQueuContent.css";
        private readonly JsonSerializerOptions jsonSerializerOptions = new() { WriteIndented = true };

        public void SaveSinglesNextSet(TournamentInfo tournamentInfo, SinglesQueuModel singles, FormatSelection formatSelection)
        {
            try
            {
                var jsonFolderPath = Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(singles, jsonSerializerOptions));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveSinglesSetQueu(TournamentInfo tournamentInfo, List<SinglesQueuModel> singlesSets, FormatSelection formatSelection)
        {
            try
            {
                var jsonFolderPath = Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonSetQueuFileName), JsonSerializer.Serialize(singlesSets, jsonSerializerOptions));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveDoublesNextSet(TournamentInfo tournamentInfo, DoublesQueuModel doubles, FormatSelection formatSelection)
        {
            try
            {
                var jsonFolderPath = Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(doubles));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveDoublesSetQueu(TournamentInfo tournamentInfo, List<DoublesQueuModel> doublesSets, FormatSelection formatSelection)
        {
            try
            {
                var jsonFolderPath = Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(doublesSets));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveCrewsClassicNextSet(TournamentInfo tournamentInfo, CrewsClassicQueuModel crewsClassic, FormatSelection formatSelection)
        {
            try
            {
                var jsonFolderPath = Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(crewsClassic));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveCrewsClassicSetQueu(TournamentInfo tournamentInfo, List<CrewsClassicQueuModel> crewsClassicSets, FormatSelection formatSelection)
        {
            try
            {
                var jsonFolderPath = Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(crewsClassicSets));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveCrewsSmashNextSet(TournamentInfo tournamentInfo, CrewsSmashQueuModel crewsSmash, FormatSelection formatSelection)
        {
            try
            {
                var jsonFolderPath = Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(crewsSmash));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveCrewsSmashSetQueu(TournamentInfo tournamentInfo, List<CrewsSmashQueuModel> crewsSmashSets, FormatSelection formatSelection)
        {
            try
            {
                var jsonFolderPath = Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(crewsSmashSets));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private string GetFormatFolderPath(FormatSelection formatSelection)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _fightingGamesFolder, formatSelection.SelectedGame.ToString(), formatSelection.SelectedFormat.ToString());
        }
    }
}