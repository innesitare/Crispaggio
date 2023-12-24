using Crispaggio.Domain.Orders;
using Crispaggio.ProductStockApi.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Crispaggio.ProductStockApi.Persistence;

public interface IProductDbContext
{
    DbSet<Product> Products { get; init; }

    DbSet<Topic> Topics { get; init; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}