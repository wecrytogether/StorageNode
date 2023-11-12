using Application.Domain.Common.ValueObjects;
using Application.Domain.Space.ValueObjects;

namespace Application.Domain.Space.Entities;

public sealed class SharedSpace : BaseSpace
{
    private const SpaceType SharedSpaceType = SpaceType.Shared;

    public SharedSpace(UserId ownerUserId, SpaceType type, SpaceName name) : base(ownerUserId, type, name)
    {
    }
}