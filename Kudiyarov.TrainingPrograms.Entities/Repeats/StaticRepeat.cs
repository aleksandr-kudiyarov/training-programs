namespace Kudiyarov.TrainingPrograms.Entities.Repeats;

public record StaticRepeat : Repeat
{
    public TimeSpan Duration { get; init; }
}