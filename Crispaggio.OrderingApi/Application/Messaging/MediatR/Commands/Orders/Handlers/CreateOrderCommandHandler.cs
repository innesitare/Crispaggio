using Crispaggio.Core.Messaging.Abstractions;
using Crispaggio.OrderingApi.Application.Repositories.Abstractions;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.Commands.Orders.Handlers;

internal sealed class CreateOrderCommandHandler(IOrderRepository orderRepository)
    : ICommandHandler<CreateOrderCommand, bool>
{
    public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        bool created = await orderRepository.CreateAsync(request.Order, cancellationToken);
        return created;
    }
}