namespace Kudiyarov.TrainingPrograms.Entities;

public class Session
{
    public int Day { get; set; }
    public IReadOnlyList<Round> Rounds { get; init; } = [];
}