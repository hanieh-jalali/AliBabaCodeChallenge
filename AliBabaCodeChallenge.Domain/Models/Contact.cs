using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AliBabaCodeChallenge.Domain.Models
{
    public class Contact
    {
        public int Id {get; init;}
        public string Name { get; init; }
        public string LastName { get; init; }

        public List<ContactAddress> ContactAddresses { get;set; }
        public List<ContactPhoneNumber> ContactPhoneNumbers { get;set; }
    }
}