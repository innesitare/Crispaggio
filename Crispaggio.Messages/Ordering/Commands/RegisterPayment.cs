using Crispaggio.Domain.Orders;

namespace Crispaggio.Messages.Ordering.Commands;

public interface RegisterPayment
{
    Order Order { get; }
}