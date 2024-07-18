using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class configsemester1N : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Enrollments_SemesterId",
                table: "Enrollments");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e7ac0f3-cc44-48c9-a9d9-893fc6a37e4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("487bff65-6b24-4a2e-bfa1-0c1af575bf98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73676786-65f7-4659-9cae-a4d72145a3bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abc5de65-d1a9-4d83-bbd5-a3fef7cfaeb1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f22a4313-4032-4cdf-8989-275ad17ad02a"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_SemesterId",
                table: "Enrollments",
                column: "SemesterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Enrollments_SemesterId",
                table: "Enrollments");

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("3e7ac0f3-cc44-48c9-a9d9-893fc6a37e4f"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 8, 27, 18, 837, DateTimeKind.Unspecified).AddTicks(1648), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAEIVDjVb5GsaNhZ5hjbVWW6xLHcgWC+uPHNbi02eegsbCDmxlgPQXVV9VTCXusE06hg==", 2, "HE999996", "hoangtt" },
                    { new Guid("487bff65-6b24-4a2e-bfa1-0c1af575bf98"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 8, 27, 18, 923, DateTimeKind.Unspecified).AddTicks(9809), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAEFnIGgR6QcZ49VQ21K6Q+EGThBKXB2gt6IqmEdcm6ss2/9/BUEYAPVQOY2CE+EWN9g==", 2, "HE999995", "thanhdt" },
                    { new Guid("73676786-65f7-4659-9cae-a4d72145a3bf"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 8, 27, 18, 547, DateTimeKind.Unspecified).AddTicks(8373), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEOhXv6XKexi6TOM60MC1+JtQ0xOaYzTDofaHjfAnBrn4NDBHQAowt9FYn4NDsfK4sA==", 1, "HE999999", "adminHN" },
                    { new Guid("abc5de65-d1a9-4d83-bbd5-a3fef7cfaeb1"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 8, 27, 18, 639, DateTimeKind.Unspecified).AddTicks(7374), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEL8r5WWldcECfE/st+i5EDJDIhZEzwoawuagPfDTyPQqGPJlNMDPYyC1dVZaanjcRg==", 1, "HE999998", "adminHCM" },
                    { new Guid("f22a4313-4032-4cdf-8989-275ad17ad02a"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 8, 27, 18, 746, DateTimeKind.Unspecified).AddTicks(4295), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAEPLfHkhzzxVL48TVaicQgo5k0wN3b8qqMGIc9csJohDWt9mfcUD4aBHOc5wvKFuyGw==", 1, "HE999997", "adminDN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_SemesterId",
                table: "Enrollments",
                column: "SemesterId",
                unique: true);
        }
    }
}
