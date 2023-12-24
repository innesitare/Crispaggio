using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Crispaggio.Core.Extensions;

public static class JwtBearerExtensions
{
    public static IServiceCollection AddJwtBearer(this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        serviceCollection.AddAuthorization(options =>
        {
            options.AddPolicy("Bearer", policyBuilder =>
            {
                policyBuilder.AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme);
                policyBuilder.RequireAuthenticatedUser().Build();
            });
        })
        .AddAuthentication(options =>
        {
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer("Bearer", options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,

                ValidAudience = configuration["Jwt:Audience"],
                ValidIssuer = configuration["Jwt:Issuer"],
            };
        });

        return serviceCollection;
    }
}