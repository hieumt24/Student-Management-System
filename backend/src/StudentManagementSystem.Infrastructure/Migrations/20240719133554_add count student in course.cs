using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addcountstudentincourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10afc0b9-d163-42b8-a6c0-0b9ad0ee5c1a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39758243-d5d2-4c4b-a2e7-a29d45a52718"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41a9f044-c000-4a8c-b59c-7ff85dedba4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65e19ab0-64a6-4475-b665-6d4f7d0f46ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2415f6e-884a-4eb2-a4dd-66389d9fc682"));

            migrationBuilder.AddColumn<int>(
                name: "StudentInCourse",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "ImageUrl", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("038a8cca-7573-4490-9e85-f52950826bf9"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 20, 35, 53, 375, DateTimeKind.Unspecified).AddTicks(6547), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", null, false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAEAn5hQItNEC1Y1fDx53v7yBf5gTT6Z8P2u2EtX5CwEMBHnFXjpPDvHSYavC3MPA0JQ==", 1, "HE999997", "adminDN" },
                    { new Guid("4ec586fb-c017-47ef-b302-8ab86f964a95"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 20, 35, 53, 627, DateTimeKind.Unspecified).AddTicks(3582), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", null, false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAEKrTDFqkxAdxbeQc2nefydETj7AEaCOFG8Of1kQLnoMZRtyA6hmI/gKxXuQYBtaLZQ==", 2, "HE999995", "thanhdt" },
                    { new Guid("609a2bb9-6df6-4232-a7c4-0d9174ebc945"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 20, 35, 53, 29, DateTimeKind.Unspecified).AddTicks(3538), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", null, false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEHM9ytDPdKaBTtrgSc/vJZu+c7a3Xq5MCb7D+KS42gt9t0SLk2VtlgA3EIHmwOEedw==", 1, "HE999999", "adminHN" },
                    { new Guid("8752ba3e-ca15-43cb-923f-128f2ba90d84"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 20, 35, 53, 206, DateTimeKind.Unspecified).AddTicks(5504), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", null, false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEPZC8KQYdiT/rVkZXJ/TIOhxjocqbpSOcgjfATPVPBq0oSsvePPeq0UlRxQnzvMsCg==", 1, "HE999998", "adminHCM" },
                    { new Guid("ffdc76d1-73b6-4d9c-8bfd-f6211dd9549e"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 20, 35, 53, 523, DateTimeKind.Unspecified).AddTicks(9115), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", null, false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAEDEAax+NsSNuJ6pCWtqGGZkfW4Oot7Xx9Ly84Ge1FCqqLhnH35a93zno5f7oEhjYRw==", 2, "HE999996", "hoangtt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("038a8cca-7573-4490-9e85-f52950826bf9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ec586fb-c017-47ef-b302-8ab86f964a95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("609a2bb9-6df6-4232-a7c4-0d9174ebc945"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8752ba3e-ca15-43cb-923f-128f2ba90d84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ffdc76d1-73b6-4d9c-8bfd-f6211dd9549e"));

            migrationBuilder.DropColumn(
                name: "StudentInCourse",
                table: "Courses");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "ImageUrl", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("10afc0b9-d163-42b8-a6c0-0b9ad0ee5c1a"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 15, 30, 44, 201, DateTimeKind.Unspecified).AddTicks(3915), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", null, false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEPqHGTDnwfbdXrmM8uHL7wscPR64WmfRuhZlwrS5sDjbUpEzWYRzoLq9i0TwPL93IA==", 1, "HE999998", "adminHCM" },
                    { new Guid("39758243-d5d2-4c4b-a2e7-a29d45a52718"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 15, 30, 44, 86, DateTimeKind.Unspecified).AddTicks(5306), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", null, false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAED12eQAhvY9tGyc9kznIUqBCiuPxjr1p62JDStj4Vsf1QOfg+tsdWQVlRrYDJWAGNQ==", 1, "HE999999", "adminHN" },
                    { new Guid("41a9f044-c000-4a8c-b59c-7ff85dedba4e"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 15, 30, 44, 325, DateTimeKind.Unspecified).AddTicks(6672), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", null, false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAELxbQEHFrdn7fi5mM/r5L9BVcly3R5caT35hTYqoc10GVLxY33Uyic8bvDVcgEZh9g==", 1, "HE999997", "adminDN" },
                    { new Guid("65e19ab0-64a6-4475-b665-6d4f7d0f46ae"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 15, 30, 44, 510, DateTimeKind.Unspecified).AddTicks(7724), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", null, false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAENfC6Kt+N34t9+NN5n8wNVM6p+DPjqWSHv0RhEyoLaXNOwEUGjfccJId8+fUhq+fZQ==", 2, "HE999995", "thanhdt" },
                    { new Guid("e2415f6e-884a-4eb2-a4dd-66389d9fc682"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 15, 30, 44, 423, DateTimeKind.Unspecified).AddTicks(516), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", null, false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAEEn3runVqY4bEuifak+IcOEBxGrtgcdqLqTEuq/Z5SrhsPwXxpF9uUtGc1CQYgDwXA==", 2, "HE999996", "hoangtt" }
                });
        }
    }
}
