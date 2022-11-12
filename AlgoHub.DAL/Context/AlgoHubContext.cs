using AlgoHub.DAL.Context.Configuration;
using AlgoHub.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AlgoHub.DAL.Context
{
    public class AlgoHubContext : DbContext
    {
        public DbSet<Lesson> Lessons { get; set; } = null!;
        public DbSet<Problem> Problems { get; set; } = null!;
        public DbSet<Solve> Solves { get; set; } = null!;
        public DbSet<Test> Tests { get; set; } = null!;
        public DbSet<ProblemComment> ProblemComments { get; set; } = null!;
        public DbSet<SolveComment> SolveComments { get; set; } = null!;
        public DbSet<Tag> Tags { get; set; } = null!;
        public DbSet<Language> Languages { get; set; } = null!;

        public AlgoHubContext(DbContextOptions<AlgoHubContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new LessonConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}