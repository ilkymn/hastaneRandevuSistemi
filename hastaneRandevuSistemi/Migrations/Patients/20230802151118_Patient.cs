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
                    patId = table.Column<int>(type: "int", nullable: true)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    patSurname = table.Column<string>(type: "nvarchar(max)", nullable:true),
                    patBirthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    patPhoneNo = table.Column<int>(type: "int", nullable: true),
                    patEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    patParola = table.Column<int>(type: "int", nullable: true),
                    patTeParola = table.Column<int>(type: "int", nullable: true),
                    patCity = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
