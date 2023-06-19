using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjetAir.ViewModels.Catalog.FlightServices;
using VietjetAir.ViewModels.Common;

namespace VietjetAir.Application.Catalog.FlightServices
{
    public interface IFlightService
    {
        Task<bool> AddPoint(PointModel request);
        Task<List<PointModel>> GetPoint();
        Task<bool> AddFlightDocs(string Creator, AddFlightDocsRequest request);
        Task<ResultModel<AllFlightModel>> GetAllFlightDocs(GetAllFlightPagingRequest request);
        Task<List<DocumentTypeSubFlightModel>> GetDocumentTypeSubFlight(string FlightNo);
        Task<string> GetDocTypeName(int DocTypeId);
        Task<List<PermissionDTO>> GetPermission(int GroupId);
        Task<List<DocsDTO>> GetDocsDTO(int DocId);
        Task<FlightDocDetailModel> GetFlightDocDetail(string FlightNo);
    }
}
