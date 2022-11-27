namespace AliBabaCodeChallenge.WebApi.ViewModels
{
    public class ContactAddressViewModel
    {
        public long Id { get;set; }
        public string Address { get; init; }
        public ContactAddressTypeViewModel ContactAddressType { get;set; }
    }
}