namespace Kudiyarov.TrainingPrograms.Entities.Requests;

public record ProgramRequest
{
    public required string ProgramName { get; init; }
}