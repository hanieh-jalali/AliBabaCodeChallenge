using AliBabaCodeChallenge.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.FluentAPIConfigurations;
public class ContactEntityConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("Contacts");

        builder.HasKey(s => s.Id);
      
        builder.Property(c => c.Name)
                .HasColumnName("Name")
                .HasMaxLength(256)
                .HasColumnOrder(1);
                
        builder.Property(c => c.LastName)
        .HasColumnName("LastName")
        .HasMaxLength(256)
        .HasColumnOrder(2);
    }
}
