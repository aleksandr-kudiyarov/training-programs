namespace Kudiyarov.TrainingPrograms.Web.Models;

public record PaginationRoute
{
    public required string? Action { get; init; }
    public required string? Controller { get; init; }
    public required Func<int, object?> ValuesFactory { get; init; }
}