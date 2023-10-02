using StronglyTypedIds;

namespace Crispaggio.Domain.Orders;

[StronglyTypedId]
public partial struct TopicId;

public sealed class Topic
{
    public required TopicId Id { get; init; }
    
    public required string Title { get; init; }
    
    public required double Price { get; init; }
}