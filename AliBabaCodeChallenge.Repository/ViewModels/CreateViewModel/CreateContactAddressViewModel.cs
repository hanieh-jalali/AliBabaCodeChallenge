using System.ComponentModel.DataAnnotations;

namespace AliBabaCodeChallenge.WebApi.ViewModels
{
    public class CreateContactAddressViewModel
    {
        [Required]
        public string Address { get; init; }
        public CreateContactAddressTypeViewModel ContactAddressType { get; set; }
    }
}