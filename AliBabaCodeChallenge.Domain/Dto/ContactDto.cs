using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AliBabaCodeChallenge.Domain.Dto
{
    public class ContactDto
    {
        public int Id {get; init;}
        public string Name { get; init; }
        public string LastName { get; init; }

        public List<ContactAddressDto> ContactAddresses { get; set; }
        public List<ContactPhoneNumberDto> ContactPhoneNumbers { get; set; }
    }
}