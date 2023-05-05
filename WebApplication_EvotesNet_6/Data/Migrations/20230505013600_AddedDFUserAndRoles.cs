using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication_EvotesNet_6.Data.Migrations
{
    public partial class AddedDFUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "62049a77-54df-4663-9mi6-3712nf2788fa", "894302a7-46d3-4m72-aina-00ee2e5f7e55" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "u2se6r1d-10d1-461e-992d-ed375e67fe6f", "894302f7-46d3-4a72-acda-00ee2e5f7e55" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62049a77-54df-4663-9mi6-3712nf2788fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u2se6r1d-10d1-461e-992d-ed375e67fe6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "894302a7-46d3-4m72-aina-00ee2e5f7e55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "894302f7-46d3-4a72-acda-00ee2e5f7e55");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "91978a77-54df-4663-9mi6-3712nf2788fa", "65a73eea-3a20-43c7-9280-eeae9a706837", "Admin", "ADMIN" },
                    { "u2se6r1d-10d1-461e-367d-ed375e67fe6f", "9adf0892-70bd-462f-ad26-bc0d136f42e4", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "798302a7-46d3-4m72-aina-00ee2e5f7e55", 0, "f322b8f7-1a76-4a5b-b9a9-b5640f2ec968", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEMPq7PAdM4m0m+od2MzfX4147dgwV4EUMFPgQdwXVOBl8N2cPJfbz4OLyjFe919f0w==", null, false, "02b7b3c8-5270-4552-95f3-649d69479a65", false, "admin@localhost.com" },
                    { "af1302f7-46d3-4a72-acda-00ee2e5f7e55", 0, "c0f34653-84f0-420c-8117-b22c65d5437d", "user@localhost.com", true, false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAELEzjyP8HyL6O0aaSifGBAJhrkSQyHnHJPE2wdk48KEcV1III9rXn805BsPNDqx1AA==", null, false, "7ee41db5-1835-4c97-98f4-7bae89e73486", false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "91978a77-54df-4663-9mi6-3712nf2788fa", "798302a7-46d3-4m72-aina-00ee2e5f7e55" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "u2se6r1d-10d1-461e-367d-ed375e67fe6f", "af1302f7-46d3-4a72-acda-00ee2e5f7e55" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91978a77-54df-4663-9mi6-3712nf2788fa", "798302a7-46d3-4m72-aina-00ee2e5f7e55" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "u2se6r1d-10d1-461e-367d-ed375e67fe6f", "af1302f7-46d3-4a72-acda-00ee2e5f7e55" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91978a77-54df-4663-9mi6-3712nf2788fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u2se6r1d-10d1-461e-367d-ed375e67fe6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "798302a7-46d3-4m72-aina-00ee2e5f7e55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af1302f7-46d3-4a72-acda-00ee2e5f7e55");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "62049a77-54df-4663-9mi6-3712nf2788fa", "6d26bc8c-ebd7-4a31-8db9-cf00deb91e1c", "Admin", "ADMIN" },
                    { "u2se6r1d-10d1-461e-992d-ed375e67fe6f", "388ca1d8-e613-4e7b-a491-6e3c4486e116", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "894302a7-46d3-4m72-aina-00ee2e5f7e55", 0, "7bf0dafe-1ca6-457d-bcf1-cb940a17ed0c", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEGQ2Vjfu6ICupiClw0FLvMe+3Nl4L+AfJVIO8xoFbjchet3qPuEwa64L9pWubnD/yw==", null, false, "cce55b68-c702-47f0-9bd3-e2d0fbc22164", false, "admin@localhost.com" },
                    { "894302f7-46d3-4a72-acda-00ee2e5f7e55", 0, "d5eb5fd4-fc60-461f-9fc9-205aa05f1caf", "user@localhost.com", true, false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBwzFFuTzYgvW5WpNJIK4en9VB81nv4++TAANfO1XWZuahVz6H9XQRC07I/9aUamYg==", null, false, "bb6d2bc3-4509-472f-8b04-159f9be8fa96", false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "62049a77-54df-4663-9mi6-3712nf2788fa", "894302a7-46d3-4m72-aina-00ee2e5f7e55" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "u2se6r1d-10d1-461e-992d-ed375e67fe6f", "894302f7-46d3-4a72-acda-00ee2e5f7e55" });
        }
    }
}
