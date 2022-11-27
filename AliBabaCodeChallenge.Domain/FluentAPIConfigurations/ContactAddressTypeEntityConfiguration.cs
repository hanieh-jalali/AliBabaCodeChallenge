using AliBabaCodeChallenge.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.FluentAPIConfigurations;
public class ContactAddressTypeEntityConfiguration : IEntityTypeConfiguration<ContactAddressType>
{
    public void Configure(EntityTypeBuilder<ContactAddressType> builder)
    {
        builder.ToTable("ContactAddressType");

        builder.HasKey(s => s.Id);
        builder.Property(c => c.Description)
                .HasColumnName("Description")
                .HasMaxLength(256)
                .HasColumnOrder(1);
    }
}
