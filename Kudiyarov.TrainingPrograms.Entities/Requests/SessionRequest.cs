namespace Kudiyarov.TrainingPrograms.Entities.Requests;

public record SessionRequest : ProgramRequest
{
    public required int Day { get; init; }
    public required Stats Stats { get; init; }
}