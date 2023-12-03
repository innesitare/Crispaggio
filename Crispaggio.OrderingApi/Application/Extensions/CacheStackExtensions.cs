using CacheTower.Providers.Redis;
using CacheTower.Serializers.Protobuf;
using StackExchange.Redis;

namespace Crispaggio.OrderingApi.Application.Extensions;

public static class CacheStackExtensions
{
    public static void AddCacheStackService(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddCacheStack(cfg =>
        {
            var connectionMultiplexer = ConnectionMultiplexer.Connect(configuration["Redis:ConnectionString"]!);

            cfg.AddRedisCacheLayer(connectionMultiplexer, new RedisCacheLayerOptions(ProtobufCacheSerializer.Instance));
            cfg.WithRedisDistributedLocking(connectionMultiplexer);
            cfg.WithRedisRemoteEviction(connectionMultiplexer);
        });
    }
}