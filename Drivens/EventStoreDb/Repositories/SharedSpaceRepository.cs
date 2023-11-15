using Application.Domain.Space.Entities;
using Application.Domain.Space.ValueObjects;
using Application.Drivens.EventStoreDb.Repositories;

namespace EventStoreDb.Repositories;

public class SharedSpaceRepository 
    : BaseRepository<SharedSpace, SpaceId>, ISharedSpaceRepository 
{
    public SharedSpaceRepository(EventStoreDbCtx dbCtx) 
        : base(dbCtx)
    {
    }
}