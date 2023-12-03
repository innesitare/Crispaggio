namespace Crispaggio.OrderingApi.Application.Contracts.Requests.Orders;

public sealed class GetAllOrdersByCustomerIdRequest
{
    public required Guid CustomerId { get; init; }
}