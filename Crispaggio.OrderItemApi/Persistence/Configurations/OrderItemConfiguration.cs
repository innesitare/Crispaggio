using Crispaggio.Domain.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crispaggio.OrderItemApi.Persistence.Configurations;

public sealed class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.ToTable("OrderItems")
            .HasKey(o => o.Id);

        builder.Property(o => o.Image)
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
            .IsUnicode(false)
            .IsUnicode();
        
        builder.Property(o => o.Rating)
            .IsUnicode(false)
            .IsUnicode();

        builder
            .HasMany(o => o.Topics)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(o => o.Id)
            .IsUnique()
            .IsDescending(false);
    }
}