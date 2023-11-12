using Application.Domain.Common.Entities;
using Application.Domain.Common.ValueObjects;
using Application.Domain.Space.Events;
using Application.Domain.Space.ValueObjects;

namespace Application.Domain.Space.Entities;

public abstract class BaseSpace : BaseAggregate<SpaceId>
{
    public UserId OwnerUserId { get; set; }
    
    public SpaceType Type { get; }
    
    public SpaceName Name { get; }
    
    protected BaseSpace(UserId ownerUserId, SpaceType type, SpaceName name)
    {
        OwnerUserId = ownerUserId;
        Type = type;
        Name = name;
        CreatedAt = DateTime.Now;

        // TODO add to event store
        var e = new PersonalSpaceCreated(Id, Name, CreatedAt);
    }
}