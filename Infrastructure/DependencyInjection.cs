using Domain.Interfaces;
using Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddRepositories();
    }
    
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IContactRepository, ContactMongoDbRepository>();
    }
}