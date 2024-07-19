using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Addlocationinstudentsemester : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a62b407-6fa8-4988-ba57-fca4ab04ff24"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f286934-8da8-4941-9ec8-712d475dc4fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a96b04-e24f-46f2-874d-c3e556a2334e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a9e147-f323-4b96-be02-92fef9b05dfc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e739d79e-0508-4118-af62-32cacb178bc9"));

            migrationBuilder.AddColumn<int>(
                name: "Location",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Enrollments");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("2a62b407-6fa8-4988-ba57-fca4ab04ff24"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 16, 55, 48, 681, DateTimeKind.Unspecified).AddTicks(3736), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEGokK0vzbSV7G57nR1f7o54QcgR87yC4YMs2igMDnHUEuXevSjvPqv2U7s1pfoJF4A==", 1, "HE999999", "adminHN" },
                    { new Guid("5f286934-8da8-4941-9ec8-712d475dc4fd"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 16, 55, 48, 783, DateTimeKind.Unspecified).AddTicks(8734), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEJglklcduDrtO7opCwl8hTqPWuJ8HSPWNHjgLZv+TP4Txlwnz2amqrXL0A3uHhdbWQ==", 1, "HE999998", "adminHCM" },
                    { new Guid("81a96b04-e24f-46f2-874d-c3e556a2334e"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 16, 55, 49, 6, DateTimeKind.Unspecified).AddTicks(5239), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAEPepD3+v3gqyehsBriuCRv4kz0W2tSOA3Z7A1Q+eDbw+5s4DIsadnFti8Be+TUf7KQ==", 2, "HE999996", "hoangtt" },
                    { new Guid("a6a9e147-f323-4b96-be02-92fef9b05dfc"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 16, 55, 48, 898, DateTimeKind.Unspecified).AddTicks(2226), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAECcIVP4/aZBs4XAp6mPRgCrH6roPy3eur6MSDk1OH8OREqC8s8R7pYVvS2o+TsGCew==", 1, "HE999997", "adminDN" },
                    { new Guid("e739d79e-0508-4118-af62-32cacb178bc9"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 16, 55, 49, 149, DateTimeKind.Unspecified).AddTicks(6018), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAEPJnb4UfbzEK6ie7HquiypKSzvaHOpWmC8zczng9yarzj4X7NALO3KgjS++L3Eu3/g==", 2, "HE999995", "thanhdt" }
                });
        }
    }
}
