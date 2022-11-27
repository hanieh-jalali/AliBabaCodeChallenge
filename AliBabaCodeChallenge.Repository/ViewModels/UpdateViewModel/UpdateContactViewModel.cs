using System.ComponentModel.DataAnnotations;

namespace AliBabaCodeChallenge.WebApi.ViewModels
{
    public class UpdateContactViewModel
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string LastName { get; init; }

        public List<UpdateContactAddressViewModel> ContactAddresses { get; init; }
        public List<UpdateContactPhoneNumberViewModel> ContactPhoneNumbers { get; init; }

    }
}