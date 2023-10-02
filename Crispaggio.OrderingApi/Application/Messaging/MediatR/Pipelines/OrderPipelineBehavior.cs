using CacheTower;
using Crispaggio.Domain.Orders;
using Crispaggio.OrderingApi.Application.Helpers;
using Crispaggio.OrderingApi.Application.Messaging.MediatR.Queries.Orders;
using MediatR;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.Pipelines;

internal sealed class OrderPipelineBehavior(ICacheStack cacheStack) :
    IPipelineBehavior<GetAllOrdersQuery, IEnumerable<Order>>,
    IPipelineBehavior<GetAllOrdersByCustomerIdQuery, IEnumerable<Order>>,
    IPipelineBehavior<GetOrderByIdQuery, Order?>
{
    public async Task<IEnumerable<Order>> Handle(GetAllOrdersQuery request,
        RequestHandlerDelegate<IEnumerable<Order>> next,
        CancellationToken cancellationToken)
    {
        return await cacheStack.GetOrSetAsync<IEnumerable<Order>>(
            CacheKeys.Orders.GetAll(),
            _ => next(),
            new CacheSettings(timeToLive: TimeSpan.FromMinutes(60), staleAfter: TimeSpan.FromMinutes(30))
        );
    }

    public async Task<IEnumerable<Order>> Handle(GetAllOrdersByCustomerIdQuery request,
        RequestHandlerDelegate<IEnumerable<Order>> next, CancellationToken cancellationToken)
    {
        return await cacheStack.GetOrSetAsync<IEnumerable<Order>>(
            CacheKeys.Orders.GetAllByCustomerId(request.CustomerId),
            _ => next(),
            new CacheSettings(timeToLive: TimeSpan.FromMinutes(60), staleAfter: TimeSpan.FromMinutes(30))
        );
    }

    public async Task<Order?> Handle(GetOrderByIdQuery request, RequestHandlerDelegate<Order?> next,
        CancellationToken cancellationToken)
    {
        return await cacheStack.GetOrSetAsync<Order?>(
            CacheKeys.Orders.GetById(request.Id),
            _ => next(),
            new CacheSettings(timeToLive: TimeSpan.FromMinutes(60), staleAfter: TimeSpan.FromMinutes(30))
        );
    }
}