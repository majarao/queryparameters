using QueryParameters.Entities;

namespace QueryParameters.Abstractions;

public interface ICategoryRepository
{
    IQueryable<Category> Get();
}
