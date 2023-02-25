using LPMBlitz.FG.Enums;

namespace LPMBlitz.FG.Models;

public class FormatModel
{
	public FormatsEnum Format { get; set; }
	public string Name { get => Format.GetDescription(); }
	public string Path { get; set; }

    public FormatModel(FormatsEnum format) => Format = format;
}