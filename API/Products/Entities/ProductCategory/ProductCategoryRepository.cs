using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Products.Database;
using Products.Entities;
using Products.Errors;
using SharedKernel.Entities;
using SharedKernel.Repositories;

namespace Products.Repositories;

public class ProductCategoryRepository : IGenericRepository<ProductCategory>
{
    private readonly ProductsDBContext _context;
    private readonly ILogger<ProductCategoryRepository> _logger;

    public ProductCategoryRepository(ProductsDBContext context, ILogger<ProductCategoryRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public Task<Result<ProductCategory>> AddAsync(ProductCategory entity)
    {
        throw new NotImplementedException();
    }

    public Task<Result<bool>> DeleteAsync(ProductCategory entity)
    {
        throw new NotImplementedException();
    }

    public Task<Result<ProductCategory>> GetAsync(int top, int skip)
    {
        throw new NotImplementedException();
    }

    public Task<Result<ProductCategory>> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Result<IEnumerable<ProductCategory>> GetByQuery(Func<ProductCategory, bool> query)
    {
        var categories = _context.ProductCategories.Where(query).ToList(); ;

        if (categories is null || categories.Count == 0)
        {
            return ProductCategoryErrors.ProductCategoryNotFoundForQyery();
        }

        return categories;
    }

    public Task<Result<ProductCategory>> UpdateAsync(ProductCategory entity)
    {
        throw new NotImplementedException();
    }
}
