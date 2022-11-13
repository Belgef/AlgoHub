using AlgoHub.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlgoHub.DAL.Context.Configuration;

public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
{
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        builder.Property(l => l.Content).IsRequired().HasDefaultValue(/*lang=json*/"[{type:\"paragraph\",\"value\":\"Nothing in there yet!\"}]");
        builder.Property(l => l.Views).IsRequired().HasDefaultValue(0);
        builder.Property(l => l.Upvotes).IsRequired().HasDefaultValue(0);
        builder.Property(l => l.Downvotes).IsRequired().HasDefaultValue(0);
        builder.Property(l => l.CreationDate).IsRequired().HasDefaultValueSql("getdate()");
        builder.Property(l => l.UpdateDate).IsRequired().HasDefaultValueSql("getdate()").ValueGeneratedOnAddOrUpdate();

        builder.HasData(
            new Lesson
            {
                Id = 1,
                Title = "Алгоритм Дейкстри",
                Content = /*lang=json*/"""
                [
                    {
                        "type":"emphasis",
                        "value":"Алгоритм Дейкстри дозволяє знайти найкоротший шлях між будь-якими двома вузлами графа."
                    },{
                        "type":"paragraph",
                        "value":"Він відрізняється від алгоритму мінімального остовного дерева тим, що знайдений найкоротший шлях не обов'язково міститиме усі вузли графу."
                    },{
                        "type":"bar"
                    },{
                        "type":"subtitle",
                        "value":"Принцип роботи"
                    },{
                        "type":"paragraph",
                        "value":"Алгоритм Дейкстри працює на основі того, що будь-який підшлях B -> D найкоротшого шляху A -> D між вершинами A і D також є найкоротшим шляхом між вершинами B і D."
                    },{
                        "type":"image",
                        "value":"lesson1/1",
                        "caption":"Кожен підшлях є найкоротшим шляхом"
                    }
                ]
                """,
                AuthorId = 1,
                Views = 14662,
                Upvotes = 1425,
                Downvotes = 76
            },
            new Lesson
            {
                Id=2,
                Title="Empty lesson",
                AuthorId=2
            }
        );


        builder.HasMany(l => l.Tags).WithMany().UsingEntity<Dictionary<string, object>>(
            "LessonTag",
            t => t.HasOne<Tag>().WithMany().HasForeignKey("TagId"),
            l => l.HasOne<Lesson>().WithMany().HasForeignKey("LessonId"),
            lt =>
            {
                lt.HasKey("LessonId", "TagId");
                lt.HasData(
                    new { LessonId = 1, TagId = 2 },
                    new { LessonId = 1, TagId = 3 },
                    new { LessonId = 1, TagId = 4 },
                    new { LessonId = 1, TagId = 5 },
                    new { LessonId = 1, TagId = 20 }
                );
            }
        );
    }
}