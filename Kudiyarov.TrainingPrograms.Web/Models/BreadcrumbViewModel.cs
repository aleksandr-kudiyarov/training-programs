namespace Kudiyarov.TrainingPrograms.Web.Models;

public class BreadcrumbViewModel
{
    public required BreadcrumbItem[] Items { get; init; }
}

public class BreadcrumbItem
{
    public required string Text { get; init; }
    public string? Controller { get; init; }
    public string? Action { get; init; }
    public object? RouteValues { get; init; }
    public bool IsActive { get; init; }
}
