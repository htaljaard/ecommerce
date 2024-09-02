using System;
using SharedKernel.Entities;

namespace Products.Errors;

public static class ProductCategoryErrors
{
    public static Error ProductCategoryNotFound(Guid id) => new Error($"Product category with id {id} not found.", "ProductCategory.NotFound");

    public static Error ProductCategoryNotFoundForQyery() => new Error("Product category not found for query.", "ProductCategory.NotFound");

    public static Error ProductCategoryAlreadyExists(string categoryName) => new Error($"Product category with name {categoryName} already exists.", "ProductCategory.AlreadyExists");
}
