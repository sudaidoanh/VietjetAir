using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.Application.Systems.Permission
{
    public interface IPermissionService
    {
        Task<bool> CheckPermission(string User, string Permission);
        Task<bool> CheckPermissionOnDocsWithFlightNo(string User, string FlightNo, string Permission);
    }
}
