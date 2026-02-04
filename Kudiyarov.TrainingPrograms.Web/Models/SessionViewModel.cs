using Kudiyarov.TrainingPrograms.Entities;
using Kudiyarov.TrainingPrograms.Programs;

namespace Kudiyarov.TrainingPrograms.Web.Models;

public class SessionViewModel : IHasPagination
{
    public required Session Session { get; init; }
    public required TrainingProgram Program { get; init; }
    public required PaginationInfo PaginationInfo { get; init; }
    public required PaginationRoute PaginationRoute { get; init; }
}