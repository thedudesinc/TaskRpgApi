using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskRpgApi.Migrations
{
    /// <inheritdoc />
    public partial class questtablefix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Quests",
                newName: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Quests",
                newName: "Name");
        }
    }
}
