namespace AlgoHub.DAL.Entities;

public class Lesson : IEntity
{
    public int? Id { get; set; }
        
    public string Title { get; set; } = null!;

    public string? Content { get; set; }

    public User? Author { get; set; }

    public int? AuthorId { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? ImageUrl { get; set; }

    public int? Views { get; set; }

    public int? Upvotes { get; set; }

    public int? Downvotes { get; set; }

    public IEnumerable<Tag>? Tags { get; set; }
}