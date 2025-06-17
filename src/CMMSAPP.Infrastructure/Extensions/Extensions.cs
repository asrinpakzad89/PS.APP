using CMMSAPP.Domain.Repositories;

namespace CMMSAPP.Infrastructure.Extensions;

public static class Extensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<ApplicationDBContext>(options =>
           options.UseNpgsql(config.GetConnectionString("DefaultConnection")));

        AddRepositories(services);
        return services;
    }
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, ApplicationDBContext>();
        services.AddScoped(typeof(IEFRepository<>), typeof(EFRepository<>));
    }
}
