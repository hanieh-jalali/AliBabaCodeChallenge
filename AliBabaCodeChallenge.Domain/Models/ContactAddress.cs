
namespace AliBabaCodeChallenge.Domain.Models
{
    public class ContactAddress
    {
        public long Id {get; init;}
        public string Address { get; init; }
        public long ContactAddressTypeId { get;set; }

        public Contact Contact { get;set; }
        public ContactAddressType ContactAddressType {get;set;}

    }
}