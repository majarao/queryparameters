using QueryParameters.DTOs;

namespace QueryParameters.Filters;

public abstract class QueryParameters<T> where T : class
{
    const int MAX_PAGE_SIZE = 10;

    public int PageNumber { get; set; } = 1;
    private int _pageSize = MAX_PAGE_SIZE;

    public int PageSize
    {
        get
        {
            return _pageSize;
        }
        set
        {
            _pageSize = (value > MAX_PAGE_SIZE) ? MAX_PAGE_SIZE : value;
        }
    }

    public static Pagination GetPagination(ref IQueryable<T> source, int pageNumber, int pageSize)
    {
        int count = source.Count();
        int totalPages = (int)Math.Ceiling(count / (double)pageSize);

        if (totalPages < pageNumber)
            pageNumber = 1;

        source = source.Skip((pageNumber - 1) * pageSize).Take(pageSize);

        return new(pageSize, pageNumber, totalPages, count);
    }
}
