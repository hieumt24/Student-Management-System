using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addlocationnewuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("502de55b-2f94-42fe-982c-67828edede0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("533b8910-cec5-4f3a-9b8e-e372f06aa916"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6abb0a14-4f78-4442-aba6-c4b8e951ef63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6df0f930-a593-4537-832d-d2d04eff58d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd739829-a476-4580-ac88-87d267651684"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("502de55b-2f94-42fe-982c-67828edede0e"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 16, 44, 40, 737, DateTimeKind.Unspecified).AddTicks(8619), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 0, "AQAAAAIAAYagAAAAEC+2b9c+eQ8bFY6o3zDXEsZfT/UoaVTa4as8Hxf21/h2ZYp8tlkfT3L3CiAzj36NsA==", 2, "HE999996", "hoangtt" },
                    { new Guid("533b8910-cec5-4f3a-9b8e-e372f06aa916"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 16, 44, 40, 644, DateTimeKind.Unspecified).AddTicks(47), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 0, "AQAAAAIAAYagAAAAEN9jrFzJuSzJMVqK8exNWnJaMpIpIDUr9dO9W+YvjRq1HlEIDm18jcLw0iFjMXlnLA==", 1, "HE999997", "adminDN" },
                    { new Guid("6abb0a14-4f78-4442-aba6-c4b8e951ef63"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 16, 44, 40, 524, DateTimeKind.Unspecified).AddTicks(5925), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 0, "AQAAAAIAAYagAAAAEHaVUd6f0rrjcv/96HpbJ3lF7m+IxAcRVvyPc/DOKO7ZMFfZRLQwvj5+UV9/ganOrg==", 1, "HE999998", "adminHCM" },
                    { new Guid("6df0f930-a593-4537-832d-d2d04eff58d3"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 16, 44, 40, 383, DateTimeKind.Unspecified).AddTicks(4761), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 0, "AQAAAAIAAYagAAAAEHJhtZ2OUkfOmr0qgykumA8g1C+UFJIwB7/TGc0xZmRAAaMpzRrRwARUWtQfqUrjRw==", 1, "HE999999", "adminHN" },
                    { new Guid("cd739829-a476-4580-ac88-87d267651684"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 16, 44, 40, 833, DateTimeKind.Unspecified).AddTicks(444), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 0, "AQAAAAIAAYagAAAAEGcQVt+CXEkLa6vCfqY/Fm5GVfa8tGh3JXXl3FwwR8XqTCgiP+NJJ5v4JLHAajqLzA==", 2, "HE999995", "thanhdt" }
                });
        }
    }
}
