using Crispaggio.Domain.CustomerInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crispaggio.OrderingApi.Persistence.Configurations;

public sealed class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customers")
            .HasKey(c => c.Id);
        
        builder.Property(x => x.Id)
            .IsRequired()
            .IsUnicode(false);
        
        builder.Property(c => c.PartyGroupId)
            .IsRequired()
            .IsUnicode(false);

        builder.Property(c => c.Username)
            .IsRequired()
            .IsUnicode(false)
            .HasMaxLength(50);

        builder.Property(c => c.Email)
            .IsRequired()
            .IsUnicode(false)
            .HasMaxLength(50);

        builder.Property(c => c.LoyaltyPoints)
            .IsRequired();

        builder.HasMany(c => c.Friends)
            .WithOne();

        builder.HasMany(c => c.DeliveryAddresses)
            .WithOne()
            .HasForeignKey("CustomerId")
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(c => c.Orders)
            .WithOne()
            .HasForeignKey(o => o.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}