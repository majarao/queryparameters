using Microsoft.EntityFrameworkCore;
using QueryParameters.Abstractions;
using QueryParameters.Context;
using QueryParameters.Repositories;

namespace QueryParameters.Extensions;

public static class ServiceExtension
{
    public static void AddDbContext(this IServiceCollection services, ConfigurationManager configurationManager) =>
        services.AddDbContext<AppDbContext>(option => option
            .UseSqlServer(configurationManager.GetConnectionString("DefaultConnection")));

    public static void AddServices(this IServiceCollection services) =>
        services.AddScoped<ICategoryRepository, CategoryRepository>();
}
