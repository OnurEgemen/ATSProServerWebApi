using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATSProServer.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class firmuseridvepasswordbilgisidegistirildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Firms",
                newName: "ServerUserId");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Firms",
                newName: "ServerPassword");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServerUserId",
                table: "Firms",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ServerPassword",
                table: "Firms",
                newName: "Password");
        }
    }
}
