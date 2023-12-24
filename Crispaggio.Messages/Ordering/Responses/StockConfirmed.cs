using Crispaggio.Domain.Orders;

namespace Crispaggio.Messages.Ordering.Responses;

public interface StockConfirmed
{
    public Order Order { get; }
}