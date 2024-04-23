using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class addFkToIssueReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_IssueReports_UserId",
                table: "IssueReports",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_IssueReports_Users_UserId",
                table: "IssueReports",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IssueReports_Users_UserId",
                table: "IssueReports");

            migrationBuilder.DropIndex(
                name: "IX_IssueReports_UserId",
                table: "IssueReports");

            migrationBuilder.UpdateData(
                table: "AssignmentSubmissions",
                keyColumn: "SubmissionId",
                keyValue: 1,
                column: "SubmissionDate",
                value: new DateTime(2024, 4, 7, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "AssignmentSubmissions",
                keyColumn: "SubmissionId",
                keyValue: 2,
                column: "SubmissionDate",
                value: new DateTime(2024, 4, 7, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "AssignmentSubmissions",
                keyColumn: "SubmissionId",
                keyValue: 3,
                column: "SubmissionDate",
                value: new DateTime(2024, 4, 7, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "AssignmentSubmissions",
                keyColumn: "SubmissionId",
                keyValue: 4,
                column: "SubmissionDate",
                value: new DateTime(2024, 4, 7, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "AssignmentSubmissions",
                keyColumn: "SubmissionId",
                keyValue: 5,
                column: "SubmissionDate",
                value: new DateTime(2024, 4, 7, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 8, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 8, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 8, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 4,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 8, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 5,
                column: "SubmissionTime",
                value: new DateTime(2024, 4, 8, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "AttendanceId",
                keyValue: 1,
                column: "AttendanceDate",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "AttendanceId",
                keyValue: 2,
                column: "AttendanceDate",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "AttendanceId",
                keyValue: 3,
                column: "AttendanceDate",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "AttendanceId",
                keyValue: 4,
                column: "AttendanceDate",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "AttendanceId",
                keyValue: 5,
                column: "AttendanceDate",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 1,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 2,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 3,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 4,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 5,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 6,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 7,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 8,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 9,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Calendars",
                keyColumn: "CalendarId",
                keyValue: 10,
                column: "DateOfEdit",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 1,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 2,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 3,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 4,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 5,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 6,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 7,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 8,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 9,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "FacultyId",
                keyValue: 10,
                column: "FacultyDoj",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "FeeDetails",
                keyColumn: "FeeId",
                keyValue: 1,
                column: "DateOfPayment",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "FeeDetails",
                keyColumn: "FeeId",
                keyValue: 2,
                column: "DateOfPayment",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "FeeDetails",
                keyColumn: "FeeId",
                keyValue: 3,
                column: "DateOfPayment",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "FeeDetails",
                keyColumn: "FeeId",
                keyValue: 4,
                column: "DateOfPayment",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "FeeDetails",
                keyColumn: "FeeId",
                keyValue: 5,
                column: "DateOfPayment",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "LeaveDetails",
                keyColumn: "LeaveDetailsId",
                keyValue: 1,
                column: "DateOfLeave",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "LeaveDetails",
                keyColumn: "LeaveDetailsId",
                keyValue: 2,
                column: "DateOfLeave",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "LeaveDetails",
                keyColumn: "LeaveDetailsId",
                keyValue: 3,
                column: "DateOfLeave",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "LeaveDetails",
                keyColumn: "LeaveDetailsId",
                keyValue: 4,
                column: "DateOfLeave",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "LeaveDetails",
                keyColumn: "LeaveDetailsId",
                keyValue: 5,
                column: "DateOfLeave",
                value: new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7594));
        }
    }
}
