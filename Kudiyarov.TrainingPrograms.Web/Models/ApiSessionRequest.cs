using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Web.Models;

public record ApiSessionRequest
{
    public required ProgramType ProgramType { get; init; }
    public required int Day { get; init; }
    public required double Snatch { get; init; }
}