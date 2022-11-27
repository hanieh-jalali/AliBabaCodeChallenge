using AliBabaCodeChallenge.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.FluentAPIConfigurations;
public class ContacyPhoneNumberTypeEntityConfiguration : IEntityTypeConfiguration<ContactPhoneNumberType>
{
    public void Configure(EntityTypeBuilder<ContactPhoneNumberType> builder)
    {
        builder.ToTable("ContactPhoneNumberType");

        builder.HasKey(s => s.Id);
        builder.Property(c => c.Description)
                .HasColumnName("Description")
                .HasMaxLength(256)
                .HasColumnOrder(1);
    }
}
