namespace AlgoHub.DAL.Entities
{
    public class User : IEntity
    {
        public int? Id { get; set; }

        public string Email { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public string? FullName { get; set; }

        public DateTime? CreationDate { get; set; }

        public string? IconUrl { get; set; }

        public string PasswordHash { get; set; } = null!;

        public string PasswordSalt { get; set; } = null!;
    }
}