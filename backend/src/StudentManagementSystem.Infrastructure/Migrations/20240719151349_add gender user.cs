using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addgenderuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("47c52ace-1b21-4813-801e-794c0e26ebec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82705c90-5390-4d16-b784-71d0340c85a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9066af5d-e355-4a69-8e99-dedaf29cfc19"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d200ab68-6739-4f25-86b5-df187c83bf7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6aafa09-36f2-4440-b944-9abdfe7cbd91"));

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "Gender", "ImageUrl", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("157a5afd-456c-4a7b-8f80-6b92da6f2295"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 22, 13, 46, 557, DateTimeKind.Unspecified).AddTicks(8969), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", 0, null, false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEINjdWujnYIgFGetFDZ+TTRRESm9AnueQ8BXYf+qR/9hTGSAD/oE0mEaQMaDj2ysVg==", 1, "HE999999", "adminHN" },
                    { new Guid("1ce66219-cb91-473d-853e-a153169b3db6"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 22, 13, 46, 703, DateTimeKind.Unspecified).AddTicks(3775), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", 0, null, false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEATf6yOCTeTfkO124vrGD2CSSiZ+eo96CutELvzP9G+erG4x5f/SPjG6veVmYlGDRw==", 1, "HE999998", "adminHCM" },
                    { new Guid("2bfecd50-cbcf-412c-9ded-a8b1ffbf5e87"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 22, 13, 47, 8, DateTimeKind.Unspecified).AddTicks(7207), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", 0, null, false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAEAdfHy38c/+ur7CmXfiqSe6iykkiAgqiI31SvV73+erNacp1AXWi97Zf5/TM/7hF9w==", 2, "HE999996", "hoangtt" },
                    { new Guid("80325baa-2963-4ecc-bdee-440d85a3150c"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 22, 13, 47, 159, DateTimeKind.Unspecified).AddTicks(4721), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", 0, null, false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAEOqYH/g4IvP8opEkMJDfuwN6ALBR+OunrOr4mIBfLhX+ZGV1zieSmfXjU4eatrsy6g==", 2, "HE999995", "thanhdt" },
                    { new Guid("b1bcd31f-fb81-495f-ba39-efd1a9bb6116"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 22, 13, 46, 861, DateTimeKind.Unspecified).AddTicks(2253), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", 0, null, false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAEFqa6Rurl0KMjIe1pkBZAWan68x4vePvL3rGAHqrlqTMIBnSZ/UjsDJr6XaDdN8N1A==", 1, "HE999997", "adminDN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("157a5afd-456c-4a7b-8f80-6b92da6f2295"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ce66219-cb91-473d-853e-a153169b3db6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bfecd50-cbcf-412c-9ded-a8b1ffbf5e87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80325baa-2963-4ecc-bdee-440d85a3150c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1bcd31f-fb81-495f-ba39-efd1a9bb6116"));

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "ImageUrl", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("47c52ace-1b21-4813-801e-794c0e26ebec"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 20, 37, 17, 616, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", null, false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEEA7PP0qMSmAnl83A/N0kO63uLKhTuSD2P5KS0mfLzO1uN2uY04VoMeg6qOtMVyQPw==", 1, "HE999999", "adminHN" },
                    { new Guid("82705c90-5390-4d16-b784-71d0340c85a3"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 20, 37, 17, 722, DateTimeKind.Unspecified).AddTicks(1837), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", null, false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAENdgfmka7FZ/+Ydicpe0XqM2edbdfY5hjG/ik50JizsPe9PK5TQgVRlhWSnwmvSiCg==", 1, "HE999998", "adminHCM" },
                    { new Guid("9066af5d-e355-4a69-8e99-dedaf29cfc19"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 20, 37, 18, 62, DateTimeKind.Unspecified).AddTicks(8817), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", null, false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAEPIVncAx31n+k586aEaKWo/Fd4hMjBOMPYkbFCg6KWu9kUbclQtxx0Js7m8d8V/24w==", 2, "HE999995", "thanhdt" },
                    { new Guid("d200ab68-6739-4f25-86b5-df187c83bf7a"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 20, 37, 17, 953, DateTimeKind.Unspecified).AddTicks(2247), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", null, false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAEJjobB2/YYkSKe0NcW/CfYFR3SyeCVtjHfcojLL6R1GSxEfCSX/jXbdpp3Slv7ptaw==", 2, "HE999996", "hoangtt" },
                    { new Guid("e6aafa09-36f2-4440-b944-9abdfe7cbd91"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 20, 37, 17, 838, DateTimeKind.Unspecified).AddTicks(7206), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", null, false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAENlfV7Ph+xGC4DjOah27cojmruAfyKNjgjNJo1Erq+PN14nZqvGhyrhB+zMGUnrdEw==", 1, "HE999997", "adminDN" }
                });
        }
    }
}
