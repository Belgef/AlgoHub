namespace AlgoHub.DAL.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }

        public string? Email { get; set; }

        public string? UserName { get; set; }

        public string? FullName { get; set; }

        public DateTime? CreationDate { get; set; }

        public string? IconUrl { get; set; }

        public UserAuthData? AuthData { get; set; }
    }
}