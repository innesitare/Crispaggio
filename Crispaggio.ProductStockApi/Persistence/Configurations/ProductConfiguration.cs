using Crispaggio.ProductStockApi.Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crispaggio.ProductStockApi.Persistence.Configurations;

public sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products")
            .HasKey(p => p.Id);
        
        builder.Property(p => p.Id)
            .IsUnicode(false)
            .IsRequired();

        builder.Property(p => p.Image)
            .IsRequired();
        
        builder.Property(p => p.Title)
            .HasMaxLength(64)
            .IsUnicode(false)
            .IsRequired();
        
        builder.Property(p => p.Description)
            .HasMaxLength(250)
            .IsUnicode(false)
            .IsRequired();

        builder.Property(p => p.Price)
            .IsRequired();

        builder.Property(p => p.Rating)
            .IsRequired();

        builder.Property(p => p.Quantity)
            .IsRequired();

        builder.HasMany(p => p.Topics)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);
    }
}