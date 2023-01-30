using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATSProServer.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class firmbilgileriniguncellendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DatabaseName",
                table: "Firms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Firms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServerName",
                table: "Firms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Firms",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatabaseName",
                table: "Firms");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Firms");

            migrationBuilder.DropColumn(
                name: "ServerName",
                table: "Firms");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Firms");
        }
    }
}
