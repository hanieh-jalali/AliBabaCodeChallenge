using AliBabaCodeChallenge.Domain.Models;
using AliBabaCodeChallenge.Domain.Dto;
using AliBabaCodeChallenge.Domain.QueryModels;

public interface IContactService
{
    Task<List<ContactDto>> GetAll();
    Task<ContactDto> Get(int id);
    Task<ContactDto> Add(ContactDto model);
    Task<List<ContactDto>> SearchAsync(ContactQueryModel model);
    bool Update(ContactDto model);
    bool Delete(int id);
}