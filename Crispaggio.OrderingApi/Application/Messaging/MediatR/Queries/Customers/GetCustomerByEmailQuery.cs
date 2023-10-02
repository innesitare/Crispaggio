using Crispaggio.Core.Messaging.Abstractions;
using Crispaggio.Domain.CustomerInfo;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.Queries.Customers;

public sealed class GetCustomerByEmailQuery : IQuery<Customer?>
{
    public required string Email { get; init; }
}