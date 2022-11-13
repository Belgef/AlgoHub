namespace AlgoHub.BLL.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Email { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public string? FullName { get; set; }

        public DateTime CreationDate { get; set; }

        public string? IconUrl { get; set; }
    }
}
