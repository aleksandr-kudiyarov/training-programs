using Kudiyarov.TrainingPrograms.Entities;

namespace Kudiyarov.TrainingPrograms.Web.Models;

public class SessionViewModel
{
    public required Session Session { get; init; }
    public required string ProgramName { get; init; }
}
