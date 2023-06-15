using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VietjecAir.Data.Migrations
{
    /// <inheritdoc />
    public partial class addCreateColToDocTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Documents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Documents");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1706e285-cee8-495e-8f1d-4f3db18e975b"),
                column: "ConcurrencyStamp",
                value: "3bd3a7df-eec1-4959-935e-6bfff52906c3");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4857318f-ea9e-4250-aaf2-5b0344e1486e"),
                column: "ConcurrencyStamp",
                value: "2f2ec6ff-b6ac-484e-b86d-ed14a29375dc");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("6ff5fb0c-912a-446f-bf64-fcec3532dd01"),
                column: "ConcurrencyStamp",
                value: "624691ca-38b8-4d0b-bd04-b5cfe149a6ad");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("944bd118-0128-412b-b6af-0e96921d64b7"),
                column: "ConcurrencyStamp",
                value: "2d42d459-7042-4a06-bc04-c8ec223df3dd");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5917976-7e77-4190-8561-f4366f1cf612"),
                column: "ConcurrencyStamp",
                value: "1db9d4fd-2f22-48a0-8c0b-d1c85b3e36b7");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("612e9def-cd18-4210-9f71-0101ea527cb3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "086a0a20-2230-4157-84e6-d56fd9d77f51", "AQAAAAEAACcQAAAAEDD+P7qmmLagDo6o9bCCPAqEO/j8ifzsSqn8Vyg2NQusGiLGGW1gAT8NJVex82lnpQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d8cc029-fe13-4a37-b241-39dafbbc94ba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e50e4664-11af-4b88-b0b0-0ef027f14c20", "AQAAAAEAACcQAAAAEJTLGKC8BpVOKlvCD6LYltFAtQ6TwCYM85nPQVRaHaeWxN4Cq9wVRnLFqyPNEG1/3Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("73b3e5f4-20a8-4db4-8cb7-8a7151429cb5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "402486f8-cbd3-4eff-ab00-e6e302454f57", "AQAAAAEAACcQAAAAEBhpC975YWLI+yqTjmnmEaeFq6OV9avDw5uxWbFo8YvxR5yQ30Wt3SKdKcqmdd03gg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7407b801-0f91-4732-9179-c24d56a353b5"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77a3c3f9-c6c9-4fb5-a1d4-b32ae309ce72", "AQAAAAEAACcQAAAAELMJqqRDxoZGtDnl6RO5WPwrDKvT8SYlcGP46Rp7qV7+VletXBZtimwHivBRAbg7aQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8814825-284e-44d0-ac12-c69a097ca81c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8f22f73-8f46-45b1-8ffb-962f912e8a45", "AQAAAAEAACcQAAAAEMXJITrkSkfRjPMX2IVKYLgj7MZFm7Oc23Kw7PHXrjMEsmUeOWmQHHLJksq474SEgg==" });

            migrationBuilder.UpdateData(
                table: "ConfigureSystems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Updated",
                value: new DateTime(2023, 6, 15, 15, 43, 36, 757, DateTimeKind.Local).AddTicks(2567));
        }
    }
}
