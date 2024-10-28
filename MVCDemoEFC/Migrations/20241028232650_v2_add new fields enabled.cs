using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCDemoEFC.Migrations
{
    /// <inheritdoc />
    public partial class v2_addnewfieldsenabled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "Courses");
        }
    }
}
