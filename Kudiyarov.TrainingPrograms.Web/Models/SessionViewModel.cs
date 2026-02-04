using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Entities.Enums;

namespace Kudiyarov.TrainingPrograms.Web.Models;

public class SessionViewModel : IHasPagination
{
    public required Session Session { get; init; }
    public required string ProgramName { get; init; }
    public required ProgramType ProgramType { get; init; }
    public required PaginationInfo PaginationInfo { get; init; }
    public required Func<int, object> RouteFactory { get; init; }
}