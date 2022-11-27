using AliBabaCodeChallenge.Domain.Dto;
using AliBabaCodeChallenge.Domain.Models;
using AliBabaCodeChallenge.WebApi.ViewModels;
using AutoMapper;

namespace AliBabaCodeChallenge.Repository
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
 
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<CreateContactViewModel, ContactDto>().ForMember(c => c.Id ,cc => cc.Ignore()).ReverseMap();
            CreateMap<ContactDto, ContactViewModel>().ReverseMap();
            CreateMap<ContactDto, UpdateContactViewModel>().ReverseMap();

            CreateMap<ContactAddress, ContactAddressDto>().ReverseMap();
            CreateMap<CreateContactAddressViewModel, ContactAddressDto>().ForMember(c => c.Id ,cc => cc.Ignore()).ReverseMap();
            CreateMap<ContactAddressViewModel, ContactAddressDto>().ReverseMap();
            CreateMap<UpdateContactAddressViewModel, ContactAddressDto>().ReverseMap();

            CreateMap<ContactPhoneNumber, ContactPhoneNumberDto>().ReverseMap();
            CreateMap<CreateContactPhoneNumberViewModel, ContactPhoneNumberDto>().ForMember(c => c.Id ,cc => cc.Ignore()).ReverseMap();
            CreateMap<ContactPhoneNumberViewModel, ContactPhoneNumberDto>().ReverseMap();
            CreateMap<UpdateContactPhoneNumberViewModel, ContactPhoneNumberDto>().ReverseMap();

            CreateMap<ContactAddressType, ContactAddressTypeDto>().ReverseMap();
            CreateMap<CreateContactAddressTypeViewModel, ContactAddressTypeDto>()
                .ForMember(c => c.Id, cc => cc.MapFrom(i => i.AddressTypeId)).ReverseMap();
            CreateMap<ContactAddressTypeViewModel, ContactAddressTypeDto>().ReverseMap();
            CreateMap<UpdateContactAddressTypeViewModel, ContactAddressTypeDto>().ForMember(c => c.Description ,cc => cc.Ignore()).ReverseMap();

            CreateMap<ContactPhoneNumberType, ContactPhoneNumberTypeDto>().ReverseMap();
            CreateMap<CreateContactPhoneNumberTypeViewModel, ContactPhoneNumberTypeDto>()
                .ForMember(c => c.Id, cc => cc.MapFrom(i => i.PhoneNumberTypeId)).ReverseMap();
            CreateMap<ContactPhoneNumberTypeViewModel, ContactPhoneNumberTypeDto>().ReverseMap();
            CreateMap<UpdateContactPhoneNumberTypeViewModel, ContactPhoneNumberTypeDto>().ForMember(c => c.Description ,cc => cc.Ignore()).ReverseMap().ReverseMap();
        }
    }
}
