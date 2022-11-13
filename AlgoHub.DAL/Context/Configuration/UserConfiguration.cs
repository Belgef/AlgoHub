using System.Security.Cryptography;
using AlgoHub.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text;

namespace AlgoHub.DAL.Context.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasIndex(u => u.UserName).IsUnique();
        builder.HasIndex(u => u.Email).IsUnique();

        builder.Property(u=>u.CreationDate).IsRequired().HasDefaultValueSql("getdate()");

        builder.HasData(
            new User
            {
                Id = 1,
                Email = "armandovargas@gmail.com",
                UserName = "armandovargas",
                FullName = "Armando Vargas"
            }.SetPassword("QE4ufxvw2???Rug"),
            new User
            {
                Id = 2,
                Email = "valentinosnyder@gmail.com",
                UserName = "valentinosnyder",
                FullName = "Valentino Snyder"
            }.SetPassword("B.Qt3vE8&6EwNmr"),
            new User
            {
                Id = 3,
                Email = "journeydixon@gmail.com",
                UserName = "journeydixon",
                FullName = "Journey Dixon"
            }.SetPassword("Rs$m,7yeU7$UjGa"),
            new User
            {
                Id = 4,
                Email = "victorwilkinson@gmail.com",
                UserName = "victorwilkinson",
                FullName = "Victor Wilkinson"
            }.SetPassword("UjTz9dP,BmBjMcB"),
            new User
            {
                Id = 5,
                Email = "braelynodom@gmail.com",
                UserName = "braelynodom",
                FullName = "Braelyn Odom"
            }.SetPassword("!,n2z9GAXKnAj?Z"),
            new User
            {
                Id = 6,
                Email = "carissafaulkner@gmail.com",
                UserName = "carissafaulkner",
                FullName = "Carissa Faulkner"
            }.SetPassword("zYQP73Di/eULaDj"),
            new User
            {
                Id = 7,
                Email = "mikemcclure@gmail.com",
                UserName = "mikemcclure",
                FullName = "Mike Mcclure"
            }.SetPassword("VW5,UcM?#xL?ix@"),
            new User
            {
                Id = 8,
                Email = "brookssawyer@gmail.com",
                UserName = "brookssawyer",
                FullName = "Brooks Sawyer"
            }.SetPassword("5e-meePE@r&#c3u"),
            new User
            {
                Id = 9,
                Email = "kylanhardy@gmail.com",
                UserName = "kylanhardy",
                FullName = "Kylan Hardy"
            }.SetPassword("x&e4PStJ8,CvN8@"),
            new User
            {
                Id = 10,
                Email = "nyasiaduarte@gmail.com",
                UserName = "nyasiaduarte",
                FullName = "Nyasia Duarte"
            }.SetPassword("qyx%3ZPVX!!WhFp"),
            new User
            {
                Id = 11,
                Email = "justineramos@gmail.com",
                UserName = "justineramos",
                FullName = "Justine Ramos"
            }.SetPassword("g?6X+,XgWbx&#4B"),
            new User
            {
                Id = 12,
                Email = "miyamorrow@gmail.com",
                UserName = "miyamorrow",
                FullName = "Miya Morrow"
            }.SetPassword("#2q.AzC/-M@qm2C")
        );
    }
}

internal static class UserExtension
{
    public static User SetPassword(this User user, string password)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(32);
        byte[] passwordHash = SHA256.HashData(Encoding.Default.GetBytes(password).Concat(salt).ToArray());

        user.PasswordHash = Convert.ToBase64String(passwordHash);
        user.PasswordSalt = Convert.ToBase64String(salt);

        return user;
    }
}