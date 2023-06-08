using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjetAir.ViewModels.Common;

namespace VietjetAir.ViewModels.Catalog.Configuration
{
    public class DocTypeResultModel<T> : ResultModel<T>
    {
        public List<string> DocsType { get; set; }
        public List<DateTime> Dates { get; set; }
    }
}
