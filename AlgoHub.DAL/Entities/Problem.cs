namespace AlgoHub.DAL.Entities;

public class Problem : IEntity
{
    public int Id { get; set; }

    public string? ProblemName { get; set; }

    public string? ProblemDescription { get; set; }

    public User? Author { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? ImageUrl { get; set; }

    public int Views { get; set; }

    public int Upvotes { get; set; }

    public int Downvotes { get; set; }

    public int Solves { get; set; }

    public double TimeLimit { get; set; }

    public int MemoryLimit { get; set; }

    public IEnumerable<Tag>? Tags { get; set; }

    public IEnumerable<ProblemComment>? Comments { get; set; }

    public IEnumerable<Test>? Tests { get; set; }
}