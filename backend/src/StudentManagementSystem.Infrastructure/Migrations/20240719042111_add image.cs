using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Courses");

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
        }
    }
}
