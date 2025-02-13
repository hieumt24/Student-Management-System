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
    [Migration("20240718095549_add location new user")]
    partial class addlocationnewuser
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
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int>("MaxStudent")
                        .HasColumnType("int");

                    b.Property<Guid>("SemesterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SemesterId");

                    b.ToTable("Courses");
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

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsPassed")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("LastModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2a62b407-6fa8-4988-ba57-fca4ab04ff24"),
                            CreatedBy = "System",
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 7, 18, 16, 55, 48, 681, DateTimeKind.Unspecified).AddTicks(3736), new TimeSpan(0, 7, 0, 0, 0)),
                            DateOfBirth = new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "adminHN@fpt.edu.vn",
                            FirstName = "Admin",
                            IsDeleted = false,
                            JoinedDate = new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Ha Noi",
                            Location = 1,
                            PasswordHash = "AQAAAAIAAYagAAAAEGokK0vzbSV7G57nR1f7o54QcgR87yC4YMs2igMDnHUEuXevSjvPqv2U7s1pfoJF4A==",
                            Role = 1,
                            StudentCode = "HE999999",
                            UserName = "adminHN"
                        },
                        new
                        {
                            Id = new Guid("5f286934-8da8-4941-9ec8-712d475dc4fd"),
                            CreatedBy = "System",
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 7, 18, 16, 55, 48, 783, DateTimeKind.Unspecified).AddTicks(8734), new TimeSpan(0, 7, 0, 0, 0)),
                            DateOfBirth = new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "adminHCM@fpt.edu.vn",
                            FirstName = "Admin",
                            IsDeleted = false,
                            JoinedDate = new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Ho Chi Minh",
                            Location = 2,
                            PasswordHash = "AQAAAAIAAYagAAAAEJglklcduDrtO7opCwl8hTqPWuJ8HSPWNHjgLZv+TP4Txlwnz2amqrXL0A3uHhdbWQ==",
                            Role = 1,
                            StudentCode = "HE999998",
                            UserName = "adminHCM"
                        },
                        new
                        {
                            Id = new Guid("a6a9e147-f323-4b96-be02-92fef9b05dfc"),
                            CreatedBy = "System",
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 7, 18, 16, 55, 48, 898, DateTimeKind.Unspecified).AddTicks(2226), new TimeSpan(0, 7, 0, 0, 0)),
                            DateOfBirth = new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "adminDN@fpt.edu.vn",
                            FirstName = "Admin",
                            IsDeleted = false,
                            JoinedDate = new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Da Nang",
                            Location = 3,
                            PasswordHash = "AQAAAAIAAYagAAAAECcIVP4/aZBs4XAp6mPRgCrH6roPy3eur6MSDk1OH8OREqC8s8R7pYVvS2o+TsGCew==",
                            Role = 1,
                            StudentCode = "HE999997",
                            UserName = "adminDN"
                        },
                        new
                        {
                            Id = new Guid("81a96b04-e24f-46f2-874d-c3e556a2334e"),
                            CreatedBy = "System",
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 7, 18, 16, 55, 49, 6, DateTimeKind.Unspecified).AddTicks(5239), new TimeSpan(0, 7, 0, 0, 0)),
                            DateOfBirth = new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hoangttHE999996@fpt.edu.vn",
                            FirstName = "Hoa",
                            IsDeleted = false,
                            JoinedDate = new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Truong Trong",
                            Location = 1,
                            PasswordHash = "AQAAAAIAAYagAAAAEPepD3+v3gqyehsBriuCRv4kz0W2tSOA3Z7A1Q+eDbw+5s4DIsadnFti8Be+TUf7KQ==",
                            Role = 2,
                            StudentCode = "HE999996",
                            UserName = "hoangtt"
                        },
                        new
                        {
                            Id = new Guid("e739d79e-0508-4118-af62-32cacb178bc9"),
                            CreatedBy = "System",
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 7, 18, 16, 55, 49, 149, DateTimeKind.Unspecified).AddTicks(6018), new TimeSpan(0, 7, 0, 0, 0)),
                            DateOfBirth = new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "thanhdtHE999995@fpt.edu.vn",
                            FirstName = "Thanh",
                            IsDeleted = false,
                            JoinedDate = new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Nguyen Duc",
                            Location = 1,
                            PasswordHash = "AQAAAAIAAYagAAAAEPJnb4UfbzEK6ie7HquiypKSzvaHOpWmC8zczng9yarzj4X7NALO3KgjS++L3Eu3/g==",
                            Role = 2,
                            StudentCode = "HE999995",
                            UserName = "thanhdt"
                        });
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.Course", b =>
                {
                    b.HasOne("StudentManagementSystem.Domain.Entities.Semester", "Semester")
                        .WithMany("Courses")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semester");
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.Enrollment", b =>
                {
                    b.HasOne("StudentManagementSystem.Domain.Entities.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementSystem.Domain.Entities.User", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

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
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("StudentManagementSystem.Domain.Entities.Semester", b =>
                {
                    b.Navigation("Courses");

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
