using Crispaggio.Core.Messaging.Abstractions;
using Crispaggio.Domain.CustomerInfo;
using Crispaggio.OrderingApi.Application.Repositories.Abstractions;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.Queries.Customers.Handlers;

internal sealed class GetCustomerByIdQueryHandler(ICustomerRepository customerRepository)
    : IQueryHandler<GetCustomerByIdQuery, Customer?>
{
    public async Task<Customer?> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
    {
        var customer = await customerRepository.GetByIdAsync(request.Id, cancellationToken);
        return customer;
    }
}