using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addlevelincourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("411fcfb6-2798-47f9-867d-fb999d0652e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d879163-9fe9-4936-9fb4-fbcb4fa8dc92"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c06d2ac4-8237-43db-914e-9ed79d3e09cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c9ef2f19-e9da-477d-849c-59bb3a8a532c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ff5ee508-4931-41f6-ad4d-266a61044148"));

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Courses");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("411fcfb6-2798-47f9-867d-fb999d0652e9"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 21, 46, 23, 947, DateTimeKind.Unspecified).AddTicks(4117), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAEAHFTWTpVYN1W7OqXD7mp1Dbtunl7BJRtipgULmw+kzdGl4a3jf/rEy+HAXcZguS3w==", 2, "HE999996", "hoangtt" },
                    { new Guid("4d879163-9fe9-4936-9fb4-fbcb4fa8dc92"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 21, 46, 23, 716, DateTimeKind.Unspecified).AddTicks(6287), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEPRIAap8bapFZaiw+GijoUpt+sHn2friXUh4++PDXH7nntetYV1tP6omJHO/btukEQ==", 1, "HE999998", "adminHCM" },
                    { new Guid("c06d2ac4-8237-43db-914e-9ed79d3e09cf"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 21, 46, 23, 567, DateTimeKind.Unspecified).AddTicks(2447), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEARXtPc7a7r/7xZ2eC6aczBalaA7cOkxgpyt+bMlIG2s6VgQ8X9a3F9XNxI+S5Ie9g==", 1, "HE999999", "adminHN" },
                    { new Guid("c9ef2f19-e9da-477d-849c-59bb3a8a532c"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 21, 46, 23, 837, DateTimeKind.Unspecified).AddTicks(4248), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAEAy2LUX4+QACYWML/jFJnYQdUEmPbarQ9PECSG0itGOXjci84vyvFWSRDRlkpJPunA==", 1, "HE999997", "adminDN" },
                    { new Guid("ff5ee508-4931-41f6-ad4d-266a61044148"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 21, 46, 24, 55, DateTimeKind.Unspecified).AddTicks(4524), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAEGUoWB0rxaLSbyrTpKQdzkCEYNSHToBVtwscqctnLacbxW3T21jKW/YeDkfWz7OfbA==", 2, "HE999995", "thanhdt" }
                });
        }
    }
}
