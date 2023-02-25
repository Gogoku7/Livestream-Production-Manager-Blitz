using LPMBlitz.FG.Enums;

namespace LPMBlitz.FG.Models;

public class SeriesModel
{
	public SeriesEnum Series { get; set; }
	public string Name { get => Series.GetDescription(); }
	public List<GameModel> Games { get; set; }

	public SeriesModel(SeriesEnum series) => Series = series;
}