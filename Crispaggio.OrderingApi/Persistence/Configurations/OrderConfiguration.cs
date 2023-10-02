using Crispaggio.Domain.CustomerInfo;
using Crispaggio.Domain.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crispaggio.OrderingApi.Persistence.Configurations;

public sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders")
            .HasKey(o => o.Id);
        
        builder.Property(o => o.Id)
            .IsRequired()
            .IsUnicode(false);

        builder.Property(o => o.CustomerId)
            .IsRequired()
            .IsUnicode(false);

        builder.Property(o => o.OrderStatus)
            .IsRequired();
        
        builder.HasMany(x => x.OrderItems)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);
    }
}