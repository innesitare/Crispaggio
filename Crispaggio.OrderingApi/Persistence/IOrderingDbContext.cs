using Crispaggio.Domain.CustomerInfo;
using Crispaggio.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace Crispaggio.OrderingApi.Persistence;

public interface IOrderingDbContext
{
    DbSet<OrderItem> OrderItems { get; init; }
    
    DbSet<Order> Orders { get; init; }
    
    DbSet<Customer> Customers { get; init; }
    
    DbSet<DeliveryAddress> DeliveryAddresses { get; init; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}