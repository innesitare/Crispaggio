using Crispaggio.Domain.Orders;

namespace Crispaggio.Messages.Ordering.Responses;

public interface PaymentConfirmed
{
    public Order Order { get; }
}