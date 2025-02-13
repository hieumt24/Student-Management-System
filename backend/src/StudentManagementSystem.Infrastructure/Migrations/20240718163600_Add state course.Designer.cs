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
    [Migration("20240718163600_Add state course")]
    partial class Addstatecourse
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

                    b.Property<Guid>("SemesterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseCode")
                        .IsUnique();

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

                    b.Property<int>("Location")
                        .HasColumnType("int");

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
                            Id = new Guid("b48d9d71-d153-4943-8989-9befea44a6f4"),
                            CreatedBy = "System",
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 7, 18, 23, 35, 59, 68, DateTimeKind.Unspecified).AddTicks(9852), new TimeSpan(0, 7, 0, 0, 0)),
                            DateOfBirth = new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "adminHN@fpt.edu.vn",
                            FirstName = "Admin",
                            IsDeleted = false,
                            JoinedDate = new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Ha Noi",
                            Location = 1,
                            PasswordHash = "AQAAAAIAAYagAAAAEP6N1cN3sIc0qMQIkRBgXId+jxnwkM5SMX3uTWLXhHTcczvFWlefWgAZNcOKfIweLQ==",
                            Role = 1,
                            StudentCode = "HE999999",
                            UserName = "adminHN"
                        },
                        new
                        {
                            Id = new Guid("0cffa71f-c7c3-4704-904c-66dddedb57ef"),
                            CreatedBy = "System",
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 7, 18, 23, 35, 59, 207, DateTimeKind.Unspecified).AddTicks(2316), new TimeSpan(0, 7, 0, 0, 0)),
                            DateOfBirth = new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "adminHCM@fpt.edu.vn",
                            FirstName = "Admin",
                            IsDeleted = false,
                            JoinedDate = new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Ho Chi Minh",
                            Location = 2,
                            PasswordHash = "AQAAAAIAAYagAAAAEExpfD2tfUjDNJMJEHG1XR2Hu8/fapGUcOYx2FEqAjvtwh59ldFIDACBrm4rQsB3+A==",
                            Role = 1,
                            StudentCode = "HE999998",
                            UserName = "adminHCM"
                        },
                        new
                        {
                            Id = new Guid("e2b7ef29-e3b5-4889-a34a-2fa71de2cb32"),
                            CreatedBy = "System",
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 7, 18, 23, 35, 59, 316, DateTimeKind.Unspecified).AddTicks(9744), new TimeSpan(0, 7, 0, 0, 0)),
                            DateOfBirth = new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "adminDN@fpt.edu.vn",
                            FirstName = "Admin",
                            IsDeleted = false,
                            JoinedDate = new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Da Nang",
                            Location = 3,
                            PasswordHash = "AQAAAAIAAYagAAAAEBwo9y+bV2QKG7J6umvUqFZq0NNFbAD4hNLGiSFYOIqfHBULBFD4gYnUZl1Zye2o9A==",
                            Role = 1,
                            StudentCode = "HE999997",
                            UserName = "adminDN"
                        },
                        new
                        {
                            Id = new Guid("e385b199-d77e-4ad9-a193-8b685476a406"),
                            CreatedBy = "System",
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 7, 18, 23, 35, 59, 465, DateTimeKind.Unspecified).AddTicks(7321), new TimeSpan(0, 7, 0, 0, 0)),
                            DateOfBirth = new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hoangttHE999996@fpt.edu.vn",
                            FirstName = "Hoa",
                            IsDeleted = false,
                            JoinedDate = new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Truong Trong",
                            Location = 1,
                            PasswordHash = "AQAAAAIAAYagAAAAEJd7J+gvWuiHqxyPQs6ZkNiqkxZ78mzo4jlab71Eyg7oe/ytP4kFGMbTz82kGAVHyQ==",
                            Role = 2,
                            StudentCode = "HE999996",
                            UserName = "hoangtt"
                        },
                        new
                        {
                            Id = new Guid("3a7c2793-016e-448c-b338-3a2b589afd2c"),
                            CreatedBy = "System",
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 7, 18, 23, 35, 59, 609, DateTimeKind.Unspecified).AddTicks(4189), new TimeSpan(0, 7, 0, 0, 0)),
                            DateOfBirth = new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "thanhdtHE999995@fpt.edu.vn",
                            FirstName = "Thanh",
                            IsDeleted = false,
                            JoinedDate = new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Nguyen Duc",
                            Location = 1,
                            PasswordHash = "AQAAAAIAAYagAAAAEH09J++0syrEE+EV7nXt5xIMkxHeQq26LF76kEPQoJrt213x9hnLAd3oLH7KoztfBg==",
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
