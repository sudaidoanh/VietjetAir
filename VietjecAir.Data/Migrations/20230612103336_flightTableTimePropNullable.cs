using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VietjecAir.Data.Migrations
{
    /// <inheritdoc />
    public partial class flightTableTimePropNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TimeUnloading",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TimeLoading",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1706e285-cee8-495e-8f1d-4f3db18e975b"),
                column: "ConcurrencyStamp",
                value: "170a7c6f-5b94-48a7-9f7b-3a827da7efe6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4857318f-ea9e-4250-aaf2-5b0344e1486e"),
                column: "ConcurrencyStamp",
                value: "c155e45f-bcda-42e7-aa8d-cf6b1af2d228");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("6ff5fb0c-912a-446f-bf64-fcec3532dd01"),
                column: "ConcurrencyStamp",
                value: "42f405a5-8557-46f9-9208-c9a663e2da49");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("944bd118-0128-412b-b6af-0e96921d64b7"),
                column: "ConcurrencyStamp",
                value: "2c25aa4c-09c7-46fa-950f-af4508b601be");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5917976-7e77-4190-8561-f4366f1cf612"),
                column: "ConcurrencyStamp",
                value: "211c8235-0900-4f8e-ad48-25135346b3ba");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("612e9def-cd18-4210-9f71-0101ea527cb3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b55b844-dd35-4791-95c3-4ab49ea78ea0", "AQAAAAEAACcQAAAAEG+dxJ2pSTNnfodc+op3eP+b6P36XEtwRnLBdLEikTnFc73VeZ8grbMPrk7y6AtwEw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d8cc029-fe13-4a37-b241-39dafbbc94ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b82e14a-0ea1-47e2-a342-b4a4ed8f2416", "AQAAAAEAACcQAAAAEPRSMPmksRlcSN7qymL4JLi3U0Aab1j00hULcE3b/QWO2MfzU8M/srCC38HCbhlhng==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("73b3e5f4-20a8-4db4-8cb7-8a7151429cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7561b12-20f5-4a89-8675-4bcc15c4cb64", "AQAAAAEAACcQAAAAEKjxUHk4BnnF75MKo9ZT/N1v01gb5TdviyVBd2nljJQQbeW3McjEul5J3BpA+26Ndg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7407b801-0f91-4732-9179-c24d56a353b5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88c3a985-2f0a-4c55-bb44-4fcef950d3be", "AQAAAAEAACcQAAAAEDHoSBoXl8cDIEgSZOZuegcwLxJtRYWr/IknUajSW1YRNMTXO45h3xjr1Q8S5ZsOeg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8814825-284e-44d0-ac12-c69a097ca81c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "35ecc1b8-8483-45e5-90e5-5476686dae54", "AQAAAAEAACcQAAAAEJdnOp8uvm/I39Xd3ndq+Tej0erNgO4FUiwub9vW5YJyHaTj1Bi8tyXkoQGD6ZOrxA==" });

            migrationBuilder.UpdateData(
                table: "ConfigureSystems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2023, 6, 12, 17, 33, 36, 488, DateTimeKind.Local).AddTicks(985));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TimeUnloading",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TimeLoading",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
