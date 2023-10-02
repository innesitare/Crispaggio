using System.Reflection;
using Crispaggio.Domain.CustomerInfo;
using Crispaggio.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace Crispaggio.OrderingApi.Persistence;

internal sealed class OrderingDbContext : DbContext, IOrderingDbContext
{
    public required DbSet<Order> Orders { get; init; }

    public required DbSet<Customer> Customers { get; init; }

    public required DbSet<DeliveryAddress> DeliveryAddresses { get; init; }
    
    public OrderingDbContext(DbContextOptions<OrderingDbContext> dbContextOptions) : base(dbContextOptions)
    {
        ChangeTracker.LazyLoadingEnabled = true;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}