using AlgoHub.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace AlgoHub.API.ServiceExtensions;

public static class DbInstaller
{
    public static IServiceCollection AddAlgoHubDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AlgoHubContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                o => o.MigrationsAssembly("AlgoHub.DAL")
            )
        );
        return services;
    }
}
