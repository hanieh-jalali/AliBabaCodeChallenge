namespace AliBabaCodeChallenge.WebApi.ViewModels
{
    public class ContactPhoneNumberViewModel
    {
        public long Id { get;set; }
        public string PhoneNumber { get; init; }
        public ContactPhoneNumberTypeViewModel ContactPhoneNumberType { get;set; }
    }
}