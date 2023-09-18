using LPMBlitz.FG.Models;
using System.Text.Json;

namespace LPMBlitz.Services
{
    public class CommentatorsDataService
    {
        private const string _commentatorsContentFileJsonPath = "./FightingGames/Commentators/JSON/Content.json";
        private const string _commentatorsContentFileCssPath = "./FightingGames/Commentators/CSS/Content.css";

        public void SaveCommentators(List<CommentatorModel> commentators)
        {
            try
            {
                var json = JsonSerializer.Serialize(commentators);
                File.WriteAllText(_commentatorsContentFileJsonPath, json);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}