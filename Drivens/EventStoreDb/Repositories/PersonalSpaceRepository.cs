using Application.Domain.Space.Entities;
using Application.Domain.Space.ValueObjects;
using Application.Drivens.EventStoreDb.Repositories;

namespace EventStoreDb.Repositories;

public class PersonalSpaceRepository 
    : BaseRepository<PersonalSpace, SpaceId>, IPersonalSpaceRepository
{
    public PersonalSpaceRepository(EventStoreDbCtx eventStoreDbCtx) 
        : base(eventStoreDbCtx)
    {
    }
}