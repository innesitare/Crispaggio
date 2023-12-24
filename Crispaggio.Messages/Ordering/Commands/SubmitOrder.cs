using Crispaggio.Domain.Orders;

namespace Crispaggio.Messages.Ordering.Commands;

public interface SubmitOrder
{
    Order Order { get; }
}