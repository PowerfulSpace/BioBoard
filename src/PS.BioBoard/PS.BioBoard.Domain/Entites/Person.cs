namespace PS.BioBoard.Domain.Entites
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Bio { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
    }
}
