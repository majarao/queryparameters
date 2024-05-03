using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using QueryParameters.Abstractions;
using QueryParameters.DTOs;
using QueryParameters.Entities;
using QueryParameters.Filters;
using System.Text.Json;

namespace QueryParameters.Controllers;

[Route("[controller]")]
[ApiController]
public class CategoriesController(ICategoryRepository category) : ControllerBase
{
    private readonly ICategoryRepository Category = category;

    [HttpGet]
    public ActionResult<IQueryable<Category>> Get([FromQuery] CategoryQueryParameters filter)
    {
        IQueryable<Category>? categories = Category.Get().Where(c => filter.Name.IsNullOrEmpty() || c.Name.Contains(filter.Name!));

        if (!categories.Any())
            return NoContent();

        Pagination pagination = CategoryQueryParameters.GetPagination(ref categories, filter.PageNumber, filter.PageSize);

        Response.Headers.Append("Pagination", JsonSerializer.Serialize(pagination));

        return Ok(categories);
    }
}
