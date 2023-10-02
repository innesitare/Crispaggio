using System.Reflection;
using Crispaggio.Domain.CustomerInfo;
using Microsoft.EntityFrameworkCore;

namespace Crispaggio.DeliveryAddressService.Persistence;

internal sealed class DeliveryAddressDbContext : DbContext, IDeliveryAddressDbContext
{
    public required DbSet<DeliveryAddress> DeliveryAddresses { get; init; }

    public DeliveryAddressDbContext(DbContextOptions<DeliveryAddressDbContext> dbContextOptions)
        : base(dbContextOptions)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}