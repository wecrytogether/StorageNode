using Application.Domain.Common.Entities;
using Application.Domain.Common.ValueObjects;

namespace Application.Drivens.EventStoreDb.Repositories;

public interface IBaseRepository<in TEntity, in TId>
    where TEntity : BaseEntity<TId>
    where TId : BaseId
{
    void Track(params TEntity[] entities);
}