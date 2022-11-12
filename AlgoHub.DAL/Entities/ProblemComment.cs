namespace AlgoHub.DAL.Entities;

public class ProblemComment : IEntity
{
    public int Id { get; set; }

    public User? Commenter { get; set; }

    public Problem? Problem { get; set; }

    public DateTime? CreationDate { get; set; }
}