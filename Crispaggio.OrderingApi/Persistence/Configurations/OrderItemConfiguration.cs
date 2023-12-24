using Crispaggio.Domain.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crispaggio.OrderingApi.Persistence.Configurations;

public sealed class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.ToTable("OrderItems")
            .HasKey(o => o.Id);

        builder.Property(o => o.Id)
            .IsUnicode(false)
            .IsRequired();
        
        builder.Property(o => o.Title)
            .HasMaxLength(64)
            .IsUnicode(false)
            .IsRequired();
        
        builder.Property(o => o.Description)
            .HasMaxLength(250)
            .IsUnicode(false)
            .IsRequired();

        builder.Property(o => o.Price)
            .IsRequired();

        builder.Property(o => o.Rating)
            .IsRequired();

        builder.HasMany(o => o.Topics)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);
    }
}