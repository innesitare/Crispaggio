using Crispaggio.Domain.CustomerInfo;
using Crispaggio.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace Crispaggio.OrderingApi.Persistence;

public interface IOrderingDbContext
{
    public DbSet<Customer> Customers { get; init; }
    
    public DbSet<Order> Orders { get; init; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}