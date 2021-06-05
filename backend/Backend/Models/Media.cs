using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Media
    {
        public int MediaID { get; set; }
        public string Tipus { get; set; }
        public string Szerzo { get; set; }
        public string Cim { get; set; }
        public string Statusz { get; set; }

    }
}