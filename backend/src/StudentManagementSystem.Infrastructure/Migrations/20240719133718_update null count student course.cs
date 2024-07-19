using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatenullcountstudentcourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "StudentInCourse",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "StudentInCourse",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
