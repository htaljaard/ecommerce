using SharedKernel.Entities;

namespace Products.Entities;
public class ProductCategory(string categoryName, string description) : Entity
{
    public string CategoryName { get; set; } = categoryName;
    public string Description { get; set; } = description;

}