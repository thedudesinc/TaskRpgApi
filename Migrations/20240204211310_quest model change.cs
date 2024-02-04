using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskRpgApi.Migrations
{
    /// <inheritdoc />
    public partial class questmodelchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tag",
                table: "Quests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tag",
                table: "Quests");
        }
    }
}
