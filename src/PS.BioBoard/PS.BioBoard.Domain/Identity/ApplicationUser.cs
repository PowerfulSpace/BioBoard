namespace PS.BioBoard.Domain.Identity
{
    public class ApplicationUser : IdentityUser
    {
        // Дополнительные свойства пользователя
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }


        // Свойство для отображения полного имени
        public string FullName => $"{FirstName} {LastName}";


        // Дополнительные метаданные пользователя
        public string ProfilePictureUrl { get; set; } = null!;
        public string Bio { get; set; } = null!;
    }
}
