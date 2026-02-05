namespace Kudiyarov.TrainingPrograms.Web.Models;

public record ApiSessionRequest
{
    public required string ProgramName { get; init; }
    public required int Day { get; init; }
    public required double Snatch { get; init; }
}