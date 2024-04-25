using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class _StudentRefact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseName",
                table: "Students",
                newName: "StudentYear");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentYear",
                table: "Students",
                newName: "CourseName");
        }
    }
}
