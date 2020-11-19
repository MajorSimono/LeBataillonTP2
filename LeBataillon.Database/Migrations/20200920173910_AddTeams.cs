using Microsoft.EntityFrameworkCore.Migrations;

namespace LeBataillon.Database.Migrations
{
    public partial class AddTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(nullable: true),
                    Captain = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "Captain", "TeamName" },
                values: new object[,]
                {
                    { 1, 10, "Krissy" },
                    { 2, 20, "Pat" },
                    { 3, 30, "Palmira" },
                    { 4, 40, "Ralph" },
                    { 5, 50, "Arielle" },
                    { 6, 60, "Troy" },
                    { 7, 70, "Marcell" },
                    { 8, 80, "Vi" },
                    { 9, 90, "Sherise" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
