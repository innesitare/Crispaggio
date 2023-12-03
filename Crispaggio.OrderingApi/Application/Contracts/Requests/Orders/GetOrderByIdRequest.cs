namespace Crispaggio.OrderingApi.Application.Contracts.Requests.Orders;

public sealed class GetOrderByIdRequest
{
    public required Guid Id { get; init; }
    
    public required Guid CustomerId { get; init; }
}