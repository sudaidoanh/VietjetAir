using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjecAir.Data.EF;
using VietjecAir.Data.Entities;
using VietjetAir.ViewModels.Common;

namespace VietjetAir.ViewModels.Catalog.GroupPermission
{
    public class GroupPermissionService : IGroupPermissionService
    {
        private readonly VietjetAirDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public GroupPermissionService(UserManager<AppUser> userManager, VietjetAirDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<ResultModel<GroupPermissionViewModel>> GetGroupPermission(PagingRequestBase request)
        {
            var query = from g in _context.Groups
                        select g;
            query = query.Include(x => x.groupMembers);
            int totalRecord = await query.CountAsync();
            var data = query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(p => new GroupPermissionViewModel()
                {
                    GroupId = p.Id,
                    GroupName = p.Name,
                    Member = p.groupMembers.Count() > 0? "p.groupMembers.Count() accounts" : "0 account",
                    CreatedDate = p.Created,
                    Note = string.IsNullOrEmpty(p.Note) ? "--" : p.Note,
                    Creator = p.Creator
                }).ToListAsync();

            return new ResultModel<GroupPermissionViewModel>() 
            { 
                TotalRecord = totalRecord,
                Items = await data,
            };
        }

        public async Task<bool> CreateGroup(CreateGroupRequest request)
        {
            if(string.IsNullOrEmpty(request.Name)) return false;
            var group = new Group()
            {
                Name = request.Name,
                Note = request.Note,
                Creator = request.Creator,
                Created = DateTime.Now,
            };
            await _context.Groups.AddAsync(group);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveGroup(string GroupName)
        {
            var group = await _context.Groups.FirstOrDefaultAsync(x => x.Name.Equals(GroupName));
            if(group == null) return false;
            _context.Groups.Remove(group);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<GroupDetailViewModel> GetGroupDetail(string GroupName)
        {
            var group = await _context.Groups.FirstOrDefaultAsync(x => x.Name.Equals(GroupName));
            if (group == null) return null;
            int groupId = group.Id;
            var memberQuery = from gm in _context.GroupMembers.Where(gm => gm.GroupId == groupId)
                              from a in _context.AppUsers.Where(a => a.Id.Equals(gm.UserId)).DefaultIfEmpty()
                              select a
                              ;
            var listMember = memberQuery.Select(x => new MembersModel()
            {
                MemberId = x.Id,
                Email = x.Email,
                Name = x.FullName,
                Permission = (IList<string>)_userManager.GetRolesAsync(x),
            }).ToListAsync();

            var member = _context.GroupMembers.Where(x => x.GroupId == group.Id);
            return new GroupDetailViewModel()
            {
                GroupId = group.Id,
                GroupName = group.Name,
                Note = group.Note,
                Members = await listMember,
            };
        }

        public async Task<bool> UpdateGroup(string GroupName, UpdateGroupRequest request)
        {
            if(string.IsNullOrEmpty(request.Name)) return false;
            if(await _context.Groups.FirstOrDefaultAsync(x => x.Name.Equals(request.Name)) != null) { return false; }
            var group = await _context.Groups.FirstOrDefaultAsync(x => x.Name.Equals(GroupName));
            if(group == null) { return false;}
            group.Name = request.Name;
            if (!string.IsNullOrEmpty(request.Note)) group.Note = request.Note;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
