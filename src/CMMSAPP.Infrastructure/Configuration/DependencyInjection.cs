namespace CMMSAPP.Infrastructure.Configuration;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDBContext>(options =>
           options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

        AddRepositories(services);
        return services;
    }
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));
    }
}
