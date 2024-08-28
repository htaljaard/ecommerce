using System;

namespace SharedKernel.Entities;

public class Entity
{
    public EntityId Id { get; init; } = new EntityId(Guid.NewGuid());

}
