using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Seeddatauser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5703af21-502b-44a7-bd3d-85db60af8ee1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5837e573-4b56-414d-aa60-a90b92f5441c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e044bd4e-d941-48fb-8fa3-a6f9f4841198"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("5703af21-502b-44a7-bd3d-85db60af8ee1"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 16, 32, 28, 643, DateTimeKind.Unspecified).AddTicks(1279), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 0, "AQAAAAIAAYagAAAAEPPpwYZRYgAqEB7rXzBzsYysqDSdgZZZ95ZvGIxm2gkU+Y64w+XLJNmOpVebeoKFUw==", 1, null, "adminHCM" },
                    { new Guid("5837e573-4b56-414d-aa60-a90b92f5441c"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 16, 32, 28, 537, DateTimeKind.Unspecified).AddTicks(5216), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 0, "AQAAAAIAAYagAAAAEJED031/rkvNQr0gutJwInKX8aAMKWmWS/kMebYGrH3tae6gWzZ8UqUzMCG+TBiuaw==", 1, null, "adminHN" },
                    { new Guid("e044bd4e-d941-48fb-8fa3-a6f9f4841198"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 16, 32, 28, 747, DateTimeKind.Unspecified).AddTicks(6069), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 0, "AQAAAAIAAYagAAAAEJH01ukXbHu9BR7q51EnI/ogRNLCaf4OYIzhOej/9HCLGHkrXXXUzvltoRtAKxkjXw==", 1, null, "adminDN" }
                });
        }
    }
}
