namespace Crispaggio.Domain.Orders;

public enum OrderStatus
{
    Submitted,
    WaitingPayment,
    Paid,
    Pending,
    Completed,
    Canceled
}