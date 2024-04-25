using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class _StudentParentFacultyRefact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacultyDoj",
                table: "Faculties");

            migrationBuilder.RenameColumn(
                name: "ParentAddress",
                table: "Parents",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "FacultyMail",
                table: "Faculties",
                newName: "MailId");

            migrationBuilder.RenameColumn(
                name: "FacultyAddress",
                table: "Faculties",
                newName: "FacultyDepartment");

            migrationBuilder.AddColumn<string>(
                name: "MailId",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Faculties",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MailId",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Faculties");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Parents",
                newName: "ParentAddress");

            migrationBuilder.RenameColumn(
                name: "MailId",
                table: "Faculties",
                newName: "FacultyMail");

            migrationBuilder.RenameColumn(
                name: "FacultyDepartment",
                table: "Faculties",
                newName: "FacultyAddress");

            migrationBuilder.AddColumn<DateTime>(
                name: "FacultyDoj",
                table: "Faculties",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
