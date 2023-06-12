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
                Date = (request.FlightInfo.Date).ToDateTime(new TimeOnly(0,0,0)),
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
