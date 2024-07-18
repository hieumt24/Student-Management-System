using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Addstatecourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b1bee18-e4f0-4d5a-a6ed-8a31c986581f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b17a9c7-f6a7-41b6-a6e6-78b076219f94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b3d1d14-6f6b-440b-94b3-c0bab987fc76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0d9539a-f9bb-41da-a103-b932d47580b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b26097c0-9eaf-48c7-9382-b31ec68cccad"));

            migrationBuilder.AddColumn<int>(
                name: "CourseState",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("0cffa71f-c7c3-4704-904c-66dddedb57ef"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 23, 35, 59, 207, DateTimeKind.Unspecified).AddTicks(2316), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEExpfD2tfUjDNJMJEHG1XR2Hu8/fapGUcOYx2FEqAjvtwh59ldFIDACBrm4rQsB3+A==", 1, "HE999998", "adminHCM" },
                    { new Guid("3a7c2793-016e-448c-b338-3a2b589afd2c"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 23, 35, 59, 609, DateTimeKind.Unspecified).AddTicks(4189), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAEH09J++0syrEE+EV7nXt5xIMkxHeQq26LF76kEPQoJrt213x9hnLAd3oLH7KoztfBg==", 2, "HE999995", "thanhdt" },
                    { new Guid("b48d9d71-d153-4943-8989-9befea44a6f4"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 23, 35, 59, 68, DateTimeKind.Unspecified).AddTicks(9852), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEP6N1cN3sIc0qMQIkRBgXId+jxnwkM5SMX3uTWLXhHTcczvFWlefWgAZNcOKfIweLQ==", 1, "HE999999", "adminHN" },
                    { new Guid("e2b7ef29-e3b5-4889-a34a-2fa71de2cb32"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 23, 35, 59, 316, DateTimeKind.Unspecified).AddTicks(9744), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAEBwo9y+bV2QKG7J6umvUqFZq0NNFbAD4hNLGiSFYOIqfHBULBFD4gYnUZl1Zye2o9A==", 1, "HE999997", "adminDN" },
                    { new Guid("e385b199-d77e-4ad9-a193-8b685476a406"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 23, 35, 59, 465, DateTimeKind.Unspecified).AddTicks(7321), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAEJd7J+gvWuiHqxyPQs6ZkNiqkxZ78mzo4jlab71Eyg7oe/ytP4kFGMbTz82kGAVHyQ==", 2, "HE999996", "hoangtt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0cffa71f-c7c3-4704-904c-66dddedb57ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a7c2793-016e-448c-b338-3a2b589afd2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b48d9d71-d153-4943-8989-9befea44a6f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2b7ef29-e3b5-4889-a34a-2fa71de2cb32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e385b199-d77e-4ad9-a193-8b685476a406"));

            migrationBuilder.DropColumn(
                name: "CourseState",
                table: "Courses");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("3b1bee18-e4f0-4d5a-a6ed-8a31c986581f"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 23, 9, 38, 142, DateTimeKind.Unspecified).AddTicks(3133), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAEI0n3cZa+nRy97BeudISgUpxOD51cB9ZTFiI5Gos3KUF9/sfkUu1YJHIv8Y7uKxzrw==", 1, "HE999997", "adminDN" },
                    { new Guid("7b17a9c7-f6a7-41b6-a6e6-78b076219f94"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 23, 9, 38, 450, DateTimeKind.Unspecified).AddTicks(1586), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAELhgLWLArHCRcR3W2/myG7IBq4KlPItu4uo9hI8CTgBqxqP6jwSm6sTkcVinujZcTg==", 2, "HE999995", "thanhdt" },
                    { new Guid("9b3d1d14-6f6b-440b-94b3-c0bab987fc76"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 23, 9, 38, 353, DateTimeKind.Unspecified).AddTicks(9831), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAEB+uc4L9v8es+2oSvUbCC2XVS+bSlbPN2TX+/a2oPv1MX6B/LOetHAebw9oVBvDctA==", 2, "HE999996", "hoangtt" },
                    { new Guid("b0d9539a-f9bb-41da-a103-b932d47580b2"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 23, 9, 37, 903, DateTimeKind.Unspecified).AddTicks(6808), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEOByKFpP3iPSCnpePC4x6IGtmATpIBv1KniSKQJsPyGOdDQduH9DVxIqQh0P+0e0dQ==", 1, "HE999999", "adminHN" },
                    { new Guid("b26097c0-9eaf-48c7-9382-b31ec68cccad"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 23, 9, 38, 20, DateTimeKind.Unspecified).AddTicks(6083), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEKARMtm1HPyOJl/BGLoKcFcqQmqwwy3WSr0v60ZMUqvSvgGdu9mGLGHGGlUN16H+QA==", 1, "HE999998", "adminHCM" }
                });
        }
    }
}
