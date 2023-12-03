namespace Crispaggio.EmailService.Application.Services.Abstractions;

public interface IEmailService
{
    Task<bool> UserRegistrationCompletedAsync(string email, CancellationToken cancellationToken);

    Task<bool> SendOrderReadyAsync(string email, Guid orderId, CancellationToken cancellationToken);
}