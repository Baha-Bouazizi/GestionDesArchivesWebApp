using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDesArchivesWebApp.Migrations
{
    /// <inheritdoc />
    public partial class suiteDsuiteF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "suiteD",
                table: "Conteneurs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "suiteF",
                table: "Conteneurs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "suiteD",
                table: "Conteneurs");

            migrationBuilder.DropColumn(
                name: "suiteF",
                table: "Conteneurs");
        }
    }
}
