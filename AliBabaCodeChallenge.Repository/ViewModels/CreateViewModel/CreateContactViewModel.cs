using System.ComponentModel.DataAnnotations;

namespace AliBabaCodeChallenge.WebApi.ViewModels
{
    public class CreateContactViewModel
    {
        [Required]
        public string Name { get; init; }
        
        [Required]
        public string LastName { get; init; }

        public List<CreateContactAddressViewModel> ContactAddresses { get; init; }
        public List<CreateContactPhoneNumberViewModel> ContactPhoneNumbers { get; init; }

    }
}