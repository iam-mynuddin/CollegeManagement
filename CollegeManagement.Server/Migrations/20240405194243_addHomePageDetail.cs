using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class addHomePageDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomePageDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePageDetails", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AssignmentSubmissions",
                keyColumn: "SubmissionId",
                keyValue: 1,
                column: "SubmissionDate",
                value: new DateTime(2024, 4, 12, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "AssignmentSubmissions",
                keyColumn: "SubmissionId",
                keyValue: 2,
                column: "SubmissionDate",
                value: new DateTime(2024, 4, 12, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "AssignmentSubmissions",
                keyColumn: "SubmissionId",
                keyValue: 3,
                column: "SubmissionDate",
                value: new DateTime(2024, 4, 12, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "AssignmentSubmissions",
                keyColumn: "SubmissionId",
                keyValue: 4,
                column: "SubmissionDate",
                value: new DateTime(2024, 4, 12, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "AssignmentSubmissions",
                keyColumn: "SubmissionId",
                keyValue: 5,
                column: "SubmissionDate",
                value: new DateTime(2024, 4, 12, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 13, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 13, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 13, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 4,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 13, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 5,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 13, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "AttendanceId",
                keyValue: 1,
                column: "AttendanceDate",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "AttendanceId",
                keyValue: 2,
                column: "AttendanceDate",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "AttendanceId",
                keyValue: 3,
                column: "AttendanceDate",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "AttendanceId",
                keyValue: 4,
                column: "AttendanceDate",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "AttendanceId",
                keyValue: 5,
                column: "AttendanceDate",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 1,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 2,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 3,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 4,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 5,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 6,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 7,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 8,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 9,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 10,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 1,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 2,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 3,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 4,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 5,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 6,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 7,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 8,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 9,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 10,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "FeeDetails",
                keyColumn: "FeeId",
                keyValue: 1,
                column: "DateOfPayment",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "FeeDetails",
                keyColumn: "FeeId",
                keyValue: 2,
                column: "DateOfPayment",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "FeeDetails",
                keyColumn: "FeeId",
                keyValue: 3,
                column: "DateOfPayment",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "FeeDetails",
                keyColumn: "FeeId",
                keyValue: 4,
                column: "DateOfPayment",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "FeeDetails",
                keyColumn: "FeeId",
                keyValue: 5,
                column: "DateOfPayment",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.InsertData(
                table: "HomePageDetails",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[] { 1, "ScrollingNotification", "Admissions are open now. Please check admission form soon. Seats are filling..!" });

            migrationBuilder.UpdateData(
                table: "LeaveDetails",
                keyColumn: "LeaveDetailsId",
                keyValue: 1,
                column: "DateOfLeave",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "LeaveDetails",
                keyColumn: "LeaveDetailsId",
                keyValue: 2,
                column: "DateOfLeave",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "LeaveDetails",
                keyColumn: "LeaveDetailsId",
                keyValue: 3,
                column: "DateOfLeave",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "LeaveDetails",
                keyColumn: "LeaveDetailsId",
                keyValue: 4,
                column: "DateOfLeave",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "LeaveDetails",
                keyColumn: "LeaveDetailsId",
                keyValue: 5,
                column: "DateOfLeave",
                value: new DateTime(2024, 4, 6, 1, 12, 42, 791, DateTimeKind.Local).AddTicks(6240));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomePageDetails");

            migrationBuilder.UpdateData(
                table: "AssignmentSubmissions",
                keyColumn: "SubmissionId",
                keyValue: 1,
                column: "SubmissionDate",
                value: new DateTime(2024, 4, 10, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "AssignmentSubmissions",
                keyColumn: "SubmissionId",
                keyValue: 2,
                column: "SubmissionDate",
                value: new DateTime(2024, 4, 10, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "AssignmentSubmissions",
                keyColumn: "SubmissionId",
                keyValue: 3,
                column: "SubmissionDate",
                value: new DateTime(2024, 4, 10, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "AssignmentSubmissions",
                keyColumn: "SubmissionId",
                keyValue: 4,
                column: "SubmissionDate",
                value: new DateTime(2024, 4, 10, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "AssignmentSubmissions",
                keyColumn: "SubmissionId",
                keyValue: 5,
                column: "SubmissionDate",
                value: new DateTime(2024, 4, 10, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 11, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 11, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 11, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 4,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 11, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 5,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 11, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "AttendanceId",
                keyValue: 1,
                column: "AttendanceDate",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "AttendanceId",
                keyValue: 2,
                column: "AttendanceDate",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "AttendanceId",
                keyValue: 3,
                column: "AttendanceDate",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "AttendanceId",
                keyValue: 4,
                column: "AttendanceDate",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "AttendanceId",
                keyValue: 5,
                column: "AttendanceDate",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 1,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 2,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 3,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 4,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 5,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 6,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 7,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 8,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 9,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 10,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 1,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 2,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 3,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 4,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 5,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 6,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 7,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 8,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 9,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 10,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "FeeDetails",
                keyColumn: "FeeId",
                keyValue: 1,
                column: "DateOfPayment",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "FeeDetails",
                keyColumn: "FeeId",
                keyValue: 2,
                column: "DateOfPayment",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "FeeDetails",
                keyColumn: "FeeId",
                keyValue: 3,
                column: "DateOfPayment",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "FeeDetails",
                keyColumn: "FeeId",
                keyValue: 4,
                column: "DateOfPayment",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "FeeDetails",
                keyColumn: "FeeId",
                keyValue: 5,
                column: "DateOfPayment",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "LeaveDetails",
                keyColumn: "LeaveDetailsId",
                keyValue: 1,
                column: "DateOfLeave",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "LeaveDetails",
                keyColumn: "LeaveDetailsId",
                keyValue: 2,
                column: "DateOfLeave",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "LeaveDetails",
                keyColumn: "LeaveDetailsId",
                keyValue: 3,
                column: "DateOfLeave",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "LeaveDetails",
                keyColumn: "LeaveDetailsId",
                keyValue: 4,
                column: "DateOfLeave",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "LeaveDetails",
                keyColumn: "LeaveDetailsId",
                keyValue: 5,
                column: "DateOfLeave",
                value: new DateTime(2024, 4, 4, 11, 8, 53, 311, DateTimeKind.Local).AddTicks(9190));
        }
    }
}
