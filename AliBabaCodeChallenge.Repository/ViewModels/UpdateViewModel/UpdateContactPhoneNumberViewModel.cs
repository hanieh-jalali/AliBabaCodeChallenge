using System.ComponentModel.DataAnnotations;

namespace AliBabaCodeChallenge.WebApi.ViewModels
{
    public class UpdateContactPhoneNumberViewModel
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Enter Phone type and a phone number below")]
        [RegularExpression("^[0-9-]{1,12}$", ErrorMessage = "Please enter the correct format.")]
        public string PhoneNumber { get; init; }
        public UpdateContactPhoneNumberTypeViewModel ContactPhoneNumberType { get; set; }
    }
}