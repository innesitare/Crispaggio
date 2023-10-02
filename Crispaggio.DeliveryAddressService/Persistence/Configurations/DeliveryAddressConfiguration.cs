using Crispaggio.Domain.CustomerInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crispaggio.DeliveryAddressService.Persistence.Configurations;

public sealed class DeliveryAddressConfiguration : IEntityTypeConfiguration<DeliveryAddress>
{
    public void Configure(EntityTypeBuilder<DeliveryAddress> builder)
    {
        builder.ToTable("DeliveryAddresses")
            .HasKey(d => d.Id);
        
        builder.Property(d => d.Id)
            .IsRequired()
            .IsUnicode(false);
        
        builder.Property(d => d.Postcode)
            .IsRequired()
            .IsUnicode(false);
        
        builder.Property(d => d.HouseNumber)
            .IsRequired()
            .IsUnicode(false);
        
        builder.Property(d => d.UnitNumber)
            .IsRequired();
    }
}