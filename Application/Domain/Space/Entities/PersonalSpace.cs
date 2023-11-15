using Application.Domain.Common.ValueObjects;
using Application.Domain.Space.Events;
using Application.Domain.Space.ValueObjects;

namespace Application.Domain.Space.Entities;

public sealed class PersonalSpace : BaseSpace
{
    private const SpaceType PersonalSpaceType = SpaceType.Personal;

    public string X { get; set; }
    
    public PersonalSpace(UserId ownerUserId, SpaceName name, string x) : base(ownerUserId, PersonalSpaceType, name)
    {
        // TODO add to event store
        X = x;
        var e = new PersonalSpaceCreated(Id, OwnerUserId, Name, CreatedAt);
    }
}