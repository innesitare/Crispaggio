namespace Crispaggio.Domain.Orders;

public sealed class Topic
{
    public required Guid Id { get; init; }
    
    public required string Title { get; init; }
    
    public required double Price { get; init; }
}