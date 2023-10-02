using Crispaggio.Domain.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crispaggio.OrderItemApi.Persistence.Configurations;

public sealed class TopicConfiguration : IEntityTypeConfiguration<Topic>
{
    public void Configure(EntityTypeBuilder<Topic> builder)
    {
        builder.ToTable("Topics")
            .HasKey(t => t.Id);

        builder.Property(t => t.Id)
            .IsUnicode(false)
            .IsRequired();
        
        builder.Property(t => t.Title)
            .IsRequired()
            .IsUnicode(false)
            .HasMaxLength(50);

        builder.Property(t => t.Price)
            .IsRequired();
    }
}