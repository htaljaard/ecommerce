using System;
using System.Collections.Generic;
using Products.Entities;

namespace Products.Database
{
    public class Seed
    {

        private readonly ProductsDBContext _context;

        public Seed(ProductsDBContext context)
        {
            _context = context;
        }

        public Seed SeedProductCategories()
        {
            var categories = new List<ProductCategory>
            {
                new ProductCategory("Electronics", "Electronic devices and accessories"),
                new ProductCategory("Clothing", "Clothing and fashion items"),
                new ProductCategory("Home & Kitchen", "Home appliances and kitchenware"),
                new ProductCategory("Books", "Books and reading materials"),
                new ProductCategory("Sports & Outdoors", "Sports equipment and outdoor gear")
            };

            _context.ProductCategories.AddRange(categories);

            return this;
        }

        public Seed SaveChanges()
        {
            _context.SaveChanges();
            return this;
        }
    }
}

