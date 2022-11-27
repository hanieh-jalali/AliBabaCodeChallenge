using AliBabaCodeChallenge.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.FluentAPIConfigurations;
public class ContactAddressEntityConfiguration : IEntityTypeConfiguration<ContactAddress>
{
    public void Configure(EntityTypeBuilder<ContactAddress> builder)
    {
        builder.ToTable("ContactAddress");

        builder.HasKey(s => s.Id);
        builder.Property(c => c.Address)
                .HasColumnName("Address")
                .HasMaxLength(256)
                .HasColumnOrder(1);
    }
}
