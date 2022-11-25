using AlgoHub.API.Services.Implementations;
using AlgoHub.API.Services.Interfaces;

namespace AlgoHub.API.ServiceExtensions;

public static class S3Installer
{
    public static IServiceCollection AddS3StorageService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IStorageService, S3StorageService>(s =>
        {
            var aws = configuration.GetSection("AWS");
            return new(aws["BucketName"]!, aws["AccessKey"]!, aws["Secret"]!, aws["Region"]!);
        });
        
        return services;
    }
}
