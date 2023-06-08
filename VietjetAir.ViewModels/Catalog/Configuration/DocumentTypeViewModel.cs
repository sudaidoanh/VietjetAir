using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjetAir.ViewModels.Catalog.Configuration
{
    public class DocumentTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string Creator { get; set; }
        public string Permission { get; set; }
    }
}
