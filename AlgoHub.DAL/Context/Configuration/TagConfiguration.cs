using System.Security.Cryptography;
using AlgoHub.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text;

namespace AlgoHub.DAL.Context.Configuration;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasIndex(t => t.TagName).IsUnique();

        builder.HasData(
            new Tag { Id = 1, TagName = "sort" },
            new Tag { Id = 2, TagName = "pathfinding" },
            new Tag { Id = 3, TagName = "tutorial" },
            new Tag { Id = 4, TagName = "search" },
            new Tag { Id = 5, TagName = "2d-arrays" },
            new Tag { Id = 6, TagName = "strings" },
            new Tag { Id = 7, TagName = "lists" },
            new Tag { Id = 8, TagName = "c++" },
            new Tag { Id = 9, TagName = "c#" },
            new Tag { Id = 10, TagName = "javascript" },
            new Tag { Id = 11, TagName = "java" },
            new Tag { Id = 12, TagName = "python" },
            new Tag { Id = 13, TagName = "tree" },
            new Tag { Id = 14, TagName = "binarytree" },
            new Tag { Id = 15, TagName = "binary" },
            new Tag { Id = 16, TagName = "classic" },
            new Tag { Id = 17, TagName = "optimization" },
            new Tag { Id = 18, TagName = "guide" },
            new Tag { Id = 19, TagName = "3d" },
            new Tag { Id = 20, TagName = "graph" }
        );
    }
}