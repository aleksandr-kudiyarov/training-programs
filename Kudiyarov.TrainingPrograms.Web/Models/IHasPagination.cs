namespace Kudiyarov.TrainingPrograms.Web.Models;

public interface IHasPagination
{
    PaginationInfo PaginationInfo { get; }
    Func<int, object> RouteFactory { get; }
}