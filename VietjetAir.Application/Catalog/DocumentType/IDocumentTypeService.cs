using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjetAir.ViewModels.Catalog.Configuration;
using VietjetAir.ViewModels.Catalog.GroupPermission;
using VietjetAir.ViewModels.Common;

namespace VietjetAir.Application.Catalog.DocumentType
{
    public interface IDocumentTypeService
    {
        Task<List<string>> GetDocsType();
        Task<List<DateTime>> GetDates();
        Task<List<GroupModel>> GetGroups();
        Task<bool> AddDocumentTypeAsync(Guid Creator, AddDocumentTypeRequest request);
        Task<DocTypeResultModel<DocumentTypeViewModel>> GetDocumentTypeAsync(GetDocumentTypeRequest request);
        Task<DocTypeDetailViewModel> GetDocTypeDetailAsync(string DocTypeName);
        Task<int> AdddDocTypePermissionAsync(string DocTypeName, AddPermissionRequest request);
        Task<int> RemoveDocTypePermissionAsync(string DocTypeName, int GroupId);
        Task<bool> UpdatedDocumentTypeAsync(string DocTypeName, UpdateDocTypeRequest request);
        Task<bool> RemovedDocumentTypeAsync(string DocTypeName);

    }
}
