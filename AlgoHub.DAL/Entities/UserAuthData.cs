namespace AlgoHub.DAL.Entities;

public class UserAuthData
{
    public int UserId { get; set; }

    public string? PasswordHash { get; set; }

    public string? PasswordSalt { get; set; }
}