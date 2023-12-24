using Firebase.Auth;
using Firebase.Auth.Providers;

namespace Crispaggio.IdentityApi.Application.Extensions;

public static class FirebaseExtensions
{
    public static void AddFirebaseAuth(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        var config = new FirebaseAuthConfig
        {
            ApiKey = configuration["Firebase:ApiKey"],
            AuthDomain = configuration["Firebase:AuthDomain"],
            Providers = new FirebaseAuthProvider[]
            {
                new EmailProvider()
            }
        };

        serviceCollection.AddScoped<IFirebaseAuthClient, FirebaseAuthClient>(_ => new FirebaseAuthClient(config));
    }
}