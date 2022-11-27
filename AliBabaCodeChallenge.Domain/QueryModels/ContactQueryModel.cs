using System.ComponentModel.DataAnnotations;

namespace AliBabaCodeChallenge.Domain.QueryModels
{
    public class ContactQueryModel
    {
        public string? Name { get;set; }
        public string? LastName { get;set; }
        
        [RegularExpression("^[0-9-]{1,12}$", ErrorMessage = "Please enter the correct format.")]
        public string? PhoneNumber { get;set; }
    }
}
