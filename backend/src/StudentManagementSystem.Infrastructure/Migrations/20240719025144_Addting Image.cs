using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddtingImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5790b861-90cd-4d03-af3c-5f9bbdf73aab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68d8cac1-529a-4407-8583-647ec1fbed4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8df00c7a-5221-46ce-bc43-4498d8dd9491"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc6218a0-1efe-4426-b19e-9f9b9d9665a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8a060f8-08d0-4fc1-94e0-b70d7e574fab"));

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSizeInBytes = table.Column<long>(type: "bigint", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("20c331c6-1080-4fb9-a9a7-f424d65677d0"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 9, 51, 43, 451, DateTimeKind.Unspecified).AddTicks(2436), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEKHdWD6InVl6wPNhQ8trJGnK+DUOj+cG8X9tmuZJ8vx8pMuDUUcDHx+jpHBDaoQWWQ==", 1, "HE999999", "adminHN" },
                    { new Guid("30b30026-c30f-47e7-901c-9a4de66da679"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 9, 51, 43, 950, DateTimeKind.Unspecified).AddTicks(5178), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAEH2nK0wL7j/PKC3N4vPXJdCj6PuEx7puclyMBFM1qO649EZla+8PlUYdEoV5HsVL0A==", 2, "HE999995", "thanhdt" },
                    { new Guid("31dbb180-efe3-4221-87a2-1ad1ee801856"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 9, 51, 43, 574, DateTimeKind.Unspecified).AddTicks(7388), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEBA+CcUzcehlQeipQO4bhJ/iB6DdHt+Ggcy6YctO+lcs+35siH02eQ3QCoQIROxU7w==", 1, "HE999998", "adminHCM" },
                    { new Guid("e307d859-0835-49ce-868f-530d940eb7ed"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 9, 51, 43, 809, DateTimeKind.Unspecified).AddTicks(1806), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAEElVPRF15N174C4Qg/zabrZAsCv7GRskjv1HvyU5pON24LctGrHgIAJr5tWAyi59hw==", 2, "HE999996", "hoangtt" },
                    { new Guid("e56f6d84-8c57-4116-9983-0c1331a4d225"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 9, 51, 43, 701, DateTimeKind.Unspecified).AddTicks(522), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAEEErjL4MHv9yDmzV0JTSU5Y2SheOtGjuCVmRz7fb6d7qf2h96gWNzdZyJEycz6I+kA==", 1, "HE999997", "adminDN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20c331c6-1080-4fb9-a9a7-f424d65677d0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30b30026-c30f-47e7-901c-9a4de66da679"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31dbb180-efe3-4221-87a2-1ad1ee801856"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e307d859-0835-49ce-868f-530d940eb7ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e56f6d84-8c57-4116-9983-0c1331a4d225"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("5790b861-90cd-4d03-af3c-5f9bbdf73aab"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 9, 25, 44, 130, DateTimeKind.Unspecified).AddTicks(4366), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAELDXptzEi2zmBffRBRf42PzeygMoic8vHB3NJu73i0Ed9TDNob/g/ZehyfkBIbdrUA==", 2, "HE999996", "hoangtt" },
                    { new Guid("68d8cac1-529a-4407-8583-647ec1fbed4b"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 9, 25, 44, 278, DateTimeKind.Unspecified).AddTicks(1200), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAEN5vNh2AOtZjImgp7XkUwm/DZphFcB0r4sMfydH74uhQmXIsNJ6PIxwzSJV203FxBg==", 2, "HE999995", "thanhdt" },
                    { new Guid("8df00c7a-5221-46ce-bc43-4498d8dd9491"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 9, 25, 43, 897, DateTimeKind.Unspecified).AddTicks(8536), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEEvtAf0jKLkcJmv+JnOFFOdLft+MH4cbXtKffnq1PlHigl8PRPY5YYyhgiL2Sb+2IA==", 1, "HE999998", "adminHCM" },
                    { new Guid("bc6218a0-1efe-4426-b19e-9f9b9d9665a5"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 9, 25, 44, 12, DateTimeKind.Unspecified).AddTicks(5239), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAEOLevZ0XS6BLo2nu3uUXhlXEQk0Q0pWSEr35ZINROETK0VixIHxu3Aecn0sTezrgng==", 1, "HE999997", "adminDN" },
                    { new Guid("d8a060f8-08d0-4fc1-94e0-b70d7e574fab"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 9, 25, 43, 762, DateTimeKind.Unspecified).AddTicks(9524), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEGWSI7q3Y1/4gMxUUMFLd68lbPRt78Xgrph2WTjwbg1mBSwpynY2e1jauMTiRrWp1g==", 1, "HE999999", "adminHN" }
                });
        }
    }
}
