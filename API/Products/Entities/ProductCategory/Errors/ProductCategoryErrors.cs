using System;
using SharedKernel.Entities;

namespace Products.Errors;

public class ProductCategoryErrors
{
    public static Error ProductCategoryNotFound(Guid id) => new Error($"Product category with id {id} not found.", "ProductCategory.NotFound");

    public static Error ProductCategoryAlreadyExists(string categoryName) => new Error($"Product category with name {categoryName} already exists.", "ProductCategory.AlreadyExists");
}
