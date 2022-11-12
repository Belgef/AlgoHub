namespace AlgoHub.DAL.Entities;

public class ProblemComment : IEntity
{
    public int Id { get; set; }

    public int CommenterId { get; set; }

    public int ProblemId { get; set; }

    public DateTime? CreationDate { get; set; }
}