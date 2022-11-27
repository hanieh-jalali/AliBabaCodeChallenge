using AliBabaCodeChallenge.Domain.Dto;
using AliBabaCodeChallenge.Domain.Models;
using AutoMapper;
using AliBabaCodeChallenge.Domain.IRepositories;
using AliBabaCodeChallenge.Domain.QueryModels;

public class ContactService : IContactService
{
    private readonly IContactRepository contactRepository;
    private readonly IMapper mapper;
    public ContactService(IContactRepository _contactRepository, IMapper mapper)
    {
        this.contactRepository = _contactRepository;
        this.mapper = mapper;
    }
    public async Task<ContactDto> Add(ContactDto model)
    {
        var contact = mapper.Map<Contact>(model);
        var contactId = await contactRepository.InsertAsync(contact);
        var contactDto = mapper.Map<ContactDto>(contactRepository.GetAllAsync().Result.OrderByDescending(o => o.Id).FirstOrDefault());

        return contactDto;
    }

    public async Task<ContactDto> Get(int id)
    {
        var contact = await contactRepository.GetAsync(id);
        var contactDto = mapper.Map<ContactDto>(contact);

        return contactDto;
    }

    public async Task<List<ContactDto>> GetAll()
    {
        var contactList = new List<ContactDto>();
        var contacts = await contactRepository.GetAllAsync();
        foreach (var item in contacts)
            contactList.Add(mapper.Map<ContactDto>(item));

        return contactList;
    }

    public async Task<List<ContactDto>> SearchAsync(ContactQueryModel model)
    {
        var result = await contactRepository.SearchAsync(model);
        var contactDtos = mapper.Map<List<ContactDto>>(result);

        return contactDtos;
    }

    public bool Update(ContactDto contactDto)
    {
        var contactResult = contactRepository.Update(mapper.Map<Contact>(contactDto));
        return contactResult;
    }
    public bool Delete(int contactId)
    {
        var result = contactRepository.Delete(contactId);
        return result;
    }
}
