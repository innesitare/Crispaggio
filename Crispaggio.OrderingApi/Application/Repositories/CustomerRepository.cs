using Crispaggio.Domain.CustomerInfo;
using Crispaggio.OrderingApi.Application.Repositories.Abstractions;
using Crispaggio.OrderingApi.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Crispaggio.OrderingApi.Application.Repositories;

internal sealed class CustomerRepository(IOrderingDbContext orderingDbContext) : ICustomerRepository
{
    public async Task<Customer?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var customer = await orderingDbContext.Customers.FindAsync(new object?[] {id}, cancellationToken);
        return customer;
    }

    public async Task<Customer?> GetByEmailAsync(string email, CancellationToken cancellationToken)
    {
        var customer = await orderingDbContext.Customers.FirstOrDefaultAsync(c => c.Email == email, cancellationToken);
        return customer;
    }
}