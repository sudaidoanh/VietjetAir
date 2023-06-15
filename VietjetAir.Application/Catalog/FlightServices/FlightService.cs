using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VietjecAir.Data.EF;
using VietjecAir.Data.Entities;
using VietjetAir.Application.Common;
using VietjetAir.ViewModels.Catalog.FlightServices;
using VietjetAir.ViewModels.Common;

namespace VietjetAir.Application.Catalog.FlightServices
{
    public class FlightService : IFlightService
    {
        private readonly VietjetAirDbContext _context;
        private readonly IStorageService _storageService;
        public FlightService(VietjetAirDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<bool> AddFlightDocs(string creator, AddFlightDocsRequest request)
        {
            var flight = new Flight()
            {
                FlightNo = request.FlightInfo.FlightNo,
                Date = (new DateOnly(request.FlightInfo.Year, request.FlightInfo.Month, request.FlightInfo.Day)).ToDateTime(new TimeOnly(0,0,0)),
                PointofLoading = request.FlightInfo.PointofLoading,
                PointofUnloading = request.FlightInfo.PointofUnloading
            };
            await _context.Flights.AddAsync(flight);
            bool result = await _context.SaveChangesAsync() > 0;

            var _flight = await _context.Flights.FindAsync(request.FlightInfo.FlightNo);
            string flightId = _flight.FlightNo;
            if(!result && _flight == null)
            {
                throw new Exception("Cant add, get Flight Infomation");
            }
            var document = new Document()
            {
                Name = request.File.Name,
                Note = request.Note,
                Creator = creator,
                DocumentTypeId = request.DocTypeId,
                FlightId = flightId,
                CreatedDate = DateTime.Now,
                Details = new List<DocumentDetail>()
                {
                    new DocumentDetail()
                    {
                        Title = request.File.Name,
                        CreatedDate = DateTime.Now,
                        Version = 1,
                        Creator = creator,
                        FilePath = await this.SaveFile(request.File),
                        FileSize = request.File.Length,
                    }
                }
            };

            await _context.Documents.AddAsync(document);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> AddPoint(PointModel request)
        {
            var point = new Point()
            {
                Id = request.Id,
                Name = request.Name,
                Local = request.Local,
            };
            await _context.Points.AddAsync(point);
            return _context.SaveChanges() > 0;
        }

        public async Task<ResultModel<AllFlightModel>> GetAllFlightDocs(GetAllFlightPagingRequest request)
        {
            var query = from f in _context.Flights select f;

            if (!string.IsNullOrEmpty(request.Keyword)) { query = query.Where(x => x.FlightNo.Contains(request.Keyword)); }
            int totalRecord = await query.CountAsync();

            var data = query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Include(x => x.Documents)
                .Select(x => new AllFlightModel()
                {
                    FlightNo = x.FlightNo,
                    Route = $"{x.PointofLoading} - {x.PointofUnloading}",
                    DepartureDate = DateOnly.FromDateTime(x.Date),
                    ToTalDocuments = x.Documents.Count(),
                }).ToListAsync();

            foreach(var d in await data)
            {
                d.Documents = await GetDocumentTypeSubFlight(d.FlightNo);
            }

            return new ResultModel<AllFlightModel>()
            {
                Items = await data,
                TotalRecord = totalRecord
            };
        }

        public async Task<List<DocumentTypeSubFlightModel>> GetDocumentTypeSubFlight(string FlightNo)
        {
            var query = from d in _context.Documents
                        where d.FlightId.Equals(FlightNo)
                        select d;
            query = query.Include(x => x.Details);
            var data = query.Select(x => new DocumentTypeSubFlightModel()
            {
                DocTypeId = x.Id,
                DocumentName = x.Name,
                CreateDate = x.CreatedDate,
                Creator = x.Creator,
                LatestVersion = $"1.{x.Details.Max( c => c.Version)}",
            }).ToListAsync();

            foreach(var d in await data)
            {
                d.Type = await this.GetDocTypeName(d.DocTypeId);
            }

            return await data;
        }

        public async Task<string> GetDocTypeName(int DocTypeId)
        {
            var doctype = await _context.DocumentTypes.FirstOrDefaultAsync(x => x.Id == DocTypeId);
            return doctype.Name;
        }

        public async Task<List<PointModel>> GetPoint()
        {
            var query = from p in _context.Points select p;
            var data = query.Select(p => new PointModel
            {
                Id = p.Id,
                Name = p.Name,
                Local = p.Local,
            }).ToListAsync();
            return await data;
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
