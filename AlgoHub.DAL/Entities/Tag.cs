namespace AlgoHub.DAL.Entities;

public class Tag : IEntity
{
    public int Id { get; set; }

    public string? TagName { get; set; }

    public IEnumerable<Lesson>? Lessons { get; set; }

    public IEnumerable<Problem>? Problems { get; set; }
}