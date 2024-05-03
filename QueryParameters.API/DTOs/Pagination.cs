namespace QueryParameters.DTOs;

public class Pagination(int pageSize, int pageNumber, int totalPages, int totalCount)
{
    public int PageSize { get; set; } = pageSize;
    public int PageNumber { get; set; } = pageNumber;
    public int TotalPages { get; set; } = totalPages;
    public int TotalCount { get; set; } = totalCount;
    public bool HasPrevious => PageNumber > 1;
    public bool HasNext => PageNumber < TotalPages;
}
