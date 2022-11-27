namespace AliBabaCodeChallenge.Domain.Models
{
    public class ContactPhoneNumberType
    {
        public long Id {get; init;}  

        public string Description { get; init; }

        public List<ContactPhoneNumber> ContactPhoneNumber { get;init; }
    }
}