using Crispaggio.OrderingApi.Persistence.Configurations;
using MassTransit.EntityFrameworkCoreIntegration;
using Microsoft.EntityFrameworkCore;

namespace Crispaggio.OrderingApi.Persistence;

internal sealed class OrderingSagaDbContext(DbContextOptions options) : SagaDbContext(options)
{
    protected override IEnumerable<ISagaClassMap> Configurations
    {
        get
        {
            yield return new OrderStateSagaMap();
        }
    }
}