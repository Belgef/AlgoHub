namespace AlgoHub.DAL.Entities;

public class Test : IEntity
{
    public int Id { get; set; }

    public Problem? Problem { get; set; }

    public string? Input { get; set; }

    public string? Output { get; set; }
}