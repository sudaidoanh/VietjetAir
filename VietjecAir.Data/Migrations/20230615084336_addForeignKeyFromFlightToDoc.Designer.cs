﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VietjecAir.Data.EF;

#nullable disable

namespace VietjecAir.Data.Migrations
{
    [DbContext(typeof(VietjetAirDbContext))]
    [Migration("20230615084336_addForeignKeyFromFlightToDoc")]
    partial class addForeignKeyFromFlightToDoc
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("6d8cc029-fe13-4a37-b241-39dafbbc94ba"),
                            RoleId = new Guid("944bd118-0128-412b-b6af-0e96921d64b7")
                        },
                        new
                        {
                            UserId = new Guid("612e9def-cd18-4210-9f71-0101ea527cb3"),
                            RoleId = new Guid("4857318f-ea9e-4250-aaf2-5b0344e1486e")
                        },
                        new
                        {
                            UserId = new Guid("7407b801-0f91-4732-9179-c24d56a353b5"),
                            RoleId = new Guid("1706e285-cee8-495e-8f1d-4f3db18e975b")
                        },
                        new
                        {
                            UserId = new Guid("f8814825-284e-44d0-ac12-c69a097ca81c"),
                            RoleId = new Guid("6ff5fb0c-912a-446f-bf64-fcec3532dd01")
                        },
                        new
                        {
                            UserId = new Guid("73b3e5f4-20a8-4db4-8cb7-8a7151429cb5"),
                            RoleId = new Guid("f5917976-7e77-4190-8561-f4366f1cf612")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens", (string)null);
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("944bd118-0128-412b-b6af-0e96921d64b7"),
                            Action = "Owner",
                            ConcurrencyStamp = "2d42d459-7042-4a06-bc04-c8ec223df3dd",
                            Description = "Owner have full access to the system and use all existing functions, manage and decentralize user classes include administrator.",
                            Name = "Owner",
                            NormalizedName = "Owner"
                        },
                        new
                        {
                            Id = new Guid("4857318f-ea9e-4250-aaf2-5b0344e1486e"),
                            Action = "Administrators",
                            ConcurrencyStamp = "2f2ec6ff-b6ac-484e-b86d-ed14a29375dc",
                            Description = "Administrators have full access to the system and use all existing functions, manage and decentralize user classes.",
                            Name = "Administrators",
                            NormalizedName = "Administrators"
                        },
                        new
                        {
                            Id = new Guid("1706e285-cee8-495e-8f1d-4f3db18e975b"),
                            Action = "GOStaff",
                            ConcurrencyStamp = "3bd3a7df-eec1-4959-935e-6bfff52906c3",
                            Description = "Functions: view information, update and upload documents, fill out document information; see the history of changes to the document… users can set up functions that allow viewing or editing of documents for specific groups of users.",
                            Name = "GOStaff",
                            NormalizedName = "GOStaff"
                        },
                        new
                        {
                            Id = new Guid("6ff5fb0c-912a-446f-bf64-fcec3532dd01"),
                            Action = "Pilot",
                            ConcurrencyStamp = "624691ca-38b8-4d0b-bd04-b5cfe149a6ad",
                            Description = "Access to the system to view the document information about the assigned flight, edit and update the document information when authorized.",
                            Name = "Pilot",
                            NormalizedName = "Pilot"
                        },
                        new
                        {
                            Id = new Guid("f5917976-7e77-4190-8561-f4366f1cf612"),
                            Action = "Attendant",
                            ConcurrencyStamp = "1db9d4fd-2f22-48a0-8c0b-d1c85b3e36b7",
                            Description = "Attendant access to the system to view the document information about the assigned flight, edit and update the document information when authorized.",
                            Name = "Attendant",
                            NormalizedName = "Attendant"
                        });
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("AppUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("6d8cc029-fe13-4a37-b241-39dafbbc94ba"),
                            AccessFailedCount = 10,
                            Address = "Ho Chi Minh City",
                            ConcurrencyStamp = "e50e4664-11af-4b88-b0b0-0ef027f14c20",
                            Email = "owner@vietjetair.com",
                            EmailConfirmed = true,
                            FullName = "Owner",
                            LockoutEnabled = false,
                            NormalizedEmail = "owner@vietjetair.com",
                            NormalizedUserName = "owner",
                            PasswordHash = "AQAAAAEAACcQAAAAEJTLGKC8BpVOKlvCD6LYltFAtQ6TwCYM85nPQVRaHaeWxN4Cq9wVRnLFqyPNEG1/3Q==",
                            PhoneNumber = "0223456789",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "owner"
                        },
                        new
                        {
                            Id = new Guid("612e9def-cd18-4210-9f71-0101ea527cb3"),
                            AccessFailedCount = 10,
                            Address = "Ho Chi Minh City",
                            ConcurrencyStamp = "086a0a20-2230-4157-84e6-d56fd9d77f51",
                            Email = "admin@vietjetair.com",
                            EmailConfirmed = true,
                            FullName = "Administrators",
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@vietjetair.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEDD+P7qmmLagDo6o9bCCPAqEO/j8ifzsSqn8Vyg2NQusGiLGGW1gAT8NJVex82lnpQ==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = new Guid("7407b801-0f91-4732-9179-c24d56a353b5"),
                            AccessFailedCount = 10,
                            Address = "Ho Chi Minh City",
                            ConcurrencyStamp = "77a3c3f9-c6c9-4fb5-a1d4-b32ae309ce72",
                            Email = "gostaff@vietjetair.com",
                            EmailConfirmed = true,
                            FullName = "GO Staff",
                            LockoutEnabled = false,
                            NormalizedEmail = "gostaff@vietjetair.com",
                            NormalizedUserName = "GOStaff",
                            PasswordHash = "AQAAAAEAACcQAAAAELMJqqRDxoZGtDnl6RO5WPwrDKvT8SYlcGP46Rp7qV7+VletXBZtimwHivBRAbg7aQ==",
                            PhoneNumber = "0123456789",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "GOStaff"
                        },
                        new
                        {
                            Id = new Guid("f8814825-284e-44d0-ac12-c69a097ca81c"),
                            AccessFailedCount = 10,
                            Address = "Ho Chi Minh City",
                            ConcurrencyStamp = "f8f22f73-8f46-45b1-8ffb-962f912e8a45",
                            Email = "pilot@vietjetair.com",
                            EmailConfirmed = true,
                            FullName = "Pilot",
                            LockoutEnabled = false,
                            NormalizedEmail = "pilot@vietjetair.com",
                            NormalizedUserName = "pilot",
                            PasswordHash = "AQAAAAEAACcQAAAAEMXJITrkSkfRjPMX2IVKYLgj7MZFm7Oc23Kw7PHXrjMEsmUeOWmQHHLJksq474SEgg==",
                            PhoneNumber = "0122222222",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "pilot"
                        },
                        new
                        {
                            Id = new Guid("73b3e5f4-20a8-4db4-8cb7-8a7151429cb5"),
                            AccessFailedCount = 10,
                            Address = "Dong Ha Quang Tri",
                            ConcurrencyStamp = "402486f8-cbd3-4eff-ab00-e6e302454f57",
                            Email = "attendant@vietjetair.com",
                            EmailConfirmed = true,
                            FullName = "Attendant ",
                            LockoutEnabled = false,
                            NormalizedEmail = "attendant@vietjetair.com",
                            NormalizedUserName = "attendant",
                            PasswordHash = "AQAAAAEAACcQAAAAEBhpC975YWLI+yqTjmnmEaeFq6OV9avDw5uxWbFo8YvxR5yQ30Wt3SKdKcqmdd03gg==",
                            PhoneNumber = "0967145696",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "attendant"
                        });
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Creator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DocumentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("FlightId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.ToTable("Documents", (string)null);
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.DocumentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DocumentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Creator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id", "DocumentId");

                    b.HasIndex("DocumentId");

                    b.ToTable("DocumentDetails", (string)null);
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Creator")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Note")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("DocumentTypes", (string)null);
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.Flight", b =>
                {
                    b.Property<string>("FlightNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("PointofLoading")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PointofUnloading")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeLoading")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeUnloading")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FlightNo");

                    b.ToTable("Flights", (string)null);
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Creator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Note")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Groups", (string)null);
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.GroupMember", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupMembers", (string)null);
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.Permission", b =>
                {
                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("DocumentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Permissions")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("GroupId", "DocumentTypeId");

                    b.HasIndex("DocumentTypeId");

                    b.ToTable("Permissions", (string)null);
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.Point", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Points", (string)null);
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.System", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("CapchaEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("LogoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("LogoSize")
                        .HasColumnType("bigint");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserUpdate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ConfigureSystems", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CapchaEnabled = false,
                            LogoPath = "",
                            LogoSize = 1L,
                            Theme = "Default theme",
                            Updated = new DateTime(2023, 6, 15, 15, 43, 36, 757, DateTimeKind.Local).AddTicks(2567),
                            UserUpdate = "Owner@vietjetair.com"
                        });
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.Document", b =>
                {
                    b.HasOne("VietjecAir.Data.Entities.Flight", "Flight")
                        .WithMany("Documents")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.DocumentDetail", b =>
                {
                    b.HasOne("VietjecAir.Data.Entities.Document", "Document")
                        .WithMany("Details")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.GroupMember", b =>
                {
                    b.HasOne("VietjecAir.Data.Entities.Group", "Group")
                        .WithMany("groupMembers")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VietjecAir.Data.Entities.AppUser", "AppUser")
                        .WithMany("groupMembers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.Permission", b =>
                {
                    b.HasOne("VietjecAir.Data.Entities.DocumentType", "DocumentType")
                        .WithMany("permissions")
                        .HasForeignKey("DocumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VietjecAir.Data.Entities.Group", "Group")
                        .WithMany("permissions")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DocumentType");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.AppUser", b =>
                {
                    b.Navigation("groupMembers");
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.Document", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.DocumentType", b =>
                {
                    b.Navigation("permissions");
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.Flight", b =>
                {
                    b.Navigation("Documents");
                });

            modelBuilder.Entity("VietjecAir.Data.Entities.Group", b =>
                {
                    b.Navigation("groupMembers");

                    b.Navigation("permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
