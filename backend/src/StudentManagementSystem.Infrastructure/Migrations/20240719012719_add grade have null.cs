using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addgradehavenull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1eb829ab-c7f4-4f97-92ce-ff1c05e0ba00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("51f07815-70fb-488b-a3b9-e404a7fc728e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7b2d30f7-f8a4-406f-b788-f5c04a3d8217"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b03cf1ec-ffae-4582-bbd8-a0b2b7c40440"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f429c781-36e7-4276-9d09-1c4c6a4a1618"));

            migrationBuilder.AlterColumn<double>(
                name: "Grade",
                table: "Enrollments",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<double>(
                name: "Grade",
                table: "Enrollments",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("1eb829ab-c7f4-4f97-92ce-ff1c05e0ba00"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 8, 7, 37, 137, DateTimeKind.Unspecified).AddTicks(8139), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEP5ZlZ0PxpvPuwagj/VmyqBPq3zr32O8kXUjHSAUOLCspLQpZwwuJ1giK/CLQsuzlg==", 1, "HE999998", "adminHCM" },
                    { new Guid("51f07815-70fb-488b-a3b9-e404a7fc728e"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 8, 7, 37, 51, DateTimeKind.Unspecified).AddTicks(1127), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEND9uwRcK8uQU4jn6VcXQcnciItKSG829R+iZjlsRnNV0Ni2W/AUyfOZU125cwgtMw==", 1, "HE999999", "adminHN" },
                    { new Guid("7b2d30f7-f8a4-406f-b788-f5c04a3d8217"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 8, 7, 37, 347, DateTimeKind.Unspecified).AddTicks(7109), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAEDRN5NcNiafIIr7enkurf0QCCDTuVMqBSF7a7wxrqcNWRrld4JcuYi2D7UynJkUheQ==", 2, "HE999996", "hoangtt" },
                    { new Guid("b03cf1ec-ffae-4582-bbd8-a0b2b7c40440"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 8, 7, 37, 227, DateTimeKind.Unspecified).AddTicks(3326), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAEG7uzevr7mYqPsMVYuM/oSzY30/6pvWmhAD+NLv/Pxev72F8c0DTFxc052FJO6CHmg==", 1, "HE999997", "adminDN" },
                    { new Guid("f429c781-36e7-4276-9d09-1c4c6a4a1618"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 8, 7, 37, 453, DateTimeKind.Unspecified).AddTicks(1199), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAEKk1KW1wC9ji+XkoO/p7hoDu2M8KYG77jQ2QPvo/RfBZ7/emZp8qGnO0TxaR/FueHw==", 2, "HE999995", "thanhdt" }
                });
        }
    }
}
