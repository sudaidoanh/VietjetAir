using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjetAir.ViewModels.Catalog.FlightServices;

namespace VietjetAir.Application.Catalog.FlightServices
{
    public interface IFlightService
    {
        Task<bool> AddPoint(PointModel request);
        Task<List<PointModel>> GetPoint();
        Task<bool> AddFlightDocs(string Creator, AddFlightDocsRequest request);
    }
}
