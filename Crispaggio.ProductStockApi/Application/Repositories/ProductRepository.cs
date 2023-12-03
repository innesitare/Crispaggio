using Crispaggio.ProductStockApi.Application.Models;
using Crispaggio.ProductStockApi.Application.Repositories.Abstractions;
using Crispaggio.ProductStockApi.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Crispaggio.ProductStockApi.Application.Repositories;

internal sealed class ProductRepository(IProductDbContext dbContext) : IProductRepository
{
    public async Task<IEnumerable<Product>> GetAllAsync(CancellationToken cancellationToken)
    {
        var products = await dbContext.Products
            .Include(product => product.Topics)
            .ToListAsync(cancellationToken);
        
        return products;
    }

    public async Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var product = await dbContext.Products.FindAsync(new object[]{id}, cancellationToken);
        return product;
    }

    public async Task<bool> CreateAsync(Product product, CancellationToken cancellationToken)
    {
        await dbContext.Products.AddAsync(product, cancellationToken);
        int result = await dbContext.SaveChangesAsync(cancellationToken);

        return result > 0;
    }

    public async Task<Product?> UpdateAsync(Product product, CancellationToken cancellationToken)
    {
        dbContext.Products.Update(product);
        int result = await dbContext.SaveChangesAsync(cancellationToken);

        return result > 0
            ? product
            : null;
    }
    
    public async Task<bool> DeleteByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        int result = await dbContext.Products
            .Where(product => product.Id == id)
            .ExecuteDeleteAsync(cancellationToken);

        return result > 0;
    }
}