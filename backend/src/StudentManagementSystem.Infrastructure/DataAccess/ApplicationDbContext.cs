using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Domain.Entities;

namespace StudentManagementSystem.Infrastructure.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        private readonly PasswordHasher<User> _passwordHasher = new PasswordHasher<User>();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<BlackListToken> BlackListTokens { get; set; }
        public DbSet<Semester> Semesters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();

            modelBuilder.Entity<Semester>()
                .Property(s => s.SemesterCode)
                .HasComputedColumnSql("CONCAT(LEFT(SemesterName, 2), RIGHT(AcademicYear, 2)) PERSISTED");

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Semester)
                .WithMany(s => s.Courses)
                .HasForeignKey(c => c.SemesterId);

            modelBuilder.Entity<StudentSemester>()
                .HasOne(ss => ss.Student)
                .WithMany(s => s.StudentSemesters)
                .HasForeignKey(ss => ss.StudentId);

            modelBuilder.Entity<StudentSemester>()
                .HasOne(ss => ss.Semester)
                .WithMany(s => s.StudentSemesters)
                .HasForeignKey(ss => ss.SemesterId);
        }
    }
}