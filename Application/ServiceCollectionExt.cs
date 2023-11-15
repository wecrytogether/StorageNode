using Application.Domain.Space.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ServiceCollectionExt
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        #region Services

        services.AddSingleton<IPersonalSpaceService, PersonalSpaceService>();
        services.AddSingleton<ISharedSpaceService, SharedSpaceService>();

        #endregion
        
        return services;
    }
}