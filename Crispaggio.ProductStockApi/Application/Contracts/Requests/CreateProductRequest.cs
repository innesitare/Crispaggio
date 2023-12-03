using Crispaggio.Domain.Orders;

namespace Crispaggio.ProductStockApi.Application.Contracts.Requests;

public sealed class CreateProductRequest 
{
    public Guid Id { get; } = Guid.NewGuid();

    public required byte[] Image { get; init; }
    
    public required string Title { get; init; }
    
    public required string Description { get; init; }
    
    public required double Price { get; init; }
    
    public required double Rating { get; init; }
    
    public required int Quantity { get; init; }
    
    public required IEnumerable<Topic>? Topics { get; init; }
}