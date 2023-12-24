using Crispaggio.Domain.Orders;

namespace Crispaggio.Messages.Ordering.Commands;

public interface ConfirmStock
{
    public Order Order { get; }
}