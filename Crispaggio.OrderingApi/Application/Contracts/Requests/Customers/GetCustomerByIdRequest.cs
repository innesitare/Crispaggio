namespace Crispaggio.OrderingApi.Application.Contracts.Requests.Customers;

public sealed class GetCustomerByIdRequest
{
    public required Guid Id { get; init; }
}