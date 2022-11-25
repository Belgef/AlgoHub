namespace AlgoHub.API.DTOs;

public class LessonBriefDto
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public UserBriefDto? Author { get; set; }

    public string? ImageUrl { get; set; }

    public int? Views { get; set; }

    public IEnumerable<TagDto> Tags { get; set; } = null!;
}
