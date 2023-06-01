using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjecAir.Data.Entities
{
    public class Permission
    {
        public int DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public string Permissions { get; set; }
    }
}
