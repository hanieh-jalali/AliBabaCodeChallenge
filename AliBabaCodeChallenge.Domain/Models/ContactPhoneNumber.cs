namespace AliBabaCodeChallenge.Domain.Models
{
    public class ContactPhoneNumber 
    {
        public long Id {get; init;}
        public string PhoneNumber { get; init; }
        public long ContactPhoneNumberTypeId { get;set; }

        public Contact Contact { get;init; }
        public ContactPhoneNumberType ContactPhoneNumberType { get;init; }
    }
}