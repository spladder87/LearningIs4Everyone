using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Mammal = table.Column<bool>(nullable: false),
                    Bird = table.Column<bool>(nullable: false),
                    Fish = table.Column<bool>(nullable: false),
                    Reptile = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LivingArea",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Land = table.Column<bool>(nullable: false),
                    Sea = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivingArea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Lang = table.Column<string>(maxLength: 200, nullable: false),
                    ImageUrl = table.Column<string>(maxLength: 1000, nullable: false),
                    Completed = table.Column<bool>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    AnimalsId = table.Column<int>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    LAId = table.Column<int>(nullable: true),
                    CSId = table.Column<int>(nullable: true),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Class_CSId",
                        column: x => x.CSId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subjects_LivingArea_LAId",
                        column: x => x.LAId,
                        principalTable: "LivingArea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_CSId",
                table: "Subjects",
                column: "CSId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_LAId",
                table: "Subjects",
                column: "LAId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "LivingArea");
        }
    }
}
