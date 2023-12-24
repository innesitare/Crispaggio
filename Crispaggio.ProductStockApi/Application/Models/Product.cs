using Crispaggio.Domain.Orders;

namespace Crispaggio.ProductStockApi.Application.Models;

public sealed class Product
{
    public required Guid Id { get; init; }
    
    public required byte[] Image { get; init; }
    
    public required string Title { get; init; }
    
    public required string Description { get; init; }
    
    public required double Price { get; init; }
    
    public required double Rating { get; init; }
    
    public required int Quantity { get; set; }
    
    public required IEnumerable<Topic>? Topics { get; init; }
}