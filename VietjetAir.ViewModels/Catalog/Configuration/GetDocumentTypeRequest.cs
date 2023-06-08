using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjetAir.ViewModels.Common;

namespace VietjetAir.ViewModels.Catalog.Configuration
{
    public class GetDocumentTypeRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public string DocType { get; set; }
        public DateTime Date { get; set; }
    }
}
