using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VietjecAir.Data.EF;
using VietjetAir.Application.Common;
using VietjetAir.ViewModels.Systems.Settings;

namespace VietjetAir.Application.Systems.Settings
{
    public class SettingService : ISettingService
    {
        private readonly VietjetAirDbContext _context;
        private readonly IStorageService _storageService;
        public SettingService(VietjetAirDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<bool> ChangeGeneralSetting(string UserUpdate, ChangeGeneralSettingRequest request)
        {
            var system = await _context.ConfigureSystems.FindAsync(1);
            if(system == null) { return  false; }
            system.Theme = request.Theme;
            system.CapchaEnabled = request.CapchaEnabled;
            system.LogoPath = await this.SaveFile(request.LogoImage);
            system.LogoSize = request.LogoImage.Length;
            system.Updated = DateTime.Now;
            system.UserUpdate = UserUpdate;
            _context.ConfigureSystems.Update(system);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<GetGeneralSettingRequest> GetGeneralSetting()
        {
            var data = await _context.ConfigureSystems.FindAsync(1);
            return new GetGeneralSettingRequest()
            {
                Theme = data.Theme,
                LogoPath = data.LogoPath,
                CapchaEnabled = data.CapchaEnabled,
            };
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
