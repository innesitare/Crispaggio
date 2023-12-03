using Crispaggio.IdentityApi.Application.Services.Abstractions;
using Crispaggio.Messages.Mailing;
using Firebase.Auth;
using MassTransit;

namespace Crispaggio.IdentityApi.Application.Services;

public sealed class AuthService(IFirebaseAuthClient firebaseAuthClient, ISendEndpointProvider sender) : IAuthService
{
    public async Task<string?> RegisterAsync(string email, string password, CancellationToken cancellationToken)
    {
        var userCredentials = await firebaseAuthClient.CreateUserWithEmailAndPasswordAsync(email, password);
        if (userCredentials is not null)
        {
            var sendEndpoint = await sender.GetSendEndpoint(new Uri("queue:user-registration-completed"));
            await sendEndpoint.Send<UserRegistrationCompleted>(new {Email = email}, cancellationToken);
            
            return await userCredentials.User.GetIdTokenAsync();
        }

        return null;
    }

    public async Task<string?> LoginAsync(string email, string password, CancellationToken cancellationToken)
    {
        var userCredentials = await firebaseAuthClient.SignInWithEmailAndPasswordAsync(email, password);
        
        return userCredentials is null 
            ? null 
            : await userCredentials.User.GetIdTokenAsync();
    }
}