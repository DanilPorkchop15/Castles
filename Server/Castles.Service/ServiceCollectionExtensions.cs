using Minio;

namespace Castles.Service;

public static class ServiceCollectionExtensions {
    public static IServiceCollection AddServiceLayer(this IServiceCollection services) {
        _ = services.AddMinio(static configureClient => {
            var secretKey = Environment.GetEnvironmentVariable("CASTLES_MINIO_SECRET_KEY");
            var accessKey = Environment.GetEnvironmentVariable("CASTLES_MINIO_ACCESS_KEY");
            _ = configureClient
                        .WithEndpoint("127.0.0.1:9000")
                        .WithCredentials(accessKey, secretKey)
                        .Build();
        });
        _ = services.AddScoped<ImageGenerator>();
        _ = services.AddScoped<FileStorage>();
        return services;
    }
}
