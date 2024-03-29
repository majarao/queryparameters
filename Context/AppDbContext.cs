using Microsoft.EntityFrameworkCore;
using QueryParameters.Configurations;
using QueryParameters.Entities;

namespace QueryParameters.Context;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ConfigCategory();
    }
}
