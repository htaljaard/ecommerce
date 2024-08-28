using System;
using Microsoft.EntityFrameworkCore;
using Products.Entities;

namespace Products.Database;

public class ProductsDBContext : DbContext
{
    public DbSet<ProductCategory> ProductCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("Products");

        modelBuilder.Entity<ProductCategory>().HasKey(x => x.Id);
    }
}
