using QueryParameters.Entities;

namespace QueryParameters.Filters;

public class CategoryQueryParameters : QueryParameters<Category>
{
    public string? Name { get; set; }
}
