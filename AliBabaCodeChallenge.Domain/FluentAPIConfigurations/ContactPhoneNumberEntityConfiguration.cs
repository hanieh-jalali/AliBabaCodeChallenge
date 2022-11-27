using AliBabaCodeChallenge.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.FluentAPIConfigurations;
public class ContactPhoneNumberEntityConfiguration : IEntityTypeConfiguration<ContactPhoneNumber>
{
    public void Configure(EntityTypeBuilder<ContactPhoneNumber> builder)
    {
        builder.ToTable("ContactPhoneNumber");

        builder.HasKey(s => s.Id);
        builder.Property(c => c.PhoneNumber)
                .HasColumnName("PhoneNumber")
                .HasMaxLength(256)
                .HasColumnOrder(1);
    }
}
