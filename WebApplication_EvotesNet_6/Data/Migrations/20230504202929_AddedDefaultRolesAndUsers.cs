using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication_EvotesNet_6.Data.Migrations
{
    public partial class AddedDefaultRolesAndUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1du3a895-30fe-4uu9-907u-b00118f7i818");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1dc3a895-30aa-4dd9-907a-b00118f7e818", "1dc3a895-30aa-4dd9-907a-b00118f7e818" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1du3a895-30fe-4uu9-907u-b00118f7i818");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dc3a895-30aa-4dd9-907a-b00118f7e818");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1dc3a895-30aa-4dd9-907a-b00118f7e818");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "82049c77-54af-4663-9fc6-3712cf2788fa", "76d70204-1111-47e3-ae74-b0f6b764c3c2", "Admin", "ADMIN" },
                    { "d2dd6a1d-10d1-461e-992d-ed375e67fe6f", "62945342-bf7c-4b0c-9e1e-9739d5be0e90", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "82049c77-54af-4663-9fc6-3712cf2788fa", 0, "b1043e5c-51ae-4d69-876d-7cf6cf559835", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAENfHyx5YgMKgZCwO6mQF9nQ4xLI7f7m+GhB/ajG87ts3h8y971W2o7v2NHIh1ysaCQ==", null, false, "ef7e78ae-4439-42fd-87a8-8f7e5a9fd4a4", false, "admin@localhost.com" },
                    { "d2dd6a1d-10d1-461e-992d-ed375e67fe6f", 0, "7565fbf4-310d-4037-bd0a-fbd4ad96e0d6", "user@localhost.com", true, false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAELpgTo3gg+uTa2osqZPW+rx8pzvbnY4bU2xkr6bXaoBgoe5pBhPEPy7fNZaZx3Et0g==", null, false, "1d2b0013-400a-4dd2-8833-6916f8dc282d", false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "82049c77-54af-4663-9fc6-3712cf2788fa", "d2dd6a1d-10d1-461e-992d-ed375e67fe6f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2dd6a1d-10d1-461e-992d-ed375e67fe6f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "82049c77-54af-4663-9fc6-3712cf2788fa", "d2dd6a1d-10d1-461e-992d-ed375e67fe6f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82049c77-54af-4663-9fc6-3712cf2788fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82049c77-54af-4663-9fc6-3712cf2788fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2dd6a1d-10d1-461e-992d-ed375e67fe6f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1dc3a895-30aa-4dd9-907a-b00118f7e818", "4514e0be-f7e6-488f-acce-98b507d58d1a", "Admin", "ADMIN" },
                    { "1du3a895-30fe-4uu9-907u-b00118f7i818", "b95aa5bf-fe8a-4118-b2ee-f1d0cdd4bd1c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1dc3a895-30aa-4dd9-907a-b00118f7e818", 0, "ad5c710e-c651-4f21-aaa2-920b5f11b9bf", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEM5mm3BM5En4N0nqNNtd6tw6pwtnpV8DMtZlp8qtdvD6xjQG8R9x+qqp8kPm42Dr4Q==", null, false, "1bfca560-ff71-4e8e-91d9-b0864cb70500", false, "admin@localhost.com" },
                    { "1du3a895-30fe-4uu9-907u-b00118f7i818", 0, "3aedf728-df39-4867-9cb6-9a1a391bdc22", "user@localhost.com", true, false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFkd+8iO0i3rZ+grl3Bfv17v8veesrIkcis3nizRRDv3irr+3FZudg/BPJvmE8mQ6A==", null, false, "91f6ed4f-44da-41de-a3d9-39deddb95280", false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1dc3a895-30aa-4dd9-907a-b00118f7e818", "1dc3a895-30aa-4dd9-907a-b00118f7e818" });
        }
    }
}
