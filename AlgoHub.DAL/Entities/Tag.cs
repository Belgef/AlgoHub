namespace AlgoHub.DAL.Entities;

public class Tag : IEntity
{
    public int Id { get; set; }

    public string TagName { get; set; }
}