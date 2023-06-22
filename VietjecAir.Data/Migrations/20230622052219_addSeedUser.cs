using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VietjecAir.Data.Migrations
{
    /// <inheritdoc />
    public partial class addSeedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1706e285-cee8-495e-8f1d-4f3db18e975b"),
                column: "ConcurrencyStamp",
                value: "6f6551fc-5c73-4f98-b398-0a12aa789c4a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4857318f-ea9e-4250-aaf2-5b0344e1486e"),
                column: "ConcurrencyStamp",
                value: "bc108194-bcb0-475a-94dd-edfbb5777f91");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("6ff5fb0c-912a-446f-bf64-fcec3532dd01"),
                column: "ConcurrencyStamp",
                value: "02539449-9a78-4912-9e0d-25f1f1252b7a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("944bd118-0128-412b-b6af-0e96921d64b7"),
                column: "ConcurrencyStamp",
                value: "e9b1a562-8405-4691-a588-7ce5cec9edea");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5917976-7e77-4190-8561-f4366f1cf612"),
                column: "ConcurrencyStamp",
                value: "626d0351-445b-442d-a73c-14f66cda3719");

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "Action", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("82a52dd8-c50a-430a-a3de-87135f988d18"), "User", "11baa482-abff-4275-b67f-f19a075f98c1", "User can logging into system", "User", "User" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("612e9def-cd18-4210-9f71-0101ea527cb3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9873df48-262d-4bf4-86de-be56200a0329", "AQAAAAEAACcQAAAAEDqb7PxixvgujwF1N5U56v2qkaxi5B5qz1ZjIGp0ASnhYbn9wQyQgA5zgNQCjDnvzg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d8cc029-fe13-4a37-b241-39dafbbc94ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "18c5e3ae-7b3c-4e6c-ab20-ad8e708fd81a", "AQAAAAEAACcQAAAAEED3tCGIucmRd+Ttf28Q8Hm5H/iyA5+307Rutgjn+IG8RlfubOfSGtQG6SdqVoF2UQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("73b3e5f4-20a8-4db4-8cb7-8a7151429cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c68efcc-e4bc-4f62-91c0-7f6e10c31e85", "AQAAAAEAACcQAAAAEBjfVAioCvu6ezYqQt/JBrPYxxzeF8RrrXLtkU9AKsB0f6o2o11MN54aRyoyEiz1dQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7407b801-0f91-4732-9179-c24d56a353b5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d7f34b29-c2e9-4d61-b658-c6d10d657bdd", "AQAAAAEAACcQAAAAEBCBcZ1NrnWN88d90dY2U+QLyKkS8D5Uwz4Y4P6gvdgPsvm9PPHouaRWvTlviWotgw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8814825-284e-44d0-ac12-c69a097ca81c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "35638a69-2b59-4709-ad95-dd061a6c5d40", "AQAAAAEAACcQAAAAEKUaTxbrPyZC9MRNzJZBIztKs73b5X7H14lJjcXFrb161Kzop9IslLLsEhnqDdIGjg==" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("82a52dd8-c50a-430a-a3de-87135f988d18"), 10, "Ha Noi City", "311a2967-db93-47c0-8c8d-41135674ca73", "user@vietjetair.com", true, "user", false, null, "user@vietjetair.com", "user", "AQAAAAEAACcQAAAAEDiC/S25fWEUf8VDxQzWLlCoaVEifSVusK67H7SmPBO9w0OfroFkXKYepdp/8cef5w==", "12312312412", true, "", false, "user" });

            migrationBuilder.UpdateData(
                table: "ConfigureSystems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2023, 6, 22, 12, 22, 18, 875, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("f4f1f7f0-c836-4f7b-9d74-8b43cb6bd269"), new Guid("82a52dd8-c50a-430a-a3de-87135f988d18") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("82a52dd8-c50a-430a-a3de-87135f988d18"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("82a52dd8-c50a-430a-a3de-87135f988d18"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f4f1f7f0-c836-4f7b-9d74-8b43cb6bd269"), new Guid("82a52dd8-c50a-430a-a3de-87135f988d18") });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1706e285-cee8-495e-8f1d-4f3db18e975b"),
                column: "ConcurrencyStamp",
                value: "4a7abf8c-f63d-4d7e-b701-46b71349749c");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4857318f-ea9e-4250-aaf2-5b0344e1486e"),
                column: "ConcurrencyStamp",
                value: "27f3fb02-220b-4249-b1e8-06919035f0d6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("6ff5fb0c-912a-446f-bf64-fcec3532dd01"),
                column: "ConcurrencyStamp",
                value: "3bb176d1-c471-45cb-8670-9008822cfb86");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("944bd118-0128-412b-b6af-0e96921d64b7"),
                column: "ConcurrencyStamp",
                value: "9e814990-ecf2-49f0-b34b-413d59fe4f0d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5917976-7e77-4190-8561-f4366f1cf612"),
                column: "ConcurrencyStamp",
                value: "77057b6e-70ce-4c52-af5a-47e77b4d5b20");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("612e9def-cd18-4210-9f71-0101ea527cb3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86bfc428-6a50-483e-9a15-68754ff4b145", "AQAAAAEAACcQAAAAEK2W6/6FEG5PwA9+O9ipsi6TjAqM4++f4oLLlKVP4xPCbIFisY02YtfIRn69PeCEjQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d8cc029-fe13-4a37-b241-39dafbbc94ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0cc649a-4977-4af0-af93-aec4219fdf38", "AQAAAAEAACcQAAAAEP+fkfo138ZBKpMVU7okcWAyu7FaN46C+yIhryF9Ryj/UovOtYhWRVKPr6NCg0yucw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("73b3e5f4-20a8-4db4-8cb7-8a7151429cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0d80532d-bf7b-4c75-8b4c-948e7acad699", "AQAAAAEAACcQAAAAEAeGEOCqUz/nYINi1MfQjIMklpU9sCOzVEm8qhkhqdMXW/1tfWmEXXQv2a3+BBQkVQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7407b801-0f91-4732-9179-c24d56a353b5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3099453-9777-4f1f-a12c-ff9d88d3d7f8", "AQAAAAEAACcQAAAAEFNPwcAmZJKM4QVCWK/cm0JilIWUwlyvLtq3I9z2jBPqwvxJLH7fXVHPiit67Blpcw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8814825-284e-44d0-ac12-c69a097ca81c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b935c259-528a-4c5f-a452-4a1838c46237", "AQAAAAEAACcQAAAAEHBH49JNW3nwGH+cDShii8MC8/su/wnyXNNOWGXdiM3N74/DytMFKiXi+aQnKdsWGw==" });

            migrationBuilder.UpdateData(
                table: "ConfigureSystems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2023, 6, 15, 16, 0, 26, 751, DateTimeKind.Local).AddTicks(9172));
        }
    }
}
