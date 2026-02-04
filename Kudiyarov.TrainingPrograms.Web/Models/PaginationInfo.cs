namespace Kudiyarov.TrainingPrograms.Web.Models;

public record PaginationInfo
{
    public required int CurrentPage { get; init; }
    public required int TotalPages { get; init; }
}