using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addbaseentitybycoursesemester : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("106e1de6-50e7-4fea-bf1a-31c696d1d5ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30fd95c2-1239-41df-bf9c-59b31c865101"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91b7dc93-2868-468a-a071-e6da0c82b2fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b34c0615-7b3c-4ad3-9623-da1de183803e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f72b413d-bfb1-476e-bc53-7389a960402d"));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CourseSemesters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "CourseSemesters",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "CourseSemesters",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CourseSemesters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "CourseSemesters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastModifiedOn",
                table: "CourseSemesters",
                type: "datetimeoffset",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CourseSemesters");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "CourseSemesters");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CourseSemesters");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CourseSemesters");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "CourseSemesters");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "CourseSemesters");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "ImageUrl", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("106e1de6-50e7-4fea-bf1a-31c696d1d5ac"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 11, 21, 10, 935, DateTimeKind.Unspecified).AddTicks(4337), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", null, false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAEDgpnO2UlZPj+UFCKfIfyNkfvC6Z7LIj9hXgcGvy8qjwwtt5XoFbyj+Bbp8mXOQAxw==", 2, "HE999996", "hoangtt" },
                    { new Guid("30fd95c2-1239-41df-bf9c-59b31c865101"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 11, 21, 11, 41, DateTimeKind.Unspecified).AddTicks(520), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", null, false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAEBFfcCBTStLLbgd034u8rtBc6AaJ16+HPgsC2ldHzzqmFPmU9+lPMw8O1vBl2TgDVQ==", 2, "HE999995", "thanhdt" },
                    { new Guid("91b7dc93-2868-468a-a071-e6da0c82b2fe"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 11, 21, 10, 843, DateTimeKind.Unspecified).AddTicks(3785), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", null, false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAEAzrH8Yo+Rdlo7AwWfqWQeJ9g3CwI8Gax7n/4i6xIltU/Bp9zR3BzVvq0JTBxqeKIw==", 1, "HE999997", "adminDN" },
                    { new Guid("b34c0615-7b3c-4ad3-9623-da1de183803e"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 11, 21, 10, 756, DateTimeKind.Unspecified).AddTicks(6127), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", null, false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEJga/IsOro7/ieVkQbHzuTwsdUICJ9woQw96N3DQlmarZ0dO16wVDUJijLBNnt5L4g==", 1, "HE999998", "adminHCM" },
                    { new Guid("f72b413d-bfb1-476e-bc53-7389a960402d"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 11, 21, 10, 658, DateTimeKind.Unspecified).AddTicks(1042), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", null, false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEJ1lkueTWt2VMSLemhw5VR6cXrLufsrM73PJKd0qRZvXm9y9DzX72OkgL+tFmy3yWw==", 1, "HE999999", "adminHN" }
                });
        }
    }
}
