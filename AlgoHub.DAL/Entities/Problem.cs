namespace AlgoHub.DAL.Entities;

public class Problem : IEntity
{
    public int? Id { get; set; }

    public string ProblemName { get; set; } = null!;

    public string ProblemDescription { get; set; } = null!;

    public User Author { get; set; } = null!;

    public DateTime CreationDate { get; set; } = DateTime.Now;

    public DateTime UpdateDate { get; set; } = DateTime.Now;

    public string? ImageUrl { get; set; }

    public int Views { get; set; }

    public int Upvotes { get; set; }

    public int Downvotes { get; set; }

    public int Solves { get; set; }

    public double TimeLimit { get; set; }

    public int MemoryLimit { get; set; }

    public IEnumerable<Tag> Tags { get; set; } = null!;

    public IEnumerable<ProblemComment> Comments { get; set; } = null!;

    public IEnumerable<Test> Tests { get; set; } = null!;
}