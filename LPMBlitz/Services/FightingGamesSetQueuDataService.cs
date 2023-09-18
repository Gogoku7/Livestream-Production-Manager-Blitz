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

        public void SaveSinglesNextSet(TournamentInfo tournamentInfo, SinglesModel singles, string formatFolderPath)
        {
            try
            {
                var jsonFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, formatFolderPath, _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(singles, jsonSerializerOptions));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveSinglesSetQueu(TournamentInfo tournamentInfo, List<SinglesModel> singlesSets, string formatFolderPath)
        {
            try
            {
                var jsonFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, formatFolderPath, _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonSetQueuFileName), JsonSerializer.Serialize(singlesSets, jsonSerializerOptions));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveDoublesNextSet(TournamentInfo tournamentInfo, DoublesModel doubles, string formatFolderPath)
        {
            try
            {
                var jsonFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, formatFolderPath, _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(doubles));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveDoublesSetQueu(TournamentInfo tournamentInfo, List<SinglesModel> doublesSets, string formatFolderPath)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveCrewsClassicNextSet(TournamentInfo tournamentInfo, CrewsClassicModel crewsClassic, string formatFolderPath)
        {
            try
            {
                var jsonFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, formatFolderPath, _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(crewsClassic));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveCrewsClassicSetQueu(TournamentInfo tournamentInfo, List<CrewsClassicModel> crewsClassicSets, string formatFolderPath)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveCrewsSmashNextSet(TournamentInfo tournamentInfo, CrewsSmashModel crewsSmash, string formatFolderPath)
        {
            try
            {
                var jsonFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, formatFolderPath, _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonNextSetFileName), JsonSerializer.Serialize(crewsSmash));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveCrewsSmashSetQueu(TournamentInfo tournamentInfo, List<CrewsSmashModel> crewsSmashSets, string formatFolderPath)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}