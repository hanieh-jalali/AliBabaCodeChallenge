using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AliBabaCodeChallenge.Domain.Dto
{
    public class ContactAddressDto
    {
        public int Id {get; init;}
        public string Address { get; init; }

        public ContactDto Contact { get;set; }
        public ContactAddressTypeDto ContactAddressType {get;set;}
    }
}