using LPMBlitz.FG.Enums;
using LPMBlitz.FG.Models;

namespace LPMBlitz.FG.Configurations;

public class FightingGamesConfiguration
{
	private readonly SeriesModel SuperSmashBros = new(SeriesEnum.SuperSmashBros)
	{
		Games = new List<GameModel>
		{
			new(GamesEnum.SuperSmashBros64)
			{
				Formats = new List<FormatModel>
				{
					new(FormatsEnum.Singles),
					new(FormatsEnum.Doubles),
					new(FormatsEnum.SmashCrew)
				}
			},
			new(GamesEnum.SuperSmashBrosMelee)
			{
				Formats = new List<FormatModel>
				{
					new(FormatsEnum.Singles),
					new(FormatsEnum.Doubles),
					new(FormatsEnum.SmashCrew)
				}
			},
			new(GamesEnum.SuperSmashBrosBrawl)
			{
				Formats = new List <FormatModel>
				{
					new(FormatsEnum.Singles),
					new(FormatsEnum.Doubles),
					new(FormatsEnum.SmashCrew)
				}
			},
			new(GamesEnum.SuperSmashBros3DSWiiU)
			{
				Formats = new List <FormatModel>
				{
					new(FormatsEnum.Singles),
					new(FormatsEnum.Doubles),
					new(FormatsEnum.SmashCrew)
				}
			},
			new(GamesEnum.SuperSmashBrosUltimate)
			{
				Formats = new List <FormatModel>
				{
					new(FormatsEnum.Singles),
					new(FormatsEnum.Doubles),
					new(FormatsEnum.SmashCrew),
					new(FormatsEnum.SquadStrike)
				}
			}
		}
	};

	private readonly SeriesModel Tekken = new(SeriesEnum.Tekken)
	{
		Games = new List<GameModel>
		{
			new(GamesEnum.Tekken7)
			{
				Formats = new List<FormatModel>
				{
					new(FormatsEnum.Singles),
                    new(FormatsEnum.ClassicCrew)
				}
			}
		}
	};

    public readonly string BasePath = "/FG";
    public List<SeriesModel> GetConfiguration() => new() { SuperSmashBros, Tekken };
}