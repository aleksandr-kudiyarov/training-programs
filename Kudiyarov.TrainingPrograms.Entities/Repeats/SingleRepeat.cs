namespace Kudiyarov.TrainingPrograms.Entities.Repeats;

public record SingleRepeat : Repeat
{
    public int Repeats { get; init; }

    public static IReadOnlyList<Repeat> GetMaxoutRepeats()
    {
        var result = new Repeat[]
        {
            new SingleRepeat { Percent = 0.500, Repeats = 3, Sets = 2 },
            new SingleRepeat { Percent = 0.600, Repeats = 2, Sets = 1 },
            new SingleRepeat { Percent = 0.650, Repeats = 2, Sets = 1 },
            new SingleRepeat { Percent = 0.700, Repeats = 2, Sets = 2 },
            new SingleRepeat { Percent = 0.750, Repeats = 2, Sets = 1 },
            new SingleRepeat { Percent = 0.800, Repeats = 1, Sets = 2 },
            new SingleRepeat { Percent = 0.850, Repeats = 1, Sets = 1 },
            new SingleRepeat { Percent = 0.900, Repeats = 1, Sets = 1 },
            new SingleRepeat { Percent = 0.925, Repeats = 1, Sets = 1 },
            new SingleRepeat { Percent = 0.950, Repeats = 1, Sets = 1 },
            new SingleRepeat { Percent = 0.975, Repeats = 1, Sets = 1 },
            new SingleRepeat { Percent = 1.000, Repeats = 1, Sets = 1 },
            new SingleRepeat { Percent = 1.025, Repeats = 1, Sets = 1 }
        };

        return result;
    }
}