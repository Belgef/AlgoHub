namespace AlgoHub.DAL.Entities;

public class Language : IEntity
{
    public int? Id { get; set; }

    public string LanguageName { get; set; } = null!;

    public string LanguageInternalName { get; set; } = null!;

    public string? IconUrl { get; set; }
}