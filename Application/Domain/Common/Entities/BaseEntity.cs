using Application.Domain.Common.ValueObjects;

namespace Application.Domain.Common.Entities;

public abstract class BaseEntity
{
    public List<string> Original { protected get; init; }
    
    public List<string> Changes { protected get; init; }
    
    public List<string> Current { protected get; init; }
    
    public DateTime CreatedAt { get; protected init; } = DateTime.Now;
    
    public DateTime? LastUpdatedAt { get; protected set; }
}

public abstract class BaseEntity<TId> 
    : BaseEntity 
    where TId : BaseId
{
    public TId Id { get; } = (TId)Activator.CreateInstance(typeof(TId), new object[] { Guid.NewGuid() })!;
}