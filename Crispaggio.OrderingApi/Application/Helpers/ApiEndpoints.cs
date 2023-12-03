namespace Crispaggio.OrderingApi.Application.Helpers;

internal static class ApiEndpoints
{
    private const string ApiBase = "/api";

    public static class Customers
    {
        private const string Base = $"{ApiBase}/customers";

        public const string Get = $"{Base}/{{id:guid}}";
        public const string GetByEmail = $"{Base}/{{email}}";
    }
    
    public static class Orders
    {
        private const string Base = $"{ApiBase}/customers/{{customerId:guid}}/orders";

        public const string Create = Base;
        public const string GetAll = Base;
        public const string Get = $"{Base}/{{id:guid}}";
        public const string Delete = $"{Base}/{{id:guid}}";
    }
}