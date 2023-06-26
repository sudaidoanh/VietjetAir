using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VietjecAir.Data.EF;
using VietjecAir.Data.Entities;
using VietjetAir.Application.Common;
using VietjetAir.ViewModels.Common;
using VietjetAir.ViewModels.Systems.Settings;

namespace VietjetAir.Application.Systems.Settings
{
    public class SettingService : ISettingService
    {
        private readonly VietjetAirDbContext _context;
        private readonly IStorageService _storageService;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        public SettingService(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, VietjetAirDbContext context, IStorageService storageService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _context = context;
            _storageService = storageService;
        }

        public async Task<bool> ChangeGeneralSetting(string UserUpdate, ChangeGeneralSettingRequest request)
        {

            var system = await _context.ConfigureSystems.FindAsync(1);

            if(system == null) { return  false; }

            await _storageService.DeleteFileAsync(system.LogoPath);

            system.Theme = request.Theme;
            system.CapchaEnabled = request.CapchaEnabled;
            system.LogoPath = await this.SaveFile(request.LogoImage);
            system.LogoSize = request.LogoImage.Length;
            system.Updated = DateTime.Now;
            system.UserUpdate = UserUpdate;
            
            _context.ConfigureSystems.Update(system);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> ChanggingOwnerAccount(string emailUser, ChangingOwnerAccountRequest request)
        {
            var currentOwner = await _context.AppUsers.FirstOrDefaultAsync(x => x.Email.Equals(emailUser));
            var checkCurrentOwnerPassword = await _signInManager.CheckPasswordSignInAsync(currentOwner, request.CurrentOwnerPassword, true);
            if (!checkCurrentOwnerPassword.Succeeded) return false;

            var user = await _context.AppUsers.FirstOrDefaultAsync(x => x.Email.Equals(request.Account));
            if(user == null) { return false; }

            var ownerRole = await _context.UserRoles.FirstOrDefaultAsync(x => x.UserId.Equals(currentOwner));
            var userRole = await _context.UserRoles.FirstOrDefaultAsync(x => x.UserId.Equals(user));

            var _userRole = await _context.AppRoles.FirstOrDefaultAsync(x => x.Name.Equals("User"));
            ownerRole.UserId = userRole.UserId;
            userRole.UserId = ownerRole.UserId;

            _context.UserRoles.Update(ownerRole);
            _context.UserRoles.Update(userRole);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<AccountDetailDTO> GetAccountDetail(Guid guid)
        {
            var user = await _context.AppUsers.FindAsync(guid);
            if (user == null) return null;

            var role = await _userManager.GetRolesAsync(user);
            var roles = _context.AppRoles.Select(x => x.Name).ToListAsync();

            return new AccountDetailDTO()
            {
                UserId = user.Id,
                FullName = user.UserName,
                Email = user.Email,
                Phone = user.PhoneNumber,
                UserRole = string.Join(",", roles),
                Roles = await roles
            };
        }

        public async Task<AccountSettingDTO> GetAccountPagingAsync(GetAccountSettingsRequest request)
        {
            var ownerRole = await _roleManager.FindByNameAsync("Owner");
            var ownerUserRole = await _context.UserRoles.FirstOrDefaultAsync(x => x.RoleId.Equals(ownerRole.Id));
            var owner = await _context.AppUsers.FindAsync(ownerUserRole.UserId);

            return new AccountSettingDTO()
            {
                CurrentOwner = owner.Email,
                CurrentOwnerName = owner.FullName,
                ListEmailUser = await GetEmailAsync(),
                AllAccounts = await GetAllAccountsAsync(request),
            };
        }

        public async Task<ResultModel<UserAccountModel>> GetAllAccountsAsync(GetAccountSettingsRequest request)
        {
            var query = from u in _context.AppUsers
                        from ur in _context.UserRoles.Where(ur => ur.UserId.Equals(u.Id)).DefaultIfEmpty()
                        from r in _context.AppRoles.Where(r => r.Id.Equals(ur.RoleId)).DefaultIfEmpty()
                        select new { u, r };

            if (!string.IsNullOrEmpty(request.Keyword)) query = query.Where(x => x.u.FullName.Contains(request.Keyword));

            int totalRecord = await query.CountAsync();

            var data = query.Select(x => new UserAccountModel()
            {
                Email = x.u.Email,
                MemberId = x.u.Id,
                Name = x.u.FullName,
                Role = x.r.Name
            }).ToListAsync();

            return new ResultModel<UserAccountModel>
            {
                TotalRecord = totalRecord,
                Items = await data
            };
        }

        public async Task<List<string>> GetEmailAsync() => await _context.AppUsers.Select(x => x.Email).ToListAsync();

        public async Task<AccountSettingModel> GetGeneralSetting()
        {
            var data = await _context.ConfigureSystems.FindAsync(1);
            return new AccountSettingModel()
            {
                Theme = data.Theme,
                LogoPath = data.LogoPath,
                CapchaEnabled = data.CapchaEnabled,
            };
        }

        public async Task<bool> RemoveUserAccount(Guid guid)
        {
            var user = await _context.AppUsers.FindAsync(guid);
            if (user != null) { return  false; }
            _context.AppUsers.Remove(user);
            return await _context.SaveChangesAsync() > 0;
        }

        public Task<bool> ResetPasswordUserAccount(Guid guid)
        {
            throw new NotImplementedException();
        }

        public async Task<int> TerminateUserSession(List<string> users)
        {
            foreach(var x in users) 
            {
                var user = await _context.AppUsers.FirstOrDefaultAsync(x => x.Email.Equals(x));
                if (user == null) continue;
                var role = await _context.UserRoles.FirstOrDefaultAsync(x => x.UserId.Equals(user.Id));
                _context.UserRoles.Remove(role);
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateUserAccount(Guid guid, UpdateUserAccountRequest request)
        {
            var user = await _context.AppUsers.FindAsync(guid);
            if (user != null) { return false; }

            var role = await _context.UserRoles.FirstOrDefaultAsync(x => x.UserId.Equals(guid));
            var roleId = await _context.AppRoles.FirstOrDefaultAsync(x => x.Name.Equals(request.RoleName));

            user.PhoneNumber = request.PhoneNumber;
            user.FullName = request.FullName;
            role.RoleId = roleId.Id;
            _context.Update(user);
            _context.Update(role);
            return await _context.SaveChangesAsync() > 0;
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}
