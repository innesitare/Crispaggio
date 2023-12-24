namespace Crispaggio.OrderingApi.Application.Helpers;

public static class CacheKeys
{
    public sealed class Customers
    {
        public static string GetByEmail(string email) => $"customer-{email}";
        public static string GetById(Guid employeeId) => $"customer-{employeeId}";
    }
    
    public sealed class Orders
    {
        public static string GetAll() => $"orders-all";
        public static string GetAllByCustomerId(Guid customerId) => $"customer-{customerId}-orders-all";
        public static string GetById(Guid id) => $"order-{id}";
    }
}