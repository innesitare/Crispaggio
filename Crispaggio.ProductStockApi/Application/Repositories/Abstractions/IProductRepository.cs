using Crispaggio.ProductStockApi.Application.Models;

namespace Crispaggio.ProductStockApi.Application.Repositories.Abstractions;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync(CancellationToken cancellationToken);

    Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<bool> CreateAsync(Product product, CancellationToken cancellationToken);

    Task<Product?> UpdateAsync(Product product, CancellationToken cancellationToken);

    Task<bool> DeleteByIdAsync(Guid id, CancellationToken cancellationToken);
}