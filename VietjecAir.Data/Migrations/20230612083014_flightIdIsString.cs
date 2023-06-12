using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VietjecAir.Data.Migrations
{
    /// <inheritdoc />
    public partial class flightIdIsString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FlightId",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1706e285-cee8-495e-8f1d-4f3db18e975b"),
                column: "ConcurrencyStamp",
                value: "08042408-3ff3-49df-b791-42eea541edee");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4857318f-ea9e-4250-aaf2-5b0344e1486e"),
                column: "ConcurrencyStamp",
                value: "df117d06-21a5-4409-88a5-dc9887a60c87");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("6ff5fb0c-912a-446f-bf64-fcec3532dd01"),
                column: "ConcurrencyStamp",
                value: "4f5040b4-be01-44b4-9ea6-aca05657ca02");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("944bd118-0128-412b-b6af-0e96921d64b7"),
                column: "ConcurrencyStamp",
                value: "697ce2f0-9a33-4919-87a4-41c832aded35");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5917976-7e77-4190-8561-f4366f1cf612"),
                column: "ConcurrencyStamp",
                value: "c4712b54-7c0a-42cf-92bb-29dd91f25393");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("612e9def-cd18-4210-9f71-0101ea527cb3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1468fac4-7310-4eb0-984c-0ac4469d532f", "AQAAAAEAACcQAAAAELAzEqxKJJUmTWZiWl1QInzN0wZkzFIOZ3DLg/4as30lbeyCHtGBgS5MmXZj8Eo1KQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d8cc029-fe13-4a37-b241-39dafbbc94ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "410b857b-bfaf-4c8c-9c98-4653d1afbc70", "AQAAAAEAACcQAAAAELgaNAgJmZkZxO16SxjMyOqrC5Yx+2C9VzVCw/HtUA8dr3Mv0BwnXqNhwt8gdrAcQA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("73b3e5f4-20a8-4db4-8cb7-8a7151429cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bfd6490e-119f-451c-a63b-70b06df6c03c", "AQAAAAEAACcQAAAAEHDSUvOzRHGfJxcLmN4ByDyDmGNx3Yw5gV3QblcyEJcCxNXjWjcvb64MsPTDrPu0Kg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7407b801-0f91-4732-9179-c24d56a353b5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44e99832-2701-41e5-a53f-555f432d5fbe", "AQAAAAEAACcQAAAAEPzoefBrWXTPIcH1BwuVdlnCne61XS3RXDY8HTYKRV6OLwlCtIe1+L3KOuILzF6Scg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8814825-284e-44d0-ac12-c69a097ca81c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa8df4ba-8f73-4ead-86f7-2d1334db84cc", "AQAAAAEAACcQAAAAEB4BnY0ROWqVQdSI4ij+V/7Ef4RTdZ3Mw//VbjaLq9gxa3Rl72HNi05uDMms2WqcCg==" });

            migrationBuilder.UpdateData(
                table: "ConfigureSystems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2023, 6, 12, 15, 30, 14, 700, DateTimeKind.Local).AddTicks(1619));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FlightId",
                table: "Documents",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1706e285-cee8-495e-8f1d-4f3db18e975b"),
                column: "ConcurrencyStamp",
                value: "524fe762-265b-4637-9772-5ba43c484b26");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4857318f-ea9e-4250-aaf2-5b0344e1486e"),
                column: "ConcurrencyStamp",
                value: "5e7e493f-59a0-4bd7-9962-33dff63901ec");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("6ff5fb0c-912a-446f-bf64-fcec3532dd01"),
                column: "ConcurrencyStamp",
                value: "44ce7fe2-2892-4eaa-9417-d27289bda850");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("944bd118-0128-412b-b6af-0e96921d64b7"),
                column: "ConcurrencyStamp",
                value: "8481bfb9-9cf2-48a0-b657-a471f5c01247");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5917976-7e77-4190-8561-f4366f1cf612"),
                column: "ConcurrencyStamp",
                value: "5ae44cbf-4ab5-43ed-af63-b5b90a036d96");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("612e9def-cd18-4210-9f71-0101ea527cb3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d2d2de9-d4aa-451e-8649-6bb87b1092d9", "AQAAAAEAACcQAAAAEEbLau1THrlcVJYmc222W3VnDMQB4Dys6WbYdGB3u9YF8gbQvnAggeyb66ijiKLuvQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d8cc029-fe13-4a37-b241-39dafbbc94ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd00b3d7-5dff-4f85-b0db-edf563a84c0d", "AQAAAAEAACcQAAAAEBZZE7x2pLtTN2zKnC65WJcfq4MVHMcDexMSPavqFWlCRsY3XThgLpKqZeIejCbXFw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("73b3e5f4-20a8-4db4-8cb7-8a7151429cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0bfbd4f9-d12c-4454-b70d-56bf352ae01e", "AQAAAAEAACcQAAAAEMvtgSB9mZZq4SW0dy4jpYEeDlqV9ysVhG2JpH39dXAu/8v+vfY0lqDiWoltVP9qGw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7407b801-0f91-4732-9179-c24d56a353b5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b05874ba-ac72-486b-ac31-6f9afd6b54b8", "AQAAAAEAACcQAAAAEF+6C2KzNe1Y6kuQOGz1ffkHxaU7b0UvMc27n5ed1K4mqDDOtO9drty6sp6wMlmEoQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8814825-284e-44d0-ac12-c69a097ca81c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8571f1b-f333-4c52-9241-869106c2faf6", "AQAAAAEAACcQAAAAEP7kDO1lOlHyxKDSyyNqpCPBdA7VlsMcs5AMx8OnXuDX1+S1SsoQ4kZ3d9YdLdMjdw==" });

            migrationBuilder.UpdateData(
                table: "ConfigureSystems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2023, 6, 5, 14, 45, 56, 179, DateTimeKind.Local).AddTicks(4733));
        }
    }
}
