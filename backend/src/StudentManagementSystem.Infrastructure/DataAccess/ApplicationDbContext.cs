using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Domain.Enums;

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

        public DbSet<CourseSemester> CourseSemesters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();

            modelBuilder.Entity<Semester>()
                .Property(s => s.SemesterCode)
                .HasComputedColumnSql("CONCAT(LEFT(SemesterName, 2), RIGHT(AcademicYear, 2)) PERSISTED")
                ;

            modelBuilder.Entity<Course>()
                .HasIndex(c => c.CourseCode)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.StudentCode)
                .IsUnique();

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<StudentSemester>()
                .HasOne(ss => ss.Student)
                .WithMany(s => s.StudentSemesters)
                .HasForeignKey(ss => ss.StudentId);

            modelBuilder.Entity<StudentSemester>()
                .HasOne(ss => ss.Semester)
                .WithMany(s => s.StudentSemesters)
                .HasForeignKey(ss => ss.SemesterId);

            modelBuilder.Entity<CourseSemester>()
                .HasKey(cs => new { cs.CourseId, cs.SemesterId });

            modelBuilder.Entity<CourseSemester>()
                .HasOne(cs => cs.Course)
                .WithMany(c => c.CourseSemesters)
                .HasForeignKey(cs => cs.CourseId);

            modelBuilder.Entity<CourseSemester>()
                .HasOne(cs => cs.Semester)
                .WithMany(s => s.CourseSemesters)
                .HasForeignKey(cs => cs.SemesterId);

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            var adminHN = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Admin",
                LastName = "Ha Noi",
                Email = "adminHN@fpt.edu.vn",
                StudentCode = "HE999999",
                DateOfBirth = new DateTime(1970, 04, 02),
                JoinedDate = new DateTime(2000, 04, 02),
                UserName = "adminHN",
                Role = RoleType.Admin,
                Location = LocationType.HaNoi
            };

            adminHN.PasswordHash = _passwordHasher.HashPassword(adminHN, "Admin@123");
            adminHN.CreatedOn = DateTime.Now;
            adminHN.CreatedBy = "System";

            var adminHCM = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Admin",
                LastName = "Ho Chi Minh",
                StudentCode = "HE999998",
                Email = "adminHCM@fpt.edu.vn",
                DateOfBirth = new DateTime(1970, 04, 02),
                JoinedDate = new DateTime(2000, 04, 02),
                UserName = "adminHCM",
                Role = RoleType.Admin,
                Location = LocationType.HoChiMinh
            };

            adminHCM.PasswordHash = _passwordHasher.HashPassword(adminHCM, "Admin@123");
            adminHCM.CreatedOn = DateTime.Now;
            adminHCM.CreatedBy = "System";

            var adminDN = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Admin",
                LastName = "Da Nang",
                StudentCode = "HE999997",
                Email = "adminDN@fpt.edu.vn",
                DateOfBirth = new DateTime(1970, 04, 02),
                JoinedDate = new DateTime(2000, 04, 02),
                UserName = "adminDN",
                Role = RoleType.Admin,
                Location = LocationType.DaNang
            };

            adminDN.PasswordHash = _passwordHasher.HashPassword(adminDN, "Admin@123");
            adminDN.CreatedOn = DateTime.Now;
            adminDN.CreatedBy = "System";

            //seed data user

            var userHoatt = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Hoa",
                LastName = "Truong Trong",
                StudentCode = "HE999996",
                Email = "hoangttHE999996@fpt.edu.vn",
                DateOfBirth = new DateTime(2002, 04, 02),
                JoinedDate = new DateTime(2020, 04, 02),
                UserName = "hoangtt",
                Role = RoleType.Student,
                Location = LocationType.HaNoi
            };

            userHoatt.PasswordHash = _passwordHasher.HashPassword(userHoatt, "hoatt@02042002");
            userHoatt.CreatedOn = DateTime.Now;
            userHoatt.CreatedBy = "System";

            var userThanhdt = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Thanh",
                LastName = "Nguyen Duc",
                StudentCode = "HE999995",
                Email = "thanhdtHE999995@fpt.edu.vn",
                DateOfBirth = new DateTime(2002, 04, 02),
                JoinedDate = new DateTime(2020, 04, 02),
                UserName = "thanhdt",
                Role = RoleType.Student,
                Location = LocationType.HaNoi
            };

            userThanhdt.PasswordHash = _passwordHasher.HashPassword(userThanhdt, "thanhdt@02042002");
            userThanhdt.CreatedOn = DateTime.Now;
            userThanhdt.CreatedBy = "System";

            modelBuilder.Entity<User>().HasData(adminHN, adminHCM, adminDN);
            modelBuilder.Entity<User>().HasData(userHoatt, userThanhdt);
        }
    }
}