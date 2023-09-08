using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultUserandRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b32ecd6-2616-46d5-81a3-4b252c146115", "a364939d-c210-400b-b6c9-0898726813a1", "User", "USER" },
                    { "879c2d2e-7ff4-48cd-adf4-1a707963003c", "f5ca11f5-6301-4043-86c2-64d7679289c4", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0d9e356f-fd63-434a-8769-91d943a1b164", 0, "4253efff-9d33-4471-89d7-ace58bff9ec1", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USERBOOKSTORE", "AQAAAAEAACcQAAAAEA4dbDKJmlLmAdtOnqYDPvL4Hm9ST873cL6w8ycI7JPa8ioeEVePN61CAWXa4gAFHA==", null, false, "188673b3-7ab4-4c98-af6e-d6517212482d", false, "userBookStore" },
                    { "fd4944e2-69b5-4d40-8f06-857314f6d139", 0, "86704ec4-8143-41e0-8656-bcb259873206", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMINBOOKSTORE", "AQAAAAEAACcQAAAAEDyOUBQvw40AsYV6bc+Tu8DxYgp1qwJA5ORstzUZjkiNS9QElvdTTwo0P6zS4r+F6A==", null, false, "8f6c73b2-d70f-4ad0-b42f-6c640948024b", false, "adminBookStore" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1b32ecd6-2616-46d5-81a3-4b252c146115", "0d9e356f-fd63-434a-8769-91d943a1b164" },
                    { "879c2d2e-7ff4-48cd-adf4-1a707963003c", "fd4944e2-69b5-4d40-8f06-857314f6d139" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1b32ecd6-2616-46d5-81a3-4b252c146115", "0d9e356f-fd63-434a-8769-91d943a1b164" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "879c2d2e-7ff4-48cd-adf4-1a707963003c", "fd4944e2-69b5-4d40-8f06-857314f6d139" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b32ecd6-2616-46d5-81a3-4b252c146115");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "879c2d2e-7ff4-48cd-adf4-1a707963003c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d9e356f-fd63-434a-8769-91d943a1b164");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4944e2-69b5-4d40-8f06-857314f6d139");
        }
    }
}
