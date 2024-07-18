using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatetypeGrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11e0826a-0466-4d01-bbbf-8e4e3918c012"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43db3a7b-5d21-473f-8c0d-88d198280acf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50c792a6-e8f9-45d9-87f8-09ef471898cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ce88b58-842b-4922-b994-0ea2a16c8070"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e4c9d93-88ae-491a-b694-c1e0e8f1eed5"));

            migrationBuilder.AlterColumn<double>(
                name: "Grade",
                table: "Enrollments",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "Enrollments",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("11e0826a-0466-4d01-bbbf-8e4e3918c012"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 7, 50, 48, 383, DateTimeKind.Unspecified).AddTicks(4110), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEDwhKGv720kKw6c7FjT4M9twARnBUAF9PoGMgx1O5/1EGgbnxwIVY6lyUPP8KSLN5w==", 1, "HE999998", "adminHCM" },
                    { new Guid("43db3a7b-5d21-473f-8c0d-88d198280acf"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 7, 50, 48, 286, DateTimeKind.Unspecified).AddTicks(6294), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEAiYvvOJcUZsonI78j/T2eK2jMP7YjL9gZeYDrS09P1/Utnd4LxFIDJu69+RF6e5+Q==", 1, "HE999999", "adminHN" },
                    { new Guid("50c792a6-e8f9-45d9-87f8-09ef471898cd"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 7, 50, 48, 571, DateTimeKind.Unspecified).AddTicks(2220), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAECnj0PAdz/3cqV8hsTLcEFBCYpuNwVCHEOisGi2+ILBImwi/k6DVV9pTWv1nq/aqJQ==", 2, "HE999996", "hoangtt" },
                    { new Guid("7ce88b58-842b-4922-b994-0ea2a16c8070"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 7, 50, 48, 661, DateTimeKind.Unspecified).AddTicks(5383), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAEL+HOrWTQwrxL3R0AZduP/0AavQY10/7z1xlxd3l9vIMLYFkjX7QGVTfy84GyiHZPg==", 2, "HE999995", "thanhdt" },
                    { new Guid("9e4c9d93-88ae-491a-b694-c1e0e8f1eed5"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 7, 50, 48, 468, DateTimeKind.Unspecified).AddTicks(6485), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAEO8ZBPOELaKca/QGcYWP8aIZY2NK5YwMJYo66MBSdyBsv53XWsWYGLY2OWC83BxkIQ==", 1, "HE999997", "adminDN" }
                });
        }
    }
}
