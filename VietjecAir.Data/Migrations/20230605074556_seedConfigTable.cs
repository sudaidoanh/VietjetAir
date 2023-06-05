using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VietjecAir.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedConfigTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ConfigureSystems",
                columns: new[] { "Id", "CapchaEnabled", "LogoPath", "LogoSize", "Theme", "Updated", "UserUpdate" },
                values: new object[] { 1, false, "", 1L, "Default theme", new DateTime(2023, 6, 5, 14, 45, 56, 179, DateTimeKind.Local).AddTicks(4733), "Owner@vietjetair.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ConfigureSystems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1706e285-cee8-495e-8f1d-4f3db18e975b"),
                column: "ConcurrencyStamp",
                value: "b4a66945-854a-40ce-a936-e4cd3f2dc165");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4857318f-ea9e-4250-aaf2-5b0344e1486e"),
                column: "ConcurrencyStamp",
                value: "f1c0d42e-150f-4334-b08d-b5de61a06eec");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("6ff5fb0c-912a-446f-bf64-fcec3532dd01"),
                column: "ConcurrencyStamp",
                value: "7da90840-29f2-4cd1-8dd0-c04d98bbf20d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("944bd118-0128-412b-b6af-0e96921d64b7"),
                column: "ConcurrencyStamp",
                value: "e9c9f36d-fa00-4cc8-bbba-9425bcc2b068");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5917976-7e77-4190-8561-f4366f1cf612"),
                column: "ConcurrencyStamp",
                value: "781747d0-3021-46b7-9a96-f531365a4a99");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("612e9def-cd18-4210-9f71-0101ea527cb3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4868dcc2-2837-47ce-a570-6e1f624f8723", "AQAAAAEAACcQAAAAECMgJhWSj/d1IyMlw46yDewluQUpNCjreK+RAY9lR/ihG6eKtJ2AZg7X5fhT/J1e1g==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d8cc029-fe13-4a37-b241-39dafbbc94ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a7d11c3-9ed7-45ec-9cf6-8c12e4fa98a8", "AQAAAAEAACcQAAAAEMzqhU1DJFh6UwdGDpIGPxlwG71qJasxzKKiQXKo3eeypLCrTmMANYECWBf3CUkMlw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("73b3e5f4-20a8-4db4-8cb7-8a7151429cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28d040ac-845b-4a02-8611-a02c8bc82c01", "AQAAAAEAACcQAAAAEHdENMeWaaWxbsP+W2VKdMwipdtqM48dDu3VspcHEapWdQXTj7cZEs0D2B9DDLWgrA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7407b801-0f91-4732-9179-c24d56a353b5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a0b78dfe-b1ee-4e47-90db-074f48c5cc16", "AQAAAAEAACcQAAAAEKD4Rj9DZ7JV9+670R3pid9SYH/dC/XudOGD+eZ/rkkkqo4RFiXSycA6Om3uU0mSoA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8814825-284e-44d0-ac12-c69a097ca81c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ad9e0ee-7ac4-40ac-9bbb-53be38b5d90e", "AQAAAAEAACcQAAAAEOtVti8w8EuHMDGzVQnr1BkzUUyhaNhHlG/NKLAk2WdsS30ifYaSKgogqJI4iLbWhw==" });
        }
    }
}
