using Crispaggio.Domain.CustomerInfo;
using Microsoft.EntityFrameworkCore;

namespace Crispaggio.DeliveryAddressService.Persistence;

public interface IDeliveryAddressDbContext
{
    public DbSet<DeliveryAddress> DeliveryAddresses { get; init; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}