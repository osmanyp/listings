using Demo.Listings.Domain.Interfaces;
using Demo.Listings.Domain.Services;
using Demo.Listings.Infrastructure;
using Demo.Listings.Infrastructure.DataAccess;
using Demo.Listings.Infrastructure.DataAccess.EF;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCustomServices(this IServiceCollection services)
    {
        services.AddDbContext<ListingsDbContext>(options =>
        options.UseInMemoryDatabase("DatabaseName"));
        
        services.AddScoped<ListingsService>();
        services.AddScoped<IListingsRepository, ListingsRepository>();

        return services;
    }
}

