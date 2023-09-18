using LPMBlitz.FG.Enums;
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
    public class FightingGamesDataService
    {
        private const string _fightingGamesFolder = "FightingGames";
        private const string _jsonFolder = "JSON";
        private const string _jsonFileName = "Content.json";
        private const string _cssFolderE = "CSS";
        private const string _cssFileName = "Content.css";
        private readonly JsonSerializerOptions jsonSerializerOptions = new() { WriteIndented = true };

        public void SaveSingles(TournamentInfo tournamentInfo, SinglesModel singles, string formatFolderPath)
        {
            try
            {
                var jsonFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, formatFolderPath, _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonFileName), JsonSerializer.Serialize(singles, jsonSerializerOptions));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveDoubles(TournamentInfo tournamentInfo, DoublesModel doubles, string formatFolderPath)
        {
            try
            {
                var jsonFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, formatFolderPath, _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonFileName), JsonSerializer.Serialize(doubles));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveCrewsClassic(TournamentInfo tournamentInfo, CrewsClassicModel crewsClassic, string formatFolderPath)
        {
            try
            {
                var jsonFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, formatFolderPath, _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonFileName), JsonSerializer.Serialize(crewsClassic));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveCrewsSmash(TournamentInfo tournamentInfo, CrewsSmashModel crewsSmash, string formatFolderPath)
        {
            try
            {
                var jsonFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, formatFolderPath, _jsonFolder);
                Directory.CreateDirectory(jsonFolderPath);
                File.WriteAllText(Path.Combine(jsonFolderPath, _jsonFileName), JsonSerializer.Serialize(crewsSmash));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string GetLatest(FormatSelection formatSelection)
        {
            try
            {
                return File.ReadAllText(Path.Combine(GetFormatFolderPath(formatSelection), _jsonFolder, _jsonFileName));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string GetFormatFolderPath(FormatSelection formatSelection)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _fightingGamesFolder, formatSelection.SelectedGame.ToString(), formatSelection.SelectedFormat.ToString());
        }
    }
}