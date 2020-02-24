using Microsoft.EntityFrameworkCore.Migrations;

namespace Required.Migrations
{
    public partial class AddedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Superhero",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuperheroName = table.Column<string>(nullable: true),
                    AlterEgo = table.Column<string>(nullable: true),
                    SuperpowerOne = table.Column<string>(nullable: true),
                    SuperpowerTwo = table.Column<string>(nullable: true),
                    CatchPhrase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superhero", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Superhero");
        }
    }
}
