using Crispaggio.Core.Messaging.Abstractions;
using Crispaggio.Domain.CustomerInfo;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.Queries.Customers;

public sealed class GetCustomerByIdQuery : IQuery<Customer?>
{
    public required Guid Id { get; init; }
}