using Crispaggio.Core.Messaging.Abstractions;
using Crispaggio.Messages.Ordering.Commands;
using Crispaggio.OrderingApi.Application.Repositories.Abstractions;
using MassTransit;
using MediatR;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.Commands.Orders.Handlers;

internal sealed class CreateOrderCommandHandler(IOrderRepository orderRepository, IPublishEndpoint publisher)
    : ICommandHandler<CreateOrderCommand, bool>
{
    public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        bool created = await orderRepository.CreateAsync(request.Order, cancellationToken);
        if (created)
        {
            await publisher.Publish<SubmitOrder>(new
            {
                request.Order
            }, cancellationToken);
        }
        
        return created;
    }
}