using Azure.Identity;
using Crispaggio.Core.Managers;
using Microsoft.Extensions.Configuration;

namespace Crispaggio.Core.Extensions;

public static class AzureKeyVaultExtensions
{
    public static IConfigurationBuilder AddAzureKeyVault(this IConfigurationBuilder configurationBuilder)
    {
        return configurationBuilder.AddEnvironmentVariables()
            .AddAzureKeyVault(new Uri($"https://{Environment.GetEnvironmentVariable("AZURE_VAULT_NAME")}.vault.azure.net/"),
                new EnvironmentCredential(),
                new PrefixKeyVaultSecretManager("Crispaggio"));
    }  
}