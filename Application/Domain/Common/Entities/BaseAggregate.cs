using Application.Domain.Common.ValueObjects;

namespace Application.Domain.Common.Entities;

public abstract class BaseAggregate<TId> : BaseEntity<TId> where TId : BaseId
{
    // TODO implement EventList here
}