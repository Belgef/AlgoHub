using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlgoHub.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "[{type:\"paragraph\",\"value\":\"Nothing in there yet!\"}]"),
                    AuthorId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Views = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Upvotes = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Downvotes = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LessonTag",
                columns: table => new
                {
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonTag", x => new { x.LessonId, x.TagId });
                    table.ForeignKey(
                        name: "FK_LessonTag_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonTag_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName" },
                values: new object[,]
                {
                    { 1, "sort" },
                    { 2, "pathfinding" },
                    { 3, "tutorial" },
                    { 4, "search" },
                    { 5, "2d-arrays" },
                    { 6, "strings" },
                    { 7, "lists" },
                    { 8, "c++" },
                    { 9, "c#" },
                    { 10, "javascript" },
                    { 11, "java" },
                    { 12, "python" },
                    { 13, "tree" },
                    { 14, "binarytree" },
                    { 15, "binary" },
                    { 16, "classic" },
                    { 17, "optimization" },
                    { 18, "guide" },
                    { 19, "3d" },
                    { 20, "graph" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FullName", "IconUrl", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[,]
                {
                    { 1, "armandovargas@gmail.com", "Armando Vargas", null, "waU/UkDFh8hpFKl2UHeiXbQuckTdFUVhJpQETDzkdaY=", "hJeXeKrTm9qo+Au0ROx9crHGXbQ4yfVd915vp62Ee0s=", "armandovargas" },
                    { 2, "valentinosnyder@gmail.com", "Valentino Snyder", null, "8sYiiQDpv5uV13JmQoNOIhPm1kb5ZypGb1xh3lgBDMM=", "GCdM2928u5CjDM+a1AgrMJX2Lr/Sli+PYzj62S0Mnnk=", "valentinosnyder" },
                    { 3, "journeydixon@gmail.com", "Journey Dixon", null, "/jLcYb6ItQoeEjsU+4N/EyXms4MVNtwMtqaRmK9QOgI=", "xrgTfUWAoiHeFwcC/uag8vhiUroTRaJWLCnaE/oGOfQ=", "journeydixon" },
                    { 4, "victorwilkinson@gmail.com", "Victor Wilkinson", null, "EOsa/Q3nXJj16O4UPZOMt+Ppygx3grSoT7CxEZEG1ww=", "+DXodsiAr/+vtG1/EGPuO/6nV8LK1RZD35SF0n703ls=", "victorwilkinson" },
                    { 5, "braelynodom@gmail.com", "Braelyn Odom", null, "Y5900ADiGFOOeZcH+AMoWupgR/zRiHMA4vOuT3v4Mtk=", "XhSZ+kCs1fQPguLs4nDkySqVnU1G7LhOqiNcTRcqwqQ=", "braelynodom" },
                    { 6, "carissafaulkner@gmail.com", "Carissa Faulkner", null, "N83GZVgtWntGfPYd/rDXgK5AtjsjDmg/c57YBLiQqvQ=", "EKQuPBV135Upx4JEpt4cWSqaUWVxSa8X/FZolJSaa9U=", "carissafaulkner" },
                    { 7, "mikemcclure@gmail.com", "Mike Mcclure", null, "qZGdear3uo7ykSeF3sChfiqYgrOi+doh9UK6wok/u18=", "OeBRRX0bLKy3pa/69Nqgtl9Gs4dVPXGkbDrWMCWIKzQ=", "mikemcclure" },
                    { 8, "brookssawyer@gmail.com", "Brooks Sawyer", null, "GyIoLhsXmBrYw4zS1x6i85gsQxknPBthBiyxEEku9RU=", "IJUUwAs4oYjkQV0kx0yHGbrGE6bHHMTvzL21U0TxdOA=", "brookssawyer" },
                    { 9, "kylanhardy@gmail.com", "Kylan Hardy", null, "44lqozQ4wYMvVowKpoojBHKZl7+LJLxTwRTcgfi8peQ=", "BB/eMgsCf1ihzaEI3gV1IkSENgVeLS0Lsi7JbsIZ94E=", "kylanhardy" },
                    { 10, "nyasiaduarte@gmail.com", "Nyasia Duarte", null, "ynxf6zi1WWKpt436IvLQOak5zXsAhKoqsYmPRUbq7TE=", "MBbFNuowRYW7nx+RAthd4aCKePRrCyFnN0ZGf5gQLXY=", "nyasiaduarte" },
                    { 11, "justineramos@gmail.com", "Justine Ramos", null, "mGIJjs4ZqWFSTpVQPv9rbF4xBD0Gh7Xtpn6fqvMvu7U=", "Ezc0Pr2DKpd58NLK51hlG81FuPBKM2oWn3RSTtaoJtE=", "justineramos" },
                    { 12, "miyamorrow@gmail.com", "Miya Morrow", null, "5EqaWFvsox77K0S58C18iIONB+8YuKb1YvvfnfTzsos=", "6XrwbJ/GoqcWNgwFNYf7+ZtwuKozdFRZnFgekDD+h/A=", "miyamorrow" }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "AuthorId", "Content", "Downvotes", "ImageUrl", "Title", "Upvotes", "Views" },
                values: new object[] { 1, 1, "[\r\n    {\r\n        \"type\":\"emphasis\",\r\n        \"value\":\"Алгоритм Дейкстри дозволяє знайти найкоротший шлях між будь-якими двома вузлами графа.\"\r\n    },{\r\n        \"type\":\"paragraph\",\r\n        \"value\":\"Він відрізняється від алгоритму мінімального остовного дерева тим, що знайдений найкоротший шлях не обов'язково міститиме усі вузли графу.\"\r\n    },{\r\n        \"type\":\"bar\"\r\n    },{\r\n        \"type\":\"subtitle\",\r\n        \"value\":\"Принцип роботи\"\r\n    },{\r\n        \"type\":\"paragraph\",\r\n        \"value\":\"Алгоритм Дейкстри працює на основі того, що будь-який підшлях B -> D найкоротшого шляху A -> D між вершинами A і D також є найкоротшим шляхом між вершинами B і D.\"\r\n    },{\r\n        \"type\":\"image\",\r\n        \"value\":\"lesson1/1\",\r\n        \"caption\":\"Кожен підшлях є найкоротшим шляхом\"\r\n    }\r\n]", 76, null, "Алгоритм Дейкстри", 1425, 14662 });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "AuthorId", "ImageUrl", "Title" },
                values: new object[] { 2, 2, null, "Empty lesson" });

            migrationBuilder.InsertData(
                table: "LessonTag",
                columns: new[] { "LessonId", "TagId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_AuthorId",
                table: "Lessons",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonTag_TagId",
                table: "LessonTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_TagName",
                table: "Tags",
                column: "TagName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonTag");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
