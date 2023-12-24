using Crispaggio.Domain.CustomerInfo;

namespace Crispaggio.OrderingApi.Application.Repositories.Abstractions;

public interface ICustomerRepository
{
    Task<Customer?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    
    Task<Customer?> GetByEmailAsync(string email, CancellationToken cancellationToken);
}