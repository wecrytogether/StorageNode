using Application.Domain.Common.ValueObjects;
using Application.Domain.Space.Entities;
using Application.Domain.Space.ValueObjects;

namespace Application.Domain.Space.Services;

public interface IPersonalSpaceService
{
    PersonalSpace CreatePersonalService(UserId ownerUserId);
}

public record PersonalSpaceService : IPersonalSpaceService
{
    // TODO
    public PersonalSpace CreatePersonalService(UserId ownerUserId)
    {
        // check if Owner exist
        var spaceName = new SpaceName(ownerUserId.Val);
        
        // check if Owner already have a Personal Space, consider this

        return new PersonalSpace(ownerUserId, spaceName, "");
    }
}