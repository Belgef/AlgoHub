using AlgoHub.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AlgoHub.DAL.Context
{
    public class AlgoHubContext : DbContext
    {
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<Solve> Solves { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<ProblemComment> ProblemComments { get; set; }
        public DbSet<SolveComment> SolveComments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Language> Languages { get; set; }

        public AlgoHubContext(DbContextOptions<AlgoHubContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(u => u.UserName).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }

    }
}