namespace SharedKernel.Entities;

public record EntityId(Guid Value)
{
    public static EntityId New => new(Guid.NewGuid());
}