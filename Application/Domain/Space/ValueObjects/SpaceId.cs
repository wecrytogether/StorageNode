using Application.Domain.Common.ValueObjects;

namespace Application.Domain.Space.ValueObjects;

public record SpaceId(Guid Val) : BaseId(Val);