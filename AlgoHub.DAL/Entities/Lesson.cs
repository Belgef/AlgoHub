namespace AlgoHub.DAL.Entities;

public class Lesson : IEntity
{
    public int Id { get; set; }
        
    public string Title { get; set; } = null!;
        
    public string Content { get; set; } = null!;

    public User Author { get; set; } = null!;

    public int AuthorId { get; set; }

    public DateTime CreationDate { get; set; } = DateTime.Now;

    public DateTime UpdateDate { get; set; } = DateTime.Now;

    public string? ImageUrl { get; set; }

    public int Views { get; set; }

    public int Upvotes { get; set; }

    public int Downvotes { get; set; }

    public IEnumerable<Tag> Tags { get; set; } = null!;
}