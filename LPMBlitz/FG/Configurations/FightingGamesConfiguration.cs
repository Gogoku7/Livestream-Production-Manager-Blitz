using LPMBlitz.FG.Enums;
using LPMBlitz.FG.Models;

namespace LPMBlitz.FG.Configurations;

public class FightingGamesConfiguration
{
	private readonly SeriesModel SuperSmashBros = new(SeriesEnum.SuperSmashBros)
	{
		Games = new List<GameModel>
		{
			new GameModel(GamesEnum.SuperSmashBros64)
			{
				Formats = new List<FormatModel>
				{
					new FormatModel(FormatsEnum.Singles),
					new FormatModel(FormatsEnum.Doubles),
					new FormatModel(FormatsEnum.SmashCrew)
				}
			},
			new GameModel(GamesEnum.SuperSmashBrosMelee)
			{
				Formats = new List<FormatModel>
				{
					new FormatModel(FormatsEnum.Singles),
					new FormatModel(FormatsEnum.Doubles),
					new FormatModel(FormatsEnum.SmashCrew)
				}
			},
			new GameModel(GamesEnum.SuperSmashBrosBrawl)
			{
				Formats = new List <FormatModel>
				{
					new FormatModel(FormatsEnum.Singles),
					new FormatModel(FormatsEnum.Doubles),
					new FormatModel(FormatsEnum.SmashCrew)
				}
			},
			new GameModel(GamesEnum.SuperSmashBros3DSWiiU)
			{
				Formats = new List <FormatModel>
				{
					new FormatModel(FormatsEnum.Singles),
					new FormatModel(FormatsEnum.Doubles),
					new FormatModel(FormatsEnum.SmashCrew)
				}
			},
			new GameModel(GamesEnum.SuperSmashBrosUltimate)
			{
				Formats = new List <FormatModel>
				{
					new FormatModel(FormatsEnum.Singles),
					new FormatModel(FormatsEnum.Doubles),
					new FormatModel(FormatsEnum.SmashCrew),
					new FormatModel(FormatsEnum.SquadStrike)
				}
			}
		}
	};

	private readonly SeriesModel Tekken = new(SeriesEnum.Tekken)
	{
		Games = new List<GameModel>
		{
			new GameModel(GamesEnum.Tekken7)
			{
				Formats = new List<FormatModel>
				{
					new FormatModel(FormatsEnum.Singles),
					new FormatModel(FormatsEnum.ClassicCrew)
				}
			}
		}
	};

    public readonly string BasePath = "/FG";
    public List<SeriesModel> GetConfiguration() => new() { SuperSmashBros, Tekken };
}