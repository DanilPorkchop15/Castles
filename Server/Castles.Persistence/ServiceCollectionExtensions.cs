using Castles.Persistence.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Castles.Persistence;

public static class ServiceCollectionExtensions {
    public static IServiceCollection AddPersistenceLayer(this IServiceCollection services) {
        _ = services.AddNpgsql<CastlesDbContext>("postgresql://localhost:5432");
        _ = services.AddStackExchangeRedisCache(static options => {
            options.Configuration = "localhost:6379";
        });
        _ = services.AddScoped<ImageRepository>();

        return services;
    }
}

