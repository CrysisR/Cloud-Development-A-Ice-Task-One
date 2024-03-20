using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IceTaskOne_CLVDA.Migrations
{
    /// <inheritdoc />
    public partial class addTempVars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TempConfPass",
                table: "LoginReg",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TempPass",
                table: "LoginReg",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tempUser",
                table: "LoginReg",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TempConfPass",
                table: "LoginReg");

            migrationBuilder.DropColumn(
                name: "TempPass",
                table: "LoginReg");

            migrationBuilder.DropColumn(
                name: "tempUser",
                table: "LoginReg");
        }
    }
}
