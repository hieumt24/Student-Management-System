using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagementSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class configdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Semesters_SemesterId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_SemesterId",
                table: "Courses");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0cffa71f-c7c3-4704-904c-66dddedb57ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a7c2793-016e-448c-b338-3a2b589afd2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b48d9d71-d153-4943-8989-9befea44a6f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e2b7ef29-e3b5-4889-a34a-2fa71de2cb32"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e385b199-d77e-4ad9-a193-8b685476a406"));

            migrationBuilder.DropColumn(
                name: "SemesterId",
                table: "Courses");

            migrationBuilder.AddColumn<Guid>(
                name: "SemesterId",
                table: "Enrollments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_SemesterId",
                table: "Enrollments",
                column: "SemesterId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Semesters_SemesterId",
                table: "Enrollments",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Semesters_SemesterId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_SemesterId",
                table: "Enrollments");

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

            migrationBuilder.DropColumn(
                name: "SemesterId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Enrollments");

            migrationBuilder.AddColumn<Guid>(
                name: "SemesterId",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DateOfBirth", "Email", "FirstName", "IsDeleted", "JoinedDate", "LastModifiedBy", "LastModifiedOn", "LastName", "Location", "PasswordHash", "Role", "StudentCode", "UserName" },
                values: new object[,]
                {
                    { new Guid("0cffa71f-c7c3-4704-904c-66dddedb57ef"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 23, 35, 59, 207, DateTimeKind.Unspecified).AddTicks(2316), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHCM@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ho Chi Minh", 2, "AQAAAAIAAYagAAAAEExpfD2tfUjDNJMJEHG1XR2Hu8/fapGUcOYx2FEqAjvtwh59ldFIDACBrm4rQsB3+A==", 1, "HE999998", "adminHCM" },
                    { new Guid("3a7c2793-016e-448c-b338-3a2b589afd2c"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 23, 35, 59, 609, DateTimeKind.Unspecified).AddTicks(4189), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhdtHE999995@fpt.edu.vn", "Thanh", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nguyen Duc", 1, "AQAAAAIAAYagAAAAEH09J++0syrEE+EV7nXt5xIMkxHeQq26LF76kEPQoJrt213x9hnLAd3oLH7KoztfBg==", 2, "HE999995", "thanhdt" },
                    { new Guid("b48d9d71-d153-4943-8989-9befea44a6f4"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 23, 35, 59, 68, DateTimeKind.Unspecified).AddTicks(9852), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminHN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ha Noi", 1, "AQAAAAIAAYagAAAAEP6N1cN3sIc0qMQIkRBgXId+jxnwkM5SMX3uTWLXhHTcczvFWlefWgAZNcOKfIweLQ==", 1, "HE999999", "adminHN" },
                    { new Guid("e2b7ef29-e3b5-4889-a34a-2fa71de2cb32"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 23, 35, 59, 316, DateTimeKind.Unspecified).AddTicks(9744), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1970, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "adminDN@fpt.edu.vn", "Admin", false, new DateTime(2000, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Da Nang", 3, "AQAAAAIAAYagAAAAEBwo9y+bV2QKG7J6umvUqFZq0NNFbAD4hNLGiSFYOIqfHBULBFD4gYnUZl1Zye2o9A==", 1, "HE999997", "adminDN" },
                    { new Guid("e385b199-d77e-4ad9-a193-8b685476a406"), "System", new DateTimeOffset(new DateTime(2024, 7, 18, 23, 35, 59, 465, DateTimeKind.Unspecified).AddTicks(7321), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangttHE999996@fpt.edu.vn", "Hoa", false, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Truong Trong", 1, "AQAAAAIAAYagAAAAEJd7J+gvWuiHqxyPQs6ZkNiqkxZ78mzo4jlab71Eyg7oe/ytP4kFGMbTz82kGAVHyQ==", 2, "HE999996", "hoangtt" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SemesterId",
                table: "Courses",
                column: "SemesterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Semesters_SemesterId",
                table: "Courses",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
