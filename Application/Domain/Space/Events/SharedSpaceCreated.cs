using Application.Domain.Common.ValueObjects;
using Application.Domain.Space.ValueObjects;

namespace Application.Domain.Space.Events;

public record SharedSpaceCreated(
    SpaceId Id,
    UserId OwnerUserId,
    SpaceName Name,
    DateTime HappenedAt);