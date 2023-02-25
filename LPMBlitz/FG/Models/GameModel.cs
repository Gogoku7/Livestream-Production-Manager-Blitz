using LPMBlitz.FG.Enums;

namespace LPMBlitz.FG.Models;

public class GameModel
{
	public GamesEnum Game { get; set; }
	public string Name { get => Game.GetDescription(); }
	public List<FormatModel> Formats { get; set; }

	public GameModel(GamesEnum game) => Game = game;
}