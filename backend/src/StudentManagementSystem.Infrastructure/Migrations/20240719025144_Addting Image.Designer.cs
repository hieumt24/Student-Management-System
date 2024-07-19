﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManagementSystem.Infrastructure.DataAccess;

#nullable disable

namespace StudentManagementSystem.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240719025144_Addting Image")]
    partial class AddtingImage
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.BlackListToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BlackListTokens");
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CourseState")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("MaxStudent")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseCode")
                        .IsUnique();

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.CourseSemester", b =>
                {
                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SemesterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CourseId", "SemesterId");

                    b.HasIndex("SemesterId");

                    b.ToTable("CourseSemesters");
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.Enrollment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<double?>("Grade")
                        .HasColumnType("float");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsPassed")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Location")
                        .HasColumnType("int");

                    b.Property<Guid>("SemesterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSizeInBytes")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.Semester", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AcademicYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("SemesterCode")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("nvarchar(max)")
                        .HasComputedColumnSql("CONCAT(LEFT(SemesterName, 2), RIGHT(AcademicYear, 2)) PERSISTED");

                    b.Property<string>("SemesterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.StudentSemester", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("SemesterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SemesterId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentSemester");
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.Token", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("JoinedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Location")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("StudentCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("StudentCode")
                        .IsUnique()
                        .HasFilter("[StudentCode] IS NOT NULL");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("20c331c6-1080-4fb9-a9a7-f424d65677d0"),
                            CreatedBy = "System",
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 7, 19, 9, 51, 43, 451, DateTimeKind.Unspecified).AddTicks(2436), new TimeSpan(0, 7, 0, 0, 0)),
                            DateOfBirth = new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "adminHN@fpt.edu.vn",
                            FirstName = "Admin",
                            IsDeleted = false,
                            JoinedDate = new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Ha Noi",
                            Location = 1,
                            PasswordHash = "AQAAAAIAAYagAAAAEKHdWD6InVl6wPNhQ8trJGnK+DUOj+cG8X9tmuZJ8vx8pMuDUUcDHx+jpHBDaoQWWQ==",
                            Role = 1,
                            StudentCode = "HE999999",
                            UserName = "adminHN"
                        },
                        new
                        {
                            Id = new Guid("31dbb180-efe3-4221-87a2-1ad1ee801856"),
                            CreatedBy = "System",
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 7, 19, 9, 51, 43, 574, DateTimeKind.Unspecified).AddTicks(7388), new TimeSpan(0, 7, 0, 0, 0)),
                            DateOfBirth = new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "adminHCM@fpt.edu.vn",
                            FirstName = "Admin",
                            IsDeleted = false,
                            JoinedDate = new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Ho Chi Minh",
                            Location = 2,
                            PasswordHash = "AQAAAAIAAYagAAAAEBA+CcUzcehlQeipQO4bhJ/iB6DdHt+Ggcy6YctO+lcs+35siH02eQ3QCoQIROxU7w==",
                            Role = 1,
                            StudentCode = "HE999998",
                            UserName = "adminHCM"
                        },
                        new
                        {
                            Id = new Guid("e56f6d84-8c57-4116-9983-0c1331a4d225"),
                            CreatedBy = "System",
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 7, 19, 9, 51, 43, 701, DateTimeKind.Unspecified).AddTicks(522), new TimeSpan(0, 7, 0, 0, 0)),
                            DateOfBirth = new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "adminDN@fpt.edu.vn",
                            FirstName = "Admin",
                            IsDeleted = false,
                            JoinedDate = new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Da Nang",
                            Location = 3,
                            PasswordHash = "AQAAAAIAAYagAAAAEEErjL4MHv9yDmzV0JTSU5Y2SheOtGjuCVmRz7fb6d7qf2h96gWNzdZyJEycz6I+kA==",
                            Role = 1,
                            StudentCode = "HE999997",
                            UserName = "adminDN"
                        },
                        new
                        {
                            Id = new Guid("e307d859-0835-49ce-868f-530d940eb7ed"),
                            CreatedBy = "System",
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 7, 19, 9, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(1806), new TimeSpan(0, 7, 0, 0, 0)),
                            DateOfBirth = new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hoangttHE999996@fpt.edu.vn",
                            FirstName = "Hoa",
                            IsDeleted = false,
                            JoinedDate = new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Truong Trong",
                            Location = 1,
                            PasswordHash = "AQAAAAIAAYagAAAAEElVPRF15N174C4Qg/zabrZAsCv7GRskjv1HvyU5pON24LctGrHgIAJr5tWAyi59hw==",
                            Role = 2,
                            StudentCode = "HE999996",
                            UserName = "hoangtt"
                        },
                        new
                        {
                            Id = new Guid("30b30026-c30f-47e7-901c-9a4de66da679"),
                            CreatedBy = "System",
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 7, 19, 9, 51, 43, 950, DateTimeKind.Unspecified).AddTicks(5178), new TimeSpan(0, 7, 0, 0, 0)),
                            DateOfBirth = new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "thanhdtHE999995@fpt.edu.vn",
                            FirstName = "Thanh",
                            IsDeleted = false,
                            JoinedDate = new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Nguyen Duc",
                            Location = 1,
                            PasswordHash = "AQAAAAIAAYagAAAAEH2nK0wL7j/PKC3N4vPXJdCj6PuEx7puclyMBFM1qO649EZla+8PlUYdEoV5HsVL0A==",
                            Role = 2,
                            StudentCode = "HE999995",
                            UserName = "thanhdt"
                        });
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.CourseSemester", b =>
                {
                    b.HasOne("StudentManagementSystem.Domain.Entities.Course", "Course")
                        .WithMany("CourseSemesters")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementSystem.Domain.Entities.Semester", "Semester")
                        .WithMany("CourseSemesters")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Semester");
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.Enrollment", b =>
                {
                    b.HasOne("StudentManagementSystem.Domain.Entities.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementSystem.Domain.Entities.Semester", "Semester")
                        .WithMany("Enrollment")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementSystem.Domain.Entities.User", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Semester");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.StudentSemester", b =>
                {
                    b.HasOne("StudentManagementSystem.Domain.Entities.Semester", "Semester")
                        .WithMany("StudentSemesters")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementSystem.Domain.Entities.User", "Student")
                        .WithMany("StudentSemesters")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semester");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.Token", b =>
                {
                    b.HasOne("StudentManagementSystem.Domain.Entities.User", "User")
                        .WithOne("Token")
                        .HasForeignKey("StudentManagementSystem.Domain.Entities.Token", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.Course", b =>
                {
                    b.Navigation("CourseSemesters");

                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.Semester", b =>
                {
                    b.Navigation("CourseSemesters");

                    b.Navigation("Enrollment");

                    b.Navigation("StudentSemesters");
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.User", b =>
                {
                    b.Navigation("Enrollments");

                    b.Navigation("StudentSemesters");

                    b.Navigation("Token");
                });
#pragma warning restore 612, 618
        }
    }
}