using QueryParameters.Abstractions;
using QueryParameters.Context;
using QueryParameters.Entities;

namespace QueryParameters.Repositories;

public class CategoryRepository(AppDbContext appDbContext) : ICategoryRepository
{
    private readonly AppDbContext AppDbContext = appDbContext;

    public IQueryable<Category> Get() => AppDbContext.Categories;
}
