
namespace AliBabaCodeChallenge.Domain.Models
{
    public class ContactAddressType
    {
        public long Id {get; init;}
        public string Description { get; init; }

        public List<ContactAddress> ContactAddress { get;set; }
    }
}