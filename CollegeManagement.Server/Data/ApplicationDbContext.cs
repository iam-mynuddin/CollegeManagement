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
		public DbSet<Subject> Subjects { get; set; }
		public DbSet<FacultySubjects> FacultySubjects { get; set; }
		public DbSet<FeeDetail> FeeDetails { get; set; }
		public DbSet<IssueReport> IssueReports { get; set; }
		public DbSet<StudentCourse> StudentCourses { get; set; }
		public DbSet<LeaveDetail> LeaveDetails { get; set; }
		public DbSet<HomePageDetail> HomePageDetails { get; set; }
		#endregion
	}
}
