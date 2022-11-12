namespace AlgoHub.DAL.Entities;

public class Language : IEntity
{
    public int Id { get; set; }

    public string? LanguageName { get; set; }

    public string? LanguageInternalName { get; set; }

    public string? IconUrl { get; set; }
}