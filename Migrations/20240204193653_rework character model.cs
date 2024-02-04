using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskRpgApi.Migrations
{
    /// <inheritdoc />
    public partial class reworkcharactermodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChallengeLevel",
                table: "Quests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChallengeLevel",
                table: "Quests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
