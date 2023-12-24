namespace Crispaggio.OrderingApi.Application.Contracts.Requests.Customers;

public sealed class GetCustomerByEmailRequest
{
    public required string Email { get; init; }
}