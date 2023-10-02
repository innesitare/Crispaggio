using StronglyTypedIds;

namespace Crispaggio.Domain.Orders;

[StronglyTypedId]
public partial struct OrderItemId;

public sealed class OrderItem
{
    public required OrderItemId Id { get; init; }
    
    public required byte[] Image { get; init; }
    
    public required string Title { get; init; }
    
    public required string Description { get; init; }
    
    public required double Price { get; init; }
    
    public required double Rating { get; init; }
    
    public required IEnumerable<Topic>? Topics { get; init; }
}