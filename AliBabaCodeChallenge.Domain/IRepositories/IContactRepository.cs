using AliBabaCodeChallenge.Domain.Models;
using AliBabaCodeChallenge.Domain.QueryModels;

namespace AliBabaCodeChallenge.Domain.IRepositories
{
    public interface IContactRepository
    {
        Task<Contact> GetAsync(int id);
        Task<List<Contact>> GetAllAsync();
        Task<int> InsertAsync(Contact contact);
        Task<List<Contact>> SearchAsync(ContactQueryModel model);
        bool Update(Contact contact);
        bool Delete(int id);
    }
}
