using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CollegeManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    AssignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmissionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseCode = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.AssignmentId);
                });

            migrationBuilder.CreateTable(
                name: "AssignmentSubmissions",
                columns: table => new
                {
                    SubmissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    CourseCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentSubmissions", x => x.SubmissionId);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPresent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    FacultyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.AttendanceId);
                });

            migrationBuilder.CreateTable(
                name: "Calendars",
                columns: table => new
                {
                    CalendarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfEdit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendars", x => x.CalendarId);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    FacultyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseCode);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    FacultyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacultyMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacultyMobileNo = table.Column<long>(type: "bigint", nullable: false),
                    FacultyAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacultyDoj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.FacultyId);
                });

            migrationBuilder.CreateTable(
                name: "FacultyCourses",
                columns: table => new
                {
                    FacultyCourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacultyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultyCourses", x => x.FacultyCourseId);
                });

            migrationBuilder.CreateTable(
                name: "FeeDetails",
                columns: table => new
                {
                    FeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    DateOfPayment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeDetails", x => x.FeeId);
                });

            migrationBuilder.CreateTable(
                name: "IssueReports",
                columns: table => new
                {
                    Ticket = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsResolved = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueReports", x => x.Ticket);
                });

            migrationBuilder.CreateTable(
                name: "LeaveDetails",
                columns: table => new
                {
                    LeaveDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfLeave = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveDetails", x => x.LeaveDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    ParentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.ParentId);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    SCourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => x.SCourseId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentDepartment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "AssignmentSubmissions",
                columns: new[] { "SubmissionId", "Answer", "CourseCode", "StudentId", "SubmissionDate" },
                values: new object[,]
                {
                    { 1, "Here's the code for factorial calculation", 1, 1, new DateTime(2024, 4, 7, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7262) },
                    { 2, "Attached is the circuit diagram", 2, 2, new DateTime(2024, 4, 7, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7265) },
                    { 3, "Solution to the problem is attached", 3, 3, new DateTime(2024, 4, 7, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7266) },
                    { 4, "FEM analysis report attached", 4, 4, new DateTime(2024, 4, 7, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7268) },
                    { 5, "Chemical reactor design is attached", 5, 5, new DateTime(2024, 4, 7, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7269) }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentId", "CourseCode", "Question", "StudentId", "SubmissionTime" },
                values: new object[,]
                {
                    { 1, 1, "Write a program to calculate factorial", 1, new DateTime(2024, 4, 8, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7221) },
                    { 2, 2, "Design a circuit for a digital clock", 2, new DateTime(2024, 4, 8, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7229) },
                    { 3, 3, "Solve the second law of thermodynamics", 3, new DateTime(2024, 4, 8, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7231) },
                    { 4, 4, "Analyze a truss structure using FEM", 4, new DateTime(2024, 4, 8, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7232) },
                    { 5, 5, "Design a reactor for a chemical process", 5, new DateTime(2024, 4, 8, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7233) }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "AttendanceId", "AttendanceDate", "FacultyId", "IsPresent", "StudentId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7534), 1, "Yes", 1 },
                    { 2, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7536), 2, "Yes", 2 },
                    { 3, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7538), 3, "Yes", 3 },
                    { 4, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7539), 4, "Yes", 4 },
                    { 5, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7540), 5, "Yes", 5 }
                });

            migrationBuilder.InsertData(
                table: "Calendars",
                columns: new[] { "CalendarId", "DateOfEdit", "Reason", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7639), "Holiday", "Active" },
                    { 2, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7641), "Maintenance", "Inactive" },
                    { 3, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7642), "Training", "Active" },
                    { 4, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7643), "Meeting", "Inactive" },
                    { 5, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7644), "Conference", "Active" },
                    { 6, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7068), "Semester start", "Active" },
                    { 7, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7091), "Public holiday", "Inactive" },
                    { 8, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7092), "Final exams begin", "Active" },
                    { 9, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7093), "Semester break", "Inactive" },
                    { 10, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7094), "Semester end", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseCode", "CourseName", "FacultyId", "StudentId" },
                values: new object[,]
                {
                    { 1, "Introduction to Computer Science", 1, 1 },
                    { 2, "Electromagnetic Theory", 2, 2 },
                    { 3, "Thermodynamics", 3, 3 },
                    { 4, "Structural Analysis", 4, 4 },
                    { 5, "Chemical Reaction Engineering", 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "FacultyId", "FacultyAddress", "FacultyDoj", "FacultyMail", "FacultyMobileNo", "UserId" },
                values: new object[,]
                {
                    { 1, "123 Main St", new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7750), "john@example.com", 1234567890L, 2 },
                    { 2, "456 Elm St", new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7753), "jane@example.com", 9876543210L, 3 },
                    { 3, "789 Oak St", new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7754), "smith@example.com", 5555555555L, 4 },
                    { 4, "101 Pine St", new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7756), "emily@example.com", 9999999999L, 5 },
                    { 5, "202 Maple St", new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7757), "mary@example.com", 1111111111L, 1 },
                    { 6, "123 Elm St", new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7189), "prof1@example.com", 1112223333L, 11 },
                    { 7, "456 Oak St", new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7191), "prof2@example.com", 4445556666L, 12 },
                    { 8, "789 Pine St", new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7193), "prof3@example.com", 7778889999L, 13 },
                    { 9, "101 Maple St", new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7194), "prof4@example.com", 1231231234L, 14 },
                    { 10, "202 Cedar St", new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7195), "prof5@example.com", 4564564567L, 15 }
                });

            migrationBuilder.InsertData(
                table: "FacultyCourses",
                columns: new[] { "FacultyCourseId", "CourseName", "FacultyId" },
                values: new object[,]
                {
                    { 1, "Computer Science", 1 },
                    { 2, "Electrical Engineering", 2 },
                    { 3, "Mechanical Engineering", 3 },
                    { 4, "Civil Engineering", 4 },
                    { 5, "Chemical Engineering", 5 }
                });

            migrationBuilder.InsertData(
                table: "FeeDetails",
                columns: new[] { "FeeId", "Amount", "DateOfPayment", "StudentId" },
                values: new object[,]
                {
                    { 1, 5000.0, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7426), 1 },
                    { 2, 6000.0, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7429), 2 },
                    { 3, 5500.0, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7430), 3 },
                    { 4, 5800.0, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7431), 4 },
                    { 5, 5200.0, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7432), 5 }
                });

            migrationBuilder.InsertData(
                table: "IssueReports",
                columns: new[] { "Ticket", "Description", "IsResolved", "UserId" },
                values: new object[,]
                {
                    { 1L, "Bug in login page", false, 2 },
                    { 2L, "Error in payment processing", false, 3 },
                    { 3L, "Website loading slow", false, 4 },
                    { 4L, "Missing functionality in dashboard", false, 5 },
                    { 5L, "Data not updating in real-time", false, 6 }
                });

            migrationBuilder.InsertData(
                table: "LeaveDetails",
                columns: new[] { "LeaveDetailsId", "DateOfLeave", "IsApproved", "Reason", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7588), true, "Vacation", 2 },
                    { 2, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7590), true, "Sick leave", 3 },
                    { 3, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7592), false, "Personal reasons", 4 },
                    { 4, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7593), false, "Family emergency", 5 },
                    { 5, new DateTime(2024, 4, 1, 4, 48, 18, 407, DateTimeKind.Local).AddTicks(7594), true, "Attending conference", 6 }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "ParentId", "ParentAddress", "UserId" },
                values: new object[,]
                {
                    { 1, "789 Oak St", 4 },
                    { 2, "101 Pine St", 5 },
                    { 3, "202 Maple St", 6 },
                    { 4, "303 Elm St", 7 },
                    { 5, "404 Oak St", 8 }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "SCourseId", "CourseName", "StudentId" },
                values: new object[,]
                {
                    { 1, "Introduction to Computer Science", 1 },
                    { 2, "Electromagnetic Theory", 2 },
                    { 3, "Thermodynamics", 3 },
                    { 4, "Structural Analysis", 4 },
                    { 5, "Chemical Reaction Engineering", 5 },
                    { 6, "Introduction to Programming", 1 },
                    { 7, "Digital Circuits", 2 },
                    { 8, "Thermodynamics I", 3 },
                    { 9, "Structural Analysis", 4 },
                    { 10, "Chemical Reaction Engineering", 5 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "CourseName", "StudentAddress", "StudentDepartment", "StudentMail", "StudentMobile", "UserId" },
                values: new object[,]
                {
                    { 1, "B.Tech", "123 Main St", "Computer Science", "john@example.com", "1234567890", 2 },
                    { 2, "B.Tech", "456 Elm St", "Electrical Engineering", "jane@example.com", "9876543210", 3 },
                    { 3, "B.Tech", "789 Oak St", "Mechanical Engineering", "smith@example.com", "5555555555", 4 },
                    { 4, "B.Tech", "101 Pine St", "Civil Engineering", "emily@example.com", "9999999999", 5 },
                    { 5, "B.Tech", "202 Maple St", "Chemical Engineering", "mary@example.com", "1111111111", 6 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "UserName", "UserType" },
                values: new object[,]
                {
                    { 1, "Admin", "User", "admin123", "admin", "Admin" },
                    { 2, "John", "Doe", "pass123", "john_doe", "Regular" },
                    { 3, "Jane", "Doe", "pass456", "jane_doe", "Regular" },
                    { 4, "Smith", "Johnson", "smith123", "smith", "Regular" },
                    { 5, "Emily", "Smith", "emily123", "emily", "Regular" },
                    { 6, "Alice", "Smith", "pass123", "student1", "Student" },
                    { 7, "Bob", "Johnson", "pass456", "student2", "Student" },
                    { 8, "Charlie", "Brown", "pass789", "student3", "Student" },
                    { 9, "Diana", "Davis", "pass101", "student4", "Student" },
                    { 10, "Eva", "Wilson", "pass111", "student5", "Student" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "AssignmentSubmissions");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Calendars");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "FacultyCourses");

            migrationBuilder.DropTable(
                name: "FeeDetails");

            migrationBuilder.DropTable(
                name: "IssueReports");

            migrationBuilder.DropTable(
                name: "LeaveDetails");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
