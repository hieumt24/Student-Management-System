using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addunique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f6ebf50-bec8-459c-b007-aeec2846599d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17f246eb-0c49-496b-ac3c-556d7687ee56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4525a55a-af97-4b09-807b-9bd3981c8b0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63c09218-9afb-4f47-a7fb-90f446b4ece8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc389062-03c2-4b58-9dfd-0a6cd6fc667b"));

            migrationBuilder.AlterColumn<string>(
                name: "StudentCode",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CourseCode",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_StudentCode",
                table: "Users",
                column: "StudentCode",
                unique: true,
                filter: "[StudentCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseCode",
                table: "Courses",
                column: "CourseCode",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_StudentCode",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseCode",
                table: "Courses");

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

            migrationBuilder.AlterColumn<string>(
                name: "StudentCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CourseCode",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("0f6ebf50-bec8-459c-b007-aeec2846599d"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 17, 23, 16, 770, DateTimeKind.Unspecified).AddTicks(9475), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAELzuQcQmsA2W9u9lmv2KSGkdd7hy9OQW7/RfASeWUnRdZgHxGQkJYisDqNjqRB4sHA==", 1, "HE999999", "adminHN" },
                    { new Guid("17f246eb-0c49-496b-ac3c-556d7687ee56"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 17, 23, 16, 903, DateTimeKind.Unspecified).AddTicks(221), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEMzqK1rKswsJIxkU6CXPHb8WcYfONFwcKOY9Sm5DoxkMi5hwgJYFZYvjBCpPFtYXMA==", 1, "HE999998", "adminHCM" },
                    { new Guid("4525a55a-af97-4b09-807b-9bd3981c8b0e"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 17, 23, 17, 49, DateTimeKind.Unspecified).AddTicks(4873), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAEPUx5crislypnpU+Uy0iDGcd16hqxHX3AxvKIjv1pUEKIeo5zjueZ7Z9o3Cd0A015w==", 1, "HE999997", "adminDN" },
                    { new Guid("63c09218-9afb-4f47-a7fb-90f446b4ece8"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 17, 23, 17, 319, DateTimeKind.Unspecified).AddTicks(9120), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAECTftZruCMRdGTu001kz0WjjHCpL+J+BXbGkJl5KXLb7vbmygSDwwevts2sWvLZD2A==", 2, "HE999995", "thanhdt" },
                    { new Guid("dc389062-03c2-4b58-9dfd-0a6cd6fc667b"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 17, 23, 17, 186, DateTimeKind.Unspecified).AddTicks(1918), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAEG1BgYX4bDrGxSTlRWodqxZdqMYf5Eb0Huj++D2ZbQBM4dnbnRFul5+HDfocIdNjbw==", 2, "HE999996", "hoangtt" }
                });
        }
    }
}
