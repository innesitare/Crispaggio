using CacheTower;
using Crispaggio.OrderingApi.Application.Helpers;
using Crispaggio.OrderingApi.Application.Messaging.MediatR.Commands.Orders;
using MediatR.Pipeline;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.PostProcessors;

internal sealed class OrderPostProcessor(ICacheStack cacheStack) 
    : IRequestPostProcessor<CreateOrderCommand, bool>, IRequestPostProcessor<DeleteOrderByIdCommand, bool>
{
    public async Task Process(CreateOrderCommand request, bool response, CancellationToken cancellationToken)
    {
        if (!response)
        {
            return;
        } 
            
        await cacheStack.EvictAsync(CacheKeys.Orders.GetAll());
    }

    public async Task Process(DeleteOrderByIdCommand request, bool response, CancellationToken cancellationToken)
    {
        if (!response)
        {
            return;
        }
        
        await cacheStack.EvictAsync(CacheKeys.Orders.GetAll());
        await cacheStack.EvictAsync(CacheKeys.Orders.GetById(request.Id));
        await cacheStack.EvictAsync(CacheKeys.Orders.GetAllByCustomerId(request.CustomerId));
    }
}