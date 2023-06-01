using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjecAir.Data.Entities
{
    public class DocumentDetail
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Version { get; set; }
        public string Creator { get; set; }
        public int DocumentId { get; set; }
        public string FilePath { get; set; }
        public long FileSize { get; set; }
        public Document Document { get; set; }
    }
}
