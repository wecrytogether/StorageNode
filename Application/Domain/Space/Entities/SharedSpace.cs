using Application.Domain.Common.ValueObjects;
using Application.Domain.Space.Events;
using Application.Domain.Space.ValueObjects;

namespace Application.Domain.Space.Entities;

public sealed class SharedSpace : BaseSpace
{
    private const SpaceType SharedSpaceType = SpaceType.Shared;

    public SharedSpace(UserId ownerUserId, SpaceName name) : base(ownerUserId, SharedSpaceType, name)
    {
        // TODO add to event store
        var e = new SharedSpaceCreated(Id, OwnerUserId, Name, CreatedAt);
    }
}