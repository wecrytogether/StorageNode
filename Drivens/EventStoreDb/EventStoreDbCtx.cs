using Application.Domain.Common.Entities;
using Application.Drivens.EventStoreDb;
using Application.Drivens.EventStoreDb.Repositories;
using EventStore.Client;
using EventStoreDb.Repositories;

namespace EventStoreDb;

public sealed class EventStoreDbCtx : IEventStoreDbCtx
{
    public EventStoreClient Db { get; }
    public List<BaseEntity> TrackedEntities { get; }

    #region Repositories
    public IPersonalSpaceRepository PersonalSpaceRepo { get; init; }
    public ISharedSpaceRepository SharedSpaceRepo { get; init; }
    #endregion

    public EventStoreDbCtx(EventStoreClient db)
    {
        Db = db;
        TrackedEntities = new List<BaseEntity>();

        #region Repositories
        PersonalSpaceRepo = new PersonalSpaceRepository(this);
        SharedSpaceRepo = new SharedSpaceRepository(this);
        #endregion
    }

    public Task SaveAsync()
    {
        throw new NotImplementedException();
    }
}