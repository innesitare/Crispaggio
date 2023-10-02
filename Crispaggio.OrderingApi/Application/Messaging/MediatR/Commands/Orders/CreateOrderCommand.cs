using Crispaggio.Core.Messaging.Abstractions;
using Crispaggio.Domain.Orders;

namespace Crispaggio.OrderingApi.Application.Messaging.MediatR.Commands.Orders;

public sealed class CreateOrderCommand : ICommand<bool>
{
    public required Order Order { get; init; }
}