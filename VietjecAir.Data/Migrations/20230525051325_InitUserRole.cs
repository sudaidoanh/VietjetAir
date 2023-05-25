using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VietjecAir.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Action = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Permission = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "Action", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "Permission" },
                values: new object[,]
                {
                    { new Guid("1706e285-cee8-495e-8f1d-4f3db18e975b"), "GOStaff", "9a3b55af-431a-49b6-8d1c-e369a767697e", "Functions: view information, update and upload documents, fill out document information; see the history of changes to the document… users can set up functions that allow viewing or editing of documents for specific groups of users.", "GOStaff", "GOStaff", "Grant, Modify, Read" },
                    { new Guid("4857318f-ea9e-4250-aaf2-5b0344e1486e"), "Adminstrator", "e1c63a63-7270-4ce5-a7e4-5ecabb79ffd7", "Administrators have full access to the system and use all existing functions, manage and decentralize user classes.", "Adminstrator", "Adminstrator", "All Permission" },
                    { new Guid("6ff5fb0c-912a-446f-bf64-fcec3532dd01"), "Pilot", "4f516c7b-2381-48f2-baa2-bce9648d7c11", "Access to the system to view the document information about the assigned flight, edit and update the document information when authorized.", "Pilot", "Pilot", "No Permission" },
                    { new Guid("f5917976-7e77-4190-8561-f4366f1cf612"), "Attendant", "b581bd14-6e23-4b23-8b0f-64d92156075a", "Attendant access to the system to view the document information about the assigned flight, edit and update the document information when authorized.", "Attendant", "Attendant", "No Permission" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("612e9def-cd18-4210-9f71-0101ea527cb3"), 10, "Ho Chi Minh City", "badf400d-3b2c-47ca-a1c0-8e9e043fecb0", "admin@vietjetair.com", true, "Adminstrator", false, null, "admin@vietjetair.com", "admin", "AQAAAAEAACcQAAAAEG2TBi1cWiOdcZFtPefKDpxAOMNt0ITI3daKPnm7hVU5cH1JlDg9sm4Saceos6zyhA==", "1234567890", true, "", false, "admin" },
                    { new Guid("73b3e5f4-20a8-4db4-8cb7-8a7151429cb5"), 10, "Dong Ha Quang Tri", "89a3a0f5-6b66-47e4-834b-42cce4cd3aa9", "attendant@vietjetair.com", true, "Attendant ", false, null, "attendant@vietjetair.com", "attendant", "AQAAAAEAACcQAAAAEC6QsPyf7maU41Mul+HzwmfZfTzC5EQy02rebcLFRzXSGp6VDKcmLG3suu6I1UgtiA==", "0967145696", true, "", false, "attendant" },
                    { new Guid("7407b801-0f91-4732-9179-c24d56a353b5"), 10, "Ho Chi Minh City", "491cd7ac-dfd4-4c55-8a85-0ffc1a035378", "gostaff@vietjetair.com", true, "GO Staff", false, null, "gostaff@vietjetair.com", "GOStaff", "AQAAAAEAACcQAAAAEMgJ/hvVxxwF6y/wUbpk5ofn2p4aoWIiRpEDrXjeHyCIPScNd/dG1ViPFSNx7DDW+w==", "0123456789", true, "", false, "GOStaff" },
                    { new Guid("f8814825-284e-44d0-ac12-c69a097ca81c"), 10, "Ho Chi Minh City", "3470d917-56f7-4741-937e-d8be49a58450", "pilot@vietjetair.com", true, "Pilot", false, null, "pilot@vietjetair.com", "pilot", "AQAAAAEAACcQAAAAEAkBUr+JDg4XGNdAMWkjMIoeVSq4Vvzcd20rb2A8vITbdVjfCJLN+t8KVYGjEDa8sg==", "0122222222", true, "", false, "pilot" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4857318f-ea9e-4250-aaf2-5b0344e1486e"), new Guid("612e9def-cd18-4210-9f71-0101ea527cb3") },
                    { new Guid("f5917976-7e77-4190-8561-f4366f1cf612"), new Guid("73b3e5f4-20a8-4db4-8cb7-8a7151429cb5") },
                    { new Guid("1706e285-cee8-495e-8f1d-4f3db18e975b"), new Guid("7407b801-0f91-4732-9179-c24d56a353b5") },
                    { new Guid("6ff5fb0c-912a-446f-bf64-fcec3532dd01"), new Guid("f8814825-284e-44d0-ac12-c69a097ca81c") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_Email",
                table: "AppUsers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "UserRoles");
        }
    }
}
