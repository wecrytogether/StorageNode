using Application.Domain.Common.ValueObjects;
using Application.Domain.Space.ValueObjects;

namespace Application.Domain.Space.Entities;

public sealed class PersonalSpace : BaseSpace
{
    private const SpaceType PersonalSpaceType = SpaceType.Personal;

    public PersonalSpace(UserId ownerUserId, SpaceType type, SpaceName name) : base(ownerUserId, type, name)
    {
    }
}