using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VietjecAir.Data.Migrations
{
    /// <inheritdoc />
    public partial class addTableConfigureSystems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfigureSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Theme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoSize = table.Column<long>(type: "bigint", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapchaEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigureSystems", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfigureSystems");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1706e285-cee8-495e-8f1d-4f3db18e975b"),
                column: "ConcurrencyStamp",
                value: "8546389c-7294-4945-adb0-25287a977542");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4857318f-ea9e-4250-aaf2-5b0344e1486e"),
                column: "ConcurrencyStamp",
                value: "8fa1ef2d-0f8c-41dc-a1fa-9ae25ddc6764");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("6ff5fb0c-912a-446f-bf64-fcec3532dd01"),
                column: "ConcurrencyStamp",
                value: "58fca573-5fa1-4d5a-986f-cfe2f5c0aac6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("944bd118-0128-412b-b6af-0e96921d64b7"),
                column: "ConcurrencyStamp",
                value: "2cd705ee-0969-4806-a3f6-2c94209ea67a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5917976-7e77-4190-8561-f4366f1cf612"),
                column: "ConcurrencyStamp",
                value: "7f083c0d-a63a-4c30-87e8-43eaa98d8a6b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("612e9def-cd18-4210-9f71-0101ea527cb3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "401c2876-c925-49ad-aafc-2223f173d981", "AQAAAAEAACcQAAAAEAlSLIUrNIFfwVRLhw0Md5FprtvlGXnjeBVcdITHn97R5ZXqo3vU9uWAf7D9Yux3nw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d8cc029-fe13-4a37-b241-39dafbbc94ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0f2e752-8120-44f9-b002-8860bf405ac6", "AQAAAAEAACcQAAAAEPCiHipoSFTSf6E0hbRjrgeK0PJ4JylRwPHIPhCMrQmt5SSRCkiuTZqFSBFfjOyypg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("73b3e5f4-20a8-4db4-8cb7-8a7151429cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7737aeef-f13a-41e6-b277-304eb091d82b", "AQAAAAEAACcQAAAAEMkQKEAbX5GqwtczZmbT5j7rda6Ffsdhk8FmWfcGvlrFDKqSF3U/Eg5YV1Be8xmm8A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7407b801-0f91-4732-9179-c24d56a353b5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c370ace3-8629-4eae-8fc2-85888a4c3a96", "AQAAAAEAACcQAAAAECmj0H55M1hAaxriuIEXYuA2LBEQze3aBGHomcIFZzNFJ3vybMA/YRjB01wh5zfuvg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8814825-284e-44d0-ac12-c69a097ca81c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "739df151-553b-4d58-b4f4-76579994c24a", "AQAAAAEAACcQAAAAEFAnnmE8Teh9spEaV8LeFuHJdttU0Xy3VQJqw3LDHJJtIocb4Gv1Wex2kmX2Mp0zYQ==" });
        }
    }
}
