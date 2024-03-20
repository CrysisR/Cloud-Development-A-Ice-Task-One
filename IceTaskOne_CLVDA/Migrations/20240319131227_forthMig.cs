using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IceTaskOne_CLVDA.Migrations
{
    /// <inheritdoc />
    public partial class forthMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "color",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "color",
                table: "Tasks");
        }
    }
}
