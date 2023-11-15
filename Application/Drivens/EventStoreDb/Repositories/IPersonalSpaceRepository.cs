using Application.Domain.Space.Entities;
using Application.Domain.Space.ValueObjects;

namespace Application.Drivens.EventStoreDb.Repositories;

public interface IPersonalSpaceRepository : IBaseRepository<PersonalSpace, SpaceId>
{
    
}