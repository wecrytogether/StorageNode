using Application.Domain.Common.ValueObjects;
using Application.Domain.Space.Entities;
using Application.Domain.Space.ValueObjects;

namespace Application.Domain.Space.Services;

public interface ISharedSpaceService
{
    SharedSpace CreateSharedSpace(UserId ownerUserId, SpaceName name);
}

public record SharedSpaceService : ISharedSpaceService
{
    // TODO
    public SharedSpace CreateSharedSpace(UserId ownerUserId, SpaceName name)
    {
        // check if Owner exist
        
        // check if the Name is taken
        
        throw new NotImplementedException();
    }
}