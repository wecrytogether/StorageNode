using Application.Domain.Common.Entities;
using Application.Domain.Common.ValueObjects;
using Application.Drivens.EventStoreDb.Repositories;
using EventStore.Client;

namespace EventStoreDb.Repositories;

public abstract class BaseRepository<TEntity, TId> 
    : IBaseRepository<TEntity, TId>
    where TEntity : BaseEntity<TId>
    where TId : BaseId
{
    private EventStoreDbCtx DbCtx { get; init; }

    protected EventStoreClient Db { get; set; }

    protected BaseRepository(EventStoreDbCtx dbCtx)
    {
        DbCtx = dbCtx;
        Db = DbCtx.Db;
    }

    public void Track(params TEntity[] entities)
    {
        DbCtx.TrackedEntities.AddRange(entities);
    }
}