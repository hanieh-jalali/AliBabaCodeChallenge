using System.ComponentModel.DataAnnotations;

namespace AliBabaCodeChallenge.WebApi.ViewModels
{
    public class ContactViewModel
    {
        public int Id { get;init; }
        public string Name { get; init; }
        public string LastName { get; init; }

        public List<ContactAddressViewModel> ContactAddresses { get;init; }
        public List<ContactPhoneNumberViewModel> ContactPhoneNumbers { get;init; }

    }
}