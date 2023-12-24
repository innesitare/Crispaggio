using Crispaggio.Core.Messaging.Abstractions;
using Crispaggio.Domain.CustomerInfo;
using Crispaggio.OrderingApi.Application.Repositories.Abstractions;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.Queries.Customers.Handlers;

internal sealed class GetCustomerByEmailQueryHandler(ICustomerRepository customerRepository)
    : IQueryHandler<GetCustomerByEmailQuery, Customer?>
{
    public async Task<Customer?> Handle(GetCustomerByEmailQuery request, CancellationToken cancellationToken)
    {
        var customer = await customerRepository.GetByEmailAsync(request.Email, cancellationToken);
        return customer;
    }
}