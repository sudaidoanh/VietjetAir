using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VietjecAir.Data.Migrations
{
    /// <inheritdoc />
    public partial class addForeignKeyFromFlightToDoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FlightId",
                table: "Documents",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_Documents_FlightId",
                table: "Documents",
                column: "FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Flights_FlightId",
                table: "Documents",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "FlightNo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Flights_FlightId",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Documents_FlightId",
                table: "Documents");

            migrationBuilder.AlterColumn<string>(
                name: "FlightId",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
