namespace Kudiyarov.TrainingPrograms.Entities.Repeats;

public class MultiRepeat : Repeat
{
    public IReadOnlyList<int> Repeats { get; init; } = Array.Empty<int>();

    public static IReadOnlyList<Repeat> GetMaxoutRepeats()
    {
        var result = new Repeat[]
        {
            new MultiRepeat { Percent = 0.500, Repeats = [2, 2], Sets = 2 },
            new MultiRepeat { Percent = 0.600, Repeats = [2, 2], Sets = 1 },
            new MultiRepeat { Percent = 0.650, Repeats = [1, 1], Sets = 1 },
            new MultiRepeat { Percent = 0.700, Repeats = [1, 1], Sets = 2 },
            new MultiRepeat { Percent = 0.750, Repeats = [1, 1], Sets = 1 },
            new MultiRepeat { Percent = 0.800, Repeats = [1, 1], Sets = 2 },
            new MultiRepeat { Percent = 0.850, Repeats = [1, 1], Sets = 1 },
            new MultiRepeat { Percent = 0.900, Repeats = [1, 1], Sets = 1 },
            new MultiRepeat { Percent = 0.950, Repeats = [1, 1], Sets = 1 },
            new MultiRepeat { Percent = 0.975, Repeats = [1, 1], Sets = 1 },
            new MultiRepeat { Percent = 1.000, Repeats = [1, 1], Sets = 1 },
            new MultiRepeat { Percent = 1.025, Repeats = [1, 1], Sets = 1 }
        };

        return result;
    }
}