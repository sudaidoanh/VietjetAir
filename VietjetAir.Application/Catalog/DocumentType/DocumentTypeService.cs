using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VietjecAir.Data.EF;
using VietjecAir.Data.Entities;
using VietjetAir.ViewModels.Catalog.Configuration;
using VietjetAir.ViewModels.Catalog.GroupPermission;
using VietjetAir.ViewModels.Common;

namespace VietjetAir.Application.Catalog.DocumentType
{
    public class DocumentTypeService : IDocumentTypeService
    {
        private readonly VietjetAirDbContext _context;
        public DocumentTypeService(VietjetAirDbContext context) 
        {
            _context = context;
        }

        public async Task<bool> AddDocumentTypeAsync(Guid Creator, AddDocumentTypeRequest request)
        {
            string name = request.Name;
            name = String.Concat(name.Where(c => !Char.IsWhiteSpace(c)));
            if (string.IsNullOrEmpty(request.Name)) return false;
            var docType = new VietjecAir.Data.Entities.DocumentType()
            {
                Name = name,
                Note = request.Note,
                Creator = Creator,
                CreatedDate = DateTime.Now,
            };
            await _context.DocumentTypes.AddAsync(docType);
            await _context.SaveChangesAsync();

            var _docType = await _context.DocumentTypes.FirstOrDefaultAsync(x => x.Name == name);
            foreach (var x in request.Permissions)
            {
                if (!x.Permission.Equals("Read and modify") && !x.Permission.Equals("Read only") && !x.Permission.Equals("No Permission"))
                {
                    return false;
                }
                var permission = new Permission()
                {
                    DocumentTypeId = _docType.Id,
                    GroupId = x.GroupId,
                    Permissions = x.Permission
                };
                await _context.Permissions.AddAsync(permission);
            }
            
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<DateTime>> GetDates()
        {
            var datedQuery = from dt in _context.DocumentTypes
                               select dt.CreatedDate;

            var listDate = datedQuery.Select(x => x).ToListAsync();
            return await listDate;
        }

        public async Task<List<string>> GetDocsType()
        {
            var docsTypeQuery = from dt in _context.DocumentTypes
                             select dt.Name;

            var listDocsType = docsTypeQuery.Select(x => x).ToListAsync();
            return await listDocsType;
        }

        public async Task<List<GroupModel>> GetGroups()
        {
            var groupQuery = from g in _context.Groups
                                select g;

            var listGroup = groupQuery.Select(x => new GroupModel()
            {
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();
            return await listGroup;
        }

        public async Task<DocTypeResultModel<DocumentTypeViewModel>> GetDocumentTypeAsync(GetDocumentTypeRequest request)
        {
            var query = from dt in _context.DocumentTypes
                        from a in _context.AppUsers.Where(a => a.Id.Equals(dt.Creator)).DefaultIfEmpty()
                        select new { dt, a };

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.dt.Name.Contains(request.Keyword));
            }

            if (!string.IsNullOrEmpty(request.DocType))
            {
                query = query.Where(x => x.dt.Name.Contains(request.DocType));
            }

            if (!request.Date.Equals("") && request.Date != null)
            {
                query = query.Where(x => x.dt.CreatedDate.Equals(request.Date));
            }

            int totalRecord = await query.CountAsync();
            var data = query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(p => new DocumentTypeViewModel()
                {
                    Id = p.dt.Id,
                    Name = p.dt.Name,
                    Permission = p.dt.permissions.Count() > 0 ? $"{p.dt.permissions.Count()} group" : "0 group",
                    Created = p.dt.CreatedDate,
                    Creator = p.a.Email
                }).ToListAsync();

            return new DocTypeResultModel<DocumentTypeViewModel>()
            {
                TotalRecord = totalRecord,
                Items = await data,
                DocsType = await GetDocsType(),
                Dates = await GetDates()
            };
        }

        public async Task<DocTypeDetailViewModel> GetDocTypeDetailAsync(string DocTypeName)
        {
            var docName = await _context.DocumentTypes.FirstOrDefaultAsync(x => x.Name.Equals(DocTypeName));
            if (docName == null) return null;
            int docTypeId = docName.Id;
            var permissionQuery = from p in _context.Permissions.Where(p => p.DocumentTypeId == docTypeId)
                                  from g in _context.Groups.Where(g => g.Id == p.GroupId).DefaultIfEmpty()
                              select new {p, g}
                              ;
            var listPermission = new List<GroupPermissionModel>();
            if(permissionQuery.Count() > 0)
            {
                listPermission = await permissionQuery.Select(x => new GroupPermissionModel()
                {
                    GroupId = x.p.GroupId,
                    Name = x.g.Name,
                    Permission = x.p.Permissions
                }).ToListAsync();
            }

            return new DocTypeDetailViewModel() 
            {
                DocumentTypeId = docTypeId,
                Name = docName.Name,
                Note = docName.Note,
                Permissions = listPermission,
                Groups = await GetGroups()
            };
        }

        public async Task<int> AdddDocTypePermissionAsync(string DocTypeName, AddPermissionRequest request)
        {
            var docType = await _context.DocumentTypes.FirstOrDefaultAsync(x => x.Name.Equals(DocTypeName));
            if (docType == null) return 0;
            int docTypepId = docType.Id;
            var permission = new Permission()
            {
                DocumentTypeId = docTypepId,
                GroupId = request.GroupId,
                Permissions = request.Permission
            };
            await _context.Permissions.AddAsync(permission);
            return await _context.SaveChangesAsync();

        }

        public async Task<int> RemoveDocTypePermissionAsync(string DocTypeName, int GroupId)
        {
            var docType = await _context.DocumentTypes.FirstOrDefaultAsync(x => x.Name.Equals(DocTypeName));
            if (docType == null) return 0;
            int docTypepId = docType.Id;
            var permission = await _context.Permissions.FirstOrDefaultAsync(x => x.DocumentTypeId == docTypepId && x.GroupId == GroupId);
            if(permission == null) return 0;
            _context.Permissions.Remove(permission);
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatedDocumentTypeAsync(string DocTypeName, UpdateDocTypeRequest request)
        {
            if (await _context.DocumentTypes.FirstOrDefaultAsync(x => x.Name.Equals(request.Name)) != null) { return false; }
            var docType = await _context.DocumentTypes.FirstOrDefaultAsync(x => x.Name.Equals(DocTypeName));
            if (docType == null) return false;
            docType.Name = request.Name;
            docType.Note = request.Note;
            return await _context.SaveChangesAsync() > 0;
            
        }

        public async Task<bool> RemovedDocumentTypeAsync(string DocTypeName)
        {
            var docType = await _context.DocumentTypes.FirstOrDefaultAsync(x => x.Name.Equals(DocTypeName));
            if (docType == null) return false;
            _context.DocumentTypes.Remove(docType);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
