using Crispaggio.Core.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Npgsql;

namespace Crispaggio.Core.Extensions;

public static class DatabaseExtensions
{
    private static IServiceCollection AddNpgsqlDbContextOptions<TDbContext>(this IServiceCollection services,
        string connectionString)
        where TDbContext : DbContext
    {
        services.AddTransient<IOptions<PostgresDbContextSettings<TDbContext>>>(_ =>
        {
            var builder = new NpgsqlConnectionStringBuilder(connectionString);
            return Options.Create(new PostgresDbContextSettings<TDbContext>
            {
                ConnectionString = connectionString,
                Database = builder.Database!,
                Host = builder.Host!,
                Port = builder.Port
            });
        });

        return services;
    }

    public static IServiceCollection AddApplicationDatabase<TDbContext>(this IServiceCollection services,
        string connectionString)
        where TDbContext : DbContext
    {
        services.AddNpgsql<TDbContext>(connectionString, builder => builder.MinBatchSize(1));
        services.AddNpgsqlDbContextOptions<TDbContext>(connectionString);

        return services;
    }

    public static IServiceCollection AddApplicationDatabase<TDbInterface, TDbContext>(this IServiceCollection services,
        string connectionString)
        where TDbContext : DbContext, TDbInterface
        where TDbInterface : class
    {
        services.AddNpgsql<TDbContext>(connectionString, builder => builder.MinBatchSize(1));
        services.AddNpgsqlDbContextOptions<TDbContext>(connectionString);

        services.AddApplicationService<TDbInterface>(services.Single(x =>
            x.ImplementationType == typeof(TDbContext)).Lifetime);
        return services;
    }
}