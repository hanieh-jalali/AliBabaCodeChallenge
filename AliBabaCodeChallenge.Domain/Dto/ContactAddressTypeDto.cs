namespace AliBabaCodeChallenge.Domain.Dto
{
    public class ContactAddressTypeDto
    {
        public int Id {get; init;}
        public string Description { get; init; }

        public List<ContactAddressDto> ContactAddress { get;set; }

    }
}