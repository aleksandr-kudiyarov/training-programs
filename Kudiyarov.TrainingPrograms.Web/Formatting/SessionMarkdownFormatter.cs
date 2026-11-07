using System.Globalization;
using System.Text;
using Kudiyarov.Packages.DoubleExtensions;
using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Exercises;
using Kudiyarov.TrainingPrograms.Entities.Repeats;

namespace Kudiyarov.TrainingPrograms.Web.Formatting;

public static class SessionMarkdownFormatter
{
    public static string Format(Session session)
    {
        ArgumentNullException.ThrowIfNull(session);

        var markdown = new StringBuilder();
        markdown.Append("Session ").AppendLine(session.Day.ToString(CultureInfo.InvariantCulture));

        foreach (var round in session.Rounds)
        {
            for (var r = 0; r < round.Rounds; r++)
            {
                foreach (var exercise in round.Exercises)
                {
                    markdown.Append("- [ ] ").AppendLine(EscapeMarkdown(exercise.Name));
                    foreach (var repeat in exercise.Repeats)
                    {
                        var description = FormatRepeat(exercise, repeat);
                        for (var s = 0; s < repeat.Sets; s++)
                            markdown.Append("    - [ ] ").AppendLine(description);
                    }
                }
            }
        }

        return markdown.ToString().TrimEnd('\r', '\n');
    }

    public static string FormatRepeat(BaseExercise exercise, Repeat repeat)
    {
        var repetitions = repeat switch
        {
            SingleRepeat single => single.Repeats.ToString(CultureInfo.InvariantCulture),
            MultiRepeat multi => string.Join("+", multi.Repeats),
            StaticRepeat duration => $"{duration.Duration.TotalSeconds.ToString(CultureInfo.InvariantCulture)} sec",
            _ => throw new ArgumentOutOfRangeException(nameof(repeat), repeat, null)
        };

        const double roundFactor = 2.5;
        var weight = repeat.Weight;
        double? asymmetryWeight = null;
        if (weight is not null)
        {
            if (exercise.Name.Contains("Asymmetry", StringComparison.OrdinalIgnoreCase))
                asymmetryWeight = (weight.Value * 0.85).RoundTo(roundFactor);
            weight = weight.Value.RoundTo(roundFactor);
        }

        var weightText = weight?.ToString(CultureInfo.InvariantCulture);
        var asymmetryText = asymmetryWeight?.ToString(CultureInfo.InvariantCulture);
        if (weightText is not null && asymmetryText is not null)
            return $"{weightText} ({asymmetryText}) × {repetitions}";
        return weightText is not null ? $"{weightText} × {repetitions}" : repetitions;
    }

    private static string EscapeMarkdown(string value) => value
        .Replace("\\", "\\\\", StringComparison.Ordinal)
        .Replace("\r", " ", StringComparison.Ordinal)
        .Replace("\n", " ", StringComparison.Ordinal)
        .Replace("[", "\\[", StringComparison.Ordinal)
        .Replace("]", "\\]", StringComparison.Ordinal)
        .Replace("*", "\\*", StringComparison.Ordinal)
        .Replace("_", "\\_", StringComparison.Ordinal)
        .Replace("`", "\\`", StringComparison.Ordinal);
}
