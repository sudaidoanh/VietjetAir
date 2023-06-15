using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjetAir.ViewModels.Common;

namespace VietjetAir.ViewModels.Catalog.FlightServices
{
    public class GetAllFlightPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
