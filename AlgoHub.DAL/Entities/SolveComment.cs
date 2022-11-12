namespace AlgoHub.DAL.Entities;

public class SolveComment : IEntity
{
    public int Id { get; set; }

    public int CommenterId { get; set; }

    public int SolveId { get; set; }

    public DateTime CreationDate { get; set; } = DateTime.Now;
}