using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hastaneRandevuSistemi.Migrations.city
{
    /// <inheritdoc />
    public partial class city : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Şehirler",
                columns: table => new
                {
                    cityId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    county = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Şehirler", x => x.cityId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Şehirler");
        }
    }
}
