namespace Kudiyarov.TrainingPrograms.Entities.Repeats;

public record MultiRepeat : Repeat
{
    public IReadOnlyList<int> Repeats { get; init; } = Array.Empty<int>();

    public static IReadOnlyList<Repeat> GetMaxoutRepeats()
    {
        var result = new Repeat[]
        {
            new MultiRepeat { Percent = 0.500, Repeats = new[] { 2, 2 }, Sets = 2 },
            new MultiRepeat { Percent = 0.600, Repeats = new[] { 2, 2 }, Sets = 1 },
            new MultiRepeat { Percent = 0.650, Repeats = new[] { 1, 1 }, Sets = 1 },
            new MultiRepeat { Percent = 0.700, Repeats = new[] { 1, 1 }, Sets = 2 },
            new MultiRepeat { Percent = 0.750, Repeats = new[] { 1, 1 }, Sets = 1 },
            new MultiRepeat { Percent = 0.800, Repeats = new[] { 1, 1 }, Sets = 2 },
            new MultiRepeat { Percent = 0.850, Repeats = new[] { 1, 1 }, Sets = 1 },
            new MultiRepeat { Percent = 0.900, Repeats = new[] { 1, 1 }, Sets = 1 },
            new MultiRepeat { Percent = 0.950, Repeats = new[] { 1, 1 }, Sets = 1 },
            new MultiRepeat { Percent = 0.975, Repeats = new[] { 1, 1 }, Sets = 1 },
            new MultiRepeat { Percent = 1.000, Repeats = new[] { 1, 1 }, Sets = 1 },
            new MultiRepeat { Percent = 1.025, Repeats = new[] { 1, 1 }, Sets = 1 }
        };

        return result;
    }
}