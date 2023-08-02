using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hastaneRandevuSistemi.Migrations.Patients
{
    /// <inheritdoc />
    public partial class Patient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hastalar",
                columns: table => new
                {
                    patId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    patBirthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    patPhoneNo = table.Column<int>(type: "int", nullable: false),
                    patEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    patParola = table.Column<int>(type: "int", nullable: false),
                    patTeParola = table.Column<int>(type: "int", nullable: false),
                    patCity = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastalar", x => x.patId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hastalar");
        }
    }
}
