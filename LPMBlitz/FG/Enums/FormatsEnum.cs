using System.ComponentModel;

namespace LPMBlitz.FG.Enums;

public enum FormatsEnum
{
	[Description("Singles")]
	Singles,
	[Description("Doubles")]
	Doubles,
	[Description("Crews (Smash)")]
	SmashCrew,
	[Description("Crews (Classic)")]
	ClassicCrew,
	[Description("Squad Strike")]
	SquadStrike
}