using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QueryParameters.Entities;

namespace QueryParameters.Configurations;

public static class CategoryConfiguration
{
    public static void ConfigCategory(this ModelBuilder builder)
    {
        EntityTypeBuilder<Category> category = builder.Entity<Category>();

        category.ToTable("Categories");
        category.HasKey(c => c.CategoryId);
        category.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(50);

        List<Category> categories = [];

        for (int i = 1; i <= 100; i++)
        {
            categories.Add(new()
            {
                CategoryId = i,
                Name = $"Category {i}"
            });
        }

        category.HasData(categories);
    }
}
