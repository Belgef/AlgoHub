namespace AlgoHub.DAL.Entities;

public class SolveComment : IEntity
{
    public int Id { get; set; }

    public User? Commenter { get; set; }

    public Solve? Solve { get; set; }

    public DateTime? CreationDate { get; set; }
}