using Kudiyarov.Packages.DoubleExtensions;
using Kudiyarov.TrainingPrograms.Entities;

namespace Kudiyarov.TrainingPrograms.Bll;

public class PercentageLogic
{
    public double GetPercent(
        int repeats,
        Intensity intensity)
    {
        var reserveRepeats = GetReserveRepeats(intensity);
        var percent = GetPercent(repeats + reserveRepeats);
        return percent;
    }

    private static double GetReserveRepeats(Intensity intensity)
    {
        var repeats = intensity switch
        {
            Intensity.None => 0,
            Intensity.Light => 5,
            Intensity.Medium => 3.5,
            Intensity.High => 1.5,
            _ => throw new ArgumentOutOfRangeException(nameof(intensity))
        };

        return repeats;
    }

    private static double GetPercent(double repeats)
    {
        var result = repeats.RelativeEquals(1)
            ? 1
            : 1 - repeats * 0.025;

        return result;
    }
}