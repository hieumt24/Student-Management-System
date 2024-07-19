using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSemester_Semesters_SemesterId",
                table: "StudentSemester");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSemester_Users_StudentId",
                table: "StudentSemester");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentSemester",
                table: "StudentSemester");

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

            migrationBuilder.RenameTable(
                name: "StudentSemester",
                newName: "StudentSemesters");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSemester_StudentId",
                table: "StudentSemesters",
                newName: "IX_StudentSemesters_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSemester_SemesterId",
                table: "StudentSemesters",
                newName: "IX_StudentSemesters_SemesterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentSemesters",
                table: "StudentSemesters",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("25b61220-eccd-4690-9f50-24a5aa2df743"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 10, 12, 1, 374, DateTimeKind.Unspecified).AddTicks(8826), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAEN7LNlspm5dnfkeWeOt7AsycjTGHupRkfXPuVrw0O5dKSdVKQtNtM5q1GNYPVb8Beg==", 2, "HE999995", "thanhdt" },
                    { new Guid("2b7466fc-0dc0-4c42-9790-a2911d86286a"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 10, 12, 0, 991, DateTimeKind.Unspecified).AddTicks(79), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEChyexAEFhTYYjPQE9ylHtLpRLVHpFX5QJA9rnyhj+lr2UyafgqhOr3iicO8Ti94rw==", 1, "HE999999", "adminHN" },
                    { new Guid("5b12f81a-3f8a-453e-8d02-bfc457484bb0"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 10, 12, 1, 82, DateTimeKind.Unspecified).AddTicks(7256), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEGw1Y6zjnZXTUjuEWiUuhfaoumUdMEQFW1z31USV8I2z0JmuR9fv9r/rLE/0bwd3Vg==", 1, "HE999998", "adminHCM" },
                    { new Guid("cce8ba54-e83e-4b15-8c9e-afef4a9ab5f4"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 10, 12, 1, 280, DateTimeKind.Unspecified).AddTicks(2936), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAEKYVGxUrMLDWz60sfYYWEqmgbojY21petyYyCC9WOnrxd9fuCnQEocXw6U0d3wz49Q==", 2, "HE999996", "hoangtt" },
                    { new Guid("e68c3f4f-178d-464a-9ece-05dffb0b7f69"), "System", new DateTimeOffset(new DateTime(2024, 7, 19, 10, 12, 1, 172, DateTimeKind.Unspecified).AddTicks(2407), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAEFpTZwRF4adiE9z/l75fnrsKRCwnt0+0ZI6ppSgAqXGgCS+ZLHMjeQIzx1g98hSl4Q==", 1, "HE999997", "adminDN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSemesters_Semesters_SemesterId",
                table: "StudentSemesters",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSemesters_Users_StudentId",
                table: "StudentSemesters",
                column: "StudentId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSemesters_Semesters_SemesterId",
                table: "StudentSemesters");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSemesters_Users_StudentId",
                table: "StudentSemesters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentSemesters",
                table: "StudentSemesters");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("25b61220-eccd-4690-9f50-24a5aa2df743"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b7466fc-0dc0-4c42-9790-a2911d86286a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b12f81a-3f8a-453e-8d02-bfc457484bb0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cce8ba54-e83e-4b15-8c9e-afef4a9ab5f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e68c3f4f-178d-464a-9ece-05dffb0b7f69"));

            migrationBuilder.RenameTable(
                name: "StudentSemesters",
                newName: "StudentSemester");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSemesters_StudentId",
                table: "StudentSemester",
                newName: "IX_StudentSemester_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentSemesters_SemesterId",
                table: "StudentSemester",
                newName: "IX_StudentSemester_SemesterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentSemester",
                table: "StudentSemester",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSemester_Semesters_SemesterId",
                table: "StudentSemester",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSemester_Users_StudentId",
                table: "StudentSemester",
                column: "StudentId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
