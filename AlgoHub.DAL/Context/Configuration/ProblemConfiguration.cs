using AlgoHub.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlgoHub.DAL.Context.Configuration;

public class ProblemConfiguration : IEntityTypeConfiguration<Problem>
{
    public void Configure(EntityTypeBuilder<Problem> builder)
    {
        builder.HasMany(l => l.Tags).WithMany().UsingEntity<Dictionary<string, object>>(
            "ProblemTag",
            t => t.HasOne<Tag>().WithMany().HasForeignKey("TagId"),
            l => l.HasOne<Problem>().WithMany().HasForeignKey("ProblemId"),
            lt =>
            {
                lt.HasKey("ProblemId", "TagId");
            }
        );
    }
}