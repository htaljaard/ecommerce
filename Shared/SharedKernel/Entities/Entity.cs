using System;

namespace SharedKernel.Entities;

public class Entity
{
    public required EntityId Id { get; set; }
    public required SKU ProductSKU { get; set; }
    public required ProductCategory Category { get; set; }
}
