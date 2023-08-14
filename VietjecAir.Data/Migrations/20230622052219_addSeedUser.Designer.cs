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
    [Migration("20230622052219_addSeedUser")]
    partial class addSeedUser
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
                        },
                        new
                        {
                            UserId = new Guid("82a52dd8-c50a-430a-a3de-87135f988d18"),
                            RoleId = new Guid("f4f1f7f0-c836-4f7b-9d74-8b43cb6bd269")
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
                            ConcurrencyStamp = "e9b1a562-8405-4691-a588-7ce5cec9edea",
                            Description = "Owner have full access to the system and use all existing functions, manage and decentralize user classes include administrator.",
                            Name = "Owner",
                            NormalizedName = "Owner"
                        },
                        new
                        {
                            Id = new Guid("4857318f-ea9e-4250-aaf2-5b0344e1486e"),
                            Action = "Administrators",
                            ConcurrencyStamp = "bc108194-bcb0-475a-94dd-edfbb5777f91",
                            Description = "Administrators have full access to the system and use all existing functions, manage and decentralize user classes.",
                            Name = "Administrators",
                            NormalizedName = "Administrators"
                        },
                        new
                        {
                            Id = new Guid("1706e285-cee8-495e-8f1d-4f3db18e975b"),
                            Action = "GOStaff",
                            ConcurrencyStamp = "6f6551fc-5c73-4f98-b398-0a12aa789c4a",
                            Description = "Functions: view information, update and upload documents, fill out document information; see the history of changes to the document… users can set up functions that allow viewing or editing of documents for specific groups of users.",
                            Name = "GOStaff",
                            NormalizedName = "GOStaff"
                        },
                        new
                        {
                            Id = new Guid("6ff5fb0c-912a-446f-bf64-fcec3532dd01"),
                            Action = "Pilot",
                            ConcurrencyStamp = "02539449-9a78-4912-9e0d-25f1f1252b7a",
                            Description = "Access to the system to view the document information about the assigned flight, edit and update the document information when authorized.",
                            Name = "Pilot",
                            NormalizedName = "Pilot"
                        },
                        new
                        {
                            Id = new Guid("82a52dd8-c50a-430a-a3de-87135f988d18"),
                            Action = "User",
                            ConcurrencyStamp = "11baa482-abff-4275-b67f-f19a075f98c1",
                            Description = "User can logging into system",
                            Name = "User",
                            NormalizedName = "User"
                        },
                        new
                        {
                            Id = new Guid("f5917976-7e77-4190-8561-f4366f1cf612"),
                            Action = "Attendant",
                            ConcurrencyStamp = "626d0351-445b-442d-a73c-14f66cda3719",
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
                            ConcurrencyStamp = "18c5e3ae-7b3c-4e6c-ab20-ad8e708fd81a",
                            Email = "owner@vietjetair.com",
                            EmailConfirmed = true,
                            FullName = "Owner",
                            LockoutEnabled = false,
                            NormalizedEmail = "owner@vietjetair.com",
                            NormalizedUserName = "owner",
                            PasswordHash = "AQAAAAEAACcQAAAAEED3tCGIucmRd+Ttf28Q8Hm5H/iyA5+307Rutgjn+IG8RlfubOfSGtQG6SdqVoF2UQ==",
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
                            ConcurrencyStamp = "9873df48-262d-4bf4-86de-be56200a0329",
                            Email = "admin@vietjetair.com",
                            EmailConfirmed = true,
                            FullName = "Administrators",
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@vietjetair.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEDqb7PxixvgujwF1N5U56v2qkaxi5B5qz1ZjIGp0ASnhYbn9wQyQgA5zgNQCjDnvzg==",
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
                            ConcurrencyStamp = "d7f34b29-c2e9-4d61-b658-c6d10d657bdd",
                            Email = "gostaff@vietjetair.com",
                            EmailConfirmed = true,
                            FullName = "GO Staff",
                            LockoutEnabled = false,
                            NormalizedEmail = "gostaff@vietjetair.com",
                            NormalizedUserName = "GOStaff",
                            PasswordHash = "AQAAAAEAACcQAAAAEBCBcZ1NrnWN88d90dY2U+QLyKkS8D5Uwz4Y4P6gvdgPsvm9PPHouaRWvTlviWotgw==",
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
                            ConcurrencyStamp = "35638a69-2b59-4709-ad95-dd061a6c5d40",
                            Email = "pilot@vietjetair.com",
                            EmailConfirmed = true,
                            FullName = "Pilot",
                            LockoutEnabled = false,
                            NormalizedEmail = "pilot@vietjetair.com",
                            NormalizedUserName = "pilot",
                            PasswordHash = "AQAAAAEAACcQAAAAEKUaTxbrPyZC9MRNzJZBIztKs73b5X7H14lJjcXFrb161Kzop9IslLLsEhnqDdIGjg==",
                            PhoneNumber = "0122222222",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "pilot"
                        },
                        new
                        {
                            Id = new Guid("82a52dd8-c50a-430a-a3de-87135f988d18"),
                            AccessFailedCount = 10,
                            Address = "Ha Noi City",
                            ConcurrencyStamp = "311a2967-db93-47c0-8c8d-41135674ca73",
                            Email = "user@vietjetair.com",
                            EmailConfirmed = true,
                            FullName = "user",
                            LockoutEnabled = false,
                            NormalizedEmail = "user@vietjetair.com",
                            NormalizedUserName = "user",
                            PasswordHash = "AQAAAAEAACcQAAAAEDiC/S25fWEUf8VDxQzWLlCoaVEifSVusK67H7SmPBO9w0OfroFkXKYepdp/8cef5w==",
                            PhoneNumber = "12312312412",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "user"
                        },
                        new
                        {
                            Id = new Guid("73b3e5f4-20a8-4db4-8cb7-8a7151429cb5"),
                            AccessFailedCount = 10,
                            Address = "Dong Ha Quang Tri",
                            ConcurrencyStamp = "9c68efcc-e4bc-4f62-91c0-7f6e10c31e85",
                            Email = "attendant@vietjetair.com",
                            EmailConfirmed = true,
                            FullName = "Attendant ",
                            LockoutEnabled = false,
                            NormalizedEmail = "attendant@vietjetair.com",
                            NormalizedUserName = "attendant",
                            PasswordHash = "AQAAAAEAACcQAAAAEBjfVAioCvu6ezYqQt/JBrPYxxzeF8RrrXLtkU9AKsB0f6o2o11MN54aRyoyEiz1dQ==",
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

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

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
                            Updated = new DateTime(2023, 6, 22, 12, 22, 18, 875, DateTimeKind.Local).AddTicks(7037),
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