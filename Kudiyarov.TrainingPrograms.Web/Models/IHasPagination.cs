namespace Kudiyarov.TrainingPrograms.Web.Models;

public interface IHasPagination
{
    PaginationInfo PaginationInfo { get; }
    PaginationRoute PaginationRoute { get; }
}