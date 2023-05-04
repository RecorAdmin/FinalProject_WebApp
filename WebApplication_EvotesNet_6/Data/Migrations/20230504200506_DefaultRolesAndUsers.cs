using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication_EvotesNet_6.Data.Migrations
{
    public partial class DefaultRolesAndUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dc3a895-30aa-4dd9-907a-b00118f7e818",
                column: "ConcurrencyStamp",
                value: "4514e0be-f7e6-488f-acce-98b507d58d1a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1du3a895-30fe-4uu9-907u-b00118f7i818",
                column: "ConcurrencyStamp",
                value: "b95aa5bf-fe8a-4118-b2ee-f1d0cdd4bd1c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1dc3a895-30aa-4dd9-907a-b00118f7e818",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad5c710e-c651-4f21-aaa2-920b5f11b9bf", "AQAAAAEAACcQAAAAEM5mm3BM5En4N0nqNNtd6tw6pwtnpV8DMtZlp8qtdvD6xjQG8R9x+qqp8kPm42Dr4Q==", "1bfca560-ff71-4e8e-91d9-b0864cb70500" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1du3a895-30fe-4uu9-907u-b00118f7i818",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3aedf728-df39-4867-9cb6-9a1a391bdc22", "AQAAAAEAACcQAAAAEFkd+8iO0i3rZ+grl3Bfv17v8veesrIkcis3nizRRDv3irr+3FZudg/BPJvmE8mQ6A==", "91f6ed4f-44da-41de-a3d9-39deddb95280" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dc3a895-30aa-4dd9-907a-b00118f7e818",
                column: "ConcurrencyStamp",
                value: "fde7071a-a69c-4753-ab3e-bffe13a72740");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1du3a895-30fe-4uu9-907u-b00118f7i818",
                column: "ConcurrencyStamp",
                value: "4d5e402d-a82b-4ecc-a454-490ff0d14e97");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1dc3a895-30aa-4dd9-907a-b00118f7e818",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "112af2d4-2f9e-456e-9002-4036aa52f6ff", "AQAAAAEAACcQAAAAEAfJDnPB73sLMIFKzEW/bxSvEi3KxpFhPIvhzMUTrKQcPSu8eatgXFZ8wGn8oXA9eA==", "950a4c02-0d86-4144-acef-2d1d55e3b7cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1du3a895-30fe-4uu9-907u-b00118f7i818",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1ed4c60-636e-4268-bfa5-4a406374f3f8", "AQAAAAEAACcQAAAAEOtwM7NgJbSeQRfvnaVtY0PifVfv/w8xkYJ4VhCJI4VRtRWwe0S0L2L4fPicfOYjPQ==", "51b02b4e-598b-4625-8c8f-a151f8a7542f" });
        }
    }
}
