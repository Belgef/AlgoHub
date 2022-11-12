namespace AlgoHub.DAL.Entities;

public class Solve : IEntity
{
    public int Id { get; set; }

    public int ProblemId { get; set; }

    public User Solver { get; set; } = null!;

    public Language Language { get; set; } = null!;

    public int Views { get; set; }

    public int Upvotes { get; set; }

    public int Downvotes { get; set; }

    public double Time { get; set; }

    public int Memory { get; set; }

    public DateTime CreationDate { get; set; } = DateTime.Now;
}