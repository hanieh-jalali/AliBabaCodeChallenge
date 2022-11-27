using AliBabaCodeChallenge.Domain.Models;
using Domain.FluentAPIConfigurations;
using Microsoft.EntityFrameworkCore;

namespace AliBabaCodeChallenge.Domain
{
    public class AliBabaDbContext : DbContext
    {
        //inject
        public AliBabaDbContext(DbContextOptions<AliBabaDbContext> options) : base(options)
        {
        }

        public DbSet<Contact> contacts => Set<Contact>();
        public DbSet<ContactAddress> contactsAddress => Set<ContactAddress>();
        public DbSet<ContactPhoneNumber> contactsPhonenNumber => Set<ContactPhoneNumber>();
        public DbSet<ContactAddressType> contactsAddressType => Set<ContactAddressType>();
        public DbSet<ContactPhoneNumberType> contactsPhoneNumberType => Set<ContactPhoneNumberType>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactEntityConfiguration());

            modelBuilder.Entity<ContactAddress>()
                        .HasOne(h => h.Contact)
                        .WithMany(c => c.ContactAddresses);

            modelBuilder.Entity<ContactAddress>()
                        .HasOne(h => h.ContactAddressType)
                        .WithMany(c => c.ContactAddress);

            modelBuilder.Entity<ContactPhoneNumber>()
                        .HasOne(h => h.Contact)
                        .WithMany(c => c.ContactPhoneNumbers);

            modelBuilder.Entity<ContactPhoneNumber>()
                        .HasOne(h => h.ContactPhoneNumberType)
                        .WithMany(c => c.ContactPhoneNumber);

            modelBuilder.Entity<ContactAddressType>()
            .HasData(new ContactAddressType() { Id = 1, Description = "منزل" }
                    , new ContactAddressType() { Id = 2, Description = "اداره" }
                    , new ContactAddressType() { Id = 3, Description = "شرکت" });

            modelBuilder.Entity<ContactAddressType>()
            .HasData(new ContactAddressType() { Id = 1, Description = "ثابت" }
                    , new ContactAddressType() { Id = 2, Description = "همراه" }
                    , new ContactAddressType() { Id = 3, Description = "محل کار" });

        }
    }
}
