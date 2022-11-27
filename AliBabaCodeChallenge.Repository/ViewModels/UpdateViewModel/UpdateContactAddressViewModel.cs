namespace AliBabaCodeChallenge.WebApi.ViewModels
{
    public class UpdateContactAddressViewModel
    {
        public long Id { get;set; }
        public string Address { get; init; }
        public UpdateContactAddressTypeViewModel ContactAddressType { get;set; }
    }
}