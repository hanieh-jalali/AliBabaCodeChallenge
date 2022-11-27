namespace AliBabaCodeChallenge.Domain.Dto
{
    public class ContactPhoneNumberTypeDto
    {
        public int Id {get; init;}

        public string Description { get; init; }

        public List<ContactPhoneNumberDto> ContactPhoneNumber { get;set; }

    }
}