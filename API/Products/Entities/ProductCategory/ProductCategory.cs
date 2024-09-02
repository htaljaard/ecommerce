using Products.Repositories;
using SharedKernel.Entities;
using SharedKernel.Repositories;

namespace Products.Entities;
public class ProductCategory(string categoryName, string description) : Entity
{
    public string CategoryName { get; set; } = categoryName;
    public string Description { get; set; } = description;

    public string CategoryCode { get; private set; } = Guid.NewGuid().ToString().Substring(0, 6);

    public bool IsUnique(IGenericRepository<ProductCategory> repository)
    {
        var result = repository.GetByQuery(c => c.CategoryName == CategoryName);
        return result.IsSuccess;
    }


}