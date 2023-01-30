using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATSProServer.Persistance.Migrations.FirmDb
{
    /// <inheritdoc />
    public partial class firmdatabaseolusturma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CarModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}
