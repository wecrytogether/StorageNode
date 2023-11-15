using Application.Drivens.AuthService.UserManagement.Enums;

namespace Application.Drivens.AuthService.Authorization.Dtos;

public record AuthorInfo(
    string Id,
    Role Role);