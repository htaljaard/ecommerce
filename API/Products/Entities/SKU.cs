using SharedKernel.Entities;

namespace Products.Entities;

internal record SKU(Guid Value)
{
    public static SKU New() => new(Guid.NewGuid());
}
