using System.ComponentModel;

namespace LPMBlitz.FG.Enums;

public enum GamesEnum
{
	[Description("Super Smash Bros. 64")]
	SuperSmashBros64,
	[Description("Super Smash Bros. Melee")]
	SuperSmashBrosMelee,
	[Description("Super Smash Bros. Brawl")]
	SuperSmashBrosBrawl,
	[Description("Super Smash Bros. for Nintendo 3DS and Wii U")]
	SuperSmashBros3DSWiiU,
	[Description("Super Smash Bros. Ultimate")]
	SuperSmashBrosUltimate,

	[Description("TEKKEN 7")]
	Tekken7,
    [Description("TEKKEN 8")]
    Tekken8,

    [Description("Street Fighter 6")]
    StreetFighter6
}