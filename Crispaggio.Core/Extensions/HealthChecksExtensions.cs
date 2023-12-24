using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Crispaggio.Core.Extensions;

public static class HealthChecksExtensions
{
    public static IHealthChecksBuilder AddHealthChecksService(this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        return serviceCollection.AddHealthChecks()
            .AddRedis(configuration["Redis:ConnectionString"]!, name: "RedisCache", tags: new[] {"Database"})
            .AddNpgSql(configuration["OrderingDb:ConnectionString"]!, name: "OrderingDatabase",  tags: new[] {"Service"})
            .AddNpgSql(configuration["OrderingStateDb:ConnectionString"]!, name: "OrderingStateDatabase", tags: new[] {"Service"});
    }
}