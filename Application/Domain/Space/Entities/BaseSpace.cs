using Application.Domain.Common.Entities;
using Application.Domain.Common.ValueObjects;
using Application.Domain.Space.ValueObjects;

namespace Application.Domain.Space.Entities;

public abstract class BaseSpace : BaseEntity<SpaceId>
{
    // Id of User who created this Space
    public UserId OwnerUserId { get; }
    
    public SpaceType Type { get; }
    
    public SpaceName Name { get; }
    
    protected BaseSpace(UserId ownerUserId, SpaceType type, SpaceName name)
    {
        OwnerUserId = ownerUserId;
        Type = type;
        Name = name;
        CreatedAt = DateTime.Now;
    }
}