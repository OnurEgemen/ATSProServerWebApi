using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATSProServer.Persistance.Migrations.FirmDb
{
    /// <inheritdoc />
    public partial class carfirmaidkaldirildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirmId",
                table: "Car");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirmId",
                table: "Car",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
