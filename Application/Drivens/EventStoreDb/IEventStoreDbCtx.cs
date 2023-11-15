using Application.Drivens.EventStoreDb.Repositories;

namespace Application.Drivens.EventStoreDb;

public interface IEventStoreDbCtx
{
    public IPersonalSpaceRepository PersonalSpaceRepo { get; init; }

    public ISharedSpaceRepository SharedSpaceRepo { get; init; }
    
    Task SaveAsync();
}