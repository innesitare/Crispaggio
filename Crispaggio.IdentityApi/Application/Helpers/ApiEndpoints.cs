namespace Crispaggio.IdentityApi.Application.Helpers;

internal static class ApiEndpoints
{
    private const string ApiBase = "/api";
    
    public static class Auth
    {
        public const string Login = $"{ApiBase}/login";
        public const string Register = $"{ApiBase}/register";
    }
}