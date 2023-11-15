using Application.Drivens.EventStoreDb;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EventStoreDb;

public static class ServiceCollectionExt
{
    public static IServiceCollection AddEventStoreDbServices(this IServiceCollection services, IConfiguration config)
    {
        // services.Configure<EventStoreDbSettings>();
        
        services.AddEventStoreClient("esdb://localhost:2113?tls=false");
        
        services.AddScoped<IEventStoreDbCtx, EventStoreDbCtx>();
        
        return services;
    }
}