
using System.Text;

/// <summary>
/// Represents the statistics for a single matchup between two teams.
/// This class holds details about the match up, including team names, final score,
/// and various in-match up statistics for both home and visiting teams.
/// </summary>

public class MatchUpStats
{
    public bool neutral { get; set; }
    public string visTeamName { get; set; }
    public TeamStatsThisMatchUp visStats { get; set; }
    public string homeTeamName { get; set; }
    public TeamStatsThisMatchUp homeStats { get; set; }
    public bool isFinal { get; set; }
    public string date { get; set; }

    // Prints formatted statistics for the match up, displaying all in-match up metrics for both the home and visiting teams
    public string PrintStats()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Match Up Statistics - {homeTeamName} vs. {visTeamName}");

        sb.AppendLine($"{"Match Date:",-11}{date, 11}");

        sb.AppendLine($"{"Final?",-11}{isFinal, 11}");

        sb.AppendLine($"{"Neutral? ",-11}{neutral, 11} {$"Home: {homeTeamName}",22}|{$"Visiting: {visTeamName}",22}|");

        sb.AppendLine(new string('-', 69));

        sb.AppendLine(PrintStatRow("statIdCode", homeStats?.statIdCode, visStats?.statIdCode));
        sb.AppendLine(PrintStatRow("gameCode", homeStats?.gameCode, visStats?.gameCode));
        sb.AppendLine(PrintStatRow("teamCode", homeStats?.teamCode, visStats?.teamCode));
        sb.AppendLine(PrintStatRow("gameDate", homeStats?.gameDate, visStats?.gameDate));
        sb.AppendLine(PrintStatRow("rushYds", homeStats?.rushYds, visStats?.rushYds));
        sb.AppendLine(PrintStatRow("rushAtt", homeStats?.rushAtt, visStats?.rushAtt));
        sb.AppendLine(PrintStatRow("passYds", homeStats?.passYds, visStats?.passYds));
        sb.AppendLine(PrintStatRow("passAtt", homeStats?.passAtt, visStats?.passAtt));
        sb.AppendLine(PrintStatRow("passComp", homeStats?.passComp, visStats?.passComp));
        sb.AppendLine(PrintStatRow("penalties", homeStats?.penalties, visStats?.penalties));
        sb.AppendLine(PrintStatRow("penaltYds", homeStats?.penaltYds, visStats?.penaltYds));
        sb.AppendLine(PrintStatRow("fumblesLost", homeStats?.fumblesLost, visStats?.fumblesLost));
        sb.AppendLine(PrintStatRow("interceptionsThrown", homeStats?.interceptionsThrown, visStats?.interceptionsThrown));
        sb.AppendLine(PrintStatRow("firstDowns", homeStats?.firstDowns, visStats?.firstDowns));
        sb.AppendLine(PrintStatRow("thirdDownAtt", homeStats?.thridDownAtt, visStats?.thridDownAtt));
        sb.AppendLine(PrintStatRow("thirdDownConver", homeStats?.thirdDownConver, visStats?.thirdDownConver));
        sb.AppendLine(PrintStatRow("fourthDownAtt", homeStats?.fourthDownAtt, visStats?.fourthDownAtt));
        sb.AppendLine(PrintStatRow("fourthDownConver", homeStats?.fourthDownConver, visStats?.fourthDownConver));
        sb.AppendLine(PrintStatRow("timePoss", homeStats?.timePoss, visStats?.timePoss));
        sb.AppendLine(PrintStatRow("score", homeStats?.score, visStats?.score));

        sb.AppendLine(new string('-', 69));

        return sb.ToString();
    }

    // Helper method to print a formatted row for a specific statistic.
    private string PrintStatRow(string statName, object homeValue, object visValue)
    {
        return $"{statName,22}|{homeValue ?? "N/A",22}|{visValue ?? "N/A",22}|";
    }

}
