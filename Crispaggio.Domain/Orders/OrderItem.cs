namespace Crispaggio.Domain.Orders;

public sealed class OrderItem
{
    public required Guid Id { get; init; }
    
    public required string Title { get; init; }
    
    public required string Description { get; init; }
    
    public required double Price { get; init; }
    
    public required double Rating { get; init; }

    public required int Quantity { get; init; }
    
    public required IEnumerable<Topic>? Topics { get; init; }
}