namespace AlgoHub.API.DTOs;

public class LessonDetailDto
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public UserDetailDto? Author { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public string? ImageUrl { get; set; }

    public int Views { get; set; }

    public int Upvotes { get; set; }

    public int Downvotes { get; set; }

    public IEnumerable<TagDto> Tags { get; set; } = null!;
}
