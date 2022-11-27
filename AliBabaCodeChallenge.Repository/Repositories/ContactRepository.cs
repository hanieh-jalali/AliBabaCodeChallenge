using AliBabaCodeChallenge.Domain;
using AliBabaCodeChallenge.Domain.IRepositories;
using AliBabaCodeChallenge.Domain.Models;
using AliBabaCodeChallenge.Domain.QueryModels;
using Microsoft.EntityFrameworkCore;

namespace AliBabaCodeChallenge.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly AliBabaDbContext dbcontext;

        public ContactRepository(AliBabaDbContext _dbcontext)
        {
            dbcontext = _dbcontext;
        }

        public async Task<Contact> GetAsync(int id)
        {
            return await dbcontext.contacts
            .Include(c => c.ContactAddresses).ThenInclude(t => t.ContactAddressType)
            .Include(c => c.ContactPhoneNumbers).ThenInclude(t => t.ContactPhoneNumberType)
            .Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Contact>> GetAllAsync()
        {
            var contacts = await dbcontext.contacts
                .Include(c => c.ContactAddresses).ThenInclude(t => t.ContactAddressType)
                .Include(c => c.ContactPhoneNumbers).ThenInclude(t => t.ContactPhoneNumberType)
                .ToListAsync();
            return contacts;
        }

        public async Task<int> InsertAsync(Contact contact)
        {
            try
            {
                dbcontext.Entry(contact.ContactAddresses[0].ContactAddressType).State = EntityState.Unchanged;
                dbcontext.Entry(contact.ContactPhoneNumbers[0].ContactPhoneNumberType).State = EntityState.Unchanged;
                await dbcontext.AddAsync(contact);
                var id = await dbcontext.SaveChangesAsync();

                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Contact>> SearchAsync(ContactQueryModel model)
        {
            var contacts = new List<Contact>();

            model.Name = model.Name?.Replace('ي', 'ی');
            model.Name = model.Name?.Replace('ك', 'ک');

            model.LastName = model.LastName?.Replace('ي', 'ی');
            model.LastName = model.LastName?.Replace('ك', 'ک');

            contacts = await dbcontext.contacts
            .Include(c => c.ContactAddresses).ThenInclude(t => t.ContactAddressType)
            .Include(c => c.ContactPhoneNumbers).ThenInclude(t => t.ContactPhoneNumberType)
            .Where(c => c.Name.Contains(model.Name) || c.LastName.Contains(model.LastName)).ToListAsync();

            var contactPhoneNumbers = await dbcontext.contactsPhonenNumber
            .Include(c => c.ContactPhoneNumberType)
            .Include(t => t.Contact)
            .ThenInclude(c => c.ContactAddresses)
            .ThenInclude(t => t.ContactAddressType)
            .Where(w => w.PhoneNumber.Contains(model.PhoneNumber)).ToListAsync();

            foreach (var contactPhoneNumber in contactPhoneNumbers)
            {
                var foundContact = contacts.Where(c => c.Id == contactPhoneNumber.Contact.Id).FirstOrDefault();

                if (foundContact is null)
                    contacts.Add(contactPhoneNumber.Contact);
            }

            return contacts;
        }

        public bool Update(Contact contact)
        {
            foreach (var contactPhoneNumber in contact.ContactPhoneNumbers)
                dbcontext.Entry(contactPhoneNumber.ContactPhoneNumberType).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;

            foreach (var contactPhoneNumber in contact.ContactAddresses)
                dbcontext.Entry(contactPhoneNumber.ContactAddressType).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;

            dbcontext.contacts.Update(contact);
            var success = dbcontext.SaveChanges();

            if (success > 0)
                return true;

            return false;
        }
        public bool Delete(int contactId)
        {
            var contactresult = dbcontext.contacts
            .Include(c => c.ContactAddresses).ThenInclude(t => t.ContactAddressType)
            .Include(c => c.ContactPhoneNumbers).ThenInclude(t => t.ContactPhoneNumberType)
            .Where(x => x.Id == contactId).FirstOrDefault();

            if (contactresult is not null)
            {
                dbcontext.Entry(contactresult).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                dbcontext.Remove<Contact>(contactresult);
                dbcontext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}