using System.Text.RegularExpressions;

namespace LPMBlitz.FG.Models;

public class TournamentInfoDataModel
{
    public string Tournament { get; set; }
    public string Phase { get; set; }
    public string Round { get; set; }
    /// <summary>
    /// Automatically calculated in the format "{Phase} - {Round}". Is identical to Round if Phase is empty. Is identitcal to Phase if Round is empty. Otherwise empty string
    /// </summary>
    public string PhaseAndRound { get { return string.IsNullOrEmpty(Phase) ? string.IsNullOrEmpty(Round) ? string.Empty : Round : string.IsNullOrEmpty(Round) ? string.Empty : $"{Phase} - {Round}"; } }

    /// <summary>
    /// Calculated from Round. "Winners side" or "Losers side", otherwise empty string.
    /// </summary>
    public string BracketSideFull
    {
        get
        {
            if (string.IsNullOrEmpty(Round)) return string.Empty;
            if (Round.StartsWith("winners", StringComparison.OrdinalIgnoreCase)) return "Winners side";
            if (Round.StartsWith("losers", StringComparison.OrdinalIgnoreCase)) return "Losers side";
            return string.Empty;
        }
    }
    /// <summary>
    /// Calculated from Round. "Winners" or "Losers", otherwise empty string.
    /// </summary>
    public string BracketSide
    {
        get
        {
            if (string.IsNullOrEmpty(Round)) return string.Empty;
            if (Round.StartsWith("winners", StringComparison.OrdinalIgnoreCase)) return "Winners";
            if (Round.StartsWith("losers", StringComparison.OrdinalIgnoreCase)) return "Losers";
            return string.Empty;
        }
    }

    /// <summary>
    /// The Win condition of the current Set. Make sure to write it as one of the following 4 formats:
    /// "Best of X", "BoX", "First to X", "FtX" where X is an integer.
    /// </summary>
    public string BestOfOrFirstTo { get; set; }
    /// <summary>
    /// Automatically calculated from BestOfOrFirstTo. Example: Best of X
    /// </summary>
    public string BestOfFull => ProcessBestOf("Best of ");
    /// <summary>
    /// Automatically calculated from BestOfOrFirstTo. Example: BoX
    /// </summary>
    public string BestOfShort => ProcessBestOf("Bo");

    private string ProcessBestOf(string prefix)
    {
        var match = Regex.Match(BestOfOrFirstTo, @"^(?'prefix'b(?:est)? *o(?:f)?|f(?:irst)? *t(?:o)?) *(?'number'\d+)$", RegexOptions.IgnoreCase);
        if (!match.Success) return string.Empty;

        if (char.ToLower(match.Groups["prefix"].Value[0]).Equals('b')) return $"{prefix}{match.Groups["number"].Value}";

        var firstToNumber = int.Parse(match.Groups["number"].Value);
        return $"{prefix}{(firstToNumber > 1 ? (firstToNumber * 2 - 1) : firstToNumber)}";
    }

    /// <summary>
    /// Automatically calculated from BestOfOrFirstTo. Example: First to X
    /// </summary>
    public string FirstToFull => ProcessFirstTo("First to ");
    /// <summary>
    /// Automatically calculated from BestOfOrFirstTo. Example: FtX
    /// </summary>
    public string FirstToShort => ProcessFirstTo("Ft");

    private string ProcessFirstTo(string prefix)
    {
        var match = Regex.Match(BestOfOrFirstTo, @"^(?'prefix'b(?:est)? *o(?:f)?|f(?:irst)? *t(?:o)?) *(?'number'\d+)$", RegexOptions.IgnoreCase);
        if (!match.Success) return string.Empty;

        return char.ToLower(match.Groups["prefix"].Value[0]).Equals('f') ? $"{prefix}{match.Groups["number"].Value}" : $"{prefix}{Math.Ceiling(int.Parse(match.Groups["number"].Value) / 2d)}";
    }

    public string WinnerAdvancesTo { get; set; } // if top 8
    public string LoserAdvancesTo { get; set; } // if top 8
}
