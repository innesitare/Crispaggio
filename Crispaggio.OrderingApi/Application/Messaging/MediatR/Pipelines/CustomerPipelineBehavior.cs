using CacheTower;
using Crispaggio.Domain.CustomerInfo;
using Crispaggio.OrderingApi.Application.Helpers;
using Crispaggio.OrderingApi.Application.Messaging.MediatR.Queries.Customers;
using MediatR;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.Pipelines;

internal sealed class CustomerPipelineBehavior(ICacheStack cacheStack) :
    IPipelineBehavior<GetCustomerByEmailQuery, Customer?>,
    IPipelineBehavior<GetCustomerByIdQuery, Customer?>
{
    public async Task<Customer?> Handle(GetCustomerByEmailQuery request, RequestHandlerDelegate<Customer?> next,
        CancellationToken cancellationToken)
    {
        return await cacheStack.GetOrSetAsync<Customer?>(
            CacheKeys.Customers.GetByEmail(request.Email),
            _ => next(),
            new CacheSettings(timeToLive: TimeSpan.FromMinutes(60), staleAfter: TimeSpan.FromMinutes(30))
        );
    }

    public async Task<Customer?> Handle(GetCustomerByIdQuery request, RequestHandlerDelegate<Customer?> next,
        CancellationToken cancellationToken)
    {
        return await cacheStack.GetOrSetAsync<Customer?>(
            CacheKeys.Customers.GetById(request.Id),
            _ => next(),
            new CacheSettings(timeToLive: TimeSpan.FromMinutes(60), staleAfter: TimeSpan.FromMinutes(30))
        );
    }
}