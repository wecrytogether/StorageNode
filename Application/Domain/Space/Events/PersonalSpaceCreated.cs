using Application.Domain.Space.ValueObjects;

namespace Application.Domain.Space.Events;

public record PersonalSpaceCreated(
    SpaceId Id,
    SpaceName Name,
    DateTime HappenedAt);