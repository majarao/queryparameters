using Microsoft.EntityFrameworkCore;
using QueryParameters.Configurations;
using QueryParameters.Entities;

namespace QueryParameters.Context;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }

    public AppDbContext(DbContextOptions options) : base(options) => Database.EnsureCreated();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ConfigCategory();
    }
}
