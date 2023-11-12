using Application.Domain.Common.ValueObjects;

namespace Application.Domain.Common.Entities;

public abstract class BaseEntity<TId> where TId : BaseId
{
    public TId Id { get; protected init; } = (TId)Activator.CreateInstance(typeof(TId), new object[] { Guid.NewGuid() })!;
    
    public DateTime CreatedAt { get; protected init; } = DateTime.Now;
    
    public DateTime? LatestUpdatedAt { get; protected set; }
}