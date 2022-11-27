namespace AliBabaCodeChallenge.Domain.Dto
{
    public class ContactPhoneNumberDto
    {
        public int Id {get; init;}
        public string PhoneNumber { get; init; }

        public ContactDto Contact { get;set; }
        public ContactPhoneNumberTypeDto ContactPhoneNumberType { get;set; }
   
    }
}