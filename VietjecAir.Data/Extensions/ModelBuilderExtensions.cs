using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjecAir.Data.Entities;

namespace VietjecAir.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var ADMINSYSTEM_ID = new Guid("612E9DEF-CD18-4210-9F71-0101EA527CB3");
            var ADMINSYSTEM_ROLE_ID = new Guid("4857318F-EA9E-4250-AAF2-5B0344E1486E");

            var GOSTAFF_ROLE_ID = new Guid("1706E285-CEE8-495E-8F1D-4F3DB18E975B");
            var GOSTAFF_ID = new Guid("7407B801-0F91-4732-9179-C24D56A353B5");

            var PILOT_ID = new Guid("F8814825-284E-44D0-AC12-C69A097CA81C");
            var PILOT_ROLE_ID = new Guid("6FF5FB0C-912A-446F-BF64-FCEC3532DD01");

            var ATTENDANT_ROLE_ID = new Guid("F5917976-7E77-4190-8561-F4366F1CF612");
            var ATTENDANT_ID = new Guid("73B3E5F4-20A8-4DB4-8CB7-8A7151429CB5");



            modelBuilder.Entity<AppRole>().HasData(new AppRole()
            {
                Id = ADMINSYSTEM_ROLE_ID,
                Name = "Adminstrator",
                NormalizedName = "Adminstrator",
                Description = "Administrators have full access to the system and use all existing functions, manage and decentralize user classes.",
                Action = "Adminstrator",
                Permission = "All Permission"
            });

            modelBuilder.Entity<AppRole>().HasData(new AppRole()
            {
                Id = GOSTAFF_ROLE_ID,
                Name = "GOStaff",
                NormalizedName = "GOStaff",
                Description = "Functions: view information, update and upload documents, fill out document information; see the history of changes to the document… users can set up functions that allow viewing or editing of documents for specific groups of users.",
                Action = "GOStaff",
                Permission = "Grant, Modify, Read"
            });

            modelBuilder.Entity<AppRole>().HasData(new AppRole()
            {
                Id = PILOT_ROLE_ID,
                Name = "Pilot",
                NormalizedName = "Pilot",
                Description = "Access to the system to view the document information about the assigned flight, edit and update the document information when authorized.",
                Action = "Pilot",
                Permission = "No Permission"
            });

            modelBuilder.Entity<AppRole>().HasData(new AppRole()
            {
                Id = ATTENDANT_ROLE_ID,
                Name = "Attendant",
                NormalizedName = "Attendant",
                Description = "Attendant access to the system to view the document information about the assigned flight, edit and update the document information when authorized.",
                Action = "Attendant",
                Permission = "No Permission"
            });

            var hasher = new PasswordHasher<AppUser>();

            modelBuilder.Entity<AppUser>().HasData(new AppUser()
            {
                Id = ADMINSYSTEM_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@vietjetair.com",
                NormalizedEmail = "admin@vietjetair.com",
                AccessFailedCount = 10,
                PhoneNumber = "1234567890",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "1234567a"),
                SecurityStamp = string.Empty,
                FullName = "Adminstrator",
                Address = "Ho Chi Minh City",
            });

            modelBuilder.Entity<AppUser>().HasData(new AppUser()
            {
                Id = GOSTAFF_ID,
                UserName = "GOStaff",
                NormalizedUserName = "GOStaff",
                Email = "gostaff@vietjetair.com",
                NormalizedEmail = "gostaff@vietjetair.com",
                AccessFailedCount = 10,
                PhoneNumber = "0123456789",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "1234567a"),
                SecurityStamp = string.Empty,
                FullName = "GO Staff",
                Address = "Ho Chi Minh City",
            });

            modelBuilder.Entity<AppUser>().HasData(new AppUser()
            {
                Id = PILOT_ID,
                UserName = "pilot",
                NormalizedUserName = "pilot",
                Email = "pilot@vietjetair.com",
                NormalizedEmail = "pilot@vietjetair.com",
                AccessFailedCount = 10,
                PhoneNumber = "0122222222",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "1234567a"),
                SecurityStamp = string.Empty,
                FullName = "Pilot",
                Address = "Ho Chi Minh City",
            });

            modelBuilder.Entity<AppUser>().HasData(new AppUser()
            {
                Id = ATTENDANT_ID,
                UserName = "attendant",
                NormalizedUserName = "attendant",
                Email = "attendant@vietjetair.com",
                NormalizedEmail = "attendant@vietjetair.com",
                AccessFailedCount = 10,
                PhoneNumber = "0967145696",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456aA@"),
                SecurityStamp = string.Empty,
                FullName = "Attendant ",
                Address = "Dong Ha Quang Tri",
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = ADMINSYSTEM_ROLE_ID,
                UserId = ADMINSYSTEM_ID,
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = GOSTAFF_ROLE_ID,
                UserId = GOSTAFF_ID,
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = PILOT_ROLE_ID,
                UserId = PILOT_ID,
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = ATTENDANT_ROLE_ID,
                UserId = ATTENDANT_ID,
            });
        }
    }
}
