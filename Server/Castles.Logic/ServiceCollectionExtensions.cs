using System.Reflection;
using Castles.Logic.Mappings;
using Mapster;

namespace Castles.Logic;

public static class ServiceCollectionExtensions {
    public static IServiceCollection AddLogicLayer(this IServiceCollection services) {
        services.AddMapster();
        _ = services.AddMediatR(static configuration => configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        ExampleMapping.Configure();

        return services;
    }
}
