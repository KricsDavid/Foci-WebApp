using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orai.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_982 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meccsek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fordulo = table.Column<int>(type: "INTEGER", nullable: false),
                    HazaiGol = table.Column<int>(type: "INTEGER", nullable: false),
                    VendegGol = table.Column<int>(type: "INTEGER", nullable: false),
                    HazaiFelidogol = table.Column<int>(type: "INTEGER", nullable: false),
                    VendegFelidogol = table.Column<int>(type: "INTEGER", nullable: false),
                    HazaiCsapat = table.Column<string>(type: "TEXT", nullable: false),
                    VendegCsapat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meccsek", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meccsek");
        }
    }
}
