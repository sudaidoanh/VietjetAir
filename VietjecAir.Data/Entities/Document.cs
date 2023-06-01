﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietjecAir.Data.Entities
{
    public class Document
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Note { get; set; }
        public string Creator { get; set; }
        public int DocumentTypeId { get; set; }
        public int FlightId { get; set; }
        public List<DocumentDetail> Details { get; set; }

    }
}
