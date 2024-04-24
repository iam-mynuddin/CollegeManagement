using CollegeManagement.Models;
using CollegeManagement.Models.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CollegeManagement.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
		#region Entities
		public DbSet<User> Users { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Parent> Parents { get; set; }
		public DbSet<Faculty> Faculties { get; set; }
		public DbSet<Assignment> Assignments { get; set; }
		public DbSet<AssignmentSubmission> AssignmentSubmissions { get; set; }
		public DbSet<Attendance> Attendances { get; set; }
		public DbSet<Calendar> Calendars { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<FacultyCourse> FacultyCourses { get; set; }
		public DbSet<FeeDetail> FeeDetails { get; set; }
		public DbSet<IssueReport> IssueReports { get; set; }
		public DbSet<StudentCourse> StudentCourses { get; set; }
		public DbSet<LeaveDetail> LeaveDetails { get; set; }
		public DbSet<HomePageDetail> HomePageDetails { get; set; }
		#endregion
		#region SeedData
		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//	base.OnModelCreating(modelBuilder);
		//	#region SeedData
		////	modelBuilder.Entity<Calendar>().HasData(
		////new Calendar { CalendarId = 6, DateOfEdit = DateTime.Now, Status = "Active", Reason = "Semester start" },
		////new Calendar { CalendarId = 7, DateOfEdit = DateTime.Now, Status = "Inactive", Reason = "Public holiday" },
		////new Calendar { CalendarId = 8, DateOfEdit = DateTime.Now, Status = "Active", Reason = "Final exams begin" },
		////new Calendar { CalendarId = 9, DateOfEdit = DateTime.Now, Status = "Inactive", Reason = "Semester break" },
		////new Calendar { CalendarId = 10, DateOfEdit = DateTime.Now, Status = "Active", Reason = "Semester end" });
		////	modelBuilder.Entity<User>().HasData(
		////new User { UserId = 6, UserName = "student1", Password = "pass123", FirstName = "Alice", LastName = "Smith", UserType = "Student" },
		////new User { UserId = 7, UserName = "student2", Password = "pass456", FirstName = "Bob", LastName = "Johnson", UserType = "Student" },
		////new User { UserId = 8, UserName = "student3", Password = "pass789", FirstName = "Charlie", LastName = "Brown", UserType = "Student" },
		////new User { UserId = 9, UserName = "student4", Password = "pass101", FirstName = "Diana", LastName = "Davis", UserType = "Student" },
		////new User { UserId = 10, UserName = "student5", Password = "pass111", FirstName = "Eva", LastName = "Wilson", UserType = "Student" });

		////	modelBuilder.Entity<Faculty>().HasData(
		////new Faculty { FacultyId = 6, FacultyMail = "prof1@example.com", FacultyMobileNo = 1112223333, FacultyAddress = "123 Elm St", FacultyDoj = DateTime.Now, UserId = 11 },
		////new Faculty { FacultyId = 7, FacultyMail = "prof2@example.com", FacultyMobileNo = 4445556666, FacultyAddress = "456 Oak St", FacultyDoj = DateTime.Now, UserId = 12 },
		////new Faculty { FacultyId = 8, FacultyMail = "prof3@example.com", FacultyMobileNo = 7778889999, FacultyAddress = "789 Pine St", FacultyDoj = DateTime.Now, UserId = 13 },
		////new Faculty { FacultyId = 9, FacultyMail = "prof4@example.com", FacultyMobileNo = 1231231234, FacultyAddress = "101 Maple St", FacultyDoj = DateTime.Now, UserId = 14 },
		////new Faculty { FacultyId = 10, FacultyMail = "prof5@example.com", FacultyMobileNo = 4564564567, FacultyAddress = "202 Cedar St", FacultyDoj = DateTime.Now, UserId = 15 });
		////	modelBuilder.Entity<Assignment>().HasData(
		////new Assignment { AssignmentId = 1, Question = "Write a program to calculate factorial", SubmissionTime = DateTime.Now.AddDays(7), CourseCode = 1, StudentId = 1 },
		////new Assignment { AssignmentId = 2, Question = "Design a circuit for a digital clock", SubmissionTime = DateTime.Now.AddDays(7), CourseCode = 2, StudentId = 2 },
		////new Assignment { AssignmentId = 3, Question = "Solve the second law of thermodynamics", SubmissionTime = DateTime.Now.AddDays(7), CourseCode = 3, StudentId = 3 },
		////new Assignment { AssignmentId = 4, Question = "Analyze a truss structure using FEM", SubmissionTime = DateTime.Now.AddDays(7), CourseCode = 4, StudentId = 4 },
		////new Assignment { AssignmentId = 5, Question = "Design a reactor for a chemical process", SubmissionTime = DateTime.Now.AddDays(7), CourseCode = 5, StudentId = 5 });

		////	modelBuilder.Entity<AssignmentSubmission>().HasData(
		////new AssignmentSubmission { SubmissionId = 1, Answer = "Here's the code for factorial calculation", SubmissionDate = DateTime.Now.AddDays(6), StudentId = 1, CourseCode = 1 },
		////new AssignmentSubmission { SubmissionId = 2, Answer = "Attached is the circuit diagram", SubmissionDate = DateTime.Now.AddDays(6), StudentId = 2, CourseCode = 2 },
		////new AssignmentSubmission { SubmissionId = 3, Answer = "Solution to the problem is attached", SubmissionDate = DateTime.Now.AddDays(6), StudentId = 3, CourseCode = 3 },
		////new AssignmentSubmission { SubmissionId = 4, Answer = "FEM analysis report attached", SubmissionDate = DateTime.Now.AddDays(6), StudentId = 4, CourseCode = 4 },
		////new AssignmentSubmission { SubmissionId = 5, Answer = "Chemical reactor design is attached", SubmissionDate = DateTime.Now.AddDays(6), StudentId = 5, CourseCode = 5 });

		////	modelBuilder.Entity<StudentCourse>().HasData(

		////new StudentCourse { SCourseId = 6, CourseName = "Introduction to Programming", StudentId = 1 },
		////new StudentCourse { SCourseId = 7, CourseName = "Digital Circuits", StudentId = 2 },
		////new StudentCourse { SCourseId = 8, CourseName = "Thermodynamics I", StudentId = 3 },
		////new StudentCourse { SCourseId = 9, CourseName = "Structural Analysis", StudentId = 4 },
		////new StudentCourse { SCourseId = 10, CourseName = "Chemical Reaction Engineering", StudentId = 5 }

		////	);
		////	modelBuilder.Entity<Course>().HasData(

		////new Course { CourseCode = 1, CourseName = "Introduction to Computer Science", StudentId = 1, FacultyId = 1 },
		////new Course { CourseCode = 2, CourseName = "Electromagnetic Theory", StudentId = 2, FacultyId = 2 },
		////new Course { CourseCode = 3, CourseName = "Thermodynamics", StudentId = 3, FacultyId = 3 },
		////new Course { CourseCode = 4, CourseName = "Structural Analysis", StudentId = 4, FacultyId = 4 },
		////new Course { CourseCode = 5, CourseName = "Chemical Reaction Engineering", StudentId = 5, FacultyId = 5 }

		////	);

		////	modelBuilder.Entity<FeeDetail>().HasData(

		////new FeeDetail { FeeId = 1, Amount = 5000.00, DateOfPayment = DateTime.Now, StudentId = 1 },
		////new FeeDetail { FeeId = 2, Amount = 6000.00, DateOfPayment = DateTime.Now, StudentId = 2 },
		////new FeeDetail { FeeId = 3, Amount = 5500.00, DateOfPayment = DateTime.Now, StudentId = 3 },
		////new FeeDetail { FeeId = 4, Amount = 5800.00, DateOfPayment = DateTime.Now, StudentId = 4 },
		////new FeeDetail { FeeId = 5, Amount = 5200.00, DateOfPayment = DateTime.Now, StudentId = 5 }

		////	);

		////	modelBuilder.Entity<StudentCourse>().HasData(

		////new StudentCourse { SCourseId = 1, CourseName = "Introduction to Computer Science", StudentId = 1 },
		////new StudentCourse { SCourseId = 2, CourseName = "Electromagnetic Theory", StudentId = 2 },
		////new StudentCourse { SCourseId = 3, CourseName = "Thermodynamics", StudentId = 3 },
		////new StudentCourse { SCourseId = 4, CourseName = "Structural Analysis", StudentId = 4 },
		////new StudentCourse { SCourseId = 5, CourseName = "Chemical Reaction Engineering", StudentId = 5 }

		////	);
		////	modelBuilder.Entity<Student>().HasData(

		////new Student { StudentId = 1, StudentDepartment = "Computer Science", CourseName = "B.Tech", StudentMail = "john@example.com", StudentMobile = "1234567890", StudentAddress = "123 Main St", UserId = 2 },
		////new Student { StudentId = 2, StudentDepartment = "Electrical Engineering", CourseName = "B.Tech", StudentMail = "jane@example.com", StudentMobile = "9876543210", StudentAddress = "456 Elm St", UserId = 3 },
		////new Student { StudentId = 3, StudentDepartment = "Mechanical Engineering", CourseName = "B.Tech", StudentMail = "smith@example.com", StudentMobile = "5555555555", StudentAddress = "789 Oak St", UserId = 4 },
		////new Student { StudentId = 4, StudentDepartment = "Civil Engineering", CourseName = "B.Tech", StudentMail = "emily@example.com", StudentMobile = "9999999999", StudentAddress = "101 Pine St", UserId = 5 },
		////new Student { StudentId = 5, StudentDepartment = "Chemical Engineering", CourseName = "B.Tech", StudentMail = "mary@example.com", StudentMobile = "1111111111", StudentAddress = "202 Maple St", UserId = 6 }

		////	);

		////	modelBuilder.Entity<FacultyCourse>().HasData(

		////new FacultyCourse { FacultyCourseId = 1, CourseName = "Computer Science", FacultyId = 1 },
		////new FacultyCourse { FacultyCourseId = 2, CourseName = "Electrical Engineering", FacultyId = 2 },
		////new FacultyCourse { FacultyCourseId = 3, CourseName = "Mechanical Engineering", FacultyId = 3 },
		////new FacultyCourse { FacultyCourseId = 4, CourseName = "Civil Engineering", FacultyId = 4 },
		////new FacultyCourse { FacultyCourseId = 5, CourseName = "Chemical Engineering", FacultyId = 5 }

		////	);

		////	modelBuilder.Entity<Attendance>().HasData(

		////new Attendance { AttendanceId = 1, AttendanceDate = DateTime.Now, IsPresent = "Yes", StudentId = 1, FacultyId = 1 },
		////new Attendance { AttendanceId = 2, AttendanceDate = DateTime.Now, IsPresent = "Yes", StudentId = 2, FacultyId = 2 },
		////new Attendance { AttendanceId = 3, AttendanceDate = DateTime.Now, IsPresent = "Yes", StudentId = 3, FacultyId = 3 },
		////new Attendance { AttendanceId = 4, AttendanceDate = DateTime.Now, IsPresent = "Yes", StudentId = 4, FacultyId = 4 },
		////new Attendance { AttendanceId = 5, AttendanceDate = DateTime.Now, IsPresent = "Yes", StudentId = 5, FacultyId = 5 }
		////		);
		////	modelBuilder.Entity<IssueReport>().HasData(
		////		new List<IssueReport>
		////		{
		////new IssueReport { Ticket = 1, Description = "Bug in login page", IsResolved = false, UserId = 2 },
		////new IssueReport { Ticket = 2, Description = "Error in payment processing", IsResolved = false, UserId = 3 },
		////new IssueReport { Ticket = 3, Description = "Website loading slow", IsResolved = false, UserId = 4 },
		////new IssueReport { Ticket = 4, Description = "Missing functionality in dashboard", IsResolved = false, UserId = 5 },
		////new IssueReport { Ticket = 5, Description = "Data not updating in real-time", IsResolved = false, UserId = 6 }
		////		}
		////	);

		////	modelBuilder.Entity<LeaveDetail>().HasData(

		////new LeaveDetail { LeaveDetailsId = 1, Reason = "Vacation", DateOfLeave = DateTime.Now, IsApproved = true, UserId = 2 },
		////new LeaveDetail { LeaveDetailsId = 2, Reason = "Sick leave", DateOfLeave = DateTime.Now, IsApproved = true, UserId = 3 },
		////new LeaveDetail { LeaveDetailsId = 3, Reason = "Personal reasons", DateOfLeave = DateTime.Now, IsApproved = false, UserId = 4 },
		////new LeaveDetail { LeaveDetailsId = 4, Reason = "Family emergency", DateOfLeave = DateTime.Now, IsApproved = false, UserId = 5 },
		////new LeaveDetail { LeaveDetailsId = 5, Reason = "Attending conference", DateOfLeave = DateTime.Now, IsApproved = true, UserId = 6 }
		////		);

		////	modelBuilder.Entity<Parent>().HasData(

		////new Parent { ParentId = 1, ParentAddress = "789 Oak St", UserId = 4 },
		////new Parent { ParentId = 2, ParentAddress = "101 Pine St", UserId = 5 },
		////new Parent { ParentId = 3, ParentAddress = "202 Maple St", UserId = 6 },
		////new Parent { ParentId = 4, ParentAddress = "303 Elm St", UserId = 7 },
		////new Parent { ParentId = 5, ParentAddress = "404 Oak St", UserId = 8 }
		////		);
		////	modelBuilder.Entity<Calendar>().HasData(

		////new Calendar { CalendarId = 1, DateOfEdit = DateTime.Now, Status = "Active", Reason = "Holiday" },
		////new Calendar { CalendarId = 2, DateOfEdit = DateTime.Now, Status = "Inactive", Reason = "Maintenance" },
		////new Calendar { CalendarId = 3, DateOfEdit = DateTime.Now, Status = "Active", Reason = "Training" },
		////new Calendar { CalendarId = 4, DateOfEdit = DateTime.Now, Status = "Inactive", Reason = "Meeting" },
		////new Calendar { CalendarId = 5, DateOfEdit = DateTime.Now, Status = "Active", Reason = "Conference" }
		////		);

		////	modelBuilder.Entity<User>().HasData(
		////		new List<User>
		////		{
		////new User { UserId = 1, UserName = "admin", Password = "admin123", FirstName = "Admin", LastName = "User", UserType = "Admin" },
		////new User { UserId = 2, UserName = "john_doe", Password = "pass123", FirstName = "John", LastName = "Doe", UserType = "Regular" },
		////new User { UserId = 3, UserName = "jane_doe", Password = "pass456", FirstName = "Jane", LastName = "Doe", UserType = "Regular" },
		////new User { UserId = 4, UserName = "smith", Password = "smith123", FirstName = "Smith", LastName = "Johnson", UserType = "Regular" },
		////new User { UserId = 5, UserName = "emily", Password = "emily123", FirstName = "Emily", LastName = "Smith", UserType = "Regular" }
		////		}
		////	);

		////	modelBuilder.Entity<Faculty>().HasData(

		////new Faculty { FacultyId = 1, FacultyMail = "john@example.com", FacultyMobileNo = 1234567890, FacultyAddress = "123 Main St", FacultyDoj = DateTime.Now, UserId = 2 },
		////new Faculty { FacultyId = 2, FacultyMail = "jane@example.com", FacultyMobileNo = 9876543210, FacultyAddress = "456 Elm St", FacultyDoj = DateTime.Now, UserId = 3 },
		////new Faculty { FacultyId = 3, FacultyMail = "smith@example.com", FacultyMobileNo = 5555555555, FacultyAddress = "789 Oak St", FacultyDoj = DateTime.Now, UserId = 4 },
		////new Faculty { FacultyId = 4, FacultyMail = "emily@example.com", FacultyMobileNo = 9999999999, FacultyAddress = "101 Pine St", FacultyDoj = DateTime.Now, UserId = 5 },
		////new Faculty { FacultyId = 5, FacultyMail = "mary@example.com", FacultyMobileNo = 1111111111, FacultyAddress = "202 Maple St", FacultyDoj = DateTime.Now, UserId = 1 });
		////	modelBuilder.Entity<HomePageDetail>().HasData(
		////new HomePageDetail { Id = 1, Key = "ScrollingNotification", Value = "Admissions are open now. Please check admission form soon. Seats are filling..!" });
		//	#endregion
		//}
		#endregion
	}
}
