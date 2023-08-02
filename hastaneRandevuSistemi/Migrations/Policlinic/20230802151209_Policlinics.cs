using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hastaneRandevuSistemi.Migrations.Policlinic
{
    /// <inheritdoc />
    public partial class Policlinics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Poliklinikler",
                columns: table => new
                {
                    policlinicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    policlinicName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    policlinicNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poliklinikler", x => x.policlinicId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Poliklinikler");
        }
    }
}
