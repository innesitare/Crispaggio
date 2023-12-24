namespace Crispaggio.IdentityApi.Application.Services.Abstractions;

public interface IAuthService
{
    Task<string?> RegisterAsync(string email, string password, CancellationToken cancellationToken);
    
    Task<string?> LoginAsync(string email, string password, CancellationToken cancellationToken);
}
