using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjecAir.Data.EF;
using VietjecAir.Data.Entities;

namespace VietjetAir.Application.Systems.Permission
{
    public class PermissionService : IPermissionService
    {
        private readonly VietjetAirDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public PermissionService(UserManager<AppUser> userManager, VietjetAirDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<bool> CheckPermissionOnDocsWithFlightNo(string User, string FlightNo, string Permission)
        {
            var user =  await _userManager.FindByEmailAsync(User);
            var role = await _userManager.GetRolesAsync(user);
            foreach(var x in role)
            {
                if (x.Equals("Administrators") || x.Equals("Owner")) return true;
            }

            var doc = await _context.Documents.FirstOrDefaultAsync(x => x.FlightId == FlightNo);

            //var docType = await _context.DocumentTypes.FirstOrDefaultAsync(x => x.Id == doc.DocumentTypeId);

            var groupsInPermission = await _context.Permissions.Where(x => x.DocumentTypeId == doc.DocumentTypeId).Select(x => new {x.GroupId, x.Permissions}).ToListAsync();
            var groupMember = await _context.GroupMembers.Where(x => x.UserId.Equals(user.Id)).Select(x => x.GroupId).ToListAsync();

            foreach(var x in groupsInPermission)
            {
                foreach(var y in groupMember)
                {
                    if(x.GroupId == y)
                    {
                        if (Permission.Equals(x.Permissions)) return true;
                    }
                }
            }

            return false;
        }
    }
}
