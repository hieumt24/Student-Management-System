using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addnewtableCourseSemester : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1cacc9d2-4253-44d5-b29e-9f5923810cc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("268bdb31-23f6-4899-a811-5a4ed2d5610c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34e51e66-8341-4e88-a6c7-756e3093ad49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("515ba009-7e91-4adf-85c7-f60298107aa2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6de32cd3-62ef-49d2-90c7-4f1f79c6bd51"));

            migrationBuilder.CreateTable(
                name: "CourseSemesters",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SemesterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSemesters", x => new { x.CourseId, x.SemesterId });
                    table.ForeignKey(
                        name: "FK_CourseSemesters_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseSemesters_Semesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semesters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("5790b861-90cd-4d03-af3c-5f9bbdf73aab"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 9, 25, 44, 130, DateTimeKind.Unspecified).AddTicks(4366), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAELDXptzEi2zmBffRBRf42PzeygMoic8vHB3NJu73i0Ed9TDNob/g/ZehyfkBIbdrUA==", 2, "HE999996", "hoangtt" },
                    { new Guid("68d8cac1-529a-4407-8583-647ec1fbed4b"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 9, 25, 44, 278, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAEN5vNh2AOtZjImgp7XkUwm/DZphFcB0r4sMfydH74uhQmXIsNJ6PIxwzSJV203FxBg==", 2, "HE999995", "thanhdt" },
                    { new Guid("8df00c7a-5221-46ce-bc43-4498d8dd9491"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 9, 25, 43, 897, DateTimeKind.Unspecified).AddTicks(8536), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEEvtAf0jKLkcJmv+JnOFFOdLft+MH4cbXtKffnq1PlHigl8PRPY5YYyhgiL2Sb+2IA==", 1, "HE999998", "adminHCM" },
                    { new Guid("bc6218a0-1efe-4426-b19e-9f9b9d9665a5"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 9, 25, 44, 12, DateTimeKind.Unspecified).AddTicks(5239), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAEOLevZ0XS6BLo2nu3uUXhlXEQk0Q0pWSEr35ZINROETK0VixIHxu3Aecn0sTezrgng==", 1, "HE999997", "adminDN" },
                    { new Guid("d8a060f8-08d0-4fc1-94e0-b70d7e574fab"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 9, 25, 43, 762, DateTimeKind.Unspecified).AddTicks(9524), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEGWSI7q3Y1/4gMxUUMFLd68lbPRt78Xgrph2WTjwbg1mBSwpynY2e1jauMTiRrWp1g==", 1, "HE999999", "adminHN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseSemesters_SemesterId",
                table: "CourseSemesters",
                column: "SemesterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseSemesters");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5790b861-90cd-4d03-af3c-5f9bbdf73aab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68d8cac1-529a-4407-8583-647ec1fbed4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8df00c7a-5221-46ce-bc43-4498d8dd9491"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc6218a0-1efe-4426-b19e-9f9b9d9665a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8a060f8-08d0-4fc1-94e0-b70d7e574fab"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("1cacc9d2-4253-44d5-b29e-9f5923810cc8"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 8, 58, 33, 496, DateTimeKind.Unspecified).AddTicks(729), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEKT9GMscOz/pl0NJTPc7Cuv3U0Y3gd0/MzAgwo+0w5C6fbkF4ASAWBl/20oUiLlhbg==", 1, "HE999999", "adminHN" },
                    { new Guid("268bdb31-23f6-4899-a811-5a4ed2d5610c"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 8, 58, 33, 703, DateTimeKind.Unspecified).AddTicks(6884), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAEKbpfGLqXt5PAM4AiYUrSe4kr/p/vY2zaLk00LhP0c/SOxTPtJ1mFTghOLtJpcqwiw==", 1, "HE999997", "adminDN" },
                    { new Guid("34e51e66-8341-4e88-a6c7-756e3093ad49"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 8, 58, 33, 829, DateTimeKind.Unspecified).AddTicks(6061), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAEGaN+rwy/8+ukpIWdcPwCj/m1ERynOC2HcG3H0B2ikbJzV8CkPFJDZJSyTmV9oRYOA==", 2, "HE999996", "hoangtt" },
                    { new Guid("515ba009-7e91-4adf-85c7-f60298107aa2"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 8, 58, 33, 600, DateTimeKind.Unspecified).AddTicks(6119), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAENFGrQtR5VFQvzkrYOE8j9Lqh6XL3VYiWrDvOErwVjNLxs21xEUEpo8SGZuMrJ/kyA==", 1, "HE999998", "adminHCM" },
                    { new Guid("6de32cd3-62ef-49d2-90c7-4f1f79c6bd51"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 8, 58, 33, 949, DateTimeKind.Unspecified).AddTicks(3532), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAEFI/ZvgV/LJtJqKmgAV9NNbtO3yCn48mEAL95u5PRQLrEFlTRNQUEOZg7bE8pK/XAQ==", 2, "HE999995", "thanhdt" }
                });
        }
    }
}
